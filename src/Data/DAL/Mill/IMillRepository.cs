using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entity.Mill;

namespace Data.DAL.Mill
{
    public interface IMillRepository : IRepository<Guid, Domain.Entity.Mill.Mill>
    {
    }
}
