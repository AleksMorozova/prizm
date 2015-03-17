using Prizm.DAL.Hibernate;
using Prizm.Data.DAL;
using Prizm.Data.DAL.Hibernate;
using Prizm.Data.DAL.Mill;
using NHibernate;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.ReleaseNote
{
    public class ReleaseNoteRepositories : IReleaseNoteRepositories
    {
        ISession session;
        private readonly IPipeRepository pipeRepo;
        private readonly IRailcarRepository railcarRepo;
        private readonly IReleaseNoteRepository releaseNoteRepo;
        private readonly IFileRepository fileRepo;
        private readonly ISimpleNoteRepository simpleNoteRepo;

        [Inject]
        public ReleaseNoteRepositories(ISession session)
        {
            this.session = session;
            this.pipeRepo = new PipeRepository(session);
            this.railcarRepo = new RailcarRepository(session);
            this.releaseNoteRepo = new ReleaseNoteRepository(session);
            this.fileRepo = new FileRepository(session);
            this.simpleNoteRepo = new SimpleNoteRepository(session);
        }
        public ISimpleNoteRepository SimpleNoteRepo
        {
            get { return simpleNoteRepo; }
        }

        public IPipeRepository PipeRepo
        {
            get { return pipeRepo; }
        }

        public IRailcarRepository RailcarRepo
        {
            get { return railcarRepo; }
        }

        public IFileRepository FileRepo
        {
            get { return fileRepo; }
        }

        public void Commit()
        {
            session.Transaction.Commit();
        }

        public void BeginTransaction()
        {
            session.BeginTransaction();
        }

        public void Rollback()
        {
            session.Transaction.Rollback();
        }

        public void Dispose()
        {
            session.Dispose();
        }


        public IReleaseNoteRepository ReleaseNoteRepo
        {
            get { return releaseNoteRepo; }
        }
    }
}
