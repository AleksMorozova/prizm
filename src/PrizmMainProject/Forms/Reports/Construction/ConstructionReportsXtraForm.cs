using System;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

using PrizmMain.Forms.MainChildForm;
using PrizmMain.Common;
using System.Windows.Forms;
using PrizmMain.Forms.Common;
using System.ComponentModel;

namespace PrizmMain.Forms.Reports.Construction
{
    [System.ComponentModel.DesignerCategory("Form")] 
    public partial class ConstructionReportsXtraForm : ChildForm
    {
        private ConstructionReportViewModel viewModel;

        public ConstructionReportsXtraForm()
        {
            InitializeComponent();

            var item1 = new RadioGroupItem(0, "Стык");
            var item2 = new RadioGroupItem(1, "Пикет");
            countPoints.Properties.Items.Add(item1);
            countPoints.Properties.Items.Add(item2);
            countPoints.SelectedIndex = 0;
        }

        private void BindToViewModel()
        {
            bindingSource.DataSource = viewModel;
        }

        private void ConstructionReportsXtraForm_Load(object sender, EventArgs e)
        {
            BindToViewModel();

            var pipeCheck = new EnumWrapper<PartType> { Value = PartType.Pipe };
            var spoolCheck = new EnumWrapper<PartType> { Value = PartType.Spool };
            var componentCheck = new EnumWrapper<PartType> { Value = PartType.Component };

            type.Properties.Items.Add(pipeCheck.Value, pipeCheck.Text, CheckState.Checked, true);
            type.Properties.Items.Add(spoolCheck.Value, spoolCheck.Text, CheckState.Checked, true);
            type.Properties.Items.Add(componentCheck.Value, componentCheck.Text, CheckState.Checked, true);

            //RefreshTypes();
        }

        //private void RefreshTypes()
        //{
        //    BindingList<PartType> selectedTypes = new BindingList<PartType>();
        //    for (int i = 0; i < type.Properties.Items.Count; i++)
        //    {
        //        if (type.Properties.Items[i].CheckState == CheckState.Checked)
        //        {
        //            selectedTypes.Add((PartType)type.Properties.Items[i].Value);
        //        }
        //    }
        //    viewModel.Types.Clear();
        //    viewModel.Types = selectedTypes;
        //}
    }
}