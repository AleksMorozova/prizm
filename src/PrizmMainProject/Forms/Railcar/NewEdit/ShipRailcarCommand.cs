using DevExpress.Mvvm.DataAnnotations;
using DevExpress.XtraEditors;
using PrizmMain.Commands;
using PrizmMain.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrizmMain.Forms.Railcar.NewEdit
{
    public class ShipRailcarCommand : ICommand
    {
        private readonly IRailcarRepositories repos;
        private readonly RailcarViewModel viewModel;

        public ShipRailcarCommand(RailcarViewModel viewModel, IRailcarRepositories repo)
        {
            this.viewModel = viewModel;
            this.repos = repo;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            var railcar = viewModel.Railcar;

            if (railcar.Pipes.Count == 0)
            {
                XtraMessageBox.Show(Resources.DLG_SHIP_RAILCAR_VS_PIPES, Resources.DLG_ERROR_HEADER, 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (railcar.ShippingDate == DateTime.MinValue)
            {
                railcar.ShippingDate = DateTime.Now;
            }

            foreach (var pipe in railcar.Pipes)
            {
                pipe.Status = "Отгружена";
            }
            viewModel.SaveCommand.Execute();
        }

        public bool CanExecute()
        {
            return !(viewModel.Railcar.ShippingDate != DateTime.MinValue);
        }
    }
}
