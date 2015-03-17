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
        public override Guid OwnerId
        {
            get
            {
                return (Pipe == null) ? this.Id : Pipe.Id;
            }
            set
            {
                base.OwnerId = value;
            }
        }
    }
}