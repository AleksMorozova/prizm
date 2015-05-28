using Prizm.Data.DAL;
using Prizm.Data.DAL.ADO;
using Prizm.Domain.Entity;
using Prizm.Domain.Entity.Construction;
using Prizm.Main.Forms.Notifications.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Notifications.Managers
{
    class DuplicateNumberManager : NotificationManager, IDuplicateNumberManager
    {
        readonly IDuplicateNumberRepository repo = new DuplicateNumberRepository();
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(DuplicateNumberManager));
        public DuplicateNumberManager()
            : base(new DuplicateNumberLoader())
        { 
        }

        public override TypeNotification Type { get { return TypeNotification.DuplicatePipeNumber; } }

        public static Notification CreateNotification(Guid userId, string ownerName, string information)
        {
            return new Notification(userId, ownerName, TypeNotification.DuplicatePipeNumber, information);
        }

        public override void LoadNotifications()
        {
            notifications.Clear();
            List<DuplicateNumberEntity> allEntities = repo.GetAllActiveEntitites();
            List<string> duplicateNumber = repo.GetAllActiveDuplicateNumber();
            List<DuplicateNumberEntity> entitieForNotification = new List<DuplicateNumberEntity>();

            foreach (DuplicateNumberEntity e in allEntities)
            {
                if (duplicateNumber.Contains(e.EntityNumber))
                {
                    notifications.Add(new Notification(e.EntityID, e.EntityType + " №" + e.EntityNumber,
                        TypeNotification.DuplicatePipeNumber, e.EntityNumber, e.EntityType, (DuplicateNumberEntityType)Enum.Parse(typeof(DuplicateNumberEntityType), e.EntityType)));
                }
            }
        }
        public void RefreshNotifications()
        {
            LoadNotifications();
            NotificationService.Instance.NotifyInterested();
        }
    }
}
