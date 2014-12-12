using DevExpress.XtraEditors;
using Domain.Entity.Construction;
using Ninject;
using PrizmMain.Common;
using PrizmMain.DummyData;
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
    }
}