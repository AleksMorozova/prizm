using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Reports.Construction
{
    public class JointProjection
    {
        public Guid Id { get; set; }
        public string Number { get; set; }
        public int NumberKP { get; set; }
        
        public override string ToString()
        {
            return Number;
        }
    }
}
