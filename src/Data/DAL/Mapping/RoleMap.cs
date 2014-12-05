using Domain.Entity.Security;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Mapping
{
   public class RoleMap : ClassMap<Role>
   {
      public RoleMap()
      {
         Id(_ => _.Id);
         Map(_ => _.Name, "name");
         Map(_ => _.Description, "description");
         HasManyToMany<Permission>(_ => _.Permissions)
            .Table("Role_Permission")
            .ParentKeyColumn("roleId")
            .ChildKeyColumn("permissionId");
      }
   }
}
