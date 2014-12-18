using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using NHibernate;
using Prizm.Data.DAL.Mill;
using Prizm.Domain.Entity.Mill;

namespace Prizm.Data.DAL.Hibernate
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
