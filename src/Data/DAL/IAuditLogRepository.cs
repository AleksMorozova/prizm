using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Domain.Entity;

namespace Prizm.Data.DAL
{
    public interface IAuditLogRepository : IRepository<Guid, AuditLog>
    {
        IEnumerable<string> GetAllUsers();
        IList<AuditLog> GetRecords(string entityID, DateTime startDate, DateTime endDate);
        IList<AuditLog> GetRecords(string entityID, string user);
    }
}
