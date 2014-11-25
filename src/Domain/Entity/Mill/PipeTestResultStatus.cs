using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Mill
{
    public enum PipeTestResultStatus
    {
        Scheduled = 1,
        Passed = 2,
        Failed = 3,

        Undef = 0
    }
}
