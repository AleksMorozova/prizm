using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Domain.Entity.Construction
{
    public class Component : Part
    {
        public Component()
        {
            this.Connectors = new List<Connector>();
            this.InspectionTestResults = new List<InspectionTestResult>();
        }

        public virtual string Certificate { get; set; }
        public virtual IList<Connector> Connectors { get; set; }
        public virtual bool ToExport { get; set; }
        public virtual ComponentType Type { get; set; }
    }
}
