using DevExpress.Mvvm.DataAnnotations;
using PrizmMain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm.POCO;
using PrizmMain.Properties;
using Domain.Entity.Mill;


namespace PrizmMain.Forms.PipeMill.NewEdit
{
    public class PipeDeactivationCommand: ICommand
    {
        private readonly IMillRepository repo;
        private readonly MillPipeNewEditViewModel viewModel;
        private readonly IUserNotify notify;

        public PipeDeactivationCommand(
            MillPipeNewEditViewModel viewModel, 
            IMillRepository repo,
            IUserNotify notify)
        {
            this.viewModel = viewModel;
            this.repo = repo;
            this.notify = notify;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            if (viewModel.Pipe.Railcar == null)
            {
                if (notify.ShowYesNo(
                    Resources.DLG_PIPE_DEACTIVATION,
                    Resources.DLG_PIPE_DEACTIVATION_HEDER))
                {
                    viewModel.SavePipeCommand.Execute();
                }
                else
                {
                    viewModel.IsNotActive = false;
                }
            }
            else if (viewModel.PipeStatus.Value == PipeMillStatus.Shipped)
            {
                notify.ShowInfo(
                    Resources.DLG_PIPE_IS_SHIPPED,
                    Resources.DLG_PIPE_IS_SHIPPED_HEDER);

                viewModel.IsNotActive = false;
            }
            else
            {
                notify.ShowInfo(
                    Resources.DLG_PIPE_IN_RAILCAR,
                    Resources.DLG_PIPE_IN_RAILCAR_HEDER);

                viewModel.IsNotActive = false;
            }
        }

        public virtual bool IsExecutable { get; set; }

        protected virtual void OnIsExecutableChanged()
        {
            this.RaiseCanExecuteChanged(x => x.Execute());
        }

        public bool CanExecute()
        {
            return 
                viewModel.Pipe.Status != PipeMillStatus.Shipped;  
        }
    }
}
