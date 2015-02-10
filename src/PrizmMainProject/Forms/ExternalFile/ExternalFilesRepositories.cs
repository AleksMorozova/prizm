using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using Prizm.Data.DAL;
using Ninject;
using Prizm.DAL.Hibernate;
using Prizm.Data.DAL.Hibernate;

namespace Prizm.Main.Forms.ExternalFile
{
    public class ExternalFilesRepositories : IExternalFilesRepositories
    {
        ISession session;
        private readonly IFileRepository fileRepo;
        private readonly IProjectRepository projectRepo;

        [Inject]
        public ExternalFilesRepositories(ISession session)
        {
            this.session = session;
            this.fileRepo = new FileRepository(session);
            this.projectRepo = new ProjectRepository(session);
        }

        public IFileRepository FileRepo
        {
            get { return fileRepo; }
        }

        public IProjectRepository ProjectRepo
        {
            get { return projectRepo; }
        }

        public void Commit()
        {
            session.Transaction.Commit();
        }

        public void BeginTransaction()
        {
            session.BeginTransaction();
        }

        public void Dispose()
        {
            session.Dispose();
        }
    }
}
