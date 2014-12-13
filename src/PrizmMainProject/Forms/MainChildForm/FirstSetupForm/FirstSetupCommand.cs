using Data.DAL;
using DevExpress.Mvvm.DataAnnotations;
using PrizmMain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.MainChildForm.FirstSetupForm
{
    class FirstSetupCommand : ICommand
    {
        FirstSetupViewModel viewModel;
        IProjectRepository repo;

        public FirstSetupCommand(FirstSetupViewModel vm, IProjectRepository r)
        {
            viewModel = vm;
            repo = r;
        }

        #region ICommand Members
        [Command(UseCommandManager = false)]
        public void Execute()
        {
            throw new NotImplementedException();
        }

        public bool CanExecute()
        {
            throw new NotImplementedException();
        }

        public bool IsExecutable { get; set; }

        #endregion
    }
}
