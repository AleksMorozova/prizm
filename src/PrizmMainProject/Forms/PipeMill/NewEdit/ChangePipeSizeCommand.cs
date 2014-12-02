using DevExpress.Mvvm.DataAnnotations;
using PrizmMain.Commands;
using PrizmMain.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.PipeMill.NewEdit
{
    public class ChangePipeSizeCommand: ICommand
    {
        private readonly IMillRepository repo;
        private readonly MillPipeNewEditViewModel viewModel;
        private readonly IUserNotify notify;
        public bool condition=true;

        public ChangePipeSizeCommand(
            MillPipeNewEditViewModel viewModel, 
            IMillRepository repo, 
            IUserNotify notify)
        {
            this.viewModel = viewModel;
            this.repo = repo;
            this.notify = notify;
        }

        public void Execute()
        {
            if (viewModel.IsAnyInspectionResult() > 0)
            {
                if (viewModel.IsNew == true)
                {
                    if (notify.ShowYesNo(Resources.DLG_CHANGE_PIPESIZE_ON_NEWPIPE, Resources.PipeSizeChangeHeader))
                    {
                        condition = true;
                    }
                    else
                    {
                        viewModel.IsModify = false;
                        condition = false;
                    }
                }
                else
                {
                    notify.ShowFailure(Resources.DLG_CHANGE_PIPESIZE_ON_EDITPIPE, Resources.PipeSizeChangeHeader);
                    condition = false;
                }
            }
            //else 
            //{
            //    notify.ShowNotify("Вы изменили типоразмер", Resources.PipeSizeChangeHeader);
            //}
        }
        
        public bool CanExecute()
        {
            return condition;
        }

        public bool IsExecutable { get; set; }
    }
}
