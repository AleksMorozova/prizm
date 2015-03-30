using Ninject;
using Prizm.Data.DAL;
using Prizm.Data.DAL.ADO;
using Prizm.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Notifications.Managers.Selective
{
    class SelectiveOperationManager : NotificationManager, ISelectiveOperationManager
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
            return new Notification(ownerId, ownerName, TypeNotification.NotRequiredInspectionOperation, information, unitsLeft);
        }

        public override void LoadNotifications()
        {
            try
            {
                cache.Clear();

                IList<SelectiveOperation> selectiveOperations = repo.GetAllSelectiveOperation();
                IList<KeyValuePair<Guid, int>> generalPipeAmount = repo.GetPipesCountPerMillSizeType();

                foreach (SelectiveOperation s in selectiveOperations)
                {
                    cache.AddOrReplace(s.PipeSizeTypeId,s.PipeSizeTypeName, s.OperationId, s.OperationCode, s.OperationName, s.SelectivePercent, s.PipesCount,0);

                    cache.SetPipeAmount(s.OperationId, generalPipeAmount.First(kvp => kvp.Key == s.PipeSizeTypeId).Value);

                    if (cache.IsExpired(s.OperationId))
                    {
                        notifications.Add(
                        CreateNotification(s.OperationId, cache.GetOwnerName(s.OperationId), cache.GetCheckValue(s.OperationId), cache.GetCheckValue(s.OperationId).ToString()));
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error("Unable to load Selective Operation Notifications: ", ex);
            }

            NotificationService.Instance.NotifyInterested();
        }

    }
}
