using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Joint
{
    public class JointActionResult : Item
    {
        public virtual bool isCompleted { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual Joint Joint { get; set; }
        //TODO: uncomment after merge
        //public virtual JointOperation Operation { get; set; }
    }
}
