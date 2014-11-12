using Domain.Entity.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Setup
{
    interface IPipeTestRepository: IRepository<Guid, PipeTest>
    {
        IList<PipeTest> GetByPipeID(PipeMillSizeType id);
    }
}
