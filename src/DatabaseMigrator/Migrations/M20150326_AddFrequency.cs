using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.DatabaseMigrator.Migrations
{
    [Migration(20150326)]
    public class M20150326_AddFrequency : Migration
    {
        public override void Up()
        {
            Alter.Table("PipeTest").AddColumn("frequencyType").AsString(1).Nullable().AddColumn("selectivePercent").AsInt32().Nullable();
            Execute.Sql(@"UPDATE [PipeTest] SET frequencyType = 'R' WHERE isRequired = 1
                          UPDATE [PipeTest] SET frequencyType = 'U' WHERE isRequired = 0");
            Delete.Column("isRequired").FromTable("PipeTest");

            Create.Table("Inspection_RepeatedInspection")
                .WithColumn("inspectionId").AsGuid()
                .WithColumn("repeatedInspectionId").AsGuid();

            Create.ForeignKey("FK_Inspection_RepeatedInspection")
                .FromTable("Inspection_RepeatedInspection").ForeignColumn("inspectionId")
                .ToTable("PipeTest").PrimaryColumn("Id");

            Create.ForeignKey("FK_RepeatedInspection_Inspection")
                .FromTable("Inspection_RepeatedInspection").ForeignColumn("repeatedInspectionId")
                .ToTable("PipeTest").PrimaryColumn("Id");
        }

        public override void Down()
        {
            Alter.Table("PipeTest").AddColumn("isRequired").AsBoolean().Nullable();
            Execute.Sql(@"UPDATE [PipeTest] SET isRequired = 1 WHERE frequencyType = 'R'
                          UPDATE [PipeTest] SET isRequired = 0 WHERE frequencyType = 'U'");
            Delete.Column("frequencyType").Column("selectivePercent").FromTable("PipeTest");

            Delete.Table("Inspection_RepeatedInspection");
        }
    }
}
