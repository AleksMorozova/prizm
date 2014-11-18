using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entity;
using Ninject;
using NHibernate;

namespace Data.DAL.Hibernate
{
    public class ProjectRepository : AbstractHibernateRepository<Guid, Project>, IProjectRepository
    {
         [Inject]
        public ProjectRepository(ISession session)
            : base(session)
        {
        }
    }
}
