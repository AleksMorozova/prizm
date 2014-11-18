using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Setup
{
    public class PipeMillSizeType: Item
    {
        public virtual string Type { get; set; }
        public virtual IList<PipeTest> PipeTests { get; set; }

    }
}
