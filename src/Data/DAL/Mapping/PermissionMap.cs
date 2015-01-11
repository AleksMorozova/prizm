using Prizm.Domain.Entity.Security;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Mapping
{
   public class PermissionMap : ClassMap<Permission>
   {
      public PermissionMap()
      {
         Id(_ => _.Id);
         Map(_ => _.Name, "name");
      }
   }
}
