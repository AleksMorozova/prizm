using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.AuditTrail
{
    public interface IAuditable
    {
        Guid GetID();
        string GetUser();
    }
}
