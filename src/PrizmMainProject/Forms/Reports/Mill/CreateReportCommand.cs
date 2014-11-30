using Data.DAL;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraReports.UI;
using PrizmMain.Commands;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.Reports.Mill
{
    public class CreateReportCommand: ICommand 
    {

        readonly IMillReportRepository repo;
        readonly MillReportsViewModel viewModel;

        private SqlDataAdapter adapter;
        //private ConnectionStringSettings settings;
        private System.Data.SqlClient.SqlConnection connection;
        private System.Data.SqlClient.SqlCommand command;

        public CreateReportCommand(MillReportsViewModel viewModel, IMillReportRepository repo)
        {
            this.viewModel = viewModel;
            this.repo = repo;
        }

        /// <summary>
        /// Creating report
        /// </summary>
        /// <param name="report"></param>
        /// <summary>
        /// creation report name
        /// </summary>
        /// <param name="dataSet"></param>
        /// <summary>
        /// dataSet for creation report
        /// </summary>
        /// 
        public void CreateReport (XtraReport report, DataSet dataSet)
        {
            report.DataSource = dataSet;
            report.CreateDocument();
            var tool = new ReportPrintTool(report);
            tool.AutoShowParametersPanel = false;
            tool.ShowPreview();
        }

        public void PreviewReport(DocumentViewer doc, XtraReport report, DataSet dataSet) 
        {

            report.DataSource = dataSet;
            report.CreateDocument();
            doc.DocumentSource = report;
        }


        public void Execute()
        {
            viewModel.pipeDataSet = repo.GetPipesByStatus(viewModel.StartDate, viewModel.EndDate);
            MillReport report = new MillReport();
            report.DataSource = viewModel.pipeDataSet;
            report.CreateDocument();
            var tool = new ReportPrintTool(report);
            tool.AutoShowParametersPanel = false;
            tool.ShowPreview();
            //Mill\ReportDesignTool r = new Mill|ReportDesignTool()
            
        }
   
        public bool CanExecute()
{
 	throw new NotImplementedException();
}
        
        public bool IsExecutable
{
	  get 
	{ 
		throw new NotImplementedException(); 
	}
	  set 
	{ 
		throw new NotImplementedException(); 
	}
}
}
}
