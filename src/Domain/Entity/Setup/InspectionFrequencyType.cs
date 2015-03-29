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
        R= 0,//Required 
        U = 1,//Recurring 
        S = 2//Selective
    }
}
