using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Notifications
{
    interface INotificationManager
    {
        IList<Notification> LoadNotificationFromDB();
        Notification CreateNotification(Guid ownerId, string representation, DateTime dateToOccur);
    }
}
