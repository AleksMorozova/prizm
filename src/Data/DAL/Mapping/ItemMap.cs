using Prizm.Domain.Entity;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Mapping
{
    public class ItemMap : ClassMap<Item>
    {
        public ItemMap()
        {
            UseUnionSubclassForInheritanceMapping();

            Id(x => x.Id).Column("id").UnsavedValue(Guid.Empty).GeneratedBy.Assigned();
            Map(x => x.IsActive).Column("isActive");
        }

    }
}
