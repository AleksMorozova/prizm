using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Security
{
   public class Permission
   {
      public virtual Guid Id { get; set; }
      public virtual string Name { get; set; }
      public virtual string Description { get; set; }
   }
}
