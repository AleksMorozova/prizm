using Domain.Entity.Mill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Setup
{
    public class PipeMillSizeType: Item
    {
        public PipeMillSizeType()
        {
            PipeTests = new List<PipeTest>();
            Pipes = new List<Pipe>();
        }
        public virtual string Type { get; set; }
        
        public virtual IList<PipeTest> PipeTests { get; set; }
        public virtual IList<Pipe> Pipes { get; set; }


    }
}
