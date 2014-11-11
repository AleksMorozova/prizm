using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Setup
{
    public class PipeMillSizeType: Item
    {
        public virtual string Name { get; set; }
        public virtual ICollection<PipeTest> PipeTests { get; set; }

    }
}
