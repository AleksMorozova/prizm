using Prizm.Main.Forms.Notifications.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Notifications
{
    class NotificationService
    {
        IDuplicateNumberManager DuplicateNumberManager 
        { 
            get 
            {
                return (IDuplicateNumberManager)managers.First(
                    (m) => { return m.Value.Type == TypeNotification.DuplicatePipeNumber; }
                    ).Value;
            } 
        }

        // Fields
        private static NotificationService StaticInstance;
        private Dictionary<TypeNotification, INotificationManager> managers;

        // Methods
        private NotificationService()
        {
            managers = new Dictionary<TypeNotification, INotificationManager>();

            RegisterManager(new DuplicateLoginManager());
            // TODO: add other managers
        }

        private void RegisterManager(INotificationManager manager)
        {
            managers.Add(manager.Type, manager);
        }

        public void RequestAllNotification()
        {
            foreach (var item in managers)
            {
                item.Value.LoadNotifications();
            }

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
                list = managers.SelectMany(f => f.Value).ToList(); // TODO ???
                return list;
            }
        }

        public int NotificationCount
        {
            get
            {
                return managers.Sum(CountSummator);
            }
        }

        private static int CountSummator(KeyValuePair<TypeNotification, INotificationManager> arg)
        {
            return (int)arg.Value.Count;
        }

    }

}
