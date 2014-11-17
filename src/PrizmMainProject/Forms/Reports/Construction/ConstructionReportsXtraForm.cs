using System;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace PrizmMain.Forms.Reports.Construction
{
    public partial class ConstructionReportsXtraForm : XtraForm
    {
        public ConstructionReportsXtraForm()
        {
            InitializeComponent();
            var item1 = new RadioGroupItem(0, "Joint");
            var item2 = new RadioGroupItem(1, "Kilometer post");
            countPoints.Properties.Items.Add(item1);
            countPoints.Properties.Items.Add(item2);
            countPoints.SelectedIndex = 0;
        }

        private void ConstructionReportsXtraForm_Load(object sender, EventArgs e)
        {
            reportType.Properties.Items.Add("Used products");
            reportType.Properties.Items.Add("Highway");
            reportType.Properties.Items.Add("Pipeline length");
            type.Properties.Items.Add("All");
            type.Properties.Items.Add("Pipes");
            type.Properties.Items.Add("Components");
        }
    }
}