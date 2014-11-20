using DevExpress.Mvvm.DataAnnotations;
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

            if (!railcar.ShippingDate.HasValue)
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
            //TODO: shipping restriction
            return true;
        }
    }
}
