using Prizm.Data.DAL.Hibernate;
using Prizm.Data.DAL.Mill;
using Prizm.Data.DAL.Setup;
using Prizm.Data.DAL;
using NHibernate;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Data.DAL.Security;
using Prizm.Data.DAL.Construction;

namespace Prizm.Main.Forms.Settings
{
    public class SettingsRepositories : ISettingsRepositories
    {
        readonly ICertificateTypeRepository certificateTypeRepo;
        readonly ISeemTypeRepository seemTypeRepo;
        readonly IComponentTypeRepository componentTypeRepo;
        readonly IWelderRepository welderRepo;
        readonly IMillPipeSizeTypeRepository pipeSizeTypeRepo;
        readonly IPipeTestRepository pipeTestRepo;
        readonly IProjectRepository projectRepo;
        readonly IPlateManufacturerRepository manufacturerRepo;
        readonly IInspectorRepository inspectorRepo;
        readonly ICategoryRepository categoryRepo;
        readonly IJointOperationRepository jointRepo;
        readonly IUserRepository userRepo;
        readonly IRoleRepository roleRepo;
        readonly IPermissionRepository permissionRepo;
        readonly ISession session;

        [Inject]
        public SettingsRepositories(ISession session)
        {
            this.session = session;
            this.welderRepo = new WelderRepository(session);
            this.pipeTestRepo = new PipeTestRepository(session);
            this.pipeSizeTypeRepo = new MillPipeSizeTypeRepository(session);
            this.projectRepo = new ProjectRepository(session);
            this.manufacturerRepo = new PlateManufacturerRepository(session);
            this.inspectorRepo = new InspectorRepository(session);
            this.categoryRepo = new CategoryRepository(session);
            this.jointRepo = new JointOperationRepository(session);
            this.userRepo = new UserRepository(session);
            this.roleRepo = new RoleRepository(session);
            this.permissionRepo = new PermissionRepository(session);
            this.componentTypeRepo = new ComponentTypeRepository(session);
            this.certificateTypeRepo = new InspectorCertificateTypeRepository(session);
            this.seemTypeRepo = new SeemTypeRepository(session);
        }

        public void Dispose()
        {
            session.Dispose();
        }

        public ICertificateTypeRepository CertificateTypeRepo
        {
            get
            {
                return certificateTypeRepo;
            }
        }

        public IComponentTypeRepository ComponentTypeRepo
        {
            get
            {
                return componentTypeRepo;
            }
        }

        public ICategoryRepository СategoryRepo
        {
            get
            {
                return categoryRepo;
            }
        }

        public IWelderRepository WelderRepo
        {
            get { return welderRepo; }
        }

        public IMillPipeSizeTypeRepository PipeSizeTypeRepo
        {
            get { return pipeSizeTypeRepo; }
        }

        public IPipeTestRepository PipeTestRepo
        {
            get { return pipeTestRepo; }
        }

        public IInspectorRepository InspectorRepo
        {
            get { return inspectorRepo; }
        }

        public IProjectRepository ProjectRepo
        {
            get { return projectRepo; }
        }

        public IPlateManufacturerRepository PlateManufacturerRepo
        {
            get { return manufacturerRepo; }
        }

        public void Commit()
        {
            session.Transaction.Commit();
        }

        public void BeginTransaction()
        {
            session.BeginTransaction();
        }



        public IRoleRepository RoleRepo
        {
            get
            {
                return roleRepo;
            }
        }

        public IUserRepository UserRepo
        {
            get
            {
                return userRepo;
            }
        }

        public IPermissionRepository PermissionRepo
        {
            get
            {
                return permissionRepo;
            }
        }

        public IJointOperationRepository JointRepo
        {
            get { return jointRepo; }
        }



        public ISeemTypeRepository SeemTypeRepo
        {
            get { return seemTypeRepo; }
        }
    }
}
