using Prizm.Domain.Entity.Mill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Domain.Entity
{
   public class Portion
   {
      public Portion()
      {
         Pipes = new List<Pipe>();
      }

      public virtual Guid Id { get; set; }
      public virtual DateTime ExportDateTime { get; set; }
      public virtual IList<Pipe> Pipes { get; set; }
      public virtual IList<Project> Projects { get; set; }
   }
}
