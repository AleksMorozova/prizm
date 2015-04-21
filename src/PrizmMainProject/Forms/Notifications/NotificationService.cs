using Prizm.Data.DAL;
using Prizm.Main.Forms.Notifications.Managers;
using Prizm.Main.Forms.Notifications.Managers.NotRequired;
using Prizm.Main.Forms.Notifications.Managers.Selective;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Notifications
{
    class NotificationService
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(NotificationService));
        // Events
        public event EventHandler NotificationsChanged;

        #region --- Managers Properties ---
        public IPipeNotifierCreator SelectiveOperationManager
        {
            get
            {
                return (IPipeNotifierCreator)managers.First(
                    (m) => { return m.Value.Type == TypeNotification.SelectiveInspectionOperation; }
                    ).Value;
            }
        }

        public IPostponeConflictManager PostponeConflictManager
        {
            get
            {
                return (IPostponeConflictManager)managers.First(
                    (m) => { return m.Value.Type == TypeNotification.PostponeConflict; }
                    ).Value;
            }
        }

        public IDuplicateNumberManager DuplicateNumberManager 
        { 
            get 
            {
                return (IDuplicateNumberManager)managers.First(
                    (m) => { return m.Value.Type == TypeNotification.DuplicatePipeNumber; }
                    ).Value;
            } 
        }

        public IDuplicateLoginManager DuplicateLoginManager
        {
            get
            {
                return (IDuplicateLoginManager)managers.First(
                    (m) => { return m.Value.Type == TypeNotification.DuplicateLogin; }
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

        public IPipeNotifierCreator NotRequiredOperationManager
        {
            get
            {
                return (IPipeNotifierCreator)managers.First(
                    (m) => { return m.Value.Type == TypeNotification.NotRequiredInspectionOperation; }
                    ).Value;
            }
        }

        #endregion // --- Managers Properties ---

        // Fields
        private static NotificationService staticInstance = new NotificationService();
        private Dictionary<TypeNotification, INotificationManager> managers;

        /// <summary>
        /// All types of managers, used in Managers Properties, must registered in this method.
        /// 
        /// </summary>
        private NotificationService()
        {
            log.Info("Registering notification managers...");

            managers = new Dictionary<TypeNotification, INotificationManager>();
            RegisterManager(new DuplicateLoginManager());
            RegisterManager(new DuplicateNumberManager());
            RegisterManager(new ExpiredWelderCertificateManager());
            RegisterManager(new ExpiredInspectorCertificateManager());
            RegisterManager(new PostponeConflictManager());

            if (Program.ThisWorkstationType == Domain.Entity.Setup.WorkstationType.Mill)
            {
                RegisterManager(new NotRequiredOperationManager());
                RegisterManager(new SelectiveOperationManager());
            }
            else
            {
                RegisterManager(new EmptyNROManager());
                RegisterManager(new EmptySelectiveManager());
            }
        }

        /// <summary>
        /// Registers one manager
        /// </summary>
        /// <param name="manager">notification manager to be registered</param>
        private void RegisterManager(INotificationManager manager)
        {
            managers.Add(manager.Type, manager);
        }

        /// <summary>
        /// 
        /// </summary>
        public void LoadAllNotifications()
        {
            foreach (var item in managers)
            {
                item.Value.LoadNotifications();
            }
            NotifyInterested();
        }

        /// <summary>
        /// Notify about reloading
        /// </summary>
        public void NotifyInterested() 
        {
            if (NotificationsChanged != null)
            {
                NotificationsChanged(this, EventArgs.Empty);
            }
        }
        public static NotificationService Instance { get { return staticInstance; } }

        /// <summary>
        /// List of all notifications in system
        /// </summary>
        public List<Notification> Notifications
        {
            get
            {
                List<Notification> list = new List<Notification>();
                list = managers.SelectMany(f => f.Value.Notifications).ToList(); 
                return list;
            }
        }

        /// <summary>
        /// Count of all notifications in system
        /// </summary>
        public int NotificationCount
        {
            get
            {
                return managers.Sum(f => f.Value.Count);
            }
        }

    }

}
