using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.DatabaseMigrator.Migrations
{
    [Migration(20150323)]
    public class M20150323_AuditAddTypeColumn : Migration
    {
        public override void Up()
        {
            Alter.Table("AuditLog").AddColumn("operationType").AsFixedLengthString(1).Nullable();
            Execute.Sql(@"UPDATE [AuditLog] SET operationType = 'C' WHERE oldValue IS NULL
                          UPDATE [AuditLog] SET operationType = 'D' WHERE newValue IS NULL
                          UPDATE [AuditLog] SET operationType = 'E' WHERE newValue IS NOT NULL AND oldValue IS NOT NULL");
        }

        public override void Down()
        {
            Delete.Column("operationType").FromTable("AuditLog");
        }
    }
}
