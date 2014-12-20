using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Office.Forms;
using PrizmMain.DummyData;
using Ninject;

namespace Prizm.Main.Forms.Notifications
{
    class NotificationViewModel : ViewModelBase, IDisposable
    {
        private List<NotificationOwners> notification;

        [Inject]
        public NotificationViewModel()
        {
            notification = new NotificationDummy().GetAllOwners().ToList();
        }

        public List<NotificationOwners> Notification
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
