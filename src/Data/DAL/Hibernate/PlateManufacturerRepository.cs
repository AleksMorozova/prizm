using Prizm.Data.DAL.Mill;
using Prizm.Domain.Entity.Mill;
using NHibernate;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Hibernate
{
    public class PlateManufacturerRepository : AbstractHibernateRepository<Guid,PlateManufacturer>, IPlateManufacturerRepository
    {
        [Inject]
        public PlateManufacturerRepository(ISession session)
            : base(session)
        {
        }
    }
}
