using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PrizmMain.DummyData;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraReports.UI;

namespace PrizmMain.Forms
{
    public partial class MillReportsXtraForm : DevExpress.XtraEditors.XtraForm
    {
        public MillReportsXtraForm()
        {
            InitializeComponent();
        }
        private List<PipesDummy> CreateData()
        {
            List<PipesDummy> pipeList = new List<PipesDummy>();

            PipesDummy pipe1 = new PipesDummy();
            pipe1.PipeNumber = 1342352;
            pipe1.Status = "production";
            pipe1.Size = "1100x20";
            pipe1.Manufacturer = "Mill 1";
            pipeList.Add(pipe1);

            PipesDummy pipe2 = new PipesDummy();
            pipe2.PipeNumber = 1342352;
            pipe2.Status = "production";
            pipe2.Size = "1100x20";
            pipe2.Manufacturer = "Mill 1";
            pipeList.Add(pipe2);

            PipesDummy pipe3 = new PipesDummy();
            pipe3.PipeNumber = 1342352;
            pipe3.Status = "production";
            pipe3.Size = "1100x20";
            pipe3.Manufacturer = "Mill 1";
            pipeList.Add(pipe3);

            PipesDummy pipe4 = new PipesDummy();
            pipe4.PipeNumber = 1342352;
            pipe4.Status = "production";
            pipe4.Size = "1100x20";
            pipe4.Manufacturer = "Mill 1";
            pipeList.Add(pipe4);

            return pipeList;
        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            MillReportsXtraReport report = new MillReportsXtraReport();
            report.DataSource = CreateData();
            report.CreateDocument();
            DocumentViewer doc = previewReportDocument;
            doc.DocumentSource = report;

        }

        private void createReportButton_Click(object sender, EventArgs e)
        {
            MillReportsXtraReport report = new MillReportsXtraReport();
            report.DataSource = CreateData();
            report.CreateDocument();
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();
        }
    }
}