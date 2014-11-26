using DevExpress.Mvvm.DataAnnotations;
using PrizmMain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// for method RaiseCanExecuteChanged
using DevExpress.Mvvm.POCO;

namespace PrizmMain.Forms.PipeMill.NewEdit
{
    public class SavePipeCommand: ICommand
    {
        private readonly IMillRepository repo;
        private readonly MillPipeNewEditViewModel viewModel;

        public SavePipeCommand(MillPipeNewEditViewModel viewModel, IMillRepository repo)
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
        }


        public virtual bool IsExecutable { get; set; }

        protected virtual void OnIsExecutableChanged()
        {
            this.RaiseCanExecuteChanged(x => x.Execute());
        }


        public bool CanExecute()
        {
            bool condition = !string.IsNullOrEmpty(viewModel.Heat.Number) &&
                viewModel.PipeMillSizeType != null &&
                viewModel.PipeStatus != null &&
                viewModel.PipePurchaseOrder != null &&
                !string.IsNullOrEmpty(viewModel.Number);

            return condition;
        }
    
    }
}
