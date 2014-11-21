using System;
using System.Collections.Generic;
using Domain.Entity.Mill;
using Domain.Entity.Setup;

namespace Data.DAL.Mill
{
    public interface IPipeTestResultRepository : IRepository<Guid, PipeTestResult>
    {
    }
}
