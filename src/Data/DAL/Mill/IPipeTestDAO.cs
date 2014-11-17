using Domain.DAL;
using Domain.Entity.Mill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Mill
{
    interface IPipeTestDAO : IDAO<PipeTest>
    {
        IQueryable<PipeTest> GetRequired();
    }
}
