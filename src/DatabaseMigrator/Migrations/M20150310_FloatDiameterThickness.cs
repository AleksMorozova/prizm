using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Domain.Entity.Security;

namespace Prizm.DatabaseMigrator.Migrations
{
    [Migration(20150310)]
    public class M20150310_FloatDiameterThickness : Migration
    {
        public override void Up()
        {
            Alter.Table("Pipe")
                .AlterColumn("diameter")
                .AsFloat();

            Alter.Table("PipeMillSizeType")
                .AlterColumn("diameter")
                .AsFloat()
                .AlterColumn("thickness")
                .AsFloat();

            Alter.Table("Connector")
                .AlterColumn("diameter")
                .AsFloat();

            // The name ViewExportImportHistory corresponds to 
            // enum item name Privileges.ViewExportImportHistory
            Insert.IntoTable("Permission")
                .Row(new Permission(){ Name = "ViewExportImportHistory"});
        }
        public override void Down()
        {
            Alter.Table("Pipe")
                .AlterColumn("diameter")
                .AsInt32();
            
            Alter.Table("PipeMillSizeType")
                .AlterColumn("diameter")
                .AsInt32()
                .AlterColumn("thickness")
                .AsInt32();

            Alter.Table("Connector")
               .AlterColumn("diameter")
               .AsInt32();

            Delete.FromTable("Permission").Row(new { Name = "ViewExportImportHistory" });
        }
    }
}
