using Data.DAL.Security;
using Domain.Entity.Security;
using NHibernate;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Hibernate
{
   public class PermissionRepository : AbstractHibernateRepository<Guid, Permission>, IPermissionRepository
   {
      [Inject]
      public PermissionRepository(ISession session) : base(session)
      {
      }
   }
}
