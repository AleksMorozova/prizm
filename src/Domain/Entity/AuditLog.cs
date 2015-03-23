using Prizm.Domain.Entity.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Domain.Entity
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
        /// number - name for Id of entity
        /// </summary>
        public virtual string Number { get; set; } 
        /// <summary>
        /// modified date
        /// </summary>
        public virtual DateTime AuditDate { get; set; }
        /// <summary>
        ///Id of user who made changes
        /// </summary>
        public virtual Guid User { get; set; }
        /// <summary>
        /// Full name of user who made changes(is not mapped)
        /// </summary>
        public virtual string UserName { get; set; }
        /// <summary>
        /// 
        /// entity that was changed
        /// </summary>
        public virtual ItemTypes TableName { get; set; }
        /// <summary>
        /// field that was changed
        /// </summary>
        public virtual FieldNames FieldName { get; set; }
        /// <summary>
        /// previous field state
        /// </summary>
        public virtual string OldValue { get; set; } 
        /// <summary>
        /// current field state
        /// </summary>
        public virtual string NewValue { get; set; }
        /// <summary>
        /// Id of entity that contains edited entity
        /// </summary>
        public virtual Guid OwnerId { get; set; }
        /// <summary>
        /// Audit operation type : inserted, edited, created, deleted
        /// </summary>
        public virtual AuditRecordType OperationType{get;set;}
    }
}
