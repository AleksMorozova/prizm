using DevExpress.Mvvm.DataAnnotations;
using Prizm.Main.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.PipeMill.NewEdit
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

            // Due to incomplete the collection type matching returned 
            // at reading from the database and properties binding  
            // the following solution have been proposed.
            // Perhaps this problem can be solved by entities mapping.
            if (viewModel.Pipe.Coats.Count == 0)
            {
                viewModel.Pipe.Coats = new List<Prizm.Domain.Entity.Mill.Coat>();
            }
            if (viewModel.Pipe.Welds.Count == 0)
            {
                viewModel.Pipe.Welds = new List<Prizm.Domain.Entity.Mill.Weld>();
            }
        }

        public bool CanExecute()
        {
            return true;
        }

        public virtual bool IsExecutable { get; set; }
    }
}
