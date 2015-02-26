using FluentNHibernate.Mapping;
using Prizm.Domain.Entity.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Mapping
{
    public class SeamTypeMap : SubclassMap<SeamType>
    {
        public SeamTypeMap()
        {
            Map(x => x.Name).Column("name");
            Map(x => x.IsNative).Column("isNative");
            References(x => x.Project).Column("projectId");
        }
    }
}
