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

        public void UpdateUnits(Guid operationId)
        {
            KeyValuePair<Guid, float> producedUnits = repo.GetUnitsProducedSinceLastDateTest(operationId, cache.GetMeasure(operationId));
            cache.SetUnits(operationId, producedUnits.Value);
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
                    cache.AddOrReplace(operation.PipeSizeTypeId, operation.OperationId, operation.Frequency, 0, 
                        operation.OperationCode, operation.OperationName, operation.PipeSizeTypeName, operation.Measure);
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
                 * 2) DB sql request: Read all MAX dates including NULL, ordering by not required inspection operations, in pipe test result. 
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

                public override bool Equals(Object obj)
                {
                    return obj is NROInfo && this == (NROInfo)obj;
                }
                public override int GetHashCode()
                {
                    return operationId.GetHashCode() ^ isCompleted.GetHashCode();
                }
                public static bool operator ==(NROInfo x, NROInfo y)
                {
                    return x.operationId == y.operationId && x.isCompleted == y.isCompleted;
                }
                public static bool operator !=(NROInfo x, NROInfo y)
                {
                    return !(x == y);
                }
            }

            private NotRequiredOperationManager manager;

            #region --- Previous state of pipe ---

            private Guid initialPipeSizeTypeId = default(Guid);
            private int initialPipeLength = 0;
            private float initialPipeWeight = 0;
            private List<PipeTestResult> initialPipeTestResult = new List<PipeTestResult>();
            private List<NROInfo> initialNROList = new List<NROInfo>();
            private bool isProperlyCreated = true;
            private bool isAlreadyUpdated = false;

            #endregion //--- Previous state of pipe ---

            private PipeNotificationInfo(NotRequiredOperationManager manager)
            {
                this.manager = manager;
            }

            private static List<NROInfo> GetNROInfoListFromPipeTestResultList(IList<PipeTestResult> results)
            {
                List<NROInfo> list = new List<NROInfo>();
                foreach (var testResult in results)
                {
                     if (!testResult.Operation.IsRequired)
                     {
                         list.Add(new NROInfo(testResult.Operation.Id, testResult.Status == PipeTestResultStatus.Accepted));
                     }
                 }
                return list;
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
                    info.initialNROList.AddRange(GetNROInfoListFromPipeTestResultList(pipeInitialState.PipeTestResult));
                }
                return info;
            }

            private void UpdateNotification(Guid operationId)
            {
                bool isGoingToExpire = manager.cache.IsGoingToExpire(operationId);
                List<Notification> found = manager.notifications.FindAll(_ => _.Id == operationId);

                if (found.Count >= 1)
                {
                    if (isGoingToExpire)
                    {
                        foreach (Notification n in found)
                        {
                            n.Status = manager.cache.IsExpired(operationId) ? NotificationStatus.Critical : n.Status = NotificationStatus.Warning; 
                        }
                    }
                    else
                    {
                        manager.notifications.RemoveAll(_ => _.Id == operationId);
                    }
                }
                else
                {
                    if (isGoingToExpire)
                    {
                        manager.notifications.Add(
                            CreateNotification(operationId, manager.cache.GetOwnerName(operationId),
                                manager.cache.GetUnits(operationId), manager.cache.GetUnits(operationId).ToString()));
                    }
                }
            }

            private float ChooseUnit(FrequencyMeasure measure, Pipe pipe = null)
            {
                float ret = 0;
                switch (measure)
                {
                    case FrequencyMeasure.Meters:
                        ret =pipe == null ? initialPipeLength : pipe.Length;
                        break;
                    case FrequencyMeasure.Tons:
                        ret = pipe == null ? initialPipeWeight : pipe.Weight;
                        break;
                    case FrequencyMeasure.Pipes:
                        ret = 1;
                        break;
                    default:
                        log.Error("Notifications: unrecognized type of unit at ChooseUnit: " + measure);
                        break;
                }
                return ret;
            }

            private enum ProcessPipeTestResultsAction { Add, Remove };

            private void ProcessPipeTestResults(IList<PipeTestResult> results)
            {
                foreach (PipeTestResult result in results)
                {
                    if (!result.Operation.IsRequired && result.Status==PipeTestResultStatus.Accepted)
                    {
                        manager.UpdateUnits(result.Operation.Id);
                    }
                }
            }
            private void ProcessNROForPipeSizeType(Guid sizeTypeId, Pipe pipe) 
            {
                foreach (Guid id in manager.cache.EnumerateOperationsForSizeType(sizeTypeId))
                {
                    manager.cache.RemoveUnits(id, ChooseUnit(manager.cache.GetMeasure(id)));
                    manager.cache.AddUnits(id, ChooseUnit(manager.cache.GetMeasure(id), pipe));
                    UpdateNotification(id);
                }
            }

            public void UpdateNotifications(Domain.Entity.Mill.Pipe pipeSavingState)
            {
                if (isProperlyCreated)//&& !isAlreadyUpdated
                {
                    //* What can happen at Save Pipe: (NRO - non required inspection operation)
                    //* - pipe is new and have no previous state (to update: NROs from current size type(new))
                    if (initialPipeSizeTypeId == null)
                    {
                        ProcessPipeTestResults(pipeSavingState.PipeTestResult);
                        ProcessNROForPipeSizeType(pipeSavingState.Type.Id, pipeSavingState);
                    }

                    //* - pipe is existing and pipe size type changed (to update: NROs from previous size type(remove), NROs from current size type(new))
                    else if(pipeSavingState.Type == null || initialPipeSizeTypeId != pipeSavingState.Type.Id)
                    {
                        ProcessPipeTestResults(initialPipeTestResult);
                        foreach (Guid id in manager.cache.EnumerateOperationsForSizeType(initialPipeSizeTypeId))
                        {
                            manager.cache.RemoveUnits(id, ChooseUnit(manager.cache.GetMeasure(id)));
                            UpdateNotification(id);
                        }
                        ProcessPipeTestResults(pipeSavingState.PipeTestResult);
                        foreach (Guid id in manager.cache.EnumerateOperationsForSizeType(pipeSavingState.Type.Id))
                        {
                            manager.cache.AddUnits(id, ChooseUnit(manager.cache.GetMeasure(id), pipeSavingState));
                            UpdateNotification(id);
                        }
                    }

                    //* - pipe is existing and operations were edited (to update: NROs from current size type(track changes))
                    else if (initialPipeSizeTypeId == pipeSavingState.Type.Id)
                    {
                        HashSet<NROInfo> initialState = new HashSet<NROInfo>();
                        initialState.UnionWith(initialNROList);
                        HashSet<NROInfo> savingState = new HashSet<NROInfo>();
                        savingState.UnionWith(GetNROInfoListFromPipeTestResultList(pipeSavingState.PipeTestResult));

                        var resultList = initialState.Except(savingState).Union(savingState.Except(initialState));
                        foreach (NROInfo result in resultList)
                        {
                            if (result.IsCompleted)
                            {
                                manager.UpdateUnits(result.OperationId); 
                            }
                        }   
             
                        ProcessNROForPipeSizeType(pipeSavingState.Type.Id, pipeSavingState);
                    }

                    //* - pipe deactivation (to update: NRO (remove))
                    else if (!pipeSavingState.IsActive)
                    {
                        ProcessPipeTestResults(pipeSavingState.PipeTestResult);
                        ProcessNROForPipeSizeType(pipeSavingState.Type.Id, pipeSavingState);
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
