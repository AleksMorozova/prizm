using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraReports.UI;
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
    public class ReportSearchCommand
    {
        public DataSet pipeDataSet;

        private SqlDataAdapter adapter;
        private System.Data.SqlClient.SqlConnection connection;
        private System.Data.SqlClient.SqlCommand command; 

        public ReportSearchCommand()
        {

            adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "Pipe");
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["PrizmDatabase"];
            connection = new System.Data.SqlClient.SqlConnection(settings.ConnectionString);
            command = new System.Data.SqlClient.SqlCommand(SQLQueryString.GetAllPipesOnMill, connection);

        }

        /// <summary>
        /// Creat new DataSet with status parameter
        /// </summary>
        /// <param name="form"></param>
        public DataSet GetPipesByStatus(string status) 
        {
            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@status", status);
                adapter.SelectCommand = command;
                pipeDataSet = new DataSet();
                adapter.Fill(pipeDataSet);
                adapter.Dispose();
                command.Dispose();
                connection.Close();
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return pipeDataSet;
        }

        /// <summary>
        /// Creating report
        /// </summary>
        /// <param name="form"></param>
        public void CreateReport (DataSet dataSet)
        {
            var report = new MillReport() { DataSource = dataSet };
            report.CreateDocument();
            var tool = new ReportPrintTool(report);
            tool.ShowPreview();
        }

        public void PreviewReport ()
        { 

        }
    }
}
