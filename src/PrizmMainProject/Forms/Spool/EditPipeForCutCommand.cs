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

namespace Prizm.Main.Forms.Spool
{
    public class EditPipeForCutCommand : ICommand
    {
        readonly ISpoolRepositories repos;
        readonly SpoolViewModel viewModel;
        readonly IUserNotify notify;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        public EditPipeForCutCommand(SpoolViewModel viewModel, ISpoolRepositories repos, IUserNotify notify)
        {
            this.viewModel = viewModel;
            this.repos = repos;
            this.notify = notify;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
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


        public bool CanExecute()
        {
            return true;
        }

    }
}
