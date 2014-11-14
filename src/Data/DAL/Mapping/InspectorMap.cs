using Domain.Entity;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Mapping
{
    public class InspectorMap : SubclassMap<Inspector>
    {
        public InspectorMap()
        {
            Table("Inspector");
            References(_ => _.Name, "id");
            Map(_ => _.Certificate).Column("certificate");
            Map(_ => _.CertificateExpiration).Column("certificateExpiration");
            HasMany(_ => _.Results).KeyColumn("id").Inverse();

        }
    }
}
