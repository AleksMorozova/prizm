using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Main.Forms.Notifications.NotificationRequest;
using PrizmMain.DummyData;

namespace Prizm.Main.Forms.Notifications
{
    class NotificationManager
    {

        // Fields
        private static NotificationManager StaticInstance;
        private Dictionary<TypeNotification, INotificationRequest> listNotificationRequest;
        private Dictionary<TypeNotification, List<Notification>> listNotification;

        // Events
        public event EventHandler NotificationReload;

        // Methods
        private NotificationManager()
        {
            listNotification = new Dictionary<TypeNotification, List<Notification>>();

            listNotificationRequest = new Dictionary<TypeNotification, INotificationRequest>();
            listNotificationRequest.Add(TypeNotification.DublicatePipeNumber, new PipeNotificationRequest());
            listNotificationRequest.Add(TypeNotification.ExpiredCertificate, new CertificateNotificationRequest());

        }


        public void RequestAllNotification()
        {
            foreach (var item in listNotificationRequest)
            {
                listNotification[item.Key] = item.Value.GetNotification();
            }

            EventHandler eventRefresh = this.NotificationReload;
            if (eventRefresh != null)
            {
                eventRefresh(this, EventArgs.Empty);
            }

        }

        private void RequestNotification(TypeNotification type)
        {
            listNotification[type] = listNotificationRequest[type].GetNotification();
        }

        public static NotificationManager Instance
        {
            get
            {
                if (StaticInstance == null)
                {
                    StaticInstance = new NotificationManager();
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
