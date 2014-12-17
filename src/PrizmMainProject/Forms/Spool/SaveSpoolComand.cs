using Prizm.Data.DAL.Construction;
using Prizm.Data.DAL.Mill;
using DevExpress.Mvvm.DataAnnotations;
using Prizm.Main.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Spool
{
    public class SaveSpoolCommand: ICommand
    {
        readonly ISpoolRepositories repos;
        readonly SpoolViewModel viewModel;
        readonly IUserNotify notify;

        public SaveSpoolCommand(SpoolViewModel viewModel, ISpoolRepositories repos, IUserNotify notify)
        {
            this.viewModel = viewModel;
            this.repos = repos;
            this.notify = notify;
        }

        [Command(UseCommandManager = false)]
        public void Execute() 
        {
            repos.BeginTransaction();
            repos.SpoolRepo.SaveOrUpdate(viewModel.Spool);
            repos.Commit();
            repos.SpoolRepo.Evict(viewModel.Spool);
            viewModel.ModifiableView.IsModified = false;
        }


        public bool CanExecute()
        {
            return true;
        }

        public virtual bool IsExecutable { get; set; }
    }
}
