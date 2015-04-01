using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.DatabaseMigrator.Migrations
{
    [Migration(20150401)]
    public class M20150401_ExpectedToFloat : Migration
    {
        public override void Up()
        {
            Alter.Table("PipeTest").AlterColumn("minExpected").AsFloat().Nullable()
                .AlterColumn("maxExpected").AsFloat().Nullable();
        }
        public override void Down()
        {
            Alter.Table("PipeTest").AlterColumn("minExpected").AsInt32().Nullable()
                .AlterColumn("maxExpected").AsInt32().Nullable();
        }
    }
}
