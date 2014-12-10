using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entity;

namespace Data.DAL
{
    public interface IAuditLogRepository : IRepository<Guid, AuditLog>
    {
        IEnumerable<string> GetAllUsers();
    }
}
