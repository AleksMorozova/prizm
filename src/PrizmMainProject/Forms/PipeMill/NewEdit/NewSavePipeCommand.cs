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
    public class NewSavePipeCommand: BaseCommand
    {
        private readonly IMillRepository repo;
        private readonly MillPipeNewEditViewModel viewModel;
        private readonly IUserNotify notify;
        private readonly ISecurityContext ctx;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        public NewSavePipeCommand(
            MillPipeNewEditViewModel viewModel, 
            IMillRepository repo,
            IUserNotify notify,
            ISecurityContext ctx)
        {
            this.viewModel = viewModel;
            this.repo = repo;
            this.notify = notify;
            this.ctx = ctx;
        }

        [Command(UseCommandManager = false)]
        public override void Execute()
        {
            if(!viewModel.ValidatableView.Validate())
            {
                return;
            }

            DateTime previousProductionDate = viewModel.Pipe.ProductionDate;
            var previousPipeMillSizeType = viewModel.PipeMillSizeType;
            var previousHeat = viewModel.Heat;
            var previousPurchaseOrder = viewModel.PipePurchaseOrder;

            viewModel.SavePipeCommand.Execute();

             if (viewModel.Number != string.Empty)
             {
                viewModel.NewPipe();

                viewModel.ProductionDate = previousProductionDate;

                viewModel.PipeMillSizeType = previousPipeMillSizeType;
                viewModel.PipeTestResults = viewModel.GetRequired(previousPipeMillSizeType);
                viewModel.Pipe.PipeTestResult = viewModel.PipeTestResults;

                viewModel.Heat = previousHeat;
                viewModel.PipePurchaseOrder = previousPurchaseOrder;
                viewModel.ModifiableView.IsModified = false;
                viewModel.ModifiableView.Id = viewModel.Pipe.Id;
             }
             RefreshVisualStateEvent();
        }

        public override bool CanExecute()
        {
            return viewModel.SavePipeCommand.CanExecute() && ctx.HasAccess(global::Domain.Entity.Security.Privileges.CreatePipe)
                && ctx.HasAccess(global::Domain.Entity.Security.Privileges.EditPipe);
        }
    }
}
