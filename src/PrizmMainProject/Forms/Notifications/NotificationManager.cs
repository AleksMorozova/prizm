using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Main.Forms.Notifications.Data;

namespace Prizm.Main.Forms.Notifications
{
    public abstract class NotificationManager : INotificationManager
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(NotificationManager));

        readonly List<DataNotificationLoader> loaders = new List<DataNotificationLoader>();
        public readonly List<Notification> notifications = new List<Notification>();

        public NotificationManager(DataNotificationLoader loader)
        {
            loaders.Add(loader);
        }

        protected void AddLoader(DataNotificationLoader loader)
        {
            loaders.Add(loader);
        }

        public void LoadNotifications()
        {
            notifications.Clear();
            foreach (var loader in loaders)
            {
                notifications.AddRange(loader.LoadNotifications());
            }
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

        /// <summary>
        /// Override in derived classes
        /// </summary>
        public virtual TypeNotification Type
        {
            get { throw new NotImplementedException(); }
        }

    }
}
