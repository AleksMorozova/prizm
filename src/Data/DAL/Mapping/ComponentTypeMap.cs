using Prizm.Domain.Entity.Construction;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Mapping
{
    public class ComponentTypeMap : SubclassMap<ComponentType>
    {
        public ComponentTypeMap()
        {
            Map(x => x.Name).Column("name");
            Map(x => x.ConnectorsCount).Column("connectorsCount");
            Map(x => x.IsNative).Column("isNative");

            References(x => x.Project).Column("projectId");

            HasMany<Component>(x => x.Components).KeyColumn("componentTypeId");
        }
    }
}
