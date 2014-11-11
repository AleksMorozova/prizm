using Domain.Entity.Mill;
using FluentNHibernate.Mapping;

namespace Data.DAL.Mapping
{
    public class PipeMap : SubclassMap<Pipe>
    {
        public PipeMap()
        {

            //DiscriminatorValue(valueRepresentingThisSubclass); //?

            Map(_ => _.Number, "number");
            Map(_ => _.Mill, "mill");
            Map(_ => _.WallThickness, "wallThickness");
            Map(_ => _.Weight, "weight");  
            Map(_ => _.Diameter, "diameter");

            References(_ => _.Railcar, "id");

            //Map(_ => _.Type, "type"); 
            //Map(_ => _.Status, "PipeMillStatus");       

            //References(_ => _.Railcar, "id");
            //References(_ => _.PurchaseOrder, "Id");




            //TODO: Implement welds, pipe test result
            //HasManyToMany(_ => _.Welds)
            //    .Table("weld_welder")
            //    .ParentKeyColumn("pipeId")
            //    .ChildKeyColumn("weldId")
            //    .Cascade
            //    .SaveUpdate();
            //HasMany(_ => _.PipeTestResult)
            //    .KeyColumn("pipeId");


            //Map(_ => _.IsActive, "is_active");
        }
    }
}