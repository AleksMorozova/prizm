using Prizm.Domain.Entity;
using Prizm.Domain.Entity.Mill;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Mapping
{
    class WelderMap : SubclassMap<Welder>
    {
        public WelderMap()
        {
            Table("Welder");
            Map(_ => _.Stamp).Column("stamp");
            Map(_ => _.Grade).Column("grade");
            Component<Certificate>(x => x.Certificate, m =>
                {
                    m.Map(x => x.Number).Column("certificate");
                    m.Map(x => x.ExpirationDate).Column("certificateExpiration");
                }
                );
            Component<PersonName>(x => x.Name, m =>
               {
                  m.Map(x => x.FirstName).Column("firstName");
                  m.Map(x => x.MiddleName).Column("middleName");
                  m.Map(x => x.LastName).Column("lastName");
               });
            HasManyToMany<Weld>(_ => _.Welds)
                .Table("[Weld_welder]")
                .ParentKeyColumn("welderId")
                .ChildKeyColumn("weldId").Inverse();
        }
    }
}
