using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Notifications.Request
{
    class NotificationRequest : INotificationRequest
    {
        AbstractNotificationFactory factory;

        public NotificationRequest(AbstractNotificationFactory factory)
        {
            this.factory = factory;
        }

        public IList<Notification> GetNotification()
        {
            return factory.GetNotifications();
        }
    }
}
