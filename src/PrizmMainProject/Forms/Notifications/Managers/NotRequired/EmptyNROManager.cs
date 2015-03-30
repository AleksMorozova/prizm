using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Notifications.Managers.NotRequired
{
    /// <summary>
    /// Use this class instead of real NotRequiredOperationManager, when non-required operation notifications are not needed.
    /// </summary>
    class EmptyNROManager : IPipeNotifierCreator, INotificationManager
    {
        private class EmptyNotifier : IPipeNotifier
        {
            public void UpdateNotifications(Domain.Entity.Mill.Pipe pipeSavingState) { }
        }

        public IPipeNotifier CreateNotifier(Domain.Entity.Mill.Pipe pipeInitialState)
        {
            return new EmptyNotifier();
        }

        public void LoadNotifications() { }

        private List<Notification> list = new List<Notification>();
        public List<Notification> Notifications
        {
            get { return list; }
        }

        public TypeNotification Type
        {
            get { return TypeNotification.NotRequiredInspectionOperation; }
        }

        public int Count
        {
            get { return list.Count; }
        }
    }
}
