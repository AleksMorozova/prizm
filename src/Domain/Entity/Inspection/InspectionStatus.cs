using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Inspection
{
    public enum InspectionStatus
    {
        Accepted = 1,
        Hold = 2,
        Rejected = 3,
        Pending = 4,

        Undef = 0
    }
}
