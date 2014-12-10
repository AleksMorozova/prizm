using Domain.Entity.Construction;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Mapping
{
    public class ComponentTypeMap : SubclassMap<ComponentType>
    {
        public ComponentTypeMap()
        {
            Map(x => x.Name).Column("name");
            Map(x => x.ConnectorsCount).Column("connectorsCount");

            HasMany<Component>(x => x.Components).KeyColumn("componentTypeId");
        }
    }
}
