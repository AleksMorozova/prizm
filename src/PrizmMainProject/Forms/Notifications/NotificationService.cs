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
        // Events
        public event EventHandler NotificationReload;

        #region --- Managers Properties ---
        public IDuplicateNumberManager DuplicateNumberManager 
        { 
            get 
            {
                return (IDuplicateNumberManager)managers.First(
                    (m) => { return m.Value.Type == TypeNotification.DuplicatePipeNumber; }
                    ).Value;
            } 
        }

        public IExpiredWelderCertificateManager ExpiredWelderCertificateManager
        {
            get
            {
                return (IExpiredWelderCertificateManager)managers.First(
                    (m) => { return m.Value.Type == TypeNotification.ExpiredWelderCertificate; }
                    ).Value;
            }
        }

        public IExpiredInspectorCertificateManager ExpiredInspectorCertificateManager
        {
            get
            {
                return (IExpiredInspectorCertificateManager)managers.First(
                    (m) => { return m.Value.Type == TypeNotification.ExpiredInspectorCertificate; }
                    ).Value;
            }
        }

        #endregion // --- Managers Properties ---

        // Fields
        private static NotificationService StaticInstance;
        private Dictionary<TypeNotification, INotificationManager> managers;

        // Methods
        private NotificationService()
        {
            managers = new Dictionary<TypeNotification, INotificationManager>();

            RegisterManager(new DuplicateLoginManager());
            RegisterManager(new DuplicateNumberManager());
            RegisterManager(new ExpiredWelderCertificateManager());
            RegisterManager(new ExpiredInspectorCertificateManager());
            RegisterManager(new NotRequiredOperationManager());
            RegisterManager(new NotRequiredOperationPipesManager());
            RegisterManager(new NotRequiredOperationTonsManager());
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

            EventHandler eventRefresh = this.NotificationReload;
            if (eventRefresh != null)
            {
                eventRefresh(this, EventArgs.Empty);
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
                list = managers.SelectMany(f => f.Value.Notifications).ToList(); 
                return list;
            }
        }

        public int NotificationCount
        {
            get
            {
                return managers.Sum(f => f.Value.Count);
            }
        }

    }

}
