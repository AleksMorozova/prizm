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
        private System.Data.DataSet allMillPipeDataSet = null;
        //private CreateReportCommand command = new CreateReportCommand();


        public MillReportsXtraForm()
        {
            InitializeComponent();
        }

        //private void previewButton_Click(object sender, EventArgs e)
        //{
        //    //TODO: input logic for reports parameters

        //    if (allMillPipeDataSet == null)
        //    {
        //        allMillPipeDataSet = command.GetPipesByStatus(startDate.DateTime.Date, finalDate.DateTime.Date);
        //        command.PreviewReport(previewReportDocument, new MillReport(), allMillPipeDataSet);
        //    }

        //    else 
        //    {
        //        command.PreviewReport(previewReportDocument, new MillReport(), allMillPipeDataSet);
        //    }
            

        //}

        //private void createReportButton_Click(object sender, EventArgs e)
        //{
        //    //TODO: input logic for reports parameters
        //    if (allMillPipeDataSet == null)
        //    {
        //        allMillPipeDataSet = command.GetPipesByStatus(startDate.DateTime.Date, finalDate.DateTime.Date);
        //        command.CreateReport(new MillReport(), allMillPipeDataSet);
        //    }

        //    else
        //    {
        //        command.CreateReport(new MillReport(), allMillPipeDataSet);
        //    }
        //}

        private void MillReportsXtraForm_Load(object sender, EventArgs e)
        {
        }
    }
}