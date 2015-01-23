using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Prizm.Main.Forms.Reports.Mill
{
    public partial class MainXtraReport : DevExpress.XtraReports.UI.XtraReport
    {
        public MainXtraReport()
        {
            InitializeComponent();
        }

        private void xrSubreport1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((SubXtraReport)((XRSubreport)sender).ReportSource).param.Value  =
        Convert.ToString(GetCurrentColumnValue("releaseNoteNumber"));
        }

        private void MainXtraReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
//            ((SubXtraReport)((XRSubreport)sender).ReportSource).param.Value =
//Convert.ToString(GetCurrentColumnValue("releaseNoteNumber"));
        }

    }
}
