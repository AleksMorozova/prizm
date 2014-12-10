using Domain.Entity.Construction;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Mapping
{
    public class ComponentMap : SubclassMap<Component>
    {
        public ComponentMap()
        {
            Map(_ => _.Certificate).Column("certificate");

            HasMany<Connector>(x => x.Connectors).KeyColumn("componentId");
        }
    }
}
