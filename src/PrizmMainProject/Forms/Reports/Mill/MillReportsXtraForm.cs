using System;
using System.Collections.Generic;

using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraReports.UI;

using PrizmMain.DummyData;
using PrizmMain.Forms.MainChildForm;
using DevExpress.XtraReports.Parameters;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace PrizmMain.Forms.Reports.Mill
{
    public partial class MillReportsXtraForm : ChildForm
    {
        private System.Data.DataSet allMillPipeDataSet;
        private ReportSearchCommand command = new ReportSearchCommand();


        public MillReportsXtraForm()
        {
            InitializeComponent();
        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            var report = new MillReport() { DataSource = allMillPipeDataSet };
            report.CreateDocument();
            DocumentViewer doc = previewReportDocument;
            doc.DocumentSource = report;
        }

        private void createReportButton_Click(object sender, EventArgs e)
        {
            allMillPipeDataSet = command.GetAllPipes("Produced"); 
            command.CreateReport(allMillPipeDataSet);
        }

        private void MillReportsXtraForm_Load(object sender, EventArgs e)
        {
           // allMillPipeDataSet = command.GetAllPipes("Produced"); 
        }
    }
}