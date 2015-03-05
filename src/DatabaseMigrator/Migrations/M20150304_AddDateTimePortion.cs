using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.DatabaseMigrator.Migrations
{
    [Migration(20150304)]
    public class M20150304_AddDateTimePortion : Migration
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
