using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using Ninject;
using Domain.Entity;

namespace Data.DAL.Hibernate
{
    public class AuditLogRepository : AbstractHibernateRepository<Guid, AuditLog>, IAuditLogRepository 
    {
        [Inject]
        public AuditLogRepository(ISession session)
            : base(session)
        {
        }
    }
}
