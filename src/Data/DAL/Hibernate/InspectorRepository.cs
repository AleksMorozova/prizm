using Prizm.Data.DAL.Mill;
using Prizm.Domain.Entity;
using NHibernate;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Exceptions;

namespace Prizm.Data.DAL.Hibernate
{
    public class InspectorRepository : AbstractHibernateRepository<Guid, Inspector>, IInspectorRepository
    {
        [Inject]
        public InspectorRepository(ISession session)
            : base(session)
        {

        }

        public override IList<Inspector> GetAll()
        {
            try
            {
                var q = session.QueryOver<Inspector>()
                    .Fetch(x => x.Certificates).Eager
                    .List<Inspector>().Distinct<Inspector>().ToList<Inspector>();
                return q;
                //return session.CreateCriteria<Inspector>().List<Inspector>();
            }
            catch(GenericADOException ex)
            {
                throw new RepositoryException("GetAll", ex);
            }
        }
    }
}
