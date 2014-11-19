using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entity.Mill;
using FluentNHibernate.Mapping;

namespace Data.DAL.Mapping
{
    public class PlateMap: SubclassMap<Plate>
    {
        public PlateMap()
        {
            Map(x => x.Number).Column("number");
            Map(x => x.Thickness).Column("thickness");

            References<Heat>(x => x.Heat).Column("heatId");

            HasOne<Pipe>(x => x.Pipe).PropertyRef("Plate").Cascade.All();
        }
    }
}
