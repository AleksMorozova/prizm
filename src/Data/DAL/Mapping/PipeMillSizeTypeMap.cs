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
            Map(x => x.IsNative).Column("isNative");

            References(x => x.SeamType).Column("seamTypeId").Cascade.SaveUpdate();
            References(x => x.Project).Column("projectId");

            HasMany(_ => _.PipeTests).KeyColumn("pipeMillSizeTypeId").Cascade.All().Inverse().Not.LazyLoad();
        }
    }
}
