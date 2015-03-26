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

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            foreach (var c in Detail.Controls)
            {
                if (c is XRLabel)
                {
                    ((XRLabel)c).SizeF = new SizeF(((XRLabel)c).SizeF.Width, 100f);
                }
            }
        }
    }
}
