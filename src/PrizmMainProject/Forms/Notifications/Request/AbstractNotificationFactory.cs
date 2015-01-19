using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Transform;
using Prizm.Data.DAL.Notifications;
using Ninject;
using System.Drawing;
using Prizm.Main.Properties;
using System.IO;
using System.Drawing.Imaging;

namespace Prizm.Main.Forms.Notifications.Request
{
    abstract class AbstractNotificationFactory : IResultTransformer
    {
        // Methods
        internal abstract string BuildSql();
        internal abstract void SetFormTypeEditor(Notification notification);
        internal abstract void SetNotificationStatus(Notification notification, object[] tuple);
        internal abstract string GetRepresentation(object[] tuple);

        private readonly INotificationRepository repo = Program.Kernel.Get<INotificationRepository>();

        public IList<Notification> GetNotifications()
        {
            return repo.CreateSQLQuery(BuildSql()).SetResultTransformer(this).List<Notification>();
        }

        public System.Collections.IList TransformList(System.Collections.IList collection)
        {
            return collection;
        }

        public virtual object TransformTuple(object[] tuple, string[] aliases)
        {
            Notification notification = new Notification(NotificationType)
            {
                Id = (Guid)tuple[0],
                Name = GetRepresentation(tuple)
            };
            SetNotificationStatus(notification, tuple);
            SetFormTypeEditor(notification);
            return notification;
        }

        // Properties
        internal abstract TypeNotification NotificationType { get; }
    }
}
