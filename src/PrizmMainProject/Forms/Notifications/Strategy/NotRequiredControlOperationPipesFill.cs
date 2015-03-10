using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Notifications.Strategy
{
    class NotRequiredControlOperationPipesFill : StrategyNotificationFill
    {
        internal override void SetNotificationStatus(Notification notification)
        {
            if (notification.TimeToOccur > 0)
            {
                notification.Status = NotificationStatus.Warning;
            }
            else
            {
                notification.Status = NotificationStatus.Critical;
            }
        }
    }
}
