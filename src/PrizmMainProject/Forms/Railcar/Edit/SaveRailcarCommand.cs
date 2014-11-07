using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using Domain.DAL;
using PrizmMain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrizmMain.Forms.Railcar.Edit
{
   public class SaveRailcarCommand : ICommand
   {
      readonly IRailcarRepository repo;
      readonly RailcarViewModel viewModel;

      public SaveRailcarCommand(RailcarViewModel viewModel, IRailcarRepository repo) 
      {
         this.viewModel = viewModel;
         this.repo = repo;
      }

      [Command(UseCommandManager = false)]
      public void Execute()
      {
         repo.BeginTransaction();
         repo.Save(viewModel.Railcar);
         repo.Commit();
         repo.Evict(viewModel.Railcar);
         viewModel.NewRailcar();
      }

      public bool CanExecute()
      {
         return true;
      }
   }
}
