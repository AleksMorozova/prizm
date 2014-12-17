using Prizm.Domain.Entity.Construction;
using Prizm.Domain.Entity.Mill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Construction
{
    public interface ISpoolRepository : IRepository<Guid, Spool>
    {
        IList<Pipe> GetAvailablePipes();
        IList<Spool> GetAllSpoolFromPipe(string number);
    }
}
