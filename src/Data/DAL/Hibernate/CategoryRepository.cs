using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using NHibernate;
using Data.DAL.Mill;
using Domain.Entity.Mill;

namespace Data.DAL.Hibernate
{
    public class CategoryRepository: AbstractHibernateRepository<Guid, Category>, ICategoryRepository
    {
        [Inject]
        public CategoryRepository(ISession session)
            : base(session)
        {

        }
    }
}
