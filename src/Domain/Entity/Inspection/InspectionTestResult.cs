using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Inspection
{
    public class InspectionTestResult : TestResult<InspectionTestResult>
    {
        public InspectionTestResult()
        {
        }

        public virtual PipelinePiece ControlEntity { get; set; }
        public virtual string Type { get; set; }
    }
}
