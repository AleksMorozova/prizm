using Prizm.Data.DAL;
using DevExpress.Mvvm.DataAnnotations;
using Prizm.Main.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.PipeMill.NewEdit
{
    public class GetProjectCommand : ICommand
    {
        readonly IProjectRepository repo;
        readonly MillPipeNewEditViewModel viewModel;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        public GetProjectCommand(MillPipeNewEditViewModel viewModel, IProjectRepository repo)
        {
            this.viewModel = viewModel;
            this.repo = repo;
        }


        [Command(UseCommandManager = false)]
        public void Execute()
        {
            viewModel.Project = repo.GetSingle();
        }

        public bool CanExecute()
        {
            return true;
        }
    }
}
