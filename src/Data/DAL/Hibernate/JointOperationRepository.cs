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

        public void SeedRequiredWeld(string requiredWeldOperation)
        {
            try
            {
                if (GetAll().Count == 0)
                {
                    BeginTransaction();
                    Save(new JointOperation()
                    { 
                        IsActive = true,
                        IsRequired = true,
                        Type = JointOperationType.Weld,
                        Name = requiredWeldOperation
                    }
                        );
                }
            }
            catch (GenericADOException e)
            {
                throw new RepositoryException("SeedRequiredWeld", e);
            }
        }

        public JointOperation GetRequiredWeld(string requiredWeldOperation)
        {
            try
            {
                return session.QueryOver<JointOperation>().Where(_ => _.Name == requiredWeldOperation && _.Type == JointOperationType.Weld).SingleOrDefault();
            }
            catch(GenericADOException e)
            { 
              throw new RepositoryException("GetRequiredWeld", e);
            }
        }
    }
}
