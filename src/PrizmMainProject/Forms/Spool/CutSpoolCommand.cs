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
        readonly ISpoolRepositories repos;
        readonly SpoolViewModel viewModel;
        readonly IUserNotify notify;

        public CutSpoolCommand(SpoolViewModel viewModel, ISpoolRepositories repos, IUserNotify notify)
        {
            this.viewModel = viewModel;
            this.repos = repos;
            this.notify = notify;
        }

        [Command(UseCommandManager = false)]
        public void Execute() 
        {
            repos.BeginTransaction();
            repos.PipeRepo.SaveOrUpdate(viewModel.Pipe);
            repos.PipeRepo.Evict(viewModel.Pipe);
            repos.SpoolRepo.SaveOrUpdate(viewModel.Spool);
            repos.Commit();
            repos.SpoolRepo.Evict(viewModel.Spool);
            //TODO: move to Resource file
            notify.ShowNotify("Отрезана катушка заданной длины","Создание катушка");
        }


        public bool CanExecute()
        {
            return true;
        }

        public virtual bool IsExecutable { get; set; }
    }
}
