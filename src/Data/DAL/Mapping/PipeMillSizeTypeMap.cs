using Domain.Entity.Setup;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Mapping
{
    public class PipeMillSizeTypeMap : ClassMap<PipeMillSizeType>
    {
        public PipeMillSizeTypeMap() 
        {
            Id(_ => _.Id, "id").Column("id").GeneratedBy.GuidComb();
            Map(_ => _.Name, "name");
            Map(_ => _.IsActive, "isActive");
            HasMany(_ => _.PipeTests).Inverse().Cascade.All().Not.LazyLoad();
        }
    }
}
