using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Mill
{
    public enum PipeMillStatus
    {
        Undefined
            = 0,

        Produced
            = 1,

        Stocked
            = 2,

        Shipped
            = 3
    }
}
