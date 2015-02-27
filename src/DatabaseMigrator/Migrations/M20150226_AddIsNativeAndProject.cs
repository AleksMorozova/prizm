using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.DatabaseMigrator.Migrations
{
    [Migration(20150226)]
    public class M20150226_AddIsNativeAndProject : Migration
    {
        public override void Up()
        {
            //PlateManufacturer
            Alter.Table("PlateManufacturer")
               .AddColumn("isNative").AsBoolean().NotNullable().WithDefaultValue(false)
               .AddColumn("projectId").AsGuid().NotNullable();
            Create.ForeignKey("FK_PlateManufacturer_Project").FromTable("PlateManufacturer").ForeignColumn("projectId").ToTable("Project").PrimaryColumn("id");
             
            //SeamType
            Alter.Table("SeamType")
              .AddColumn("isNative").AsBoolean().NotNullable().WithDefaultValue(false)
              .AddColumn("projectId").AsGuid().NotNullable();
            Create.ForeignKey("FK_SeamType_Project").FromTable("SeamType").ForeignColumn("projectId").ToTable("Project").PrimaryColumn("id");

            //PipeMillSizeType
            Alter.Table("PipeMillSizeType")
               .AddColumn("isNative").AsBoolean().NotNullable().WithDefaultValue(false)
               .AddColumn("projectId").AsGuid().NotNullable();
            Create.ForeignKey("FK_PipeMillSizeType_Project").FromTable("PipeMillSizeType").ForeignColumn("projectId").ToTable("Project").PrimaryColumn("id");

            //ComponentType
            Alter.Table("ComponentType")
               .AddColumn("isNative").AsBoolean().NotNullable().WithDefaultValue(false)
               .AddColumn("projectId").AsGuid().NotNullable();
            Create.ForeignKey("FK_ComponentType_Project").FromTable("ComponentType").ForeignColumn("projectId").ToTable("Project").PrimaryColumn("id");
        }

        public override void Down()
        {
            //PlateManufacturer
            Delete.Column("isNative").Column("projectId")
                .FromTable("PlateManufacturer");
            Delete.ForeignKey("FK_PlateManufacturer_Project").OnTable("PlateManufacturer");

            //SeamType
            Delete.Column("isNative").Column("projectId")
                .FromTable("SeamType");
            Delete.ForeignKey("FK_SeamType_Project").OnTable("SeamType");

            //PipeMillSizeType
            Delete.Column("isNative").Column("projectId")
                .FromTable("PipeMillSizeType");
            Delete.ForeignKey("FK_PipeMillSizeType_Project").OnTable("PipeMillSizeType");

            //ComponentType
            Delete.Column("isNative").Column("projectId")
                .FromTable("ComponentType");
            Delete.ForeignKey("FK_ComponentType_Project").OnTable("ComponentType");
        }
    }
}
