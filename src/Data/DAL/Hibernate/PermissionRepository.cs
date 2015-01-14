using Prizm.Data.DAL.Security;
using Prizm.Domain.Entity.Security;
using NHibernate;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entity.Security;

namespace Prizm.Data.DAL.Hibernate
{
   public class PermissionRepository : AbstractHibernateRepository<Guid, Permission>, IPermissionRepository
   {
      [Inject]
      public PermissionRepository(ISession session) : base(session)
      {}
      public void SeedPermissions()
      {
          BeginTransaction();
          foreach (string privilege in Enum.GetNames(typeof(Privileges)))
          {
              Permission permission = new Permission() { Name = privilege };          
              Save(permission);
          }
          Commit();
          foreach (Permission permission in GetAll())
          {
              Evict(permission);
          }
      }
   }
}
