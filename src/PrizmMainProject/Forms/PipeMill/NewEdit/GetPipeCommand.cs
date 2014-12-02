using DevExpress.Mvvm.DataAnnotations;
using PrizmMain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.PipeMill.NewEdit
{
    public class GetPipeCommand: ICommand
    {
        private readonly IMillRepository repo;
        private readonly MillPipeNewEditViewModel viewModel;

        public GetPipeCommand(MillPipeNewEditViewModel viewModel, IMillRepository repo)
        {
            this.viewModel = viewModel;
            this.repo = repo;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            viewModel.Pipe = repo.RepoPipe.Get(viewModel.PipeId);
            if (viewModel.Pipe.Coats.Count == 0)
            {
                viewModel.Pipe.Coats = new List<Domain.Entity.Mill.Coat>();
            }
            if (viewModel.Pipe.Welds.Count == 0)
            {
                viewModel.Pipe.Welds = new List<Domain.Entity.Mill.Weld>();
            }
        }

        public bool CanExecute()
        {
            return true;
        }

        public virtual bool IsExecutable { get; set; }
    }
}
