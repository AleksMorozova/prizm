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

        public DuplicateNumberManager()
            : base(new DuplicateNumberLoader())
        { 
        }

        public override TypeNotification Type { get { return TypeNotification.DuplicatePipeNumber; } }

        public static Notification CreateNotification(Guid userId, string ownerName, string information)
        {
            return new Notification(userId, ownerName, TypeNotification.DuplicatePipeNumber, information);
        }


        public void RefreshNotifications()
        {
            LoadNotifications();
            // TODO: NotifyInterested
        }
    }
}
