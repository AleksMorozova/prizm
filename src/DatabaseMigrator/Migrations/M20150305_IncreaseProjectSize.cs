using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.DatabaseMigrator.Migrations
{
   [Migration(20150305)]
    public class M20150305_IncreaseProjectSize: Migration
    {
       public override void Up()
       {
           Alter.Table("Project")
               .AlterColumn("title")
               .AsString(50);
       }
       public override void Down()
       {
           Alter.Table("Project")
               .AlterColumn("title")
               .AsString(20);
       }
    }
}
