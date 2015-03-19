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
        /// <param name="OperationId"></param>
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
                    cache.SetUnits(producedUnits.Key, producedUnits.Value);
                    if (cache.IsGoingToExpire(producedUnits.Key))
                    {
                        notifications.Add(
                        CreateNotification(producedUnits.Key, cache.GetOwnerName(producedUnits.Key), producedUnits.Value, producedUnits.Value.ToString()));
                    }

                }


                /*
                 * 0) Clear the cache
                 * 1) DB sql request: Read size types + not required inspection operations, from settings. Use internalCache.Add to add all information (except for UnitsLeft)
                 *      (INPUT: none)
                 *      (OUTPUT: pipe size type name (!), pipe test id, operation code, operation name, Frequency, Frequency Measure)
                 * 2) DB sql request: Read all MAX dates including NULL, ordering by not required inspection operations, in pipe test results. 
                 *      (INPUT: none)
                 *      (OUTPUT: pipe test id, date (can be NULL))
                 * 3) DB sql request: Read all "unitsProducedSinceLastDate" for all not required inspection operations.
                 *      (INPUT: pipe test id, MAX date, Frequency Measure)
                 *      (OUTPUT: pipe test id, unitsProducedSinceLastDate)
                 * 4) modify for each cache entry: UnitsLeft = Frequency - unitsProducedSinceLastDate (use SetUnits)
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
                    operationId = id;
                    isCompleted = completed;
                }
                private Guid operationId;
                private bool isCompleted;

                public Guid OperationId { get { return operationId; } }
                public bool IsCompleted { get { return isCompleted; } }
            }

            private NotRequiredOperationManager manager;
            private Guid initialPipeSizeTypeId = default(Guid);
            private int initialPipeLength = 0;
            private float initialPipeWeight = 0;
            private List<PipeTestResult> initialPipeTestResult = new List<PipeTestResult>();
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
                    info.initialPipeLength = pipeInitialState.Length;
                    info.initialPipeWeight = pipeInitialState.Weight;
                    info.initialPipeTestResult.AddRange(pipeInitialState.PipeTestResult);
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

            public void UpdateListOfNotification(Guid operationId)
            {
                NotRequiredCache c = new NotRequiredCache();
                if (manager.notifications.FindAll(_ => _.Id == operationId).Count >= 1)
                {
                    if (c.IsGoingToExpire(operationId))
                    {
                        //update notification type
                        foreach (Notification n in manager.notifications.FindAll(_ => _.Id == operationId)) 
                        {
                            if (c.IsExpired(operationId))
                            {
                                n.Status = NotificationStatus.Critical;

                            }
                            else 
                            { 
                                n.Status = NotificationStatus.Warning; 
                            }
                        }
                    }
                    else
                    {
                        //remove notification
                        manager.notifications.RemoveAll(_ => _.Id == operationId);
                    }
                }
                else
                {
                    if (c.IsGoingToExpire(operationId))
                    {
                        //create notification
                        manager.notifications.Add(CreateNotification(operationId, c.GetOwnerName(operationId), c.GetUnits(operationId), c.GetUnits(operationId).ToString()));
                    }
                }
            }
            public void UpdateNotifications(Domain.Entity.Mill.Pipe pipeSavingState)
            {
                if (isProperlyCreated && !isAlreadyUpdated)
                {
                    //* What can happen at Save Pipe: (NRO - non required inspection operation)
                    //* - pipe is new and have no previous state (to update: NROs from current size type(new))
                    if (initialPipeSizeTypeId == null)
                    {
                        NotRequiredCache c = new NotRequiredCache();
                        foreach(PipeTestResult results in pipeSavingState.PipeTestResult)
                        {
                            if (!results.Operation.IsRequired) 
                            {
                                if (results.Operation.Frequency.Measure == FrequencyMeasure.Meters)
                                    c.AddUnits(results.Operation.Id, initialPipeWeight);

                                else if (results.Operation.Frequency.Measure == FrequencyMeasure.Tons)
                                    c.AddUnits(results.Operation.Id, initialPipeLength);

                                else if (results.Operation.Frequency.Measure == FrequencyMeasure.Pipes)
                                    c.AddUnits(results.Operation.Id, 1);
                                UpdateListOfNotification(results.Operation.Id);
                            }
                        }
                    }

                    //* - pipe is existing and pipe size type changed (to update: NROs from previous size type(remove), NROs from current size type(new))
                    else if(pipeSavingState.Type == null || initialPipeSizeTypeId != pipeSavingState.Type.Id)
                    {
                        NotRequiredCache c = new NotRequiredCache();

                        //remove old operation with units units
                        foreach (PipeTestResult result in initialPipeTestResult)
                        {
                            if (!result.Operation.IsRequired)
                            {
                                if (result.Operation.Frequency.Measure == FrequencyMeasure.Meters)
                                    c.RemoveUnits(result.Operation.Id, initialPipeWeight);

                                else if (result.Operation.Frequency.Measure == FrequencyMeasure.Tons)
                                    c.RemoveUnits(result.Operation.Id, initialPipeLength);

                                else if (result.Operation.Frequency.Measure == FrequencyMeasure.Pipes)
                                    c.RemoveUnits(result.Operation.Id, 1);
                                UpdateListOfNotification(result.Operation.Id);
                            }
                        }

                        //add new operation with units units
                        foreach (PipeTestResult newResult in pipeSavingState.PipeTestResult)
                        {
                            if (!newResult.Operation.IsRequired)
                            {
                                if (newResult.Operation.Frequency.Measure == FrequencyMeasure.Meters)
                                    c.AddUnits(newResult.Operation.Id, initialPipeWeight);

                                else if (newResult.Operation.Frequency.Measure == FrequencyMeasure.Tons)
                                    c.AddUnits(newResult.Operation.Id, initialPipeLength);

                                else if (newResult.Operation.Frequency.Measure == FrequencyMeasure.Pipes)
                                    c.AddUnits(newResult.Operation.Id, 1);
                                UpdateListOfNotification(newResult.Operation.Id);
                            }
                        }
                    }

                    //* - pipe is existing and operations were edited (to update: NROs from current size type(track changes))
                    else if (initialPipeSizeTypeId == pipeSavingState.Type.Id)
                    {
                        // TODO
                    }

                    //* - pipe deactivation (to update: NRO (remove))
                    else if (!pipeSavingState.IsActive)
                    { 
                        NotRequiredCache c = new NotRequiredCache();
                        foreach (PipeTestResult result in pipeSavingState.PipeTestResult)
                        {
                            if (!result.Operation.IsRequired)
                            {
                                if (result.Operation.Frequency.Measure == FrequencyMeasure.Meters)
                                    c.RemoveUnits(result.Operation.Id, initialPipeWeight);

                                else if (result.Operation.Frequency.Measure == FrequencyMeasure.Tons)
                                    c.RemoveUnits(result.Operation.Id, initialPipeLength);

                                else if (result.Operation.Frequency.Measure == FrequencyMeasure.Pipes)
                                    c.RemoveUnits(result.Operation.Id, 1);

                                UpdateListOfNotification(result.Operation.Id);
                            }
                        }
                    }

                    isAlreadyUpdated = true;
                }
                // NotRequiredOperationManager.CreateNotification(Guid ownerId, string ownerName, float UnitsLeft, string information);
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
