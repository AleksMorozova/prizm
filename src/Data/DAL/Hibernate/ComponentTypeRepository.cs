using Prizm.Data.DAL.Construction;
using Prizm.Domain.Entity.Construction;
using NHibernate;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Hibernate
{
    public class ComponentTypeRepository: AbstractHibernateRepository<Guid, ComponentType>, IComponentTypeRepository
    {
        [Inject]
        public ComponentTypeRepository(ISession session)
            : base(session)
        {
        
        }
    
    }
}
