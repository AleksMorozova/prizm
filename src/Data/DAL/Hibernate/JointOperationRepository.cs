using Data.DAL.Setup;
using Domain.Entity.Setup;
using NHibernate;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Hibernate
{
    public class JointOperationRepository : AbstractHibernateRepository<Guid, JointOperation>, IJointOperationRepository
    {
        [Inject]
        public JointOperationRepository(ISession session)
            : base(session)
        {

        }
    }
}
