using Domain.Entity.Setup;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Mapping
{
    public class PipeMillSizeTypeMap : SubclassMap<PipeMillSizeType>
    {
        public PipeMillSizeTypeMap() 
        {
            Map(_ => _.Type, "type");

            HasMany(_ => _.PipeTests).Inverse().Cascade.All().Not.LazyLoad().KeyColumn("pipeMillSizeTypeId");
        }
    }
}
