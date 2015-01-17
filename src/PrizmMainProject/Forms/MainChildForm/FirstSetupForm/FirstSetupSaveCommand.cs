using Prizm.Data.DAL;
using Prizm.Data.DAL.Security;
using DevExpress.Mvvm.DataAnnotations;
using Prizm.Main.Commands;
using Prizm.Main.Forms.Common;
using Prizm.Main.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Prizm.Data.DAL.Hibernate;
using NHibernate;
using Prizm.Data.DAL.Setup;
using Prizm.Main.Properties;

namespace Prizm.Main.Forms.MainChildForm.FirstSetupForm
{
    public class FirstSetupSaveCommand : ICommand
    {
        private readonly FirstSetupViewModel viewModel;
        private readonly IFirstSetupRepo firstSetupRepo;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        public FirstSetupSaveCommand(FirstSetupViewModel viewModel, IFirstSetupRepo firstSetupRepo)
        {
            this.viewModel = viewModel;
            this.firstSetupRepo = firstSetupRepo;
        }

        #region ICommand Members
        [Command(UseCommandManager = false)]
        public void Execute()
        {
            viewModel.Admin.Name = viewModel.Name;
            viewModel.Admin.PasswordHash = PasswordEncryptor.EncryptPassword(viewModel.Password);
            viewModel.Admin.IsActive = true;
            viewModel.Project.IsActive = true;
            if(viewModel.Project.WorkstationType != Domain.Entity.Setup.WorkstationType.Mill)
            {
                viewModel.MillName = string.Empty;
                viewModel.MillPipeNumberMask = string.Empty;
            }

            firstSetupRepo.BeginTransaction();
            firstSetupRepo.RoleRepo.Save(viewModel.SuperUser);
            firstSetupRepo.UserRepo.Save(viewModel.Admin);
            firstSetupRepo.ProjectRepo.Save(viewModel.Project);
            SaveInspectorCertificateTypes();
            SaveSeemTypes();
            SaveCategoryes();
            firstSetupRepo.JointOperationRepo.SeedRequiredWeld(Resources.RequiredWeldJointOperation);
            firstSetupRepo.Commit();
            firstSetupRepo.RoleRepo.Evict(viewModel.SuperUser);
            firstSetupRepo.UserRepo.Evict(viewModel.Admin);
            firstSetupRepo.ProjectRepo.Evict(viewModel.Project);
            EvictInspectorCertificateTypes();
            EvictSeemTypes();
            EvictCategoryes();
            viewModel.IsSaved = true;
        }

        public bool CanExecute()
        {
            return !string.IsNullOrWhiteSpace(viewModel.Project.Title) && viewModel.Project.WorkstationType != Prizm.Domain.Entity.Setup.WorkstationType.Undef
                && !string.IsNullOrWhiteSpace(viewModel.Admin.Login) && !string.IsNullOrWhiteSpace(viewModel.Admin.Name.LastName) 
                && !string.IsNullOrWhiteSpace(viewModel.Admin.Name.FirstName);
        }

        private void SaveInspectorCertificateTypes()
        {
            foreach (var ct in viewModel.InspectorCertificateTypes)
            {
                firstSetupRepo.CertificateTypeRepo.Save(ct);
            }
        }

        private void SaveSeemTypes()
        {
            foreach (var seam in viewModel. SeamTypes)
            {
                firstSetupRepo.SeemTypeRepo.Save(seam);
            }
        }

        private void SaveCategoryes()
        {
            foreach (var category in viewModel.FixedCategoryes)
            {
                firstSetupRepo.CategoryRepo.Save(category);
            }
        }

        private void EvictInspectorCertificateTypes()
        {
            foreach (var ct in viewModel.InspectorCertificateTypes)
            {
                firstSetupRepo.CertificateTypeRepo.Evict(ct);
            }
        }

        private void EvictSeemTypes()
        {
            foreach (var seam in viewModel.SeamTypes)
            {
                firstSetupRepo.SeemTypeRepo.Evict(seam);
            }
        }

        private void EvictCategoryes()
        {
            foreach (var category in viewModel.FixedCategoryes)
            {
                firstSetupRepo.CategoryRepo.Evict(category);
            }
        }

        #endregion
    }
}
