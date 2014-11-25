using FluentMigrator;

namespace Prizm.DatabaseMigrator.Migrations
{
        [Migration(20141125)]
    public class M20141125_TestResultChanges : Migration
    {
            public override void Up()
            {
                Delete.PrimaryKey("PK_TestResult_Inspector").FromTable("TestResult_Inspector");
                Delete.ForeignKey("FK_TestResult_Inspector_TestResult").OnTable("TestResult_Inspector");
                Delete.Column("id").FromTable("TestResult_Inspector");
                Alter.Table("PipeTestResult").AddColumn("date").AsDate().Nullable();
                Alter.Table("PipeTestResult").AddColumn("status").AsString().Nullable();
                Alter.Table("PipeTestResult").AddColumn("value").AsString().Nullable();
            }
            public override void Down()
            {
                Alter.Table("TestResult_Inspector").AddColumn("id").AsGuid().NotNullable();
                Create.PrimaryKey("PK_TestResult_Inspector").OnTable("TestResult_Inspector").Column("id");
                Delete.Column("date").Column("status").Column("value").FromTable("PipeTestResult");
                Create.ForeignKey("FK_TestResult_Inspector_TestResult").FromTable("TestResult_Inspector");
            }
    }
}
