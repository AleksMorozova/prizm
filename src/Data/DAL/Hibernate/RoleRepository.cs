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
   public class RoleRepository : AbstractHibernateRepository<Guid, Role>, IRoleRepository
   {
      [Inject]
      public RoleRepository(ISession session) : base(session)
      {
      }
   }
}
