using Prizm.Domain.Entity.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Domain.Entity.Mill
{
    public class Category : Item
    {
        public Category()
        {
            this.PipeTests = new List<PipeTest>();
        }

        public virtual string Name { get; set; }

        public virtual bool Fixed { get; set; }

        public virtual IList<PipeTest> PipeTests { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
