using Prizm.Domain.Entity.Setup;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Mapping
{
    public class PipeMillSizeTypeMap : SubclassMap<PipeMillSizeType>
    {
        public PipeMillSizeTypeMap() 
        {
            Map(_ => _.Type, "type");
            Map(_=>_.Length, "length");
            Map(_ => _.Thickness, "thickness");
            Map(_ => _.Diameter, "diameter");

           // References(x => x.SeamType).Column("seamType").Cascade.SaveUpdate();

            HasMany(x => x.Pipes).KeyColumn("typeId");
            HasMany(_ => _.PipeTests).KeyColumn("pipeMillSizeTypeId").Cascade.All().Inverse().Not.LazyLoad();
        }
    }
}
