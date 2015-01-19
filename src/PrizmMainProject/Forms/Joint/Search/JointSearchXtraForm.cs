using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Prizm.Domain.Entity.Construction;
using Ninject;
using Ninject.Parameters;
using Prizm.Main.Commands;
using Prizm.Main.Common;
using Prizm.Main.DummyData;
using Prizm.Main.Forms.Joint.NewEdit;
using Prizm.Main.Forms.MainChildForm;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using Prizm.Main.Properties;

namespace Prizm.Main.Forms.Joint.Search
{
    [System.ComponentModel.DesignerCategory("Form")] 
    public partial class JointSearchXtraForm : ChildForm
    {
        private JointSearchViewModel viewModel;
        ICommandManager commandManager = new CommandManager();

        [Inject]
        public JointSearchXtraForm(JointSearchViewModel vm)
        {
            viewModel = vm;
            InitializeComponent();
            weldingDateFrom.Properties.NullDate = DateTime.MinValue;
            weldingDateFrom.Properties.NullText = string.Empty;
            weldingDateTo.Properties.NullDate = DateTime.MinValue;
            weldingDateTo.Properties.NullText = string.Empty;
            jointNumber.SetAsIdentifier();

        }

        private void JointSearchXtraForm_Load(object sender, System.EventArgs e)
        {
            BindCommands();
            BindToViewModel();

            foreach(JointStatus item in Enum.GetValues(typeof(JointStatus)))
            {
                if(item == JointStatus.Undefined || item == JointStatus.Deactivated)
                {
                    continue;
                }
                controlState.Properties.Items.Add(new EnumWrapper<JointStatus>() { Value = item },true);
            }
            activity.SelectedIndex = 1;
            viewModel.Activity = activity.SelectedItem.ToString(); 
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
            activity.DataBindings.Add("EditValue", bindingSource, "Activity");
            activity.Properties.Items.AddRange(viewModel.ActivityArray);
        }

        private void BindCommands()
        {
            commandManager["Search"].Executor(viewModel.SearchCommand).AttachTo(searchButton);
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
                parent.OpenChildForm(typeof(JointNewEditXtraForm), id);
            }
        }

        private void JointSearchXtraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            commandManager.Dispose();
            viewModel.Dispose();
            viewModel = null;
        }

        private void resultView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView v = sender as GridView;
            var data = v.GetRow(e.RowHandle) as Prizm.Domain.Entity.Construction.Joint;
            if (data != null)
            {
                if (!data.IsActive)
                {
                    e.Appearance.ForeColor = Color.Gray;
                }
            }
        }

        private void activity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (activity.EditValue != Resources.PipeStatusComboActive)
            {
                viewModel.Statuses.Add(JointStatus.Deactivated);
            }
        }
    }
}