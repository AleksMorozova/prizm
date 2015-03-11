using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Notifications.Strategy
{
    public class DuplicateLoginFill : StrategyNotificationFill
    {
        internal override void SetNotificationStatus(Notification notification)
        {
            notification.Status = NotificationStatus.Critical;
        }
    }
}
