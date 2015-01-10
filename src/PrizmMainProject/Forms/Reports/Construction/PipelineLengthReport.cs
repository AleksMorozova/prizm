using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Prizm.Main.Forms.Reports.Construction
{
    public partial class PipelineLengthReport : DevExpress.XtraReports.UI.XtraReport
    {
        public PipelineLengthReport()
        {
            InitializeComponent();
        }

        public int PipelinePartCount 
        {
            get { return Convert.ToInt32(pipelinePartCountXrLabel.Text); }
            set { pipelinePartCountXrLabel.Text = value.ToString(); }
        }

        public int PipelineLength
        {
            get { return Convert.ToInt32(pipelineLengthXrLabel.Text); }
            set { pipelineLengthXrLabel.Text = value.ToString(); }
        }

        public int PipelineJointCount
        {
            get { return Convert.ToInt32(pipelineJointCountXrLabel.Text); }
            set { pipelineJointCountXrLabel.Text = value.ToString(); }
        }

        public string CoordinatesFrom
        {
            get { return coordinatesFromXrLabel.Text; }
            set { coordinatesFromXrLabel.Text = value; }
        }

        public string CoordinatesTo
        {
            get { return coordinatesToXrLabel.Text; }
            set { coordinatesToXrLabel.Text = value; }
        }

    }
}
