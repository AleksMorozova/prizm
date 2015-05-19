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
    class NotRequiredOperationManager : NotificationManager, IPipeNotifierCreator
    {
        readonly INRONotificationRepository repo = new NRONotificationRepository();
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(NotRequiredOperationManager));
        private NotRequiredCache cache = new NotRequiredCache();

        public NotRequiredOperationManager()
            : base(null)
        {
        }

        public override TypeNotification Type { get { return TypeNotification.NotRequiredInspectionOperation; } }

        public static Notification CreateNotification(Guid ownerId, string ownerName, decimal unitsLeft, string information)
        {
            return new Notification(ownerId, ownerName, TypeNotification.NotRequiredInspectionOperation, information, unitsLeft.ToString());
        }

        public void UpdateUnits(Guid operationId)
        {
            KeyValuePair<Guid, decimal> producedUnits = repo.GetUnitsProducedSinceLastDateTest(operationId, cache.GetMeasure(operationId));
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
                    KeyValuePair<Guid, decimal> producedUnits = repo.GetAllUnitsProducedSinceLastDate(list.Value, list.Key, cache.GetMeasure(list.Value));
                    cache.SetUnits(producedUnits.Key, producedUnits.Value);
                    if (cache.IsGoingToExpire(producedUnits.Key))
                    {
                        notifications.Add(
                        CreateNotification(producedUnits.Key, cache.GetOwnerName(producedUnits.Key), producedUnits.Value, cache.GetInformation(producedUnits.Key)));
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error("Unable to load Not Required Operation Notifications: ", ex);
            }
            NotificationService.Instance.NotifyInterested();
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

            private struct TestResultInfo
            {
                public TestResultInfo(Guid id, bool status)
                {
                    operationId = id;
                    resultStatus = status;
                }
                private Guid operationId;
                private bool resultStatus;

                public Guid OperationId { get { return operationId; } }
                public bool ResultStatus { get { return resultStatus; } }


            }


            private NotRequiredOperationManager manager;

            #region --- Previous state of pipe ---

            private Guid initialPipeSizeTypeId = default(Guid);
            private int initialPipeLength = 0;
            private decimal initialPipeWeight = 0;
            private List<PipeTestResult> initialPipeTestResult = new List<PipeTestResult>();
            private List<NROInfo> initialNROList = new List<NROInfo>();
            private List<TestResultInfo> initialTestResultList = new List<TestResultInfo>();

            private bool isProperlyCreated = true;

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
                         list.Add(new NROInfo(testResult.Operation.Id, testResult.Status != PipeTestResultStatus.Scheduled));
                     }
                 }
                return list;
            }

            private static List<TestResultInfo> GetInitialTestResult(IList<PipeTestResult> results)
            {
                List<TestResultInfo> list = new List<TestResultInfo>();
                foreach (var testResult in results)
                {
                    if (!testResult.Operation.IsRequired)
                    {
                        list.Add(new TestResultInfo(testResult.Operation.Id, testResult.Status == PipeTestResultStatus.Accepted));
                    }
                }
                return list;
            }

            public static PipeNotificationInfo Create(NotRequiredOperationManager manager, Pipe pipeInitialState)
            {
                PipeNotificationInfo info = new PipeNotificationInfo(manager);
                info.SavePipeState(pipeInitialState);
                return info;
            }

            private void SavePipeState(Pipe pipeState)
            {
                if (pipeState.Type != null)
                {
                    this.initialPipeSizeTypeId = pipeState.Type.Id;
                    this.initialPipeLength = pipeState.Length;
                    this.initialPipeWeight = pipeState.Weight;
                    this.initialPipeTestResult.AddRange(pipeState.PipeTestResult);
                }
                if (pipeState.PipeTestResult != null)
                {
                    this.initialNROList.AddRange(GetNROInfoListFromPipeTestResultList(pipeState.PipeTestResult));
                    this.initialTestResultList.AddRange(GetInitialTestResult((pipeState.PipeTestResult)));
                }
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

            private decimal ChooseUnit(FrequencyMeasure measure, Pipe pipe = null)
            {
                decimal ret = 0;
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
   
            private void ProcessPipeTestResults(IList<PipeTestResult> results)
            {
                IList<Guid> listID = new List<Guid>();
                foreach (PipeTestResult result in results)
                {
                    if (!result.Operation.IsRequired && result.Status!=PipeTestResultStatus.Scheduled)
                    {
                        listID.Add(result.Operation.Id);
                    }
                }

                listID.Distinct();
                foreach (Guid id in listID) 
                {
                    manager.UpdateUnits(id);
                }
            }

            private enum NROWhatToDo { Add, Remove, EditOperations };

            private void ProcessNROForPipeSizeType(Guid sizeTypeId, Pipe pipe, NROWhatToDo what)
            {
                foreach (Guid id in manager.cache.EnumerateOperationsForSizeType(sizeTypeId))
                {
                    if (what != NROWhatToDo.Add)
                    {
                        manager.cache.RemoveUnits(id, ChooseUnit(manager.cache.GetMeasure(id)));
                    }
                    if (what != NROWhatToDo.Remove)
                    {
                        manager.cache.AddUnits(id, ChooseUnit(manager.cache.GetMeasure(id), pipe));
                    }
                    
                    UpdateNotification(id);
                }
            }

            public void UpdateNotifications(Domain.Entity.Mill.Pipe pipeSavingState)
            {
                if (isProperlyCreated)
                {
                    //* What can happen at Save Pipe: (NRO - non required inspection operation)
                    //* - pipe is new and have no previous state (to update: NROs from current size type(new))
                    if (initialPipeSizeTypeId == Guid.Empty)
                    {
                        ProcessPipeTestResults(pipeSavingState.PipeTestResult);
                        ProcessNROForPipeSizeType(pipeSavingState.Type.Id, pipeSavingState, NROWhatToDo.Add);
                    }

                    //* - pipe is existing and pipe size type changed (to update: NROs from previous size type(remove), NROs from current size type(new))
                    else if(pipeSavingState.Type == null || initialPipeSizeTypeId != pipeSavingState.Type.Id)
                    {
                        //update notification for old size type
                        IList<Guid> removeId = new List<Guid>();

                        foreach (TestResultInfo t in initialTestResultList)
                        {
                            removeId.Add(t.OperationId);
                        }
                        removeId.Distinct();
                        foreach (Guid id in removeId)
                        {
                            manager.UpdateUnits(id);
                        }

                        foreach (Guid id in manager.cache.EnumerateOperationsForSizeType(initialPipeSizeTypeId))
                        {
                            manager.cache.RemoveUnits(id, ChooseUnit(manager.cache.GetMeasure(id)));
                            UpdateNotification(id);
                        }

                        //update notification for new size type
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

                        var resultList = savingState.Except(initialState);
                        foreach (NROInfo result in resultList.Distinct())
                        {
                            if (result.IsCompleted)
                            {
                                manager.UpdateUnits(result.OperationId); 
                            }
                        }

                        ProcessNROForPipeSizeType(pipeSavingState.Type.Id, pipeSavingState, NROWhatToDo.EditOperations);
                    }

                    //* - pipe deactivation (to update: NRO (remove))
                    else if (!pipeSavingState.IsActive)
                    {
                        ProcessPipeTestResults(pipeSavingState.PipeTestResult);
                        ProcessNROForPipeSizeType(pipeSavingState.Type.Id, pipeSavingState, NROWhatToDo.Remove);
                    }
                }
                NotificationService.Instance.NotifyInterested();
                SavePipeState(pipeSavingState);
            }
        }

        public IPipeNotifier CreateNotifier(Pipe pipeInitialState)
        {
            return PipeNotificationInfo.Create(this, pipeInitialState);
        }

        #endregion // --- Notifier ---
    }
}
