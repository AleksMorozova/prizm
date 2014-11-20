using DevExpress.Mvvm.DataAnnotations;
using DevExpress.XtraEditors;
using PrizmMain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                //TODO: extract hardcoded text
                XtraMessageBox.Show("Отправка вагона без труб невозможна!", "Ошибка");
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
            if (viewModel.Railcar.ShippingDate != DateTime.MinValue)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
