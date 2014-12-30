using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Domain.Entity.Construction
{
    public class InspectionTestResult : TestResult<PartInspectionStatus>
    {
        public virtual Part Part { get; set; }
    }
}
