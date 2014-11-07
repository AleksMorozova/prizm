using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Mill
{
    public enum PipeTestControlType
    {
        Witness = 1,
        Review = 2,
        Monitor = 3,
        Hold = 4,

        Undef = 0
    }
}
