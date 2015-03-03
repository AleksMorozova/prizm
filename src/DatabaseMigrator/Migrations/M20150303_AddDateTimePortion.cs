using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.DatabaseMigrator.Migrations
{
    [Migration(20150303)]
    public class M20150303_AddDateTimePortion : Migration
    {
        public override void Up()
        {
            Alter.Table("Portion")
                .AlterColumn("exportDateTime")
                .AsDateTime();
        }

        public override void Down()
        {
            Alter.Column("exportDateTime")
                .OnTable("Portion")
                .AsDate();
        }
    }
}
