using Data.DAL.Construction;
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
    public class SaveSpoolCommand: ICommand
    {
        readonly ISpoolRepository repoSpool;
        readonly SpoolViewModel viewModel;
        readonly IUserNotify notify;

        public SaveSpoolCommand(SpoolViewModel viewModel, ISpoolRepository repoSpool, IUserNotify notify)
        {
            this.viewModel = viewModel;
            this.repoSpool = repoSpool;
            this.notify = notify;
        }

        [Command(UseCommandManager = false)]
        public void Execute() 
        {
            repoSpool.BeginTransaction();
            repoSpool.SaveOrUpdate(viewModel.Spool);
            repoSpool.Commit();
            repoSpool.Evict(viewModel.Spool);
            viewModel.ModifiableView.IsModified = false;
        }


        public bool CanExecute()
        {
            return true;
        }

        public virtual bool IsExecutable { get; set; }
    }
}
