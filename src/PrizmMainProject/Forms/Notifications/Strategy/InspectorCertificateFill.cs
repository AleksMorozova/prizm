using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Main.Forms.PipeMill.NewEdit;
using Prizm.Main.Forms.Settings;
using Prizm.Main.Properties;

namespace Prizm.Main.Forms.Notifications.Strategy
{
    class InspectorCertificateFill : StrategyNotificationFill
    {

  
        internal override void SetNotificationStatus(Notification notification)
        {

            if (notification.DayToOccur < 0)
            {
                notification.Status = NotificationStatus.Critical;
            }
            else
            {
                notification.Status = NotificationStatus.Warning;
            }
        }

    }
}
