using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Domain.Entity.Setup
{
    public class InspectorCertificateType : Item
    {
        public InspectorCertificateType()
        {
            this.InspectorCertificates = new List<InspectorCertificate>();
        }

        public override string ToString()
        {
            return Name;
        }

        public virtual string Name { get; set; }

        public virtual IList<InspectorCertificate> InspectorCertificates { get; set; }
    }
}
