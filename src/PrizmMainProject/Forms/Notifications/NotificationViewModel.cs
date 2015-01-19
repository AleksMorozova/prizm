using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Office.Forms;
using Ninject;

namespace Prizm.Main.Forms.Notifications
{
    class NotificationViewModel : ViewModelBase, IDisposable
    {
        private List<Notification> notification;


        public NotificationViewModel()
        {
            notification =  NotificationManager.Instance.Notifications;
        }

        public List<Notification> Notification
        {
            get
            {
                return notification;
            }

        }

        public void Dispose()
        {
        }
    }
}
