using FluentMigrator;

namespace Prizm.DatabaseMigrator.Migrations
{
    [Migration(20141119)]
    public class M20141119_CreateBaseSchemeFromFile : Migration
    {
        private const string CREATE_DBSCHEME_SCRIPT_NAME = "CreateSchemeObjects.sql";
        private const string REMOVE_DBSCHEME_SCRIPT_NAME = "RemoveSchemeObjects.sql";
      
        public override void Up()
        {
            Execute.EmbeddedScript(CREATE_DBSCHEME_SCRIPT_NAME);
        }

        public override void Down()
        {
            Execute.EmbeddedScript(REMOVE_DBSCHEME_SCRIPT_NAME);
        }
    }
}