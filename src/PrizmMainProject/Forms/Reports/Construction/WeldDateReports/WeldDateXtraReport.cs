using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Prizm.Main.Forms.Reports.Construction.WeldDateReports
{
    public partial class WeldDateXtraReport : DevExpress.XtraReports.UI.XtraReport
    {
        public WeldDateXtraReport()
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
