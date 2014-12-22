using FluentNHibernate.Mapping;
using Prizm.Domain.Entity.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Mapping
{
    public class InspectorCertificateTypeMap: SubclassMap<InspectorCertificateType>
    {
        public InspectorCertificateTypeMap()
        {
            Map(x => x.Name).Column("name");
            HasMany<InspectorCertificate>(x => x.InspectorCertificates)
                .KeyColumn("inspectorCertificateTypeId");
        }
    }
}
