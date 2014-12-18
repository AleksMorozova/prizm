using Prizm.Domain.Entity.Mill;
using Prizm.Domain.Entity.Setup;
using System;
using System.Collections.Generic;

namespace Prizm.Domain.Entity.Mill
{
    public class PipeTestResult : TestResult<PipeTestResultStatus>
    {
        public PipeTestResult()
        {
        }

        public virtual PipeTest Operation { get; set; }
        public virtual Pipe Pipe { get; set; }
    }
}