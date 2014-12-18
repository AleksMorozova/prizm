using Prizm.Data.DAL.Construction;
using Prizm.Domain.Entity.Construction;
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
    public class JointWeldResultRepository : AbstractHibernateRepository<Guid, JointWeldResult>, IJointWeldResultRepository
    {
        [Inject]
        public JointWeldResultRepository(ISession session)
            : base(session)
        {

        }

        public IList<JointWeldResult> GetByJoint(Joint joint)
        {
            try
            {
                return session
                    .QueryOver<JointWeldResult>()
                    .Where(x => x.Joint == joint)
                    .List<JointWeldResult>();
            }
            catch (GenericADOException ex)
            {
                throw new RepositoryException("GetByJoint", ex);
            }
        }
    }
}
