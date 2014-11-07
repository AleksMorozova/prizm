using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Context;

namespace Domain.Entity.AuditTrail
{
    public class AuditLogRepository : IAuditLogRepository 
    {
        // TODO : get somehow sessionFactory
        public ISessionFactory sessionFactory;
        private ISession session;

        public AuditLogRepository(ISessionFactory sessionFactory)
        {
            this.sessionFactory = sessionFactory;
        }
        public void Insert(AuditLog record)
        {
            try
            {
                session = sessionFactory.OpenSession();
                session.Save(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                session.Close();
            }
        }
    }
}
