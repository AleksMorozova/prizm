using Prizm.Data.DAL.Mill;
using Prizm.Domain.Entity;
using NHibernate;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Hibernate
{
    public class WelderRepository :AbstractHibernateRepository<Guid,Welder>, IWelderRepository
    {
        [Inject]
        public WelderRepository(ISession session)
            : base(session)
        {

        }
    }
}
