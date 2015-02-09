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
    public class InspectorCertificateMap : SubclassMap<InspectorCertificate>
    {
        public InspectorCertificateMap()
        {
            Table("InspectorCertificate");
            References(x => x.Inspector).Column("inspectorId");

            References(x => x.Type).Column("inspectorCertificateTypeId").Cascade.SaveUpdate();

            Component<Certificate>(x => x.Certificate, m =>
            {
                m.Map(x => x.Grade).Column("Grade");
                m.Map(x => x.Number).Column("Number");
                m.Map(x => x.ExpirationDate).Column("expirationDate");
            }
            );
            
        }
    }
}
