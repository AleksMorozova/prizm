using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using Ninject;
using Prizm.Domain.Entity;
using NHibernate.Criterion;

namespace Prizm.Data.DAL.Hibernate
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

        //public IList<AuditLog> GetRecords(string user, DateTime startDate, DateTime endDate, string entityID)
        //{

        //    return session.QueryOver<AuditLog>().Where(_ => _.AuditDate <= endDate && _.AuditDate >= startDate).WhereRestrictionOn(x => x.User).IsLike(user).List<AuditLog>();

        //}


        //public IList<AuditLog> GetRecords(string user, DateTime startDate, DateTime endDate, string entityIDSub)
        //{
        //     return session.QueryOver<AuditLog>().Where(_ => _.AuditDate <= endDate && _.AuditDate >= startDate && _.EntityID.ToString().StartsWith(entityIDSub)).List<AuditLog>();
        //}

        public IList<AuditLog> GetRecords(string entityIDSub, string user)
        {
            //Guid substr = new Guid(entityIDSub + "%");
            string substr = entityIDSub;
            return session.QueryOver<AuditLog>().WhereRestrictionOn(_ => _.EntityID.ToString()).IsLike(substr, MatchMode.Start).WhereRestrictionOn(x => x.User).IsLike(user).List<AuditLog>();
            //return session.QueryOver<AuditLog>().WhereRestrictionOn(x => x.User).IsLike(user).List<AuditLog>();
        }

        public IList<AuditLog> GetRecords(string entityIDSub, DateTime startDate, DateTime endDate)
        {
            return session.QueryOver<AuditLog>().Where(_ => _.AuditDate <= endDate && _.AuditDate >= startDate).List<AuditLog>();
        }


    }
}
