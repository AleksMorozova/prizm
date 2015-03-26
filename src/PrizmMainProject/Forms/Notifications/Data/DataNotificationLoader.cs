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
    public abstract class DataNotificationLoader
    {
        // Fields
        private INotificationRepository repo;
        private IResultTransformer transformer;

        // Methods
        public abstract string BuildSql();

        public DataNotificationLoader(IResultTransformer transformer)
        {
            this.transformer = transformer;
            repo = Program.Kernel.Get<INotificationRepository>();
        }

        public IList<Notification> LoadNotifications()
        {
            return repo.CreateSQLQuery(BuildSql()).SetResultTransformer(transformer).List<Notification>();
        }

    }
}