using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Main.Forms.Notifications.Data;
using Prizm.Main.Forms.Notifications.Strategy;

namespace Prizm.Main.Forms.Notifications
{
    public abstract class NotificationManager : INotificationManager
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(NotificationManager));

        DataNotificationLoader loader;
        public List<Notification> notifications = new List<Notification>();

        public NotificationManager(DataNotificationLoader loader)
        {
            this.loader = loader;
        }

        public void LoadNotifications()
        {
            notifications.Clear();
            notifications.AddRange(loader.LoadNotifications());
        }


        public List<Notification> Notifications
        {
            get
            {
                return notifications;
            }
        }

        public int Count 
        { 
            get 
            { 
                return notifications.Count; 
            }
        }


        public virtual TypeNotification Type
        {
            get { throw new NotImplementedException(); }
        }

    }
}
