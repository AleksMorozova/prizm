using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraEditors;
using Prizm.Domain.Entity.Mill;
using Ninject;
using Prizm.Main.Commands;
using Prizm.Main.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prizm.Main.Forms.Railcar.NewEdit
{
    public class ShipRailcarCommand : ICommand
    {
        private readonly IRailcarRepositories repos;
        private readonly RailcarViewModel viewModel;
        private readonly IUserNotify notify;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        [Inject]
        public ShipRailcarCommand(RailcarViewModel viewModel, IRailcarRepositories repo, IUserNotify notify)
        {
            this.viewModel = viewModel;
            this.repos = repo;
            this.notify = notify;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            if(viewModel.Railcar.Pipes.Count == 0)
            {
                notify.ShowError(Resources.DLG_SHIP_RAILCAR_VS_PIPES, Resources.DLG_ERROR_HEADER);
                return;
            }

            int distinctSizes = viewModel.Railcar.Pipes.Select(p => p.Type).Distinct().Count();

            if(distinctSizes > 1)
            {
                notify.ShowError(Resources.DLG_RAILCAR_TYPESIZE_ERROR, Resources.DLG_ERROR_HEADER);
            }
            else
            {
                if(viewModel.Railcar.ShippingDate == DateTime.MinValue || viewModel.Railcar.ShippingDate == null)
                {
                    viewModel.Railcar.ShippingDate = DateTime.Now;
                }

                foreach(var pipe in viewModel.Railcar.Pipes)
                {
                    pipe.Status = PipeMillStatus.Shipped;
                    //pipe.ToExport = true;
                }
                viewModel.IsShipped = true;
                viewModel.SaveCommand.Execute();
                notify.ShowSuccess(Resources.AlertShipRailcar + " #" + viewModel.Railcar.Number, Resources.AlertInfoHeader);
            }
            RefreshVisualStateEvent();
        }

        public bool CanExecute()
        {
            return (!viewModel.Railcar.IsShipped && !string.IsNullOrWhiteSpace(viewModel.Number) && viewModel.Pipes.Count != 0);
        }
    }
}
