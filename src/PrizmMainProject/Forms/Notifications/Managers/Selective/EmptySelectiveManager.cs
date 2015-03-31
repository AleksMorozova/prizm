using Prizm.Main.Forms.Notifications.Managers.NotRequired;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Notifications.Managers.Selective
{
    class EmptySelectiveManager : IPipeNotifierCreator, INotificationManager
    {
        public void LoadNotifications()
        {
        }

        private List<Notification> list = new List<Notification>();
        public List<Notification> Notifications
        {
            get { return list; }
        }

        public TypeNotification Type
        {
            get { return TypeNotification.SelectiveInspectionOperation; }
        }

        public int Count
        {
            get { return list.Count; }
        }

        private class EmptyNotifier : IPipeNotifier
        {
            public void UpdateNotifications(Domain.Entity.Mill.Pipe pipeSavingState) { }
        }

        public IPipeNotifier CreateNotifier(Domain.Entity.Mill.Pipe pipeInitialState)
        {
            return new EmptyNotifier();
        }
    }
}
