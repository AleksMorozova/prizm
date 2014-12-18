using Prizm.Domain.Entity;
using Prizm.Domain.Entity.Security;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Mapping
{
   public class UserMap : SubclassMap<User>
   {
      public UserMap()
      {
         Map(_ => _.Login, "login");
         Map(_ => _.PasswordExpires, "password_expires");
         Map(_ => _.PasswordHash, "password_hash");
         Map(_ => _.Undeletable).Column("undeletable");
         Component<PersonName>(x => x.Name, m =>
         {
            m.Map(x => x.FirstName).Column("firstName");
            m.Map(x => x.MiddleName).Column("middleName");
            m.Map(x => x.LastName).Column("lastName");
         });
         HasManyToMany<Role>(_ => _.Roles)
            .Table("User_Role")
            .ParentKeyColumn("userId")
            .ChildKeyColumn("roleId").Not.LazyLoad();
      }
   }
}
