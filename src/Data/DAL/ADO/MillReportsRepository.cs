using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Ninject;


namespace Data.DAL.ADO
{
    public class MillReportsRepository : IMillReportsRepository
    {
        [Inject]
        public MillReportsRepository() { }
        //private DataSet pipeDataSet;
        public SqlConnection connection;
        

        public DataSet GetPipesByStatus(DateTime startDate, DateTime finalDate)
        {
            CreateConnection();
            DataSet pipeDataSet = new DataSet();

            try
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.TableMappings.Add("Table", "Pipe");
                SqlCommand  command = new System.Data.SqlClient.SqlCommand(SQLQueryString.GetAllActivePipesByDate, connection);
                //input search criteria value
                command.Parameters.AddWithValue("@startDate", startDate);
                command.Parameters.AddWithValue("@finalDate", finalDate);

                adapter.SelectCommand = command;
               
                adapter.Fill(pipeDataSet);
                adapter.Dispose();
                command.Dispose();
                connection.Close();
            }
            catch (System.Exception ex)
            {
                return null;
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

        public SqlConnection CreateConnection() 
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["PrizmDatabase"];
            connection = new System.Data.SqlClient.SqlConnection(settings.ConnectionString);
            return connection;
        }

    }
}
