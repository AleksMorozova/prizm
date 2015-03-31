using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Domain.Entity.Setup
{
    /// <summary>
    /// Existing names and order of that enum should not be changed.
    /// New items should be added only to the end of list
    /// </summary>
    public enum InspectionFrequencyType
    {
        /// <summary>
        /// Required
        /// </summary>
        R= 0,
        /// <summary>
        /// Recurring
        /// </summary>
        U = 1,
        /// <summary>
        /// Selective
        /// </summary>
        S = 2
    }
}
