using Prizm.Data.DAL;
using Prizm.Data.DAL.ADO;
using Prizm.Domain.Entity;
using Prizm.Domain.Entity.Mill;
using Prizm.Domain.Entity.Setup;
using Prizm.Main.Forms.Notifications.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Notifications.Managers.NotRequired
{
    class NotRequiredOperationManager : NotificationManager,  INotRequiredOperationManager
    {
        readonly INORNotificationRepository repo = new NORNotificationRepository();
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(NotRequiredOperationManager));
        private NotRequiredCache cache = new NotRequiredCache();

        public NotRequiredOperationManager()
            : base(null)
        {
        }

        public override TypeNotification Type { get { return TypeNotification.NotRequiredInspectionOperation; } }

        public static Notification CreateNotification(Guid ownerId, string ownerName, float unitsLeft, string information)
        {
            return new Notification(ownerId, ownerName, TypeNotification.NotRequiredInspectionOperation, information, unitsLeft);
        }

        #region --- Loading ---

        /// <summary>
        /// This method should be used when "Passed" NRO at pipe was removed or set to other not ready state, or pipe was deactivated.
        /// </summary>
        /// <param name="operationId"></param>
        private void LoadNotifications(Guid operationId)
        { 
            // TODO: reload certain NRO data to cache 
        }

        public override void LoadNotifications()
        {
            base.LoadNotifications();
            // TODO: renew cache and notifications list

            try 
            {
                cache.Clear();

                List<NotRequiredOperation> inspectionOperations = repo.GetAllNotRequiredOperation();

                foreach (NotRequiredOperation operation in inspectionOperations)
                {
                    cache.AddOrReplace(operation.operationId, operation.frequency, 0, operation.operationCode, operation.operationName, operation.pipeSizeTypeName, operation.measure);
                }

                List<KeyValuePair<DateTime, Guid>> listOfDate = repo.GetAllNotRequiredOperationResult();

                foreach (KeyValuePair<DateTime, Guid> list in listOfDate)
                {

                    KeyValuePair<Guid, float> producedUnits = repo.GetAllUnitsProducedSinceLastDate(list.Value, list.Key, cache.GetMeasure(list.Value));
                    cache.SetUnitsLeft(producedUnits.Key, producedUnits.Value);
                    if (cache.IsGoingToExpire(producedUnits.Key))
                    {
                        notifications.Add(
                        CreateNotification(producedUnits.Key, cache.GetOwnerName(producedUnits.Key), producedUnits.Value, producedUnits.Value.ToString()));
                    }

                }


                /*
                 * 0) Clear the cache
                 * 1) DB sql request: Read size types + not required inspection operations, from settings. Use internalCache.Add to add all information (except for unitsLeft)
                 *      (INPUT: none)
                 *      (OUTPUT: pipe size type name (!), pipe test id, operation code, operation name, frequency, frequency measure)
                 * 2) DB sql request: Read all MAX dates including NULL, ordering by not required inspection operations, in pipe test results. 
                 *      (INPUT: none)
                 *      (OUTPUT: pipe test id, date (can be NULL))
                 * 3) DB sql request: Read all "unitsProducedSinceLastDate" for all not required inspection operations.
                 *      (INPUT: pipe test id, MAX date, frequency measure)
                 *      (OUTPUT: pipe test id, unitsProducedSinceLastDate)
                 * 4) modify for each cache entry: unitsLeft = frequency - unitsProducedSinceLastDate (use SetUnitsLeft)
                 * 
                 * 5) iterate cache and use IsGoingToExpire to determine whether to create Notification (use this.CreateNotification)
                 * 
                 */
            }
            catch (Exception ex)
            {
                log.Error("Unable to load Not Required Operation Notifications: ", ex);
            }
        }

        #endregion // --- Loading ---

        #region --- Notifier ---

        class PipeNotificationInfo : IPipeNotifier
        {
            private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(PipeNotificationInfo));

            private struct NROInfo
            {
                public NROInfo(Guid id, bool completed)
                {
                    OperationId = id;
                    IsCompleted = completed;
                }
                public Guid OperationId { get; private set; }
                public bool IsCompleted { get; private set; }
            }

            private NotRequiredOperationManager manager;
            private Guid initialPipeSizeTypeId = default(Guid);
            private List<NROInfo> initialNROList = new List<NROInfo>();
            private bool isProperlyCreated = true;
            private bool isAlreadyUpdated = false;

            private PipeNotificationInfo(NotRequiredOperationManager manager)
            {
                this.manager = manager;
            }

            public static PipeNotificationInfo Create(NotRequiredOperationManager manager, Pipe pipeInitialState)
            {
                PipeNotificationInfo info = new PipeNotificationInfo(manager);
                if (pipeInitialState.Type != null)
                {
                    info.initialPipeSizeTypeId = pipeInitialState.Type.Id;
                }
                if (pipeInitialState.PipeTestResult != null)
                {
                    foreach (var testResult in pipeInitialState.PipeTestResult)
                    {
                        if (testResult.Operation != null)
                        {
                            if (!testResult.Operation.IsRequired)
                            {
                                info.initialNROList.Add(new NROInfo(testResult.Operation.Id, testResult.Status == PipeTestResultStatus.Passed));
                            }
                        }
                        else
                        {
                            log.Error("Operation types aren't loaded. Not able to calculate Not Required Operation notifications.");
                            info.isProperlyCreated = false;
                            break;
                        }
                    }
                }
                return info;
            }

            public void UpdateNotifications(Domain.Entity.Mill.Pipe pipeSavingState)
            {
                if (isProperlyCreated && !isAlreadyUpdated)
                {
                    //* What can happen at Save Pipe: (NRO - non required inspection operation)
                    //* - pipe is new and have no previous state (to update: NROs from current size type(new))
                    if (initialPipeSizeTypeId == null)
                    { 
                        // TODO
                    }

                    //* - pipe is existing and pipe size type changed (to update: NROs from previous size type(remove), NROs from current size type(new))
                    else if(pipeSavingState.Type == null || initialPipeSizeTypeId != pipeSavingState.Type.Id)
                    {
                        // TODO
                    }

                    //* - pipe is existing and operations were edited (to update: NROs from current size type(track changes))
                    else if (initialPipeSizeTypeId == pipeSavingState.Type.Id)
                    {
                        // TODO
                    }

                    //* - pipe deactivation (to update: NRO (remove))
                    else if (!pipeSavingState.IsActive)
                    { 
                        // TODO
                    }

                    isAlreadyUpdated = true;
                }
                // NotRequiredOperationManager.CreateNotification(Guid ownerId, string ownerName, float unitsLeft, string information);
                // manager.cache. // TODO: what is required from cache, to update the information
                // manager.notifications.Find( match operation id )  // in case when notification has to be removed
            }
        }

        public IPipeNotifier CreateNotifier(Pipe pipeInitialState)
        {
            return PipeNotificationInfo.Create(this, pipeInitialState);
        }

        #endregion // --- Notifier ---
    }
}
