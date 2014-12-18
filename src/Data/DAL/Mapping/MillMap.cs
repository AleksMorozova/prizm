using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Mapping
{
    class MillMap : SubclassMap<Prizm.Domain.Entity.Mill.Mill>
    {
        public MillMap()
        {
            Table("Mill");
            Map(x => x.Name).Column("name");
        }
    }
}
