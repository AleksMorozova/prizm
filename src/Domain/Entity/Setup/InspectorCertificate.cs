using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Setup
{
    public class InspectorCertificate : Item
    {
        public InspectorCertificate()
        {
            this.Certificates = new List<Certificate>();
        }
        public virtual Inspector Inspector { get; set; }
        public virtual IList<Certificate> Certificates { get; set; }
    }
}
