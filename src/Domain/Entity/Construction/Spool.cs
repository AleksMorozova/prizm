using Domain.Entity.Mill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Construction
{
    public class Spool : Part
    {
        public virtual string PipeNumber { get; set; }
        public virtual Pipe Pipe { get; set; }
    }
}
