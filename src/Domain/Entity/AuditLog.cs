using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class AuditLog
    {
        /// <summary>
        /// Id of log record
        /// </summary>
        public virtual Guid AuditID { get; set; } 
        /// <summary>
        /// Id of modified entity
        /// </summary>
        public virtual Guid EntityID { get; set; } 
        /// <summary>
        /// modified date
        /// </summary>
        public virtual DateTime AuditDate { get; set; }
        /// <summary>
        /// user who made changes
        /// </summary>
        public virtual string User { get; set; }
        /// <summary>
        /// entity that was changed
        /// </summary>
        public virtual string TableName { get; set; }
        /// <summary>
        /// field that was changed
        /// </summary>
        public virtual string FieldName { get; set; }
        /// <summary>
        /// previous field state
        /// </summary>
        public virtual string OldValue { get; set; } 
        /// <summary>
        /// current field state
        /// </summary>
        public virtual string NewValue { get; set; } 
    }
}
