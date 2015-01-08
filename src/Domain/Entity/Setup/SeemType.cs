using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Domain.Entity.Setup
{
    public class SeemType : Item
    {
        public SeemType()
        {
            //this.SeeamTypes = new List<SeemType>();
        }

        public virtual string Name { get; set; }

       // public virtual IList<SeemType> SeeamTypes { get; set; }
    }
}
