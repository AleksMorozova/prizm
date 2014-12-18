using Prizm.Data.DAL.Security;
using Prizm.Domain.Entity.Security;
using NHibernate;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Hibernate
{
   public class PermissionRepository : AbstractHibernateRepository<Guid, Permission>, IPermissionRepository
   {
      [Inject]
      public PermissionRepository(ISession session) : base(session)
      {
      }
   }
}
