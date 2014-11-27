using Data.DAL.Mill;
using DevExpress.Mvvm.DataAnnotations;
using NHibernate.Criterion;
using PrizmMain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.PipeMill.NewEdit
{
    public class ExtractHeatsCommand: ICommand
    {
        
        readonly IHeatRepository repo;
        readonly MillPipeNewEditViewModel viewModel;

        public ExtractHeatsCommand(MillPipeNewEditViewModel viewModel, IHeatRepository repo)
        {
            this.viewModel = viewModel;
            this.repo = repo;
        }


        [Command(UseCommandManager = false)]
        public void Execute()
        {
            viewModel.Heats = repo.GetAll();
        }

        public bool CanExecute()
        {
            return true;
        }
        public virtual bool IsExecutable { get; set; }
    }
}
