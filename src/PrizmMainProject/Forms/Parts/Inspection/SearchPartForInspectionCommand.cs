using DevExpress.Mvvm.DataAnnotations;
using NHibernate;
using Ninject;
using Ninject.Parameters;
using Prizm.Main.Commands;
using Prizm.Main.Forms.Component.NewEdit;
using Prizm.Main.Forms.MainChildForm;
using Prizm.Main.Forms.Parts.Search;
using Prizm.Main.Forms.Spool;
using Prizm.Main.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prizm.Main.Forms.Parts.Inspection
{
    public class SearchPartForInspectionCommand : ICommand
    {
        PartInspectionViewModel viewModel;
        ISession session;
        ISecurityContext ctx;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        [Inject]
        public SearchPartForInspectionCommand(PartInspectionViewModel viewModel, ISession session, ISecurityContext ctx)
        {
            this.viewModel = viewModel;
            this.session = session;
            this.ctx = ctx;
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
                if(item.IsActive)
                parts.Add(item);
            }

            viewModel.Parts = parts;
            if (parts.Count > 0)
            {
                NumbersDialog dialog = new NumbersDialog(parts, viewModel);
                dialog.ShowDialog();
            }
            else if (ctx.HasAccess(global::Domain.Entity.Security.Privileges.NewDataEntry))
            {
                CreateSpoolComponentDialog dialog = new CreateSpoolComponentDialog(viewModel.SearchNumber);
                dialog.ShowDialog();
                var parent = viewModel.CurrentForm.MdiParent as PrizmApplicationXtraForm;
                if (parent != null && dialog.DialogResult == DialogResult.Yes)
                {
                    parent.OpenChildForm(typeof(SpoolsXtraForm), Guid.Empty, viewModel.SearchNumber);
                }
                else if (parent != null && dialog.DialogResult == DialogResult.No)
                {
                    parent.OpenChildForm(typeof(ComponentNewEditXtraForm), Guid.Empty, viewModel.SearchNumber);
                }
            }
            RefreshVisualStateEvent();
        }

        public bool CanExecute()
        {
            return true;
        }

    }
}
