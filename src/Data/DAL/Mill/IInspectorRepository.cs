using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Mill
{
    public interface IInspectorRepository : IRepository<Guid,Inspector>
    {
    }
}
