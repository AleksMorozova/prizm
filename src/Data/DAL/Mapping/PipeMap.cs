using Domain.Entity.Mill;
using Domain.Entity.Setup;
using FluentNHibernate.Mapping;
using NHibernate.Mapping.ByCode.Conformist;

namespace Data.DAL.Mapping
{
    public class PipeMap : SubclassMap<Pipe>
    {
        public PipeMap()
        {
            Map(_ => _.Mill).Column("mill");
            Map(_ => _.WallThickness, "wallThickness");
            Map(_ => _.Weight, "weight"); 
            Map(_ => _.Diameter).Column("diameter");

            Map(_ => _.Status).Column("pipeMillStatus");

            References<Railcar>(x => x.Railcar).Column("railcarId");
	        References<PipeMillSizeType>(x => x.Type).Column("typeId");
            References<PurchaseOrder>(x => x.PurchaseOrder).Column("purchaseOrderId");

            References<Plate>(x => x.Plate).Column("plateId").Cascade.All();

            HasMany<Coat>(x => x.Coats).KeyColumn("pipeId").Cascade.All();
        }
    }
}