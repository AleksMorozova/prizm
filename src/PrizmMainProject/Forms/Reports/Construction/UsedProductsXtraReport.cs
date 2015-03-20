using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Prizm.Main.Forms.Reports.Construction
{
    public partial class UsedProductsXtraReport : DevExpress.XtraReports.UI.XtraReport
    {
        public UsedProductsXtraReport()
        {
            InitializeComponent();
        }

        public bool FootersVisibility
        {
            get { return pageFooter.Visible; }
            set { pageFooter.Visible = value; }
        }
    }
}
