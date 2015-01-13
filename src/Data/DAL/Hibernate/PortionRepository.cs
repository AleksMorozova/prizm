using NHibernate;
using Ninject;
using Prizm.Data.DAL.Synch;
using Prizm.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Hibernate
{
   public class PortionRepository : AbstractHibernateRepository<Guid, Portion>, IPortionRepository
   {
      [Inject]
      public PortionRepository(ISession session) : base(session)
      {
      }
   }
}
