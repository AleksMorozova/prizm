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

        public static Notification CreateNotification(Guid userId, string ownerName, DateTime expirationDate, string information)
        {
            return new Notification(userId, ownerName, TypeNotification.ExpiredInspectorCertificate, information, expirationDate);
        }

        public void RefreshNotifications()
        {
            LoadNotifications();
            // TODO: NotifyInterested
        }

    }
}
