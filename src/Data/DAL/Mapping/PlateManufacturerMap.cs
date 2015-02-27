using Prizm.Domain.Entity.Mill;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Mapping
{
    public class PlateManufacturerMap : SubclassMap<PlateManufacturer>
    {
        public PlateManufacturerMap()
        {
            Table("PlateManufacturer");
            Map(_ => _.Name).Column("name");
            Map(x => x.IsNative).Column("isNative");
            References(x => x.Project).Column("projectId");
            HasMany(_ => _.Heats).KeyColumn("plateManufacturer");
        }
    }
}
