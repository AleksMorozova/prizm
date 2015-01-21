using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Notifications
{
    class NotificationService
    {

        // Fields
        private static NotificationService StaticInstance;
        private Dictionary<TypeNotification, INotificationManager> listNotificationRequest;
        private Dictionary<TypeNotification, IList<Notification>> listNotification;

        // Events
        public event EventHandler NotificationReload;

        // Methods
        private NotificationService()
        {
            listNotification = new Dictionary<TypeNotification, IList<Notification>>();
            listNotificationRequest = new Dictionary<TypeNotification, INotificationManager>();

            foreach (TypeNotification type in Enum.GetValues(typeof(TypeNotification)))
            {
                RegisterManager(type);
            }

        }

        private void RegisterManager(TypeNotification type)
        {
            listNotificationRequest.Add(type, new NotificationManager(type));
        }


        public void RequestAllNotification()
        {
            foreach (var item in listNotificationRequest)
            {
                listNotification[item.Key] = item.Value.LoadNotificationFromDB();
            }

            EventHandler eventRefresh = this.NotificationReload;
            if (eventRefresh != null)
            {
                eventRefresh(this, EventArgs.Empty);
            }

        }

        private void RequestNotification(TypeNotification type)
        {
            listNotification[type] = listNotificationRequest[type].LoadNotificationFromDB();
        }

        public static NotificationService Instance
        {
            get
            {
                if (StaticInstance == null)
                {
                    StaticInstance = new NotificationService();
                }
                return StaticInstance;
            }
        }


        // Properties
        public List<Notification> Notifications
        {
            get
            {
                List<Notification> list = new List<Notification>();
                list = listNotification.SelectMany(f => f.Value).ToList();
                return list;
            }
        }

        public int NotificationCount
        {
            get
            {
                return listNotification.SelectMany(f => f.Value).Count();
            }
        }

    }

}
