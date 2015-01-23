using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Prizm.Main.Forms.Settings;

namespace Prizm.Main.Forms.Notifications.Strategy
{
    class WelderCertificateFill : StrategyNotificationFill
    {
 
        internal override void SetNotificationStatus(Notification notification)
        {

            if (notification.DayToOccur <= 0)
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
