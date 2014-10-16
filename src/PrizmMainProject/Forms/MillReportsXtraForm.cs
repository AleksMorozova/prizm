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
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting.Preview;

namespace PrizmMain.Forms
{
    public partial class MillReportsXtraForm : DevExpress.XtraEditors.XtraForm
    {
        public MillReportsXtraForm()
        {
            InitializeComponent();
            heatNumber.Text = "";
        }
        private List<Pipe> CreateData()
        {
            List<Pipe> pipeList = new List<Pipe>();

            Pipe pipe1 = new Pipe();
            pipe1.PipeNumber = 1342352;
            pipe1.Status = "production";
            pipe1.Size="1100x20";
            pipe1.Manufacturer = "Mill 1";
            pipeList.Add(pipe1);

            Pipe pipe2 = new Pipe();
            pipe2.PipeNumber = 1342352;
            pipe2.Status = "production";
            pipe2.Size = "1100x20";
            pipe2.Manufacturer = "Mill 1";
            pipeList.Add(pipe2);

            Pipe pipe3 = new Pipe();
            pipe3.PipeNumber = 1342352;
            pipe3.Status = "production";
            pipe3.Size = "1100x20";
            pipe3.Manufacturer = "Mill 1";
            pipeList.Add(pipe3);

            Pipe pipe4 = new Pipe();
            pipe4.PipeNumber = 1342352;
            pipe4.Status = "production";
            pipe4.Size = "1100x20";
            pipe4.Manufacturer = "Mill 1";
            pipeList.Add(pipe4);

            return pipeList;
        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            millReport report = new millReport();
            report.DataSource = CreateData();
            report.CreateDocument();
            DocumentViewer doc = previewReportDocument;
            doc.DocumentSource = report;
        }

        private void createReportButton_Click(object sender, EventArgs e)
        {
            millReport report = new millReport();
            report.DataSource = CreateData();
            report.CreateDocument();
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();
        }

    }
}