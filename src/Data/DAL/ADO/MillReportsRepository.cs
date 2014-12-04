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
        

        public DataSet GetPipesByStatus(DateTime startDate, DateTime finalDate, List<Guid> categories)
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

                        var parameters = new string[categories.Count];
                        for (int i = 0; i < categories.Count; i++)
                        {
                            parameters[i] = string.Format("@Category{0}", i);
                            command.Parameters.AddWithValue(parameters[i], categories[i]);
                        }
               
                        //input search criteria value
                        command.Parameters.AddWithValue("@startDate", startDate);
                        command.Parameters.AddWithValue("@finalDate", finalDate);

                        command.CommandText = (categories.Count != 0)? string.Format(SQLQueryString.GetAllActivePipesByDate + "AND PipeTest.categoryId IN ({0})", string.Join(", ", parameters))
                                                                     : SQLQueryString.GetAllActivePipesByDate; 
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
