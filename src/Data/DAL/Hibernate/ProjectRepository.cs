using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entity;
using Ninject;
using NHibernate;
using NHibernate.Exceptions;

namespace Data.DAL.Hibernate
{
    public class ProjectRepository : AbstractHibernateRepository<Guid, Project>, IProjectRepository
    {
         [Inject]
        public ProjectRepository(ISession session)
            : base(session)
        {}
         public Project GetSingle()
         {
             try
             {
                 return session.QueryOver<Project>().SingleOrDefault();
             }
             catch (GenericADOException ex)
             {
                 throw new RepositoryException("GetSingle", ex);
             }
         }
    }
}
