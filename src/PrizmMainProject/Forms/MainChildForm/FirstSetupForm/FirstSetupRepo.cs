using NHibernate;
using Prizm.Data.DAL;
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
    }
}
