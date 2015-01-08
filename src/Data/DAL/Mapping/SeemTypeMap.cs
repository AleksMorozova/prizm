using FluentNHibernate.Mapping;
using Prizm.Domain.Entity.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Mapping
{
    public class SeemTypeMap : SubclassMap<SeemType>
    {
        public SeemTypeMap()
        {
            Map(x => x.Name).Column("name");

            HasMany<SeemType>(x => x.SeamTypes)
                .KeyColumn("seamType");
        }
    }
}
