using NHibernate;
using Prizm.Data.DAL;
using Prizm.Data.DAL.Construction;
using Prizm.Data.DAL.Hibernate;
using Prizm.Data.DAL.Mill;
using Prizm.Data.DAL.Security;
using Prizm.Data.DAL.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.MainChildForm.FirstSetupForm
{
    public class FirstSetupRepo : IFirstSetupRepo
    {
        private readonly ISession session;
        private readonly IUserRepository userRepo;
        private readonly IProjectRepository projectRepo;
        private readonly ICertificateTypeRepository certificateTypeRepo;
        private readonly ISeamTypeRepository seemTypeRepo;
        private readonly IPermissionRepository permissionRepo;
        private readonly IRoleRepository roleRepo;
        private readonly ICategoryRepository categoryRepo;
        private readonly IJointOperationRepository jointOperationRepo;

        private readonly IPipeTestRepository pipeTestsRepo;
        private readonly IMillPipeSizeTypeRepository sizeTypeRepo;
        private readonly IPlateManufacturerRepository plateManRepo;
        private readonly IHeatRepository heatRepo;
        private readonly IPlateRepository plateRepo;
        private readonly IPurchaseOrderRepository purchaseRepo;
        private readonly IRailcarRepository railRepo;
        private readonly IPipeRepository pipeRepo;
        private readonly IInspectorRepository inspectorRepo;
        private readonly IPipeTestResultRepository pipeTestResultRepo;
        private readonly IWelderRepository welderRepo;
        private readonly IComponentTypeRepository componentTypeRepo;
        private readonly IComponentRepository componentRepo;
        private readonly IReleaseNoteRepository releaseRepo;

        public FirstSetupRepo()
        {
            this.session = HibernateUtil.OpenSession(false);
            this.userRepo = new UserRepository(session);
            this.projectRepo = new ProjectRepository(session);
            this.certificateTypeRepo = new InspectorCertificateTypeRepository(session);
            this.seemTypeRepo = new SeamTypeRepository(session);
            this.permissionRepo = new PermissionRepository(session);
            this.roleRepo = new RoleRepository(session);
            this.categoryRepo = new CategoryRepository(session);
            this.jointOperationRepo = new JointOperationRepository(session);
            this.pipeTestsRepo = new PipeTestRepository(session);
            this.sizeTypeRepo = new MillPipeSizeTypeRepository(session);
            this.plateManRepo = new PlateManufacturerRepository(session);
            this.heatRepo = new HeatRepository(session);
            this.plateRepo = new PlateRepository(session);
            this.purchaseRepo = new PurchaseOrderRepository(session);
            this.railRepo = new RailcarRepository(session);
            this.pipeRepo = new PipeRepository(session);
            this.inspectorRepo = new InspectorRepository(session);
            this.pipeTestResultRepo = new PipeTestResultRepository(session);
            this.welderRepo = new WelderRepository(session);
            componentTypeRepo = new ComponentTypeRepository(session);
            componentRepo = new ComponentRepository(session);
            releaseRepo = new ReleaseNoteRepository(session);
        }
        public IReleaseNoteRepository ReleaseRepo { get { return releaseRepo; } }

        public IComponentRepository ComponentRepo { get { return componentRepo; } }

        public IComponentTypeRepository ComponentTypeRepo { get { return componentTypeRepo; } }

        public IWelderRepository WelderRepo { get { return welderRepo; } }

        public IPipeTestResultRepository PipeTestResultRepo { get { return pipeTestResultRepo; } }

        public IInspectorRepository InspectorRepo { get { return inspectorRepo; } }

        public IPipeRepository PipeRepo { get { return pipeRepo; } }

        public IRailcarRepository RailRepo { get { return railRepo; } }

        public IPurchaseOrderRepository PurchaseRepo { get { return purchaseRepo; } }

        public IPlateRepository PlateRepo { get { return plateRepo; } }

        public IHeatRepository HeatRepo { get { return heatRepo; } }

        public IPlateManufacturerRepository PlateManRepo
        { get { return plateManRepo; } }

        public IPipeTestRepository TestRepo
        {
            get { return pipeTestsRepo; }
        }

        public IUserRepository UserRepo
        {
            get { return userRepo; }
        }

        public IProjectRepository ProjectRepo
        {
            get { return projectRepo; }
        }

        public ICertificateTypeRepository CertificateTypeRepo
        {
            get { return certificateTypeRepo; }
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

        public ISeamTypeRepository SeemTypeRepo
        {
            get { return seemTypeRepo; }
        }

        public IPermissionRepository PermissionRepo
        {
            get { return permissionRepo; }
        }

        public IRoleRepository RoleRepo
        {
            get { return roleRepo; }
        }


        public ICategoryRepository CategoryRepo
        {
            get { return categoryRepo; }
        }

        public IJointOperationRepository JointOperationRepo
        {
            get { return jointOperationRepo; }
        }

        #region IFirstSetupRepo Members


        public IMillPipeSizeTypeRepository SizeTypeRepo
        {
            get { return sizeTypeRepo; }
        }

        #endregion
    }
}
