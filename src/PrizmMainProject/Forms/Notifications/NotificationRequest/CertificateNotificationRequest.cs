using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrizmMain.DummyData;

namespace Prizm.Main.Forms.Notifications.NotificationRequest
{
    class CertificateNotificationRequest : INotificationRequest
    {
        public List<Notification> GetNotification()
        {
            // Select Notification from DB
            return NotificationDummy.QueryNotification(TypeNotification.ExpiredCertificate);
        }
    }
}
