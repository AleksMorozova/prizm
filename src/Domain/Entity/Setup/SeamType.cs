using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Domain.Entity.Setup
{
    public class SeamType : Item
    {
        public SeamType()
        {
            this.SeamTypes = new List<SeamType>();
        }

        public virtual string Name { get; set; }

        public virtual IList<SeamType> SeamTypes { get; set; }
    }
}
