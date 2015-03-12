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

        public static Notification CreateNotification(Guid userId, string ownerName, DateTime dateToOccur, string information)
        {
            return new Notification(userId, ownerName, TypeNotification.DuplicatePipeNumber, dateToOccur, information);
        }


        public void RefreshNotification(Guid pipe, string oldNumber, string newNumber)
        {
            throw new NotImplementedException();
        }
    }
}
