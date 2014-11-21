using Data.DAL.Mill;
using DevExpress.Mvvm.DataAnnotations;
using PrizmMain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.PipeMill.NewEdit
{
    public class MillPipeNewEditCommand: ICommand
    {
        private readonly IMillRepository repo;
        private readonly MillPipeNewEditViewModel viewModel;

        public MillPipeNewEditCommand(MillPipeNewEditViewModel viewModel, IMillRepository repo)
        {
            this.viewModel = viewModel;
            this.repo = repo;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            repo.BeginTransaction();
            repo.RepoPipe.SaveOrUpdate(viewModel.Pipe);
            repo.Commit();
            repo.RepoPipe.Evict(viewModel.Pipe);
            viewModel.NewPipe();
        }

        public bool CanExecute()
        {
            return true;
        }
    }
}
