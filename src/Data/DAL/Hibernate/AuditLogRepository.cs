using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using Ninject;
using Domain.Entity;
using NHibernate.Criterion;

namespace Data.DAL.Hibernate
{
    public class AuditLogRepository : AbstractHibernateRepository<Guid, AuditLog>, IAuditLogRepository 
    {
        [Inject]
        public AuditLogRepository(ISession session)
            : base(session)
        {            
        }
        public IEnumerable<string> GetAllUsers()
        {
            return (from b in session.QueryOver<AuditLog>() select b.User).List<string>().Distinct();
        }
    }
}
