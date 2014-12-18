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
    public class InspectorRepository : AbstractHibernateRepository<Guid, Inspector>, IInspectorRepository
    {
        [Inject]
        public InspectorRepository(ISession session)
            : base(session)
        {

        }
    }
}
