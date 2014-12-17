using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Domain.Entity.Setup
{
    public class InspectorCertificate : Item
    {
        public virtual Inspector Inspector { get; set; }
        public virtual Certificate Certificate { get; set; }
    }
}
