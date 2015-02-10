using Prizm.Domain.Entity;
using Prizm.Domain.Entity.Setup;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Mapping
{
    public class InspectorMap : SubclassMap<Inspector>
    {
        public InspectorMap()
        {
            Table("Inspector");
            Map(x => x.Grade).Column("Grade");
            Component<PersonName>(x => x.Name, m =>
               {
                  m.Map(_ => _.FirstName).Column("firstName");
                  m.Map(_ => _.LastName).Column("lastName");
                  m.Map(_ => _.MiddleName).Column("middleName");
               });
            HasMany<InspectorCertificate>(x => x.Certificates).KeyColumn("inspectorId").Cascade.All().Not.LazyLoad();
        }
    }
}
