using Domain.Entity.Construction;
using Domain.Entity.Mill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Construction
{
    public interface ISpoolRepository : IRepository<Guid, Spool>
    {
    }
}
