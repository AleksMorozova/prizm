using Prizm.Data.DAL.Mill;
using DevExpress.Mvvm.DataAnnotations;
using Prizm.Domain.Entity.Mill;
using Prizm.Main.Commands;
using Prizm.Main.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Main.Languages;
using Prizm.Main.Common;
using Prizm.Main.Security;
using Prizm.Data.DAL;

namespace Prizm.Main.Forms.Spool
{
    public class EditPipeForCutCommand : ICommand
    {
        readonly ISpoolRepositories repos;
        readonly SpoolViewModel viewModel;
        readonly IUserNotify notify;
        readonly ISecurityContext ctx;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(EditPipeForCutCommand));

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        public EditPipeForCutCommand(SpoolViewModel viewModel, ISpoolRepositories repos, IUserNotify notify, ISecurityContext ctx)
        {
            this.viewModel = viewModel;
            this.repos = repos;
            this.notify = notify;
            this.ctx = ctx;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            try
            {
                if(repos.PipeRepo.GetByNumber(viewModel.PipeNumber) != null)
                {
                    viewModel.Pipe = repos.PipeRepo.GetByNumber(viewModel.PipeNumber);
                    if(viewModel.Pipe.Length <= Constants.MinSpoolCut)
                    {
                        notify.ShowError(
                            Program.LanguageManager.GetString(StringResources.Spool_NullSpoolLength),
                            Program.LanguageManager.GetString(StringResources.Spool_CutSpoolFromPipeHeader));
                        viewModel.ModifiableView.IsEditMode = false;
                    }
                    else
                    {
                        viewModel.ModifiableView.IsEditMode = true;
                        StringBuilder number = new StringBuilder();
                        int spoolNumber = repos.SpoolRepo.GetAllSpoolFromPipe(viewModel.Spool.PipeNumber).Count + 1;
                        number.Append(viewModel.Spool.PipeNumber + "/" + spoolNumber.ToString());
                        viewModel.SpoolNumber = number.ToString();
                        viewModel.InitPipeLenght = viewModel.Pipe.Length;
                        viewModel.editableForm.spoolLength.Properties.MinValue = Constants.MinSpoolCut;
                        viewModel.editableForm.spoolLength.Properties.MaxValue = viewModel.Pipe.Length - Constants.MinSpoolCut;
                    }
                }

                else
                {
                    notify.ShowError(
                        Program.LanguageManager.GetString(StringResources.Spool_WrongPipeNumberForCutting),
                        Program.LanguageManager.GetString(StringResources.Spool_WrongPipeNumberForCuttingHeader));
                    viewModel.ModifiableView.IsEditMode = false;
                }
                RefreshVisualStateEvent();
            }
            catch(RepositoryException ex)
            {
                log.Warn(this.GetType().Name + " | " + ex.ToString());
                notify.ShowWarning(Program.LanguageManager.GetString(StringResources.Notification_Error_Db_Message),
            Program.LanguageManager.GetString(StringResources.Notification_Error_Db_Header));
            }
        }


        public bool CanExecute()
        {
            return viewModel.Spool.IsActive
                   && ctx.HasAccess(viewModel.IsNew
                    ? global::Domain.Entity.Security.Privileges.CreateSpool
                    : global::Domain.Entity.Security.Privileges.EditSpool);
        }

    }
}
