using Prizm.Data.DAL.Mill;
using Prizm.Data.DAL.Setup;
using DevExpress.Mvvm.DataAnnotations;
using Prizm.Main.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.PipeMill.NewEdit
{
    public class ExtractPipeTypeCommand : ICommand
    {

        readonly IMillPipeSizeTypeRepository repo;
        readonly MillPipeNewEditViewModel viewModel;

        public ExtractPipeTypeCommand(MillPipeNewEditViewModel viewModel, IMillPipeSizeTypeRepository repo)
        {
            this.viewModel = viewModel;
            this.repo = repo;
        }


        [Command(UseCommandManager = false)]
        public void Execute()
        {
            viewModel.PipeTypes = repo.GetAll();
        }

        public bool CanExecute()
        {
            return true;
        }
        public virtual bool IsExecutable { get; set; }
    }
}
