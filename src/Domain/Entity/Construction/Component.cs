using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Construction
{
    public class Component : PipelinePiece
    {
        public Component()
        {
            this.Connectors = new List<Connector>();
        }

        public virtual string Certificate { get; set; }
        public virtual IList<Connector> Connectors { get; set; }
    }
}
