using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Prizm.Domain.Entity.Mill;

namespace Prizm.Main.Forms.Reports.Mill
{
    public partial class additionToTheReport : DevExpress.XtraReports.UI.XtraReport
    {
        private IList<Pipe> pipes;
        public additionToTheReport()
        {
            InitializeComponent();
            pipes = this.DataSource as List<Pipe>;
            xrLabel18.Text = "123";
            //calculatedField2.Expression = "ewrt";
        }

        

    }
}
