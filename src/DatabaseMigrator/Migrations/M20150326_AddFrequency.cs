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
            Alter.Table("PipeTest").AddColumn("frequencyType").AsString(1).Nullable().AddColumn("selectivePercent").AsInt32().WithDefaultValue(1);
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


            // The names PrintWeldDateReport and PrintWeldTracingReport correspond to 
            // enum items name Privileges.PrintWeldDateReport and Privileges.PrintWeldTracingReport
            Execute.Sql(@"
                If Not Exists(select * from [Permission] 
                    where Name = 'PrintWeldTracingReport') 
                        and (select COUNT(*) from [Permission]) > 0
                Begin
                    insert into [Permission] (id, Name) values (NEWID(), 'PrintWeldDateReport')
                End");
            Execute.Sql(@"
                If Not Exists(select * from [Permission] 
                    where Name = 'PrintWeldTracingReport') 
                        and (select COUNT(*) from [Permission]) > 0
                Begin
                    insert into [Permission] (id, Name) values (NEWID(), 'PrintWeldTracingReport')
                End");
        }

        public override void Down()
        {
            Alter.Table("PipeTest").AddColumn("isRequired").AsBoolean().Nullable();
            Execute.Sql(@"UPDATE [PipeTest] SET isRequired = 1 WHERE frequencyType = 'R'
                          UPDATE [PipeTest] SET isRequired = 0 WHERE frequencyType = 'U'");
            Delete.Column("frequencyType").Column("selectivePercent").FromTable("PipeTest");

            Delete.Table("Inspection_RepeatedInspection");

            
            Execute.Sql(@"
                    If Exists(select * from [Permission] where Name = 'PrintWeldDateReport')
                    Begin
                        delete from [Role_Permission] where [permissionId] = (select id from [Permission] where Name = 'PrintWeldDateReport')
                        delete from [Permission] where Name = 'PrintWeldDateReport'
                    End");
            Execute.Sql(@"
                    If Exists(select * from [Permission] where Name = 'PrintWeldTracingReport')
                    Begin
                        delete from [Role_Permission] where [permissionId] = (select id from [Permission] where Name = 'PrintWeldTracingReport')
                        delete from [Permission] where Name = 'PrintWeldTracingReport'
                    End");
        }
    }
}
