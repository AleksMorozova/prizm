using Prizm.Data.DAL.Hibernate;
using Prizm.Data.DAL.Mill;
using NHibernate;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Railcar
{
    public class RailcarRepositories : IRailcarRepositories
    {
        ISession session;
        private readonly IPipeRepository pipeRepo;
        private readonly IRailcarRepository railcarRepo;
        private readonly IReleaseNoteRepository releaseNoteRepo;

        [Inject]
        public RailcarRepositories(ISession session)
        {
            this.session = session;
            this.pipeRepo = new PipeRepository(session);
            this.railcarRepo = new RailcarRepository(session);
            this.releaseNoteRepo = new ReleaseNoteRepository(session);
        }

        public IPipeRepository PipeRepo
        {
            get { return pipeRepo; }
        }

        public IRailcarRepository RailcarRepo
        {
            get { return railcarRepo; }
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


        public IReleaseNoteRepository ReleaseNoteRepo
        {
            get { return releaseNoteRepo; }
        }
    }
}
