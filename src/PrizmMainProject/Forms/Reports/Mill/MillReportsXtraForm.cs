using System;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraReports.UI;
using PrizmMain.DummyData;

namespace PrizmMain.Forms.Reports.Mill
{
    public partial class MillReportsXtraForm : XtraForm
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
                Manufacturer = "Mill 1"
            };
            pipeList.Add(pipe3);

            var pipe4 = new PipesDummy
            {
                PipeNumber = 1342352,
                Status = "production",
                Size = "1100x20",
                Manufacturer = "Mill 1"
            };
            pipeList.Add(pipe4);

            return pipeList;
        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            var report = new MillReportsXtraReport {DataSource = CreateData()};
            report.CreateDocument();
            DocumentViewer doc = previewReportDocument;
            doc.DocumentSource = report;
        }

        private void createReportButton_Click(object sender, EventArgs e)
        {
            var report = new MillReportsXtraReport {DataSource = CreateData()};
            report.CreateDocument();
            var tool = new ReportPrintTool(report);
            tool.ShowPreview();
        }
    }
}