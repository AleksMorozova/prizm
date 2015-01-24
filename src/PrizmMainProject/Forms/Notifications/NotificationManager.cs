using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Main.Forms.Notifications.Data;
using Prizm.Main.Forms.Notifications.Strategy;

namespace Prizm.Main.Forms.Notifications
{
    public class NotificationManager : INotificationManager
    {
        StrategyNotificationFill strategyFill;
        DataNotificationLoader loader;
        TypeNotification type;

        public NotificationManager(TypeNotification type)
        {
            this.type = type;
            switch (type)
            {
                case TypeNotification.DublicatePipeNumber:
                    strategyFill = new DublicateNumberFill();
                    loader = new DublicateNumberLoader(this);
                    break;
                case TypeNotification.ExpiredCertificate:
                    this.strategyFill = new InspectorCertificateFill();
                    loader = new InspectorCertificateLoader(this);
                    break;
                case TypeNotification.WelderCrtificateExpired:
                    strategyFill = new WelderCertificateFill();
                    loader = new WelderCertificateLoader(this);
                    break;
                default:
                    throw new NotImplementedException();
                    //break; // unreachable code
            }
        }

        public IList<Notification> LoadNotificationFromDB()
        {
            return loader.LoadNotificationFromDB();
        }

        public Notification CreateNotification(Guid ownerId, string ownerName, DateTime dateToOccur)
        {
            Notification notification = new Notification(ownerId, ownerName, type, dateToOccur);
            strategyFill.FillAttribute(notification);
            return notification;
        }
    }
}
