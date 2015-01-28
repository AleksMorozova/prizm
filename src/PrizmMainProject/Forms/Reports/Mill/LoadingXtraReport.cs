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

        private void xrSubreport1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((SubReportForLoadingXtraReport)((XRSubreport)sender).ReportSource).Note.Value =
       Convert.ToString(GetCurrentColumnValue("Notes"));
        }

    }
}
