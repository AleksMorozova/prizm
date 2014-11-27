using Domain.Entity.Mill;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Mapping
{
    public class ChemicalCompositionMap : SubclassMap<ChemicalComposition>
    {
        public ChemicalCompositionMap()
        {
            Table("ChemicalComposition");

            Map(x => x.Parameter).Column("parameter");
            Map(x => x.HeatValue).Column("heatValue");
            Map(x => x.PlateValue).Column("plateValue");
            Map(x => x.PipeValue).Column("pipeValue");

            References<Heat>(x => x.HeatId).Column("heatId");
        }
    }
}
