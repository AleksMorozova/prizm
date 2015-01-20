using Prizm.Domain.Entity.Construction;
using Prizm.Domain.Entity.Mill;
using Prizm.Domain.Entity.Setup;
using FluentNHibernate.Mapping;
using NHibernate.Mapping.ByCode.Conformist;
using Prizm.Domain.Entity;
using System;

namespace Prizm.Data.DAL.Mapping
{
    public class PipeMap : SubclassMap<Pipe>
    {
        public PipeMap()
        {
            #region --- Map ---
            Map(_ => _.Mill).Column("mill");
            Map(_ => _.WallThickness, "wallThickness");
            Map(_ => _.Weight, "weight"); 
            Map(_ => _.Diameter).Column("diameter");
            Map(_ => _.ProductionDate).Column("productionDate");
            Map(_ => _.Status).Column("pipeMillStatus");
            Map(_ => _.ToExport).Column("ToExport");
            Map(_ => _.IsCutOnSpool).Column("isCutOnSpool");
            #endregion

            #region --- References ---
            References<Railcar>(x => x.Railcar).Column("railcarId");
	        References<PipeMillSizeType>(x => x.Type).Column("typeId");
            References<PurchaseOrder>(x => x.PurchaseOrder).Column("purchaseOrderId");
            References<Plate>(x => x.Plate).Column("plateId").Cascade.All();
            References<Project>(x => x.Project).Column("projectId");
            #endregion

            #region --- HasMany ---
            HasMany<PipeTestResult>(_ => _.PipeTestResult).KeyColumn("pipeId").Cascade.All().Not.LazyLoad();
            HasMany<Coat>(x => x.Coats).KeyColumn("pipeId").Cascade.All();
            HasMany<Weld>(x => x.Welds).KeyColumn("pipeId").Cascade.All();

            HasMany<Spool>(x => x.Spools).KeyColumn("pipeId").Cascade.All();
            HasMany<File>(x => x.Attachments).KeyColumn("item").Inverse().LazyLoad();
            #endregion
        }
    }
}