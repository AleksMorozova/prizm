using NHibernate;
using Ninject;
using Prizm.Data.DAL.Setup;
using Prizm.Domain.Entity.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Hibernate
{
    public class InspectorCertificateTypeRepository: AbstractHibernateRepository<Guid, InspectorCertificateType>, ICertificateTypeRepository
    {
        [Inject]
        public InspectorCertificateTypeRepository(ISession session)
            : base(session)
        { }

    }
}
