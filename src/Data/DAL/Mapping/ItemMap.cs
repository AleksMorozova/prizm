using Prizm.Domain.Entity;
using Prizm.Data.DAL.Hibernate;
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

            if(HibernateUtil.Import)
            {
                Id(x => x.Id).Column("id").UnsavedValue(Guid.Empty).GeneratedBy.Assigned();
            }
            else
            {
                Id(x => x.Id).Column("id").GeneratedBy.Guid();
            }

            Map(x => x.IsActive).Column("isActive");
        }

    }
}
