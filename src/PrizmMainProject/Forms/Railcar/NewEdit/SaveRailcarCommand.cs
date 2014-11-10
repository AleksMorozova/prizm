using Data.DAL;
using DevExpress.Mvvm.DataAnnotations;
using PrizmMain.Commands;

namespace PrizmMain.Forms.Railcar.Edit
{
    public class SaveRailcarCommand : ICommand
    {
        private readonly IRailcarRepository repo;
        private readonly RailcarViewModel viewModel;

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