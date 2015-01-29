using Prizm.Data.DAL.Mill;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraEditors;
using Prizm.Domain.Entity.Mill;
using Prizm.Main.Commands;
using Prizm.Main.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Ninject;
using Prizm.Data.DAL;
using Prizm.Main.Security;

namespace Prizm.Main.Forms.Railcar.NewEdit
{
    public class SaveRailcarCommand : ICommand
    {
        private readonly IRailcarRepositories repos;
        private readonly RailcarViewModel viewModel;
        private readonly IUserNotify notify;
        private readonly ISecurityContext ctx;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        [Inject]
        public SaveRailcarCommand(RailcarViewModel viewModel, IRailcarRepositories repo, IUserNotify notify, ISecurityContext ctx)
        {
            this.viewModel = viewModel;
            this.repos = repo;
            this.notify = notify;
            this.ctx = ctx;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            if(!viewModel.validatableView.Validate())
            {
                return;
            }

            if(string.IsNullOrWhiteSpace(viewModel.Number))
            {
                notify.ShowError(Resources.DLG_RAILCAR_NUMBER_EMPTY, Resources.DLG_ERROR_HEADER);
                return;
            }

           
            try
            {
                foreach (Prizm.Domain.Entity.Mill.Railcar r in viewModel.Railcars)
                {
                    r.ReleaseNote = viewModel.ReleaseNote;
                }
                repos.BeginTransaction();

                repos.ReleaseNoteRepo.SaveOrUpdate(viewModel.ReleaseNote);
                repos.Commit();

                repos.ReleaseNoteRepo.Evict(viewModel.ReleaseNote);
                viewModel.ModifiableView.IsModified = false;

                //saving attached documents
                if (viewModel.FilesFormViewModel != null)
                {
                    viewModel.FilesFormViewModel.Item = viewModel.ReleaseNote.Id;
                    viewModel.FilesFormViewModel.AddExternalFileCommand.Execute();
                    viewModel.FilesFormViewModel = null;
                }

                notify.ShowSuccess(Resources.AlertSaveRailcar, Resources.AlertSaveHeader);
            }
            catch(RepositoryException ex)
            {
                notify.ShowFailure(ex.InnerException.Message, ex.Message);
            }
            RefreshVisualStateEvent();
        }

        public bool CanExecute()
        {
            bool condition = !string.IsNullOrWhiteSpace(viewModel.Number)
                && !viewModel.Shipped;

            bool conditionAndPermission;
            if(viewModel.IsNew)
            {
                conditionAndPermission = condition && ctx.HasAccess(global::Domain.Entity.Security.Privileges.CreateReleaseNote);
            }
            else
            {
                conditionAndPermission = condition && ctx.HasAccess(global::Domain.Entity.Security.Privileges.EditReleaseNote);
            }
            return conditionAndPermission;
        }
    }
}