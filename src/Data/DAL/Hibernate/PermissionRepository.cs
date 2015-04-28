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
using NHibernate.Exceptions;

namespace Prizm.Data.DAL.Hibernate
{
    public class PermissionRepository : AbstractHibernateRepository<Guid, Permission>, IPermissionRepository
    {
        [Inject]
        public PermissionRepository(ISession session)
            : base(session)
        { }
        public void SeedPermissions()
        {
            try
            {
                BeginTransaction();
                foreach(Privileges p in Enum.GetValues(typeof(Privileges)))
                {
                    // Null privileges won't seed.
                    if(p == Privileges.NullPrivilegeAllowed || p == Privileges.NullPrivilegeRestricted)
                    {
                        continue;
                    }
                    Permission permission = new Permission() { Name = p.ToString() };
                    Save(permission);
                }
                Commit();
                foreach(Permission permission in GetAll())
                {
                    Evict(permission);
                }
            }
            catch(GenericADOException ex)
            {
                throw new RepositoryException("SeedPermissions", ex);
            }
        }
    }
}
