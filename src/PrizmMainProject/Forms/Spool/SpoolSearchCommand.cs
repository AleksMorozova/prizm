using Data.DAL.Mill;
using DevExpress.Mvvm.DataAnnotations;
using PrizmMain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.Spool
{
    public class SpoolSearchCommand : ICommand
    {
        readonly IPipeRepository repo;
        readonly SpoolViewModel viewModel;

        public SpoolSearchCommand(SpoolViewModel viewModel, IPipeRepository repo)
        {
            this.viewModel = viewModel;
            this.repo = repo;
        }

        [Command(UseCommandManager = false)]
        public void Execute() 
        {
            viewModel.Pipe = repo.GetByNumber(viewModel.Spool.PipeNumber);
        }


        public bool CanExecute()
        {
            return true;
        }

        public virtual bool IsExecutable { get; set; }
    }
}
