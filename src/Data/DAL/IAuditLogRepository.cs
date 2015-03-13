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
        Dictionary<Guid, string> GetAllUsers();
        IList<AuditLog> GetRecordsByNumber(string number, DateTime startDate, DateTime endDate);
        IList<AuditLog> GetRecordsByUser(Guid user, DateTime startDate, DateTime endDate);
    }
}
