using Prizm.Data.DAL.Construction;
using Prizm.Data.DAL.Hibernate;
using Prizm.Data.DAL.Mill;
using NHibernate;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Spool
{
    public class SpoolRepositories : ISpoolRepositories
    {
        ISession session;
        private readonly ISpoolRepository spoolRepo;
        private readonly IPipeRepository pipeRepo;
        private readonly IInspectorRepository inspectorRepo;

        [Inject]
        public SpoolRepositories(ISession session)
        {
            this.session = session;
            this.spoolRepo = new SpoolRepository(session);
            this.pipeRepo = new PipeRepository(session);
            this.inspectorRepo = new InspectorRepository(session);
        }

        public ISpoolRepository SpoolRepo
        {
            get { return spoolRepo; }
        }

        public IPipeRepository PipeRepo
        {
            get { return pipeRepo; }
        }

        public IInspectorRepository RepoInspector
        {
            get { return inspectorRepo; }
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
