using Data.DAL.Setup;
using DevExpress.Mvvm.DataAnnotations;
using PrizmMain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.Settings
{
    public class SaveSettingsCommand: ICommand 
    {
        readonly ISettingsRepository repo;
        readonly SettingsViewModel viewModel;

        public SaveSettingsCommand(SettingsViewModel viewModel, ISettingsRepository repo) 
        {
            this.viewModel = viewModel; 
            this.repo = repo;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
         repo.BeginTransaction();
         repo.Save(viewModel.PipeMillSizeType);
         repo.Commit();
         repo.Evict(viewModel.PipeMillSizeType);
         viewModel.NewPipeMillSizeType();
        }

        public bool CanExecute()
        {
         return true;
        }
    }
}
