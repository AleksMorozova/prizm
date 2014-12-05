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
   public class UserRepository : AbstractHibernateRepository<Guid, User>, IUserRepository
   {
      [Inject]
      public UserRepository(ISession session) : base(session)
      {
      }

      public User FindByLogin(string login)
      {
         return session.CreateQuery("from User where login = :login").SetString("login", login).UniqueResult<User>();
      }
   }
}
