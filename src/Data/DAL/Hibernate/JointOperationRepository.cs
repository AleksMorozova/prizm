using Data.DAL.Setup;
using Domain.Entity.Setup;
using NHibernate;
using NHibernate.Exceptions;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Hibernate
{
    public class JointOperationRepository : AbstractHibernateRepository<Guid, JointOperation>, IJointOperationRepository
    {
        [Inject]
        public JointOperationRepository(ISession session)
            : base(session)
        {}
        public IList<JointOperation> GetControlOperations()
        {
            try
            {
                return session.QueryOver<JointOperation>().Where(n => ((n.IsTest ==true) && (n.IsActive == true))).List<JointOperation>();
            }
            catch (GenericADOException ex)
            {
                throw new RepositoryException("GetStored", ex);
            }
        }
        public IList<JointOperation> GetRepairOperations()
        {
            return session.QueryOver<JointOperation>().Where(n => ((n.IsTest == false) && (n.IsActive == true))).List<JointOperation>();
        }
    }
}
