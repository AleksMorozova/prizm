using Data.DAL.Mill;
using DevExpress.Mvvm.DataAnnotations;
using PrizmMain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrizmMain.Forms.Railcar.Search
{
    public class SearchRailcarCommand : ICommand
    {
        private readonly RailcarSearchViewModel viewModel;
        private readonly IRailcarRepository repo;

        public SearchRailcarCommand(RailcarSearchViewModel viewmodel, IRailcarRepository repo)
        {
            this.viewModel = viewmodel;
            this.repo = repo;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            MessageBox.Show(string.Format("Num:{0}; Cert:{1}; Rec{2}; Ship:{3}",viewModel.RailcarNumber,viewModel.Certificate
                ,viewModel.Receiver,viewModel.ShippingDate));
        }

        public bool CanExecute()
        {
            return true;
        }
    }
}
