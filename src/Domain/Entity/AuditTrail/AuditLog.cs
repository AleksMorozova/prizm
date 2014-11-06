using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.AuditTrail
{
    public class AuditLog
    {
        public virtual Guid AuditID { get; set; } // Id og log record
        public virtual Guid EntityID { get; set; } // Id of modified entity
        public virtual DateTime AuditDate { get; set; } //modified date
        public virtual string User { get; set; } //user who made changes
        public virtual string TableName { get; set; } //entity that was changed
        public virtual string FieldName { get; set; } //field that was changed
        public virtual string OldValue { get; set; } //previous field state
        public virtual string NewValue { get; set; } //current field state
    }
}
