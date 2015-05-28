using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.DatabaseMigrator.Migrations
{
    [Migration(20150527)]
    public class M20150527_AddIsWithdrawnToParts : Migration
    {
        public override void Up()
        {
            Alter.Table("Pipe").AddColumn("isWithdrawn").AsBoolean().WithDefaultValue(false);
            Alter.Table("Spool").AddColumn("isWithdrawn").AsBoolean().WithDefaultValue(false);
            Alter.Table("Component").AddColumn("isWithdrawn").AsBoolean().WithDefaultValue(false);
        }

        public override void Down()
        {
            Delete.Column("isWithdrawn").FromTable("Pipe");
            Delete.Column("isWithdrawn").FromTable("Spool");
            Delete.Column("isWithdrawn").FromTable("Component");
        }
    }
}
