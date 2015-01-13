using Prizm.Data.DAL.Mill;
using DevExpress.Mvvm.DataAnnotations;
using Prizm.Main.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using DevExpress.Mvvm.POCO;
using Prizm.Main.Properties;
using Prizm.Main.Security;

namespace Prizm.Main.Forms.PipeMill.NewEdit
{
    public class NewSavePipeCommand: ICommand
    {
        private readonly IMillRepository repo;
        private readonly MillPipeNewEditViewModel viewModel;
        private readonly IUserNotify notify;
        ISecurityContext ctx = Program.Kernel.Get<ISecurityContext>();

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        public NewSavePipeCommand(
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
            if(!viewModel.ValidatableView.Validate())
            {
                return;
            }
            DateTime previousProductionDate = viewModel.Pipe.ProductionDate;
            viewModel.SavePipeCommand.Execute();

             if (viewModel.Number != string.Empty)
             {
                viewModel.NewPipe();
                viewModel.ProductionDate = previousProductionDate;
             }
             RefreshVisualStateEvent();
        }

        public bool CanExecute()
        {
            return viewModel.SavePipeCommand.CanExecute() && ctx.HasAccess(global::Domain.Entity.Security.Privileges.NewDataEntry);
        }
    }
}
