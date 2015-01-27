using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Domain.Entity.Mill
{
    /// <summary>
    /// All items in this list should correspond to appropriate types of report.
    /// Items must be numbered from 0 and without gaps.
    /// Items may be removed if necessary.
    /// </summary>
    public enum MillReportType
    {
        ByCategories = 0,
        ByShipped = 1,
        ByProducing = 2,
        General = 3
    }
}
