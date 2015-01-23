using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Reports.Construction
{
    public class TracingData
    {
        public string JointNumber { get; set; }
        public string WeldingDate { get; set; }

        public string FirstPartNumber { get; set; }
        public string FirstPartTypeDescription { get; set; }
        public int FirstPartLength { get; set; }

        public string SecondPartNumber { get; set; }
        public string SecondPartTypeDescription { get; set; }
        public int SecondPartLength { get; set; }
    }
}
