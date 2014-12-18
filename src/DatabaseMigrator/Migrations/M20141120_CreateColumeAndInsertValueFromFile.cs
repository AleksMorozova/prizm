using FluentMigrator;

namespace Prizm.DatabaseMigrator.Migrations
{

    [Migration(20141120)]
    public class M20141120_CreateColumeAndInsertValueFromFile : Migration
    {
        private const string FILL_INIT_SCRIPT_NAME = "fillDb.sql";

        public override void Up()
        {
            Execute.EmbeddedScript(FILL_INIT_SCRIPT_NAME);
        }

        public override void Down()
        {
            Delete.FromTable("weld_welder").AllRows();
            Delete.FromTable("welder").AllRows();
            Delete.FromTable("weld").AllRows();
            Delete.FromTable("pipeTestResult").AllRows();
            Delete.FromTable("pipeTest").AllRows();
            Delete.FromTable("testResult_inspector").AllRows();
            Delete.FromTable("testResult").AllRows();
            Delete.FromTable("inspector").AllRows();
            Delete.FromTable("pipe").AllRows();
            Delete.FromTable("railcar").AllRows();
            Delete.FromTable("PurchaseOrder").AllRows();
            Delete.FromTable("plate").AllRows();
            Delete.FromTable("pipeMillSizeType").AllRows();
            Delete.FromTable("heat").AllRows();
        }
    }
}