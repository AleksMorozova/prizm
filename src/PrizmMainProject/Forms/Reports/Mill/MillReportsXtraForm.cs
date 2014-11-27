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
        public System.Data.DataSet allMillPipeDataSet;
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
            var report = new MillReport() { DataSource = allMillPipeDataSet };
            report.CreateDocument();
            DocumentViewer doc = previewReportDocument;
            doc.DocumentSource = report;
        }

        private void createReportButton_Click(object sender, EventArgs e)
        {

            var report = new XtraReport1() { DataSource = allMillPipeDataSet };
            
            //// Create a parameter and specify its name.
            //Parameter param1 = new Parameter();
            //param1.Name = "CatID";

            //// Specify other parameter properties.
            //param1.Type = typeof(System.String);
            //param1.Value = "Mill 1";
            //param1.Description = "Category: ";
            //param1.Visible = true;

            //// Add the parameter to the report.
            //report.Parameters.Add(param1);

            //// Specify the report's filter string.
            //report.FilterString = "[Manufacturer] = [Parameters.CatID]";

            //// Force the report creation without previously 
            //// requesting the parameter value from end-users.
            //report.RequestParameters = false;

            report.CreateDocument();
            var tool = new ReportPrintTool(report);
            tool.AutoShowParametersPanel = false;
            tool.ShowPreview();
        }

        private void MillReportsXtraForm_Load(object sender, EventArgs e)
        {
            ReportSearchCommand command = new ReportSearchCommand();
            allMillPipeDataSet = command.GetAllPipes(); 
            //SqlDataAdapter adapter = new SqlDataAdapter();
            //adapter.TableMappings.Add("Table", "Pipe");
            //ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["PrizmDatabase"];

            //System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(settings.ConnectionString);
            //System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(SQLQueryString.GetAllPipesOnMill, connection);

            //try
            //{

            //    connection.Open();
            //    adapter.SelectCommand = command;
            //    allMillPipeDataSet = new DataSet();
            //    adapter.Fill(allMillPipeDataSet);
            //    adapter.Dispose();
            //    command.Dispose();
            //    connection.Close();
      
            //   // command.ExecuteNonQuery();

            //    //XtraMessageBox.Show("DataBase is Created Successfully", "MyProgram");
            //}
            //catch (System.Exception ex)
            //{
            //    XtraMessageBox.Show(ex.ToString(), "MyProgram");
            //}
            //finally
            //{
            //    if (connection.State == System.Data.ConnectionState.Open)
            //    {
            //        connection.Close();
            //    }
            //}

        //    string connetionString = null;
        //    SqlConnection connection;
        //    SqlCommand command;
        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    ds = new DataSet();
        //    int i = 0;
        //    string sql = null;

        //    System.Configuration.ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["PrizmDatabase"];

        //    System.Data.SqlClient.SqlConnection connetionString = new System.Data.SqlClient.SqlConnection(settings.ConnectionString);

        //    //connetionString = System.Configuration.ConfigurationManager.ConnectionStrings["PrizmDatabase"];
        //    sql = "Select number From Pipe";

        //    connection = new SqlConnection(connetionString);

        //    try
        //    {
        //        connection.Open();
        //        command = new SqlCommand(sql, connection);
        //        adapter.SelectCommand = command;
        //        adapter.Fill(ds);
        //        adapter.Dispose();
        //        command.Dispose();
        //        connection.Close();

        //        for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
        //        {
        //            XtraMessageBox.Show(ds.Tables[0].Rows[i].ItemArray[0] + " -- " + ds.Tables[0].Rows[i].ItemArray[1]);

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        XtraMessageBomx.Show("Can not open connection ! ");
        //    }
        
        }
    }
}