using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Domain.Entity.Construction
{
    /// <summary>
    /// Sequence of numbers in this enum is used for different purposes. Rules are:
    /// - 0 is always Undefined
    /// - do not make gaps in numbering
    /// - all new items should be added to the end. Old items must remain as is (comment them as unused if they will become so).
    /// - never change names of existing items.
    /// </summary>
    public enum JointStatus
    {
        Undefined = 0,
        Welded = 1,
        Lowered = 2,        
        Withdrawn = 3
    }
}
