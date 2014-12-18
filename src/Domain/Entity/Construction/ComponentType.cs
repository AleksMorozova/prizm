using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Domain.Entity.Construction
{
    public class ComponentType : Item
    {
        public virtual string Name { get; set; }
        public virtual int ConnectorsCount { get; set; }

        public virtual IList<Component> Components { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
