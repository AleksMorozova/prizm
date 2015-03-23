using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Domain.Entity
{
    public enum AuditRecordType
    {
        E = 0, //Edited
        I = 1, //Imported
        C = 2, //Created
        D = 3  //Deleted
       
    }
}
