using DevExpress.Mvvm.DataAnnotations;
using NHibernate;
using Ninject;
using Prizm.Main.Commands;
using Prizm.Main.Forms.Parts.Search;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Parts.Inspection
{
    public class SearchPartForInspectionCommand : ICommand
    {
        PartInspectionViewModel viewModel;
        ISession session;

        [Inject]
        public SearchPartForInspectionCommand(PartInspectionViewModel viewModel, ISession session)
        {
            this.viewModel = viewModel;
            this.session = session;
        }
        [Command(UseCommandManager = false)]
        public void Execute()
        {
            BindingList<Part> parts = new BindingList<Part>();
            var query = session.CreateSQLQuery(PartQuery.BuildSqlForInspection(viewModel.SearchNumber))
                .SetResultTransformer(PartQuery.Transformer);

            var qparts = query.List<Part>();

            foreach (var item in qparts)
            {
                parts.Add(item);
            }

            viewModel.Parts = parts;
            NumbersDialog dialog = new NumbersDialog(parts, viewModel);
            dialog.ShowDialog();
        }

        public bool CanExecute()
        {
            return true;
        }

        public bool IsExecutable { get; set; }
    }
}
