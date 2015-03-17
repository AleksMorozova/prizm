using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Domain.Entity.Mill
{
   public class Coat : Item
   {
      public virtual DateTime Date { get; set; }
      public virtual CoatingType Type { get; set; }
      public virtual Pipe Pipe { get; set; }

      public override Guid OwnerId
      {
          get
          {
              return (Pipe == null) ? this.Id : Pipe.Id;
          }
          set
          {
              base.OwnerId = value;
          }
      }
   }
}
