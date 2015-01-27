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
            firstSetupRepo.JointOperationRepo.SeedRequiredWeld(Resources.RequiredWeldJointOperation);
            firstSetupRepo.Commit();
            firstSetupRepo.RoleRepo.Evict(viewModel.SuperUser);
            firstSetupRepo.UserRepo.Evict(viewModel.Admin);
            firstSetupRepo.ProjectRepo.Evict(viewModel.Project);
            viewModel.IsSaved = true;

            var seeder = new InnitialDataSeeder(viewModel);
            seeder.Seed(Program.IsSeed);
            

        }

        public bool CanExecute()
        {
            return !string.IsNullOrWhiteSpace(viewModel.Project.Title) && viewModel.Project.WorkstationType != Prizm.Domain.Entity.Setup.WorkstationType.Undefined
                && !string.IsNullOrWhiteSpace(viewModel.Admin.Login) && !string.IsNullOrWhiteSpace(viewModel.Admin.Name.LastName) 
                && !string.IsNullOrWhiteSpace(viewModel.Admin.Name.FirstName);
        }

        #endregion
    }
}
