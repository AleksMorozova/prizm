using Prizm.DAL.Hibernate;
using Prizm.Data.DAL;
using Prizm.Data.DAL.Hibernate;
using Prizm.Data.DAL.Mill;
using Prizm.Data.DAL.Setup;
using NHibernate;
using Ninject;
using Prizm.Main.Forms.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.PipeMill
{
    public class MillRepository : IMillRepository
    {
        private readonly IPipeRepository repoPipe;
        private readonly IPlateRepository repoPlate;
        private readonly IHeatRepository repoHeat;
        private readonly IWeldRepository repoWeld;
        private readonly IMillPipeSizeTypeRepository repoPipeType;
        private readonly IPurchaseOrderRepository repoPurchaseOrder;
        private readonly IWelderRepository welderRepo;
        private readonly IPipeTestResultRepository repoPipeTestResult;
        private readonly IInspectorRepository repoInspector;
        private readonly IPipeTestRepository repoPipeTest;
        private readonly IProjectRepository repoProject;
        private readonly IFileRepository fileRepo;

        private readonly ISession session;

        [Inject]
        public MillRepository(ISession session)
        {
            this.session = session;
            this.repoPipe = new PipeRepository(session);
            this.repoPlate = new PlateRepository(session);
            this.repoHeat = new HeatRepository(session);
            this.repoWeld = new WeldRepository(session);
            this.repoPipeType = new MillPipeSizeTypeRepository(session);
            this.repoPurchaseOrder = new PurchaseOrderRepository(session);
            this.repoPipeTestResult = new PipeTestResultRepository(session);
            this.repoInspector = new InspectorRepository(session);
            this.repoPipeTest = new PipeTestRepository(session);
            this.welderRepo = new WelderRepository(session);
            this.repoProject = new ProjectRepository(session);
            this.fileRepo = new FileRepository(session);
        }

        public IFileRepository FileRepo { get { return fileRepo; } }

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

        public IPipeRepository RepoPipe
        {
            get { return repoPipe; }
        }

        public IPlateRepository RepoPlate
        {
            get { return repoPlate; }
        }

        public IHeatRepository RepoHeat
        {
            get { return repoHeat; }
        }

        public IWeldRepository RepoWeld
        {
            get { return repoWeld; }
        }

        public IMillPipeSizeTypeRepository RepoPipeType
        {
            get { return repoPipeType; }
        }

        public IPurchaseOrderRepository RepoPurchaseOrder
        {
            get { return repoPurchaseOrder; }
        }

        public IPipeTestResultRepository RepoPipeTestResult
        {
            get { return repoPipeTestResult; }
        }

        public IPipeTestRepository RepoPipeTest
        {
            get { return repoPipeTest; }
        }

        public IWelderRepository WelderRepo
        {
            get { return welderRepo; }
        }

        public IInspectorRepository RepoInspector
        {
            get { return repoInspector; }
        }

        public IProjectRepository RepoProject
        {
            get { return repoProject; }
        }
    }
}
