using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Construction
{
    public enum PieceInspectionStatus
    {
        Pending = 1,
        Hold = 2,
        Rejected = 3,
        Accepted = 4,

        Undefined = 0
    }
}
