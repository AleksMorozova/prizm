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
    public class ComponentRepository: AbstractHibernateRepository<Guid, Component>, IComponentRepository
    {
        [Inject]
        public ComponentRepository(ISession session)
            : base(session)
        { }
        
    }
}
