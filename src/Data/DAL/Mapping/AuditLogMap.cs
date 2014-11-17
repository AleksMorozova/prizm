using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Domain.Entity;

namespace Data.DAL.Mapping
{
    public class AuditLogMap : ClassMap<AuditLog>
    {
        public AuditLogMap()
        {
            Id(a => a.AuditID);
            Map(a => a.EntityID);
            Map(a => a.AuditDate);
            Map(a => a.User);
            Map(a => a.TableName);
            Map(a => a.FieldName);
            Map(a => a.OldValue);
            Map(a => a.NewValue);
        }
    }
}
