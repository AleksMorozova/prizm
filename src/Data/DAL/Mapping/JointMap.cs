using Domain.Entity.Construction;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Mapping
{
    public class JointMap : SubclassMap<Joint>
    {
        public JointMap()
        {
            Map(_ => _.Number).Column("number");
            Map(_ => _.NumberKP).Column("numberKP");
            Map(_ => _.DistanceFromKP).Column("distanceFromKP");
            Map(_ => _.LoweringDate).Column("loweringDate");
            Map(_ => _.Status).Column("status");
            Map(_ => _.GpsHeight).Column("gpsHeight");
            Map(_ => _.GpsLatitude).Column("gpsLatitude");
            Map(_ => _.GpsLongitude).Column("gpsLongitude");
        }
    }
}
