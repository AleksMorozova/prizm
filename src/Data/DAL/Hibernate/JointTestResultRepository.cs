using Data.DAL.Construction;
using Domain.Entity.Construction;
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
    public class JointTestResultRepository : AbstractHibernateRepository<Guid, JointTestResult>, IJointTestResultRepository
    {
        [Inject]
        public JointTestResultRepository(ISession session)
            : base(session)
        {

        }
        public IList<JointTestResult> GetByJoint(Joint joint)
        {
            try
            {
                return session
                    .QueryOver<JointTestResult>()
                    .Where(x => x.Joint == joint)
                    .List<JointTestResult>();
            }
            catch (GenericADOException ex)
            {
                throw new RepositoryException("GetByJoint", ex);
            }
        }
    }
}
