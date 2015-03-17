using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Prizm.Main.Forms.Reports.Construction.PipeReport
{
    public partial class PipeConstructionXtraReport : DevExpress.XtraReports.UI.XtraReport
    {
        public PipeConstructionXtraReport()
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
