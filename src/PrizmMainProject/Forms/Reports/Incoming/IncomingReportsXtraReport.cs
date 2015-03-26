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
            float maxHeightforDataLabel = 0;

            foreach (var c in Detail.Controls)
            {
                if (c is XRLabel)
                {
                    if (((XRLabel)c).SizeF.Height > maxHeightforDataLabel)
                    {
                    
                        maxHeightforDataLabel = ((XRLabel)c).SizeF.Height;
                    }
                }
            }

            float maxHeightforHeaderLabel = 0;

            foreach (var c in groupHeader.Controls)
            {
                if (c is XRLabel)
                {
                    if (((XRLabel)c).SizeF.Height > maxHeightforHeaderLabel)
                    {
                        maxHeightforHeaderLabel = ((XRLabel)c).SizeF.Height;
                    }
                }
            }

            // set max height for all label
            // for data label
            foreach (var c in Detail.Controls)
            {
                if (c is XRLabel)
                {
                    ((XRLabel)c).SizeF = new SizeF(((XRLabel)c).SizeF.Width, maxHeightforDataLabel);
                }
            }

            // for column header
            foreach (var c in groupHeader.Controls)
            {
                if (c is XRLabel)
                {
                    ((XRLabel)c).SizeF = new SizeF(((XRLabel)c).SizeF.Width, maxHeightforHeaderLabel);
                }
            }
        }
    }
}
