using DevExpress.Mvvm.DataAnnotations;
using Ninject;
using Prizm.Data.DAL.Construction;
using Prizm.Main.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Joint.NewEdit
{
    public class QuickSearchCommand : ICommand
    {
        private readonly IJointRepository repo;
        private readonly JointNewEditViewModel viewModel;
        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };
        [Inject]
        public QuickSearchCommand(JointNewEditViewModel vm, IJointRepository repo)
        {
            viewModel = vm;
            this.repo = repo;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            IList<Prizm.Domain.Entity.Construction.Joint> list = repo.QuickSearchByNumber(viewModel.Number);
        }

        public bool CanExecute()
        {
            return true;
        }

    }
}
