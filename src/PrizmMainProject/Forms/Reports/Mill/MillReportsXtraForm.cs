using System;
using System.Collections.Generic;

using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraReports.UI;

using PrizmMain.DummyData;
using PrizmMain.Forms.MainChildForm;
using DevExpress.XtraReports.Parameters;

namespace PrizmMain.Forms.Reports.Mill
{
    public partial class MillReportsXtraForm : ChildForm
    {
        public MillReportsXtraForm()
        {
            InitializeComponent();
        }

        private List<PipesDummy> CreateData()
        {
            var pipeList = new List<PipesDummy>();

            var pipe1 = new PipesDummy
            {
                PipeNumber = 1342352,
                Status = "production",
                Size = "1100x20",
                Manufacturer = "Mill 1"
            };
            pipeList.Add(pipe1);

            var pipe2 = new PipesDummy
            {
                PipeNumber = 1342352,
                Status = "production",
                Size = "1100x20",
                Manufacturer = "Mill 1"
            };
            pipeList.Add(pipe2);

            var pipe3 = new PipesDummy
            {
                PipeNumber = 1342352,
                Status = "production",
                Size = "1100x20",
                Manufacturer = "Mill 2"
            };
            pipeList.Add(pipe3);

            var pipe4 = new PipesDummy
            {
                PipeNumber = 1342352,
                Status = "production",
                Size = "1100x20",
                Manufacturer = "Mill 3"
            };
            pipeList.Add(pipe4);

            return pipeList;
        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            var report = new MillReportsXtraReport {DataSource = CreateData()};
            report.CreateDocument();
            //report.FilterString(
            DocumentViewer doc = previewReportDocument;
            doc.DocumentSource = report;
        }

        private void createReportButton_Click(object sender, EventArgs e)
        {

            var report = new MillReportsXtraReport {DataSource = CreateData()};

            // Create a parameter and specify its name.
            Parameter param1 = new Parameter();
            param1.Name = "CatID";

            // Specify other parameter properties.
            param1.Type = typeof(System.String);
            param1.Value = "Mill 1";
            param1.Description = "Category: ";
            param1.Visible = true;

            // Add the parameter to the report.
            report.Parameters.Add(param1);

            // Specify the report's filter string.
            report.FilterString = "[Manufacturer] = [Parameters.CatID]";

            // Force the report creation without previously 
            // requesting the parameter value from end-users.
            report.RequestParameters = false;

            report.CreateDocument();
            var tool = new ReportPrintTool(report);
            tool.AutoShowParametersPanel = false;
            tool.ShowPreview();
        }
    }
}