using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Prizm.Domain.Entity;

namespace Prizm.Data.DAL.Mapping
{
    public class AuditLogMap : ClassMap<AuditLog>
    {
        public AuditLogMap()
        {
            Id(a => a.AuditID).Column("id");
            Map(a => a.EntityID).Column("entityID");
            Map(a => a.AuditDate).Column("auditDate");
            Map(a => a.User).Column("userName");
            Map(a => a.TableName).Column("tableName");
            Map(a => a.FieldName).Column("fieldName");
            Map(a => a.OldValue).Column("oldValue").Nullable();
            Map(a => a.NewValue).Column("newValue").Nullable();
        }
    }
}
