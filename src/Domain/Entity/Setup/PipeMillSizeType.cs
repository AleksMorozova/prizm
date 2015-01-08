using Prizm.Domain.Entity.Mill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Domain.Entity.Setup
{
    public class PipeMillSizeType: Item
    {
        public PipeMillSizeType()
        {
            PipeTests = new List<PipeTest>();
            Pipes = new List<Pipe>();
        }
        public virtual string Type { get; set; }
        public virtual int Length { get; set; }
        public virtual int Diameter { get; set; }
        public virtual int Thickness { get; set; }

        public virtual SeamType SeamType { get; set; }


        public virtual IList<PipeTest> PipeTests { get; set; }
        public virtual IList<Pipe> Pipes { get; set; }

        public override string ToString()
        {
            return Type;
        }


    }
}
