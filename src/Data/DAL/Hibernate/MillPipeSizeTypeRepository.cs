using Prizm.Data.DAL.Setup;
using Prizm.Domain.Entity.Setup;
using NHibernate;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Hibernate
{
    public class MillPipeSizeTypeRepository : AbstractHibernateRepository<Guid, PipeMillSizeType>, IMillPipeSizeTypeRepository
    {
        [Inject]
        public MillPipeSizeTypeRepository(ISession session)
         : base(session)
      {

      }
    }
}
