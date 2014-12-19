﻿using Prizm.Data.DAL.Construction;
using Prizm.Data.DAL.Mill;
using DevExpress.Mvvm.DataAnnotations;
using Prizm.Main.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Main.Properties;

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
            if (viewModel.Spool.Length != 0)
            {
                if (viewModel.canCut)
                {
                    repos.BeginTransaction();
                    repos.PipeRepo.SaveOrUpdate(viewModel.Pipe);
                    repos.SpoolRepo.SaveOrUpdate(viewModel.Spool);
                    repos.Commit();
                    repos.PipeRepo.Evict(viewModel.Pipe);
                    repos.SpoolRepo.Evict(viewModel.Spool);
                    viewModel.ModifiableView.IsModified = false;
                    notify.ShowNotify(Resources.Cut_Spool_from_pipe, Resources.Cut_Spool_from_pipe_Header);
                    string oldPipeNumber = viewModel.Pipe.Number;
                    viewModel.NewSpool();
                    viewModel.PipeNumber = oldPipeNumber;
                    viewModel.editMode = false;

                }
                else 
                {
                    notify.ShowError(Resources.Wrong_Spool_Lengs, Resources.Cut_Spool_from_pipe_Header);
                }
            }
            else
            {
                notify.ShowError("Длинна катушки не может быть равна 0", Resources.Cut_Spool_from_pipe_Header);
                
            }
        }


        public bool CanExecute()
        {
            bool condition = viewModel.ModifiableView.IsEditMode;
            return condition;
        }

        public virtual bool IsExecutable { get; set; }
    }
}
