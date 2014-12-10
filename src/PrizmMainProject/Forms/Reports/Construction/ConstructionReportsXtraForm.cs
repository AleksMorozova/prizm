using System;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

using PrizmMain.Forms.MainChildForm;

namespace PrizmMain.Forms.Reports.Construction
{
    [System.ComponentModel.DesignerCategory("Form")] 
    public partial class ConstructionReportsXtraForm : ChildForm
    {
        public ConstructionReportsXtraForm()
        {
            InitializeComponent();
            var item1 = new RadioGroupItem(0, "Стык");
            var item2 = new RadioGroupItem(1, "Пикет");
            countPoints.Properties.Items.Add(item1);
            countPoints.Properties.Items.Add(item2);
            countPoints.SelectedIndex = 0;
        }

        private void ConstructionReportsXtraForm_Load(object sender, EventArgs e)
        {
            reportType.Properties.Items.Add("Использованные изделия");
            reportType.Properties.Items.Add("Трассовка");
            reportType.Properties.Items.Add("Протяженность трубопровода");
            type.Properties.Items.Add("Все");
            type.Properties.Items.Add("Трубы");
            type.Properties.Items.Add("Комплектующие изделия");
        }
    }
}