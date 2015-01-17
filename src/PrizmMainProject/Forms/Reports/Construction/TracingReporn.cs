using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Prizm.Main.Forms.Reports.Construction
{
    public partial class TracingReporn : DevExpress.XtraReports.UI.XtraReport
    {
        public TracingReporn()
        {
            InitializeComponent();
        }

        public int PipelineJointCount
        {
            get { return Convert.ToInt32(pipelineJointCountXrLabel.Text); }
            set { pipelineJointCountXrLabel.Text = value.ToString(); }
        }

        public int PipelinePipeCount
        {
            get { return Convert.ToInt32(pipelinePipeCountXrLabel.Text); }
            set { pipelinePipeCountXrLabel.Text = value.ToString(); }
        }

        public int PipelineSpoolCount
        {
            get { return Convert.ToInt32(pipelineSpoolCountXrLabel.Text); }
            set { pipelineSpoolCountXrLabel.Text = value.ToString(); }
        }

        public int PipelineComponentCount
        {
            get { return Convert.ToInt32(pipelineComponentCount.Text); }
            set { pipelineComponentCount.Text = value.ToString(); }
        }

        public int PipelineLength
        {
            get { return Convert.ToInt32(pipelineLengthXrLabel.Text); }
            set { pipelineLengthXrLabel.Text = value.ToString(); }
        }

    }
}
