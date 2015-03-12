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
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(NotificationManager));

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
                case TypeNotification.WelderCertificateExpired:
                    strategyFill = new WelderCertificateFill();
                    loader = new WelderCertificateLoader(this);
                    break;
                case TypeNotification.DublicateLogin:
                    strategyFill = new DublicateLoginFill();
                    loader = new DuplicateLoginLoader(this);
                    break;
                case TypeNotification.NotRequiredControlOperationPipes:
                    strategyFill = new NotRequiredControlOperationPipesFill();
                    loader = new NotRequiredControlOperationPipesLoader(this);
                    break;
                case TypeNotification.NotRequiredControlOperationTons:
                    strategyFill = new NotRequiredControlOperationTonsFill();
                    loader = new NotRequiredControlOperationTonsLoader(this);
                    break;
                case TypeNotification.NotRequiredControlOperationMeters:
                    strategyFill = new NotRequiredControlOperationMetersFill();
                    loader = new NotRequiredControlOperationMetersLoader(this);
                    break;
                default:
                    var ex = new NotImplementedException();
                    log.Error(ex.Message);
                    throw ex;
                    //break; // unreachable code
            }
        }

        public IList<Notification> LoadNotificationFromDB()
        {
            return loader.LoadNotificationFromDB();
        }

        public Notification CreateNotification(Guid ownerId, string ownerName, DateTime dateToOccur, float timeToOccur)
        {
            Notification notification = new Notification(ownerId, ownerName, type, dateToOccur, timeToOccur);
            strategyFill.FillAttribute(notification);
            return notification;
        }
    }
}
