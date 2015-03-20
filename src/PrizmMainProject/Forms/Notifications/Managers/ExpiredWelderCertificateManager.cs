using Prizm.Main.Forms.Notifications.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Notifications.Managers
{
    class ExpiredWelderCertificateManager: NotificationManager, IExpiredWelderCertificateManager
    {
        public ExpiredWelderCertificateManager()
            : base(new ExpiredWelderCertificateLoader())
        { 
        }

        public override TypeNotification Type { get { return TypeNotification.ExpiredWelderCertificate; } }

        public static Notification CreateNotification(Guid userId, string ownerName, DateTime expirationDate, string information)
        {
            return new Notification(userId, ownerName, TypeNotification.ExpiredWelderCertificate, information, expirationDate);
        }


        public void RefreshNotifications()
        {
            LoadNotifications();
            // TODO: NotifyInterested
        }

    }
}
