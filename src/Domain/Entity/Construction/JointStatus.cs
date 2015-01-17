using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Domain.Entity.Construction
{
    public enum JointStatus
    {
        Undefined = 0,
        AtControl = 1,
        AtIsolation = 2,
        Lowered = 3,
        Filled = 4,
        Welded = 5,
        Withdrawn = 6
    }
}
