using NHibernate;
using Ninject;
using Prizm.Data.DAL;
using Prizm.Data.DAL.Hibernate;
using Prizm.Data.DAL.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Audit
{
    public class AuditRepository: IAuditRepository
    {
        private readonly IAuditLogRepository auditLogRepo;
        private readonly IUserRepository userRepo;

        private readonly ISession session;

        [Inject]
        public AuditRepository(ISession session)
        {
            this.session = session;
            this.auditLogRepo = new AuditLogRepository(session);
            this.userRepo = new UserRepository(session);
        }

        public IAuditLogRepository AuditLogRepo
        {
            get { return auditLogRepo; } 
        }
        public IUserRepository UserRepo
        { 
            get { return userRepo; } 
        }

        public void Commit()
        {
            session.Transaction.Commit();
        }

        public void BeginTransaction()
        {
            session.BeginTransaction();
        }

        public void Rollback()
        {
            session.Transaction.Rollback();
        }

        public void Dispose()
        {
            session.Dispose();
        }
    }
}
