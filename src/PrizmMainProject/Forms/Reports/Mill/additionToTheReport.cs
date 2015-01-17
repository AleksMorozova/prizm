using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Prizm.Domain.Entity.Mill;

namespace Prizm.Main.Forms.Reports.Mill
{
    public partial class AdditionToTheReport : DevExpress.XtraReports.UI.XtraReport
    {
        private IList<Pipe> pipes;
        public AdditionToTheReport()
        {
            InitializeComponent();
            pipes = this.DataSource as List<Pipe>;
        }

        public double PipesLength
        {
            get { return Convert.ToInt32(pipesLength.Text); }
            set { pipesLength.Text = value.ToString(); }
        }

        public double PipesCount
        {
            get { return Convert.ToInt32(totalCount.Text); }
            set { totalCount.Text = value.ToString(); }
        }

        public double PipesWeight
        {
            get { return Convert.ToInt32(pipesWeight.Text); }
            set { pipesWeight.Text = value.ToString(); }
        }

    }
}
