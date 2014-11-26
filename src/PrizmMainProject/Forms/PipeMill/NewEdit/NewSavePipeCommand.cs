using Data.DAL.Mill;
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
    public class NewSavePipeCommand: ICommand
    {
        private readonly IMillRepository repo;
        private readonly MillPipeNewEditViewModel viewModel;

        public NewSavePipeCommand(MillPipeNewEditViewModel viewModel, IMillRepository repo)
        {
            this.viewModel = viewModel;
            this.repo = repo;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            viewModel.SavePipeCommand.Execute();
            viewModel.NewPipe();
        }


        public virtual bool IsExecutable { get; set; }

        protected virtual void OnIsExecutableChanged()
        {
            this.RaiseCanExecuteChanged(x => x.Execute());
        }


        public bool CanExecute()
        {
            return viewModel.SavePipeCommand.CanExecute();
        }
    }
}
