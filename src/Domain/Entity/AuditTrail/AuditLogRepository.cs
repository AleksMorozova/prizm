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
        private ISessionFactory sessionFactory;
        private ISession session;
        private AuditLog record;
        public AuditLogRepository(AuditLog record)
        {
            this.record = record;
        }
        public void Insert()
        {
            try
            {
                if (CurrentSessionContext.HasBind(sessionFactory))
                {
                    session = sessionFactory.GetCurrentSession();
                }
                else
                {
                    session = sessionFactory.OpenSession();
                    CurrentSessionContext.Bind(session);
                }
                session.Save(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {
                if (sessionFactory != null && CurrentSessionContext.HasBind(sessionFactory))
                {
                    var session = CurrentSessionContext.Unbind(sessionFactory);
                    session.Close();
                }
            }
        }
    }
}
