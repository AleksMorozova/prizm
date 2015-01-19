using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Main.Forms.PipeMill.NewEdit;
using Prizm.Main.Forms.Settings;
using Prizm.Main.Properties;

namespace Prizm.Main.Forms.Notifications.Request
{
    class CertificateNotificationFactory : AbstractNotificationFactory
    {

        internal override string BuildSql()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(
                @" SELECT
                    InspectorCertificate.id,
                    Inspector.firstName,
                    Inspector.lastName,
                    Inspector.middleName,
                    InspectorCertificate.number,
                    InspectorCertificate.expirationDate,
                    DATEDIFF(day, GETDATE(), InspectorCertificate.expirationDate) As DayToExpired
                    FROM  InspectorCertificate 
                    LEFT OUTER JOIN Inspector ON 
                    InspectorCertificate.inspectorId = Inspector.id
                    WHERE (InspectorCertificate.isActive = 1) 
                    AND (DATEDIFF(day, GETDATE(), InspectorCertificate.expirationDate) < 5)");
            return sb.ToString();
        }


        internal override string GetRepresentation(object[] tuple)
        {
            return tuple[1].ToString() + " " + tuple[2].ToString() + " " + tuple[3].ToString() + " " +
            Resources.ResourceManager.GetString("Certificate") + " №" + tuple[4].ToString();
        }

        internal override void SetFormTypeEditor(Notification notification)
        {
            notification.Editor = typeof(SettingsXtraForm);
        }

        internal override void SetNotificationStatus(Notification notification, object[] tuple)
        {
            int dayToExpired = (int)tuple[6];

            if (dayToExpired <= 0)
            {
                notification.Status = NotificationStatus.Critical;
            }
            else
            {
                notification.Status = NotificationStatus.Warning;
            }

        }

        internal override TypeNotification NotificationType
        {
            get
            {
                return TypeNotification.ExpiredCertificate;
            }
        }
    }
}
