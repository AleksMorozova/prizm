using Data.DAL.Mill;
using DevExpress.Mvvm.DataAnnotations;
using Domain.Entity.Mill;
using PrizmMain.Commands;
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
                //TODO: input in Resource
                notify.ShowError("Неверный номер трубы", "Введен неверный номер трубы.");
            }
        }


        public bool CanExecute()
        {
            return true;
        }

        public virtual bool IsExecutable { get; set; }
    }
}
