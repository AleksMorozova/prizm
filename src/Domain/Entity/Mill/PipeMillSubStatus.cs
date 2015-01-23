using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Domain.Entity.Mill
{
    public enum PipeMillSubStatus
    {
        Undefined
            = 0,

        Scheduled
            = 1,

        Repair
            = 2,

        WithRepair
            = 3,
       
        Passed 
            = 4,
        
        Failed 
            = 5
    }
}
