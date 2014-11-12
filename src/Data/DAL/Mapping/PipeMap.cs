using Domain.Entity.Mill;
using FluentNHibernate.Mapping;

namespace Data.DAL.Mapping
{
    public class PipeMap : ClassMap<Pipe>
    {
        public PipeMap()
        {
            Id(_ => _.Id, "id").Column("id").GeneratedBy.GuidComb();
            Map(_ => _.Number, "number");
            Map(_ => _.Mill, "mill");
            Map(_ => _.Diameter, "diameter");
            Map(_ => _.WallThickness, "wallThickness");
            Map(_ => _.Weight, "weight");
            Map(_ => _.Type, "type");

            References(_ => _.Railcar, "id");
            References(_ => _.PurchaseOrder, "id");

            //TODO: Implement welds, pipe test result
            //HasManyToMany(_ => _.Welds)
            //    .Table("weld_welder")
            //    .ParentKeyColumn("pipeId")
            //    .ChildKeyColumn("weldId")
            //    .Cascade
            //    .SaveUpdate();
            //HasMany(_ => _.PipeTestResult)
            //    .KeyColumn("pipeId");


            Map(_ => _.IsActive, "is_active");
        }
    }
}