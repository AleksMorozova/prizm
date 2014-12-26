using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrizmMain.DummyData;

namespace Prizm.Main.Forms.Notifications.NotificationRequest
{
    interface INotificationRequest
    {
        List<Notification> GetNotification();
    }
}
