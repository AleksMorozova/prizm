using Data.DAL.Construction;
using Data.DAL.Mill;
using DevExpress.Mvvm.DataAnnotations;
using PrizmMain.Commands;
using PrizmMain.Properties;
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
            if (viewModel.canCut)
            {
                repos.BeginTransaction();
                repos.PipeRepo.SaveOrUpdate(viewModel.Pipe);
                repos.SpoolRepo.SaveOrUpdate(viewModel.Spool);
                repos.Commit();
                repos.PipeRepo.Evict(viewModel.Pipe);
                repos.SpoolRepo.Evict(viewModel.Spool);
                notify.ShowNotify(Resources.Cut_Spool_from_pipe, Resources.Cut_Spool_from_pipe_Header);
            }
            else 
            {
                notify.ShowFailure("Длинны трубы не достаточно дял отрезания заданной катушки", Resources.Cut_Spool_from_pipe_Header);
            }
        }


        public bool CanExecute()
        {
            return true;
        }

        public virtual bool IsExecutable { get; set; }
    }
}
