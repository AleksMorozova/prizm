using DevExpress.XtraEditors;
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

        public DataSet GetAllPipes() 
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "Pipe");
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["PrizmDatabase"];

            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(settings.ConnectionString);
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(SQLQueryString.GetAllPipesOnMill, connection);

            try
            {

                connection.Open();
                adapter.SelectCommand = command;
                pipeDataSet = new DataSet();
                adapter.Fill(pipeDataSet);
                adapter.Dispose();
                command.Dispose();
                connection.Close();

                // command.ExecuteNonQuery();

                //XtraMessageBox.Show("DataBase is Created Successfully", "MyProgram");
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
    }
}
