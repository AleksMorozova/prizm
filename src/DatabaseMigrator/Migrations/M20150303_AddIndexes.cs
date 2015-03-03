using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.DatabaseMigrator.Migrations
{
    [Migration(20150303)]
    public class M20150303_AddIndexes : Migration
    {
        public override void Up()
        {
            if (!Schema.Table("ReleaseNote").Index("IDX_ReleaseNote_Number").Exists())
            {
                Create.Index("IDX_ReleaseNote_Number")
                  .OnTable("ReleaseNote")
                  .OnColumn("number").Ascending();
            }

            if (!Schema.Table("ReleaseNote").Index("IDX_ReleaseNote_Date").Exists())
            {
                Create.Index("IDX_ReleaseNote_Date")
                  .OnTable("ReleaseNote")
                  .OnColumn("date").Ascending();
            }

            if (!Schema.Table("Railcar").Index("IDX_Railcar_Number").Exists())
            {
                Create.Index("IDX_Railcar_Number")
                  .OnTable("Railcar")
                  .OnColumn("number").Ascending();
            }

            if (!Schema.Table("Railcar").Index("IDX_Railcar_Certificate").Exists())
            {
                Create.Index("IDX_Railcar_Certificate")
                  .OnTable("Railcar")
                  .OnColumn("certificate").Ascending();
            }

            if (!Schema.Table("Joint").Index("IDX_Joint_Number").Exists())
            {
                Create.Index("IDX_Joint_Number")
                  .OnTable("Joint")
                  .OnColumn("number").Ascending();
            }

            if (!Schema.Table("Joint").Index("IDX_Joint_Date").Exists())
            {
                Create.Index("IDX_Joint_Date")
                  .OnTable("Joint")
                  .OnColumn("loweringDate").Ascending();
            }
        }

        public override void Down()
        {
            if (Schema.Table("ReleaseNote").Index("IDX_ReleaseNote_Number").Exists())
            {
                Delete.Index("IDX_ReleaseNote_Number");
            }

            if (Schema.Table("ReleaseNote").Index("IDX_ReleaseNote_Date").Exists())
            {
                Delete.Index("IDX_ReleaseNote_Number");
            }

            if (Schema.Table("Railcar").Index("IDX_Railcar_Number").Exists())
            {
                Delete.Index("IDX_Railcar_Number");
            }

            if (Schema.Table("Railcar").Index("IDX_Railcar_Certificate").Exists())
            {
                Delete.Index("IDX_Railcar_Certificate");
            }

            if (Schema.Table("Joint").Index("IDX_Joint_Number").Exists())
            {
                Delete.Index("IDX_Joint_Number");
            }

            if (Schema.Table("Joint").Index("IDX_Joint_Date").Exists())
            {
                Delete.Index("IDX_Joint_Date");
            }
        }
    }
}
