using Prizm.Main.Forms.Notifications.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Notifications.Managers
{
    class ExpiredInspectorCertificateManager : NotificationManager, IExpiredInspectorCertificateManager
    {
        public ExpiredInspectorCertificateManager()
            : base(new ExpiredInspectorCertificateLoader())
        { 
        }

        public override TypeNotification Type { get { return TypeNotification.ExpiredInspectorCertificate; } }

        public static Notification CreateNotification(Guid userId, string ownerName, DateTime dateToOccur, string information)
        {
            Notification notification = new Notification(userId, ownerName, TypeNotification.ExpiredInspectorCertificate, dateToOccur, information);
            if (notification.DayToOccur < 0)
            {
                notification.Status = NotificationStatus.Critical;
            }
            else
            {
                notification.Status = NotificationStatus.Warning;
            }
            return notification;
        }

        public void RefreshNotification(Guid pipe, string oldNumber, string newNumber)
        {
            throw new NotImplementedException();
        }
    }
}
