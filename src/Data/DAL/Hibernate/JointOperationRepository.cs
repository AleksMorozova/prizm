using Prizm.Data.DAL.Setup;
using Prizm.Domain.Entity.Setup;
using NHibernate;
using NHibernate.Exceptions;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Hibernate
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
                return session.QueryOver<JointOperation>().Where(n => ((n.Type == JointOperationType.Test) && (n.IsActive == true))).List<JointOperation>();
            }
            catch (GenericADOException ex)
            {
                throw new RepositoryException("GetControlOperations", ex);
            }
        }
        public IList<JointOperation> GetRepairOperations()
        {
            try
            {
                return session.QueryOver<JointOperation>().Where(n => ((n.Type != JointOperationType.Test) && (n.IsActive == true))).List<JointOperation>();
            }
            catch (GenericADOException e)
            {
                throw new RepositoryException("GetRepairOperations", e);
            }
        }
    }
}
