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
        CreateSpoolComponentDialog dialog = null;
        InspectionSelectPartDialog inspectionDialog = null;
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
                if (inspectionDialog == null)
                {
                    inspectionDialog = new InspectionSelectPartDialog(parts, viewModel);
                }
                else 
                {
                    inspectionDialog.SetupForm(parts, viewModel);
                }

                inspectionDialog.ShowDialog();
            }
            else if (ctx.HasAccess(global::Domain.Entity.Security.Privileges.PartsInspection))
            {
                if (dialog == null)
                {
                    dialog = new CreateSpoolComponentDialog(viewModel.SearchNumber);
                }
                else 
                {
                    dialog.SetupForm(viewModel.SearchNumber);
                }

                dialog.ShowDialog();
                if (dialog.DialogResult == DialogResult.Yes)
                {
                    FormManager.Instance.OpenChildForm(DocumentTypes.ConstructionSpool, viewModel.SearchNumber);
                }
                else if (dialog.DialogResult == DialogResult.No)
                {
                    FormManager.Instance.OpenChildForm(DocumentTypes.ConstructionComponent, viewModel.SearchNumber);
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
