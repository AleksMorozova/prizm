using Prizm.Data.DAL.Mill;
using Prizm.Data.DAL.Setup;
using Prizm.Data.DAL;
using DevExpress.Mvvm.DataAnnotations;
using Prizm.Domain.Entity.Setup;
using Prizm.Main.Commands;
using Prizm.Main.Forms.Settings.ViewTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Main.Properties;
using Prizm.Main.Documents;
using Prizm.Domain.Entity.Security;
using Prizm.Main.Security;
using Ninject;
using Prizm.Main.Languages;

namespace Prizm.Main.Forms.Settings
{
    public class SaveSettingsCommand : ICommand
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(SaveSettingsCommand));

        readonly ISettingsRepositories repos;
        readonly SettingsViewModel viewModel;
        readonly IUserNotify notify;
        readonly ISecurityContext ctx;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        public SaveSettingsCommand(SettingsViewModel viewModel, ISettingsRepositories repos, IUserNotify notify, ISecurityContext ctx)
        {
            this.viewModel = viewModel;
            this.repos = repos;
            this.notify = notify;
            this.ctx = ctx;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            if(!viewModel.validatableView.Validate())
            {
                notify.ShowError(
                     Program.LanguageManager.GetString(StringResources.Settings_CheckValues),
                     Program.LanguageManager.GetString(StringResources.Settings_ErrorHeader));
                    
                return;
            }

            try
            {
                repos.BeginTransaction();
                SaveWelders();
                SaveInspectors();
                SaveMillSizeTypes();
                SavePlateManufacturers();
                repos.ProjectRepo.SaveOrUpdate(viewModel.CurrentProjectSettings);
                SaveRoles();
                SaveUsers();
                SaveCategories();
                SaveJointOperations();
                SaveComponentryType();
                SaveInspectorCertificateType();
                SaveSeamType();
                repos.Commit();
                EvictMillSizeTypes();
                EvictWelders();
                EvictInspectors();
                EvictPlateManufacturers();
                EvictRoles();
                EvictUsers();
                EvictJointOperations();
                repos.ProjectRepo.Evict(viewModel.CurrentProjectSettings);
                EvictCategories();
                EvictComponentryType();
                EvictInspectorCertificateType();
                EvictSeamType();
                viewModel.ModifiableView.IsModified = false;

                notify.ShowNotify(
                     Program.LanguageManager.GetString(StringResources.Settings_SetupSaves),
                    Program.LanguageManager.GetString(StringResources.Settings_SetupSavedHeader));
            }
            catch (RepositoryException ex)
            {
                log.Error(ex.Message);
                notify.ShowFailure(ex.InnerException.Message, ex.Message);
            }

            RefreshVisualStateEvent();
        }

        private void EvictUsers()
        {
           if (viewModel.Users != null)
           {
              viewModel.Users.ForEach<User>(_ => repos.UserRepo.Evict(_));
           }
        }

        private void SaveUsers()
        {
           if (viewModel.Users != null)
           {
              viewModel.Users.ForEach<User>(_ => repos.UserRepo.SaveOrUpdate(_));
              log.Info("Settings setup for Users has been updated in DB.");
           }
        }

        private void EvictRoles()
        {
           if (viewModel.Roles != null)
           {
              viewModel.Roles.ForEach<Role>(_ => repos.RoleRepo.Evict(_));
           }
        }

        private void SaveRoles()
        {
           if (viewModel.Roles != null)
           {
              viewModel.Roles.ForEach<Role>(_ => repos.RoleRepo.SaveOrUpdate(_));
              log.Info("Settings setup for Roles has been updated in DB.");
           }
        }

        private void EvictWelders()
        {
            if (viewModel.Welders != null)
            {
                viewModel.Welders.ForEach<WelderViewType>(_ => repos.WelderRepo.Evict(_.Welder));
            }
        }

        private void EvictMillSizeTypes()
        {
            foreach (PipeMillSizeType t in viewModel.PipeMillSizeType)
            {
                repos.PipeSizeTypeRepo.Evict(t);
            }
        }

        private void EvictJointOperations()
        {
            foreach (JointOperation o in viewModel.JointOperations)
            {
                repos.JointRepo.Evict(o);
            }
        }

        private void EvictPlateManufacturers()
        {
            foreach (Prizm.Domain.Entity.Mill.PlateManufacturer manufacturer in viewModel.PlateManufacturers)
            {
                repos.PlateManufacturerRepo.Evict(manufacturer);
            }
        }

        public bool CanExecute()
        {
            return ctx.HasAccess(global::Domain.Entity.Security.Privileges.EditSettings);
        }

        void SaveMillSizeTypes()
        {
            foreach (PipeMillSizeType t in viewModel.PipeMillSizeType)
            {
                repos.PipeSizeTypeRepo.SaveOrUpdate(t);
            }

            log.Info("Settings setup for Pipe Mill Sizetype has been updated in DB.");
        }

        void SaveJointOperations()
        {
            foreach (JointOperation o in viewModel.JointOperations)
            {
                repos.JointRepo.SaveOrUpdate(o);
            }

            log.Info("Settings setup for Joint Operations has been updated in DB.");
        }

        void SaveWelders()
        {
            if (viewModel.Welders != null)
            {
                viewModel.Welders.ForEach<WelderViewType>(_ => repos.WelderRepo.SaveOrUpdate(_.Welder));
            }

            log.Info("Settings setup for Welders has been updated in DB.");
        }

        void SaveInspectors()
        {
           if (viewModel.Inspectors != null)
           {
              viewModel.Inspectors.ForEach<InspectorViewType>(_ => repos.InspectorRepo.SaveOrUpdate(_.Inspector));
           }

           log.Info("Settings setup for Inspectors has been updated in DB.");
        }

        void EvictInspectors()
        {
            if (viewModel.Inspectors != null)
            {
                viewModel.Inspectors.ForEach<InspectorViewType>(_ => repos.InspectorRepo.Evict(_.Inspector));
            }
        }

        void SavePlateManufacturers()
        {
            foreach (Prizm.Domain.Entity.Mill.PlateManufacturer manufacturer in viewModel.PlateManufacturers)
            {
                repos.PlateManufacturerRepo.SaveOrUpdate(manufacturer);
            }

            log.Info("Settings setup for Plate Manufacturers has been updated in DB.");
        }
      
        private void EvictCategories()
        {
            foreach (var category in viewModel.CategoryTypes)
            {
                repos.СategoryRepo.Evict(category);
            }
        }

        private void SaveCategories()
        {
            foreach (var category in viewModel.CategoryTypes)
            {
                repos.СategoryRepo.SaveOrUpdate(category);
            }

            log.Info("Settings setup for Category Types has been updated in DB.");
        }

        private void EvictComponentryType()
        {
            foreach (var component in viewModel.ComponentryTypes)
            {
                repos.ComponentTypeRepo.Evict(component);
            }
        }

        private void SaveComponentryType()
        {
            foreach (var component in viewModel.ComponentryTypes)
            {
                repos.ComponentTypeRepo.SaveOrUpdate(component);
            }

            log.Info("Settings setup for Componentry Types has been updated in DB.");
        }

        private void EvictInspectorCertificateType()
        {
            foreach (var certificate in viewModel.CertificateTypes)
            {
                repos.CertificateTypeRepo.Evict(certificate);
            }
        }

        private void SaveInspectorCertificateType()
        {
            foreach (var certificate in viewModel.CertificateTypes)
            {
                repos.CertificateTypeRepo.SaveOrUpdate(certificate);
            }

            log.Info("Settings setup for Inspector Certificate Types has been updated in DB.");
        }

        private void EvictSeamType()
        {
            foreach (var seam in viewModel.SeamTypes)
            {
                repos.SeamTypeRepo.Evict(seam);
            }
        }

        private void SaveSeamType()
        {
            foreach (var seam in viewModel.SeamTypes)
            {
                repos.SeamTypeRepo.SaveOrUpdate(seam);
            }

            log.Info("Settings setup for Seam Types has been updated in DB.");
        }

    }
}
