using DevExpress.Mvvm.DataAnnotations;
using PrizmMain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.Railcar.NewEdit
{
    public class UnshipRailcarCommand : ICommand
    {
        private readonly IRailcarRepositories repos;
        private readonly RailcarViewModel viewModel;

        public UnshipRailcarCommand(RailcarViewModel viewModel, IRailcarRepositories repo)
        {
            this.viewModel = viewModel;
            this.repos = repo;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            var railcar = viewModel.Railcar;
            foreach (var pipe in railcar.Pipes)
            {
                pipe.Status = "Склад";
            }
            railcar.ShippingDate = DateTime.MinValue;
            
            viewModel.SaveCommand.Execute();
        }


        public bool CanExecute()
        {
            return (viewModel.Railcar.ShippingDate != DateTime.MinValue);
        }
    }
}
