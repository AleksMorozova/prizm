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
    public class JointRepository : AbstractHibernateRepository<Guid, Joint>, IJointRepository
    {
        [Inject]
        public JointRepository(ISession session)
            : base(session)
        {
        }

        public IList<Joint> GetActiveByNumber(Joint joint)
        {
            try
            {
                return session.QueryOver<Joint>().Where(_ => _.IsActive == true && _.Id != joint.Id && _.Number == joint.Number).List<Joint>();
            }
            catch (GenericADOException ex)
            {
                throw new RepositoryException("GetActiveByNumber", ex);
            }
        }


        public IList<Joint> GetJointsToExport()
        {
           try
           {
              return session.QueryOver<Joint>().Where(_ => _.ToExport).List<Joint>();
           }
           catch (GenericADOException ex)
           {
              throw new RepositoryException("GetJointsToExport", ex);
           }
        }
    }
}
