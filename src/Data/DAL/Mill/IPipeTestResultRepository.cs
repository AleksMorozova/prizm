using System;
using System.Collections.Generic;
using Prizm.Domain.Entity.Mill;
using Prizm.Domain.Entity.Setup;

namespace Prizm.Data.DAL.Mill
{
    public interface IPipeTestResultRepository : IRepository<Guid, PipeTestResult>
    {
    }
}
