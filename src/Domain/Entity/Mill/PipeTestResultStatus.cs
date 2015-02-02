using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Domain.Entity.Mill
{
    public enum PipeTestResultStatus
    {
        Undefined = 0,
        Scheduled = 1,
        Passed = 2,
        Failed = 3,
        Repair = 4,
    }
}
