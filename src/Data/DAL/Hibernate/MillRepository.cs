using Data.DAL.Mill;
using NHibernate;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Hibernate
{
    public class MillRepository : AbstractHibernateRepository<Guid, Domain.Entity.Mill.Mill>, IMillRepository
    {
        [Inject]
        public MillRepository(ISession session)
            : base(session)
        {

        }
    }
}
