using Domain.Entity.Mill;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Mapping
{
    class WeldMap : SubclassMap<Weld>
    {
        public WeldMap()
        {
            Table("Weld");
            Map(_ => _.Date).Column("date");
            References(_ => _.Pipe,"id");
        }
    }
}
