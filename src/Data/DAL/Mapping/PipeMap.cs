using Domain.Entity.Mill;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Mapping
{
    public class PipeMap : ClassMap<Pipe>
    {
        public PipeMap()
        {
            Table("pipe");
            Id(_ => _.Id, "id").Column("id").GeneratedBy.GuidComb();
            Map(_ => _.Number, "number");
            Map(_ => _.Mill, "Mill");
            Map(_ => _.Diameter, "Diameter");
            Map(_ => _.WallThickness, "WallThickness");
            Map(_ => _.Weight, "Weight");
            Map(_ => _.Type, "Type");
            References(_ => _.Railcar, "Id");
            References(_ => _.PurchaseOrder, "Id");
            HasManyToMany(_ => _.Welds)
                .Table("weld_welder")
                .ParentKeyColumn("pipeId")
                .ChildKeyColumn("weldId")
                .Cascade
                .SaveUpdate();
            HasMany(_ => _.PipeTestResult)
                .KeyColumn("pipeId");
                
        }
    }
}
