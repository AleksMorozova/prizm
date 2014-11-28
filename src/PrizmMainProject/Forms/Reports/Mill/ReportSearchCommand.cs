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

        public DataSet GetAllPipes(string status) 
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "Pipe");
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["PrizmDatabase"];

            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(settings.ConnectionString);
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(SQLQueryString.GetAllPipesOnMill, connection);

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
                XtraMessageBox.Show(ex.ToString(), "MyProgram");
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
