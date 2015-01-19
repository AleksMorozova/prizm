using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using Ninject;
using Prizm.Data.DAL.Notifications;
using Prizm.Domain.Entity;

namespace Prizm.Data.DAL.Hibernate
{
    public class NotificationRepository : AbstractHibernateRepository<Guid, Item>, INotificationRepository
    {
        [Inject]
        public NotificationRepository(ISession session)
            : base(session)
        {
        }
    }
}
