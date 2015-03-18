using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Domain.Entity.Construction
{
    /// <summary>
    /// All items in this list should correspond to appropriate statuses for search. 
    /// Used for all combo boxes with activity search criteria.
    /// Please do not add items that will not go to combo choices.
    /// Items must be numbered from 0 and without gaps.
    /// Items may be removed if necessary.
    /// </summary>
    public enum JointTestResultStatus
    {
        Undefined = 0,
        Accepted = 1,
        Repair = 2,
        Withdraw = 3
    }
}
