using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Transform;
using Prizm.Data.DAL.Notifications;
using Ninject;

namespace Prizm.Main.Forms.Notifications.Data
{
    public abstract class DataNotificationLoader : IResultTransformer
    {
        // Fields
        private INotificationManager manager;
        private INotificationRepository repo;

        // Methods
        public abstract string BuildSql();
        public abstract Guid GetId(object[] tuple);
        public abstract string GetOwnerName(object[] tuple);
        public abstract DateTime GetDateToOccur(object[] tuple);

        public DataNotificationLoader(NotificationManager manager)
        {
            this.manager = manager;
            repo = Program.Kernel.Get<INotificationRepository>();
        }

        public IList<Notification> LoadNotificationFromDB()
        {
            return repo.CreateSQLQuery(BuildSql()).SetResultTransformer(this).List<Notification>();
        }

        public System.Collections.IList TransformList(System.Collections.IList collection)
        {
            return collection;
        }

        public virtual object TransformTuple(object[] tuple, string[] aliases)
        {
            return manager.CreateNotification(GetId(tuple), GetOwnerName(tuple), GetDateToOccur(tuple));
        }
    }
}
