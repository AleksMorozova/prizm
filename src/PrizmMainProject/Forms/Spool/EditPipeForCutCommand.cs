using Data.DAL.Mill;
using DevExpress.Mvvm.DataAnnotations;
using Domain.Entity.Mill;
using PrizmMain.Commands;
using PrizmMain.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.Spool
{
    public class EditPipeForCutCommand : ICommand
    {
        readonly ISpoolRepositories repos;
        readonly SpoolViewModel viewModel;
        readonly IUserNotify notify;

        public EditPipeForCutCommand(SpoolViewModel viewModel, ISpoolRepositories repos, IUserNotify notify)
        {
            this.viewModel = viewModel;
            this.repos = repos;
            this.notify = notify;
        }

        [Command(UseCommandManager = false)]
        public void Execute() 
        {
            if (repos.PipeRepo.GetByNumber(viewModel.PipeNumber) != null)
            {
                viewModel.Pipe = repos.PipeRepo.GetByNumber(viewModel.PipeNumber);
                viewModel.ModifiableView.IsModified = false;
            }

            else
            {
                notify.ShowError(Resources.Wrong_pipe_number_for_cutting, Resources.Wrong_pipe_number_for_cutting_Header);
            }
        }


        public bool CanExecute()
        {
            return true;
        }

        public virtual bool IsExecutable { get; set; }
    }
}
