using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Prizm.Main.Forms.Reports.Mill
{
    public partial class LoadingXtraReport : DevExpress.XtraReports.UI.XtraReport
    {
        public LoadingXtraReport()
        {
            InitializeComponent();
        }
        public bool FootersVisibility
        {
            get { return pageFooterBand.Visible; }
            set { pageFooterBand.Visible = value; }
        }
    }
}
