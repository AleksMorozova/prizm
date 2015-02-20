using NHibernate;
using Ninject;
using Prizm.Data.DAL.Mill;
using Prizm.Domain.Entity.Mill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Hibernate
{
    public class CannedMessageRepository : AbstractHibernateRepository<Guid, CannedMessage>, ICannedMessageRepository
    {
        [Inject]
        public CannedMessageRepository(ISession session)
            : base(session)
        {

        }
    }
}
