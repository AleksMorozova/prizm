using NHibernate;
using Ninject;
using Prizm.Data.DAL.Setup;
using Prizm.Domain.Entity.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Hibernate
{
    public class SeemTypeRepository: AbstractHibernateRepository<Guid, SeemType>, ISeemTypeRepository
    {
        [Inject]
        public SeemTypeRepository(ISession session)
            : base(session)
        { }
    }
}
