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
        ISecurityContext ctx = Program.Kernel.Get<ISecurityContext>();

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        [Inject]
        public SaveRailcarCommand(RailcarViewModel viewModel, IRailcarRepositories repo, IUserNotify notify)
        {
            this.viewModel = viewModel;
            this.repos = repo;
            this.notify = notify;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            if(!viewModel.validatableView.Validate())
            {
                return;
            }

            if(string.IsNullOrWhiteSpace(viewModel.Railcar.Number))
            {
                notify.ShowError(Resources.DLG_RAILCAR_NUMBER_EMPTY, Resources.DLG_ERROR_HEADER);
                return;
            }

            if(viewModel.Railcar.ShippingDate == DateTime.MinValue)
            {
                viewModel.Railcar.ShippingDate = null;
            }
            try
            {
                foreach(var pipe in viewModel.Railcar.Pipes)
                {
                    pipe.Railcar = viewModel.Railcar;
                }

                repos.BeginTransaction();
                repos.RailcarRepo.SaveOrUpdate(viewModel.Railcar);
                repos.Commit();
                repos.RailcarRepo.Evict(viewModel.Railcar);
                viewModel.ModifiableView.IsModified = false;

                //saving attached documents
                if(viewModel.FilesFormViewModel != null)
                {
                    viewModel.FilesFormViewModel.Item = viewModel.Railcar.Id;
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
            bool condition = !string.IsNullOrWhiteSpace(viewModel.Number) && !viewModel.IsShipped;
            bool conditionAndPermission;
            if(viewModel.IsNew)
            {
                conditionAndPermission = condition && ctx.HasAccess(global::Domain.Entity.Security.Privileges.NewDataEntry);
            }
            else
            {
                conditionAndPermission = condition && ctx.HasAccess(global::Domain.Entity.Security.Privileges.EditData);
            }
            return conditionAndPermission;
        }
    }
}