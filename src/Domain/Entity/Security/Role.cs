using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Domain.Entity.Security
{
   public class Role
   {
      public Role()
      {
         Permissions = new List<Permission>();
      }

      public virtual Guid Id { get; set; }
      public virtual string Name { get; set; }
      public virtual string Description { get; set; }
      public virtual IList<Permission> Permissions { get; set; }
   }
}
