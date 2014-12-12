using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Domain.Entity.Construction;
using Ninject;
using Ninject.Parameters;
using PrizmMain.Common;
using PrizmMain.DummyData;
using PrizmMain.Forms.Joint.NewEdit;
using PrizmMain.Forms.MainChildForm;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace PrizmMain.Forms.Joint.Search
{
    [System.ComponentModel.DesignerCategory("Form")] 
    public partial class JointSearchXtraForm : ChildForm
    {
        private JointSearchViewModel viewModel;

        [Inject]
        public JointSearchXtraForm(JointSearchViewModel vm)
        {
            viewModel = vm;
            InitializeComponent();
            weldingDateFrom.Properties.NullDate = DateTime.MinValue;
            weldingDateFrom.Properties.NullText = string.Empty;
            weldingDateTo.Properties.NullDate = DateTime.MinValue;
            weldingDateTo.Properties.NullText = string.Empty;

        }

        private void JointSearchXtraForm_Load(object sender, System.EventArgs e)
        {
            BindCommands();
            BindToViewModel();

            foreach(JointStatus item in Enum.GetValues(typeof(JointStatus)))
            {
                if(item == JointStatus.Undefined)
                {
                    continue;
                }
                controlState.Properties.Items.Add(new EnumWrapper<JointStatus>() { Value = item },true);
            }
            RefreshCombo();
        }


        private void BindToViewModel()
        {
            bindingSource.DataSource = viewModel;
            jointNumber.DataBindings.Add("EditValue", bindingSource, "Number");
            pegNumber.DataBindings.Add("EditValue", bindingSource, "PegNumber");
            weldingDateFrom.DataBindings.Add("EditValue", bindingSource, "FromDate");
            weldingDateTo.DataBindings.Add("EditValue", bindingSource, "ToDate");
            gridControlSerchResult.DataBindings.Add("DataSource", bindingSource, "Joints");
        }

        private void BindCommands()
        {
            searchButton.BindCommand(() => viewModel.SearchCommand.Execute(), viewModel.SearchCommand);
        }

        private void controlState_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            RefreshCombo();
        }

        private void RefreshCombo()
        {
            BindingList<JointStatus> checkedStatuses = new BindingList<JointStatus>();
            for(int i = 0; i < controlState.Properties.Items.Count; i++)
            {
                if(controlState.Properties.Items[i].CheckState == CheckState.Checked )
                {
                    var status = (EnumWrapper<JointStatus>)controlState.Properties.Items[i].Value;
                    checkedStatuses.Add(status.Value);
                }
            }
            viewModel.Statuses.Clear();
            viewModel.Statuses = checkedStatuses;
        }

        private void resultView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            GridView view = sender as GridView;
            if(e.Column.FieldName == "statusLocalizedCol" && e.IsGetData)
            {
                e.Value = LocalizeStatus(view, e.ListSourceRowIndex);
            }
        }

        private string LocalizeStatus(GridView view, int p)
        {
            JointStatus status = (JointStatus)view.GetListSourceRowCellValue(p, "Status");
            var wrp = new EnumWrapper<JointStatus>() { Value = status };
            return wrp.Text;
        }

        private void resultView_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo info = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));

            if(info.InRow || info.InRowCell)
            {
                var id = (Guid)view.GetRowCellValue(info.RowHandle, "Id");
                var parent = this.MdiParent as PrizmApplicationXtraForm;
                parent.CreateChildForm(typeof(JointNewEditXtraForm), new ConstructorArgument("jointId", id));
            }
        }
    }
}