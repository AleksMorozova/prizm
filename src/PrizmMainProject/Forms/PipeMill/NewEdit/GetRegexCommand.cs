using Data.DAL;
using DevExpress.Mvvm.DataAnnotations;
using PrizmMain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.PipeMill.NewEdit
{
    public class GetRegexCommand : ICommand
    {
        readonly IProjectRepository repo;
        readonly MillPipeNewEditViewModel viewModel;

        public GetRegexCommand(MillPipeNewEditViewModel viewModel, IProjectRepository repo)
        {
            this.viewModel = viewModel;
            this.repo = repo;
        }


        [Command(UseCommandManager = false)]
        public void Execute()
        {
            viewModel.Regex= (repo.GetSingle() == null) ? null : repo.GetSingle().MillPipeNumberMaskRegexp;
        }

        public bool CanExecute()
        {
            return true;
        }
        public virtual bool IsExecutable { get; set; }
    }
}
