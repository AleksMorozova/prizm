using Prizm.Data.DAL;
using Prizm.Data.DAL.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Audit
{
    public interface IAuditRepository : IDisposable
    {
        IAuditLogRepository AuditLogRepo { get; }
        IUserRepository UserRepo { get; }
        void Commit();
        void BeginTransaction();
        void Rollback();
    }
}
