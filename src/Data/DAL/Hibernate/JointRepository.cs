using Data.DAL.Construction;
using Domain.Entity.Joint;
using NHibernate;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Hibernate
{
    public class JointRepository : AbstractHibernateRepository<Guid, Joint>, IJointRepository
    {
        [Inject]
        public JointRepository(ISession session)
            : base(session)
        {

        }
    }
}
