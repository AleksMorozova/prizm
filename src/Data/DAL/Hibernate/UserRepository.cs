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
   public class UserRepository : AbstractHibernateRepository<Guid, User>, IUserRepository
   {
      [Inject]
      public UserRepository(ISession session) : base(session)
      {
      }

      public User FindByLogin(string login)
      {
          return session.QueryOver<User>().Where(_ => _.Login == login).List().FirstOrDefault();
      }
   }
}
