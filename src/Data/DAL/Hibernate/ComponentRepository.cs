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
    public class ComponentRepository: AbstractHibernateRepository<Guid, Component>, IComponentRepository
    {
        [Inject]
        public ComponentRepository(ISession session) : base(session) { }

        public IList<Component> GetActiveByNumber(Component component)
        {
            try
            {
                return session
                    .QueryOver<Component>()
                    .Where(x => x.IsActive && x.Number == component.Number && x.Id != component.Id)
                    .List<Component>();
            }
            catch (GenericADOException ex)
            {
                throw new RepositoryException("Get", ex);
            }
        }



        public IList<Component> GetComponentsToExport()
        {
           try
           {
              return session.QueryOver<Component>().Where(x => x.ToExport).List<Component>();
           }
           catch (GenericADOException ex)
           {
              throw new RepositoryException("GetComponentsToExport", ex);
           }
        }
    }
}
