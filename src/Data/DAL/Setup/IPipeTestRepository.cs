using Prizm.Domain.Entity.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Setup
{
    public interface IPipeTestRepository: IRepository<Guid, PipeTest>
    {
        IList<PipeTest> GetByMillSizeType(PipeMillSizeType pipeType);
    }
}
