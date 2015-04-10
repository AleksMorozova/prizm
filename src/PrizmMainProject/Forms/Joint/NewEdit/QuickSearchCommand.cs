using DevExpress.Mvvm.DataAnnotations;
using Ninject;
using Prizm.Data.DAL.Construction;
using Prizm.Domain.Entity.Construction;
using Prizm.Main.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Joint.NewEdit
{
    public class QuickSearchCommand : BaseCommand
    {
        private readonly IJointRepository repo;
        private readonly JointNewEditViewModel viewModel;
        JointSelectDialog dialog = null;
        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };
        [Inject]
        public QuickSearchCommand(JointNewEditViewModel vm, IJointRepository repo)
        {
            viewModel = vm;
            this.repo = repo;
        }

        [Command(UseCommandManager = false)]
        public override void Execute()
        {
            IList<Prizm.Domain.Entity.Construction.Joint> list = repo.QuickSearchByNumber(viewModel.SearchNumber);
            if (dialog == null)
            {
                dialog = new JointSelectDialog(list, viewModel);
            }
            else
            {
                dialog.SetupForm(list, viewModel);
            }

            dialog.ShowDialog();
        }

        public override bool CanExecute()
        {
            return true;
        }

    }
}
