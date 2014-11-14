using Domain.Entity;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Mapping
{
    class WelderMap : SubclassMap<Welder>
    {
        public WelderMap()
        {
            Table("Welder");
            Map(_ => _.Certificate).Column("certificate");
            Map(_ => _.CertificateExpitation).Column("certificateExpiration");
            Map(_ => _.Stamp).Column("stamp");
            Map(_ => _.Grade).Column("grade");

            References(_ => _.Name, "id");
            HasManyToMany(_ => _.Welds)
                .Table("[Weld_welder]")
                .ParentKeyColumn("weldId")
                .ChildKeyColumn("welderId")
                .Cascade.SaveUpdate();
        }
    }
}
