using Prizm.Data.DAL;
using DevExpress.Mvvm.DataAnnotations;
using Ninject;
using Prizm.Domain.Entity;
using Prizm.Main.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm.POCO;
using Prizm.Main.Common;
using Prizm.Main.Properties;
using Prizm.Main.Security;
using Prizm.Main.Languages;
using Prizm.Domain.Entity.Construction;

namespace Prizm.Main.Forms.Component.NewEdit
{
    public class SaveComponentCommand : ICommand
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(SaveComponentCommand));

        private readonly IComponentRepositories repos;
        private readonly ComponentNewEditViewModel viewModel;
        private readonly IUserNotify notify;
        private readonly ISecurityContext ctx;

        private int numberOfOperationWithoutInspectors=0;
        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        [Inject]
        public SaveComponentCommand(
            ComponentNewEditViewModel viewModel,
            IComponentRepositories repo,
            IUserNotify notify,
            ISecurityContext ctx)
        {
            this.viewModel = viewModel;
            this.repos = repo;
            this.notify = notify;
            this.ctx = ctx;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            if (!viewModel.ValidatableView.Validate())
            {
                return;
            }

            foreach(var result in viewModel.InspectionTestResults)
            {
                if(!result.Date.IsValid())
                {
                    notify.ShowInfo(Program.LanguageManager.GetString(StringResources.WrongDate),
                    Program.LanguageManager.GetString(StringResources.Message_ErrorHeader));
                    log.Warn("Date limits not valid!");
                    return;
                }
            }

            var c = repos.ComponentRepo.GetActiveByNumber(viewModel.Component);
            foreach (var component in c)
            {
                repos.ComponentRepo.Evict(component);
            }

            if (c != null && c.Count > 0)
            {
                notify.ShowInfo(
                    string.Concat(Program.LanguageManager.GetString(StringResources.ComponentNewEdit_Duplicate), " ", viewModel.Number),
                    Program.LanguageManager.GetString(StringResources.ComponentNewEdit_DuplicateHeader));
                viewModel.Number = string.Empty;
            }
            else
            {
                foreach (InspectionTestResult t in viewModel.InspectionTestResults)
                {
                    if (t.Status != PartInspectionStatus.Pending && t.Inspectors.Count<=0) 
                    {
                        numberOfOperationWithoutInspectors++;
                    }
                }
                if (numberOfOperationWithoutInspectors==0)
                {
                    try
                    {
                        viewModel.Component.InspectionStatus = viewModel.Component.GetPartInspectionStatus();
                        viewModel.Component.ToExport = true;
                        repos.BeginTransaction();
                        viewModel.Component.Number = viewModel.Component.Number.ToUpper();
                        repos.ComponentRepo.SaveOrUpdate(viewModel.Component);

                        var filesViewModel = viewModel.FilesFormViewModel;

                        //saving attached documents
                        bool fileCopySuccess = true;
                        if (null != filesViewModel)
                        {
                            filesViewModel.FileRepo = repos.FileRepo;
                            viewModel.FilesFormViewModel.Item = viewModel.Component.Id;
                            if (!viewModel.FilesFormViewModel.TrySaveFiles(viewModel.Component))
                            {
                                fileCopySuccess = false;
                                repos.Rollback();
                            }
                        }

                        if (fileCopySuccess)
                        {
                            repos.Commit();
                        }

                        repos.ComponentRepo.Evict(viewModel.Component);
                        viewModel.ModifiableView.IsModified = false;
                        viewModel.ModifiableView.Id = viewModel.Component.Id;
                        viewModel.ModifiableView.UpdateState();

                        if (fileCopySuccess)
                        {
                            if (null != filesViewModel) 
                            {
                                filesViewModel.DetachFileEntities();
                            }
                           
                           notify.ShowSuccess(
                                string.Concat(Program.LanguageManager.GetString(StringResources.ComponentNewEdit_Saved), viewModel.Number),
                                Program.LanguageManager.GetString(StringResources.ComponentNewEdit_SavedHeader));

                            log.Info(string.Format("The entity #{0}, id:{1} has been saved in DB.",
                             viewModel.Component.Number, viewModel.Component.Id));
                        }
                        else
                        {
                            notify.ShowError(Program.LanguageManager.GetString(StringResources.ExternalFiles_NotCopied),
                                Program.LanguageManager.GetString(StringResources.ExternalFiles_NotCopied_Header));
                        }

                    }
                    catch (RepositoryException ex)
                    {
                        log.Error(ex.Message);
                        notify.ShowFailure(ex.InnerException.Message, ex.Message);
                    }
                }
                else
                {
                    notify.ShowError(
                        Program.LanguageManager.GetString(StringResources.SelectInspectorsForTestResult),
                        Program.LanguageManager.GetString(StringResources.SelectInspectorsForTestResultHeader));
                        numberOfOperationWithoutInspectors = 0;
                }
            }
            RefreshVisualStateEvent();
        }


        public bool CanExecute()
        {
            return !string.IsNullOrEmpty(viewModel.Number)
                && viewModel.Type != null
                && viewModel.Component.IsActive
                && ctx.HasAccess(viewModel.IsNew
                                    ? global::Domain.Entity.Security.Privileges.CreateComponent
                                    : global::Domain.Entity.Security.Privileges.EditComponent);
        }

    }
}
