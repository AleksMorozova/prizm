using Domain.Entity.Mill;
using Domain.Entity.Setup;
using System;
using System.Collections.Generic;

namespace Domain.Entity.Mill
{
    public class PipeTestResult : TestResult<PipeTestResultStatus>
    {
        public PipeTestResult()
        {
        }

        public virtual PipeTest Operation { get; set; }
    }
}