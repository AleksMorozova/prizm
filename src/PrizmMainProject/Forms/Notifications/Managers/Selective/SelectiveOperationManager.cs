using Ninject;
using Prizm.Data.DAL;
using Prizm.Data.DAL.ADO;
using Prizm.Domain.Entity;
using Prizm.Domain.Entity.Mill;
using Prizm.Domain.Entity.Setup;
using Prizm.Main.Forms.Notifications.Managers.NotRequired;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Notifications.Managers.Selective
{
    class SelectiveOperationManager : NotificationManager, IPipeNotifierCreator
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(SelectiveOperationManager));
        private SelectiveCache cache = new SelectiveCache();
        readonly SelectiveNotificationRepository repo = new SelectiveNotificationRepository();

        [Inject]
        public SelectiveOperationManager()
            : base(null)
        {
        }

        public override TypeNotification Type { get { return TypeNotification.SelectiveInspectionOperation; } }

        public static Notification CreateNotification(Guid ownerId, string ownerName, float unitsLeft, string information)
        {
            return new Notification(ownerId, ownerName, TypeNotification.SelectiveInspectionOperation, information, unitsLeft);
        }

        public override void LoadNotifications()
        {
            try
            {
                cache.Clear();
                notifications.Clear();
                IList<SelectiveOperation> selectiveOperations = repo.GetAllSelectiveOperation();
                IList<KeyValuePair<Guid, int>> generalPipeAmount = repo.GetPipesCountPerMillSizeType();

                foreach (SelectiveOperation s in selectiveOperations)
                {
                    cache.AddOrReplace(s.PipeSizeTypeId,s.PipeSizeTypeName, s.OperationId, s.OperationCode, s.OperationName, s.SelectivePercent, s.PipesCount,0);

                    cache.SetPipeAmount(s.OperationId, generalPipeAmount.First(kvp => kvp.Key == s.PipeSizeTypeId).Value);

                    if (cache.IsExpired(s.OperationId))
                    {
                        notifications.Add(
                        CreateNotification(s.OperationId, cache.GetOwnerName(s.OperationId), cache.GetCheckValue(s.OperationId), cache.GetInformation(s.OperationId)));
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error("Unable to load Selective Operation Notifications: ", ex);
            }

            NotificationService.Instance.NotifyInterested();
        }

        #region --- Notifier ---

        class PipeNotificationInfo : IPipeNotifier
        {
            private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(PipeNotificationInfo));

            private struct TestResultInfo
            {
                public TestResultInfo(Guid id, bool accepted)
                {
                    operationId = id;
                    isAccepted = accepted;
                }
                private Guid operationId;
                private bool isAccepted;
                

                public Guid OperationId { get { return operationId; } }
                public bool IsAccepted { get { return isAccepted; } }
            }

            private SelectiveOperationManager manager;

            #region --- Previous state of pipe ---

            private Guid initialPipeSizeTypeId = default(Guid);
            private List<PipeTestResult> initialSelectivePipeTestResult = new List<PipeTestResult>();
            private List<TestResultInfo> initialSelectiveInfo = new List<TestResultInfo>();
            private bool isProperlyCreated = true;

            #endregion //--- Previous state of pipe ---

            private PipeNotificationInfo(SelectiveOperationManager manager)
            {
                this.manager = manager;
            }

            public static PipeNotificationInfo Create(SelectiveOperationManager manager, Pipe pipeInitialState)
            {
                PipeNotificationInfo info = new PipeNotificationInfo(manager);
                info.SavePipeState(pipeInitialState);
                return info;
            }

            private static List<TestResultInfo> GetTestResultInfoListFromPipeTestResultList(IList<PipeTestResult> results)
            {
                List<TestResultInfo> list = new List<TestResultInfo>();
                foreach (var testResult in results)
                {
                    if (testResult.Operation.FrequencyType == InspectionFrequencyType.S && testResult.Status != PipeTestResultStatus.Scheduled)
                    {
                        list.Add(new TestResultInfo(testResult.Operation.Id, testResult.Status != PipeTestResultStatus.Scheduled));
                    }
                }
                return list;
            }

            private void SavePipeState(Pipe pipeState)
            {
                if (pipeState.Type != null)
                {
                    this.initialPipeSizeTypeId = pipeState.Type.Id;
                    initialSelectiveInfo.AddRange(GetTestResultInfoListFromPipeTestResultList(pipeState.PipeTestResult));
                }
            }

            private void UpdateNotification(Guid operationId)
            {
                bool isGoingToExpire = manager.cache.IsExpired(operationId);
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
                        CreateNotification(operationId, manager.cache.GetOwnerName(operationId), manager.cache.GetCheckValue(operationId), manager.cache.GetCheckValue(operationId).ToString()));
                    }
                }
            }

            private void ProcessOperationForPipeSizeType(Guid sizeTypeId)
            {
                foreach (Guid id in manager.cache.EnumerateOperationsForSizeType(sizeTypeId))
                {
                    manager.cache.AddGeneralPipeAmount(id);
                    UpdateNotification(id);
                }
            }

            private void AddPipe(IList<PipeTestResult> result)
            {
                IList<Guid> addId = new List<Guid>();

                addId.Clear();
                foreach (PipeTestResult test in result)
                {
                    if (test.Operation.FrequencyType == InspectionFrequencyType.S && test.Status != PipeTestResultStatus.Scheduled)
                    {
                        addId.Add(test.Operation.Id);
                    }
                }

                addId.Distinct();
                foreach (Guid id in addId)
                {
                    manager.cache.AddPipeAmount(id);
                }

            }

            private void AddAndUpdate(IList<PipeTestResult> result)
            {
                IList<Guid> addId = new List<Guid>();

                addId.Clear();
                foreach (PipeTestResult test in result)
                {
                    if (test.Operation.FrequencyType == InspectionFrequencyType.S && test.Status != PipeTestResultStatus.Scheduled)
                    {
                        addId.Add(test.Operation.Id);
                    }
                }

                addId.Distinct();
                foreach (Guid id in addId)
                {
                    manager.cache.AddGeneralPipeAmount(id);
                    manager.cache.AddPipeAmount(id);

                    UpdateNotification(id);

                }

            }

            private void RemoveAndUpdatePipe(IList<PipeTestResult> result)
            {
                IList<Guid> removeID = new List<Guid>();

                removeID.Clear();
                foreach (PipeTestResult test in result)
                {
                    if (test.Operation.FrequencyType == InspectionFrequencyType.S && test.Status != PipeTestResultStatus.Scheduled)
                    {
                        removeID.Add(test.Operation.Id);
                    }
                }

                removeID.Distinct();
                foreach (Guid id in removeID)
                {
                    manager.cache.RemoveGeneralPipeAmount(id);
                    manager.cache.RemovePipeAmount(id);

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
                        AddPipe(pipeSavingState.PipeTestResult);
                        ProcessOperationForPipeSizeType(pipeSavingState.Type.Id);
                    }

                    //* - pipe is existing and pipe size type changed (to update: NROs from previous size type(remove), NROs from current size type(new))
                    else if (pipeSavingState.Type == null || initialPipeSizeTypeId != pipeSavingState.Type.Id)
                    {
                        RemoveAndUpdatePipe(initialSelectivePipeTestResult);
                        AddAndUpdate(pipeSavingState.PipeTestResult);

                    }

                    //* - pipe is existing and operations were edited (to update: NROs from current size type(track changes))
                    else if (initialPipeSizeTypeId == pipeSavingState.Type.Id)
                    {
                        HashSet<TestResultInfo> savingState = new HashSet<TestResultInfo>(GetTestResultInfoListFromPipeTestResultList(pipeSavingState.PipeTestResult));
                        HashSet<TestResultInfo> initialState = new HashSet<TestResultInfo>(initialSelectiveInfo);

                        savingState.ExceptWith(initialState);

                        foreach (TestResultInfo result in savingState.Distinct())
                        {
                            manager.cache.RemovePipeAmount(result.OperationId);
                            manager.cache.AddPipeAmount(result.OperationId);

                            UpdateNotification(result.OperationId);
                        }
                    }

                    //* - pipe deactivation (to update: NRO (remove))
                    else if (!pipeSavingState.IsActive)
                    {
                        RemoveAndUpdatePipe(pipeSavingState.PipeTestResult);
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
