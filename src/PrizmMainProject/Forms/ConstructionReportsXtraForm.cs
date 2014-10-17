using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace PrizmMain.Forms
{
    public partial class ConstructionReportsXtraForm : DevExpress.XtraEditors.XtraForm
    {
        public ConstructionReportsXtraForm()
        {
            InitializeComponent();
            object[] itemValues = new object[] { 0, 1};
            string[] itemDescriptions = new string[] { "Joint", "Kilometer post" };
            for (int i = 0; i < itemValues.Length; i++)
            {
                countPoints.Properties.Items.Add(new RadioGroupItem(itemValues[i], itemDescriptions[i]));
            }

           

        }

        private void ConstructionReportsXtraForm_Load(object sender, EventArgs e)
        {
            reportType.Properties.Items.Add("Report about used products");
            reportType.Properties.Items.Add("Report about highway");
            reportType.Properties.Items.Add("Report about pipeline length");
        }
    }
}