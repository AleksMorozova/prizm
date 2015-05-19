using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.DatabaseMigrator.Migrations
{
    [Migration(20150519)]
    public class M20150519_ChangeFloatToDecimal : Migration
    {
        public override void Up()
        {
            Alter.Table("Connector").AlterColumn("diameter").AsDecimal(8,2).Nullable().
                AlterColumn("wallThickness").AsDecimal(8,2).Nullable();

            Alter.Table("Joint").AlterColumn("gpsHeight").AsDecimal(8,2).Nullable();

            Alter.Table("Pipe").AlterColumn("diameter").AsDecimal(8,2).Nullable()
                .AlterColumn("wallThickness").AsDecimal(8,2).Nullable()
                .AlterColumn("weight").AsDecimal(15,2).Nullable();

            Alter.Table("Plate").AlterColumn("thickness").AsDecimal(8,2).Nullable();

            Alter.Table("PipeMillSizeType").AlterColumn("thickness").AsDecimal(8,2).Nullable()
                .AlterColumn("diameter").AsDecimal(8,2).Nullable();

            Alter.Table("PipeTest").AlterColumn("minExpected").AsDecimal(8,2).Nullable()
                .AlterColumn("maxExpected").AsDecimal(8,2).Nullable();

        }

        public override void Down()
        {
            Alter.Table("Connector").AlterColumn("diameter").AsFloat().Nullable().
                AlterColumn("wallThickness").AsFloat().Nullable();

            Alter.Table("Joint").AlterColumn("gpsHeight").AsFloat().Nullable();

            Alter.Table("Pipe").AlterColumn("diameter").AsFloat().Nullable()
                .AlterColumn("wallThickness").AsFloat().Nullable()
                .AlterColumn("weight").AsFloat().Nullable();

            Alter.Table("Plate").AlterColumn("thickness").AsFloat().Nullable();

            Alter.Table("PipeMillSizeType").AlterColumn("thickness").AsFloat().Nullable()
                .AlterColumn("diameter").AsFloat().Nullable();

            Alter.Table("PipeTest").AlterColumn("minExpected").AsFloat().Nullable()
              .AlterColumn("maxExpected").AsFloat().Nullable();
        }
    }
}
