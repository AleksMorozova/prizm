using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Domain.Entity
{
    /// <summary>
    /// Existing names and order of that enum should not be changed.
    /// New items should be added only to the end of list
    /// </summary>
    public enum AuditRecordType
    {
        E = 0, //Edited
        I = 1, //Imported
        C = 2, //Created
        D = 3  //Deleted
       
    }
}
