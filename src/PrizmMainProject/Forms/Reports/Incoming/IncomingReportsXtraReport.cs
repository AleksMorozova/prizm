using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Prizm.Main.Forms.Reports.Incoming
{
    public partial class IncomingReportsXtraReport : DevExpress.XtraReports.UI.XtraReport
    {
        public IncomingReportsXtraReport()
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
