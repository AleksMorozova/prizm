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
        private SqlConnection connection=null;
        

        public DataSet GetPipesByStatus(DateTime startDate, DateTime finalDate)
        {
            CreateConnection();
            DataSet pipeDataSet = new DataSet();

            try
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {

                    using (SqlCommand command = new System.Data.SqlClient.SqlCommand())
                    {
                        connection.Open();
                        adapter.TableMappings.Add("Table", "Pipe");
                        command.Connection = connection;
                        command.CommandText = SQLQueryString.GetAllActivePipesByDate;
                        //input search criteria value
                        command.Parameters.AddWithValue("@startDate", startDate);
                        command.Parameters.AddWithValue("@finalDate", finalDate);
                        adapter.SelectCommand = command;
                        adapter.Fill(pipeDataSet);
                    }
                }
                
            }
            catch (SqlException ex)
            {
                throw new RepositoryException("GetPipesByStatus", ex);
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
            if (connection == null)
            {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["PrizmDatabase"];
            connection = new System.Data.SqlClient.SqlConnection(settings.ConnectionString);
            }

            return connection;
        }

    }
}
