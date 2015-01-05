using NHibernate;
using Ninject;
using Prizm.Data.DAL;
using Prizm.Data.DAL.Construction;
using Prizm.Data.DAL.Hibernate;
using Prizm.Data.DAL.Mill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Parts.Inspection
{
    public class PartInspectionRepository : IPartInspectionRepository
    {
        private readonly IInspectorRepository repoInspector;
        private readonly IInspectionTestResultRepository repoInspectionTestResult;
        private readonly IPipeRepository repoPipe;
        private readonly ISpoolRepository repoSpool;
        private readonly IComponentRepository repoComponent;
        private readonly ISession session;
        [Inject]
        public PartInspectionRepository(ISession session)
        {
            this.session = session;
            this.repoInspector = new InspectorRepository(session);
            this.repoInspectionTestResult = new InspectionTestResultRepository(session);
            this.repoPipe = new PipeRepository(session);
            this.repoSpool = new SpoolRepository(session);
            this.repoComponent = new ComponentRepository(session);
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

        public IInspectorRepository RepoInspector
        {
            get { return repoInspector; }
        }

        public IInspectionTestResultRepository RepoInspectionTestResult
        {
            get { return repoInspectionTestResult; }
        }

        public IPipeRepository RepoPipe
        {
            get { return repoPipe; }
        }

        public ISpoolRepository RepoSpool
        {
            get { return repoSpool; }
        }

        public IComponentRepository RepoComponent
        {
            get { return repoComponent; } 
        }
    }
}
