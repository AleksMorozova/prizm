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
    public class CutSpoolCommand : ICommand
    {
        readonly IPipeRepository repoPipe;
        readonly ISpoolRepository repoSpool;
        readonly SpoolViewModel viewModel;
        readonly IUserNotify notify;

        public CutSpoolCommand(SpoolViewModel viewModel, IPipeRepository repoPipe, ISpoolRepository repoSpool, IUserNotify notify)
        {
            this.viewModel = viewModel;
            this.repoPipe = repoPipe;
            this.repoSpool = repoSpool;
            this.notify = notify;
        }

        [Command(UseCommandManager = false)]
        public void Execute() 
        {
            repoPipe.BeginTransaction();
            repoPipe.SaveOrUpdate(viewModel.Pipe);
            repoPipe.Commit();
            repoPipe.Evict(viewModel.Pipe);

            repoSpool.BeginTransaction();
            repoSpool.SaveOrUpdate(viewModel.Spool);
            repoSpool.Commit();
            repoSpool.Evict(viewModel.Spool);

            notify.ShowNotify("Катушка","Отрезана катушка");
        }


        public bool CanExecute()
        {
            return true;
        }

        public virtual bool IsExecutable { get; set; }
    }
}
