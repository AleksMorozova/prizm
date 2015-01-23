using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Main.Forms.PipeMill.NewEdit;

namespace Prizm.Main.Forms.Notifications.Strategy
{
    class DublicateNumberFill : StrategyNotificationFill
    {


        internal override void SetNotificationStatus(Notification notification)
        {
            notification.Status = NotificationStatus.Critical;
        }

    }
}
