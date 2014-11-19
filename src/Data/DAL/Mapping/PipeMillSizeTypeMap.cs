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

            HasMany(x => x.Pipes).KeyColumn("typeId");
            HasMany(_ => _.PipeTests).KeyColumn("pipeMillSizeTypeId").Cascade.All().Inverse();
        }
    }
}
