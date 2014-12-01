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

        //[Command(UseCommandManager = false)]
        public void Execute()
        {
            if (viewModel.IsAnyInspectionResult() > 0)
            {
                if (viewModel.IsNew == true)
                {
                    if (notify.ShowYesNo("Вы действительно хотите изменить типоразмер трубы?", "Изменение типоразмера"))
                    {
                        condition = true;
                    }
                    else
                    {
                        condition = false;
                    }
                }
                else
                {
                    notify.ShowFailure("Нельзя изменить типоразмер", "Изменение типоразмера");
                    condition = false;
                }
            }

            else 
            {
                notify.ShowNotify("Вы изменили типоразмер", "Изменение типоразмера");
            }
        }
        
        public bool CanExecute()
        {
            return condition;
        }

        public bool IsExecutable { get; set; }
    }
}
