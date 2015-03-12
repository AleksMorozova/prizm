using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.DatabaseMigrator.Migrations
{
    [Migration(20150312)]
    public class M20150312_AuditChangeColumnTypes : Migration
    {
        public override void Up()
        {
            if (Schema.Table("AuditLog").Index("IX_Audit_Date_User").Exists())
            {
                Delete.Index("IX_Audit_Date_User").OnTable("AuditLog");
            }
            Alter.Table("AuditLog")
               .AlterColumn("tableName")
               .AsInt32()
               .AlterColumn("fieldName")
               .AsInt32()
               .AlterColumn("userName")
               .AsGuid();
            Create.Index("IX_Audit_Date").OnTable("AuditLog").OnColumn("auditDate").Descending();
            Create.Index("IX_Audit_User").OnTable("AuditLog").OnColumn("userName").Ascending();
        }

        public override void Down()
        {
            if (Schema.Table("AuditLog").Index("IX_Audit_Date").Exists())
            {
                Delete.Index("IX_Audit_Date").OnTable("AuditLog");
            }
            if (Schema.Table("AuditLog").Index("IX_Audit_User").Exists())
            {
                Delete.Index("IX_Audit_User").OnTable("AuditLog");
            }
            Alter.Table("AuditLog")
               .AlterColumn("tableName")
               .AsString()
               .AlterColumn("fieldName")
               .AsString()
               .AlterColumn("userName")
               .AsString();
            Create.Index("IX_Audit_Date_User").OnTable("AuditLog").OnColumn("auditDate").Descending().OnColumn("userName").Ascending();
        }
    }
}
