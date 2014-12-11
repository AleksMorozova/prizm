using Data.DAL.Construction;
using Domain.Entity.Construction;
using NHibernate;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Hibernate
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
