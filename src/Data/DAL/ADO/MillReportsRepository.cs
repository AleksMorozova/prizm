using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Ninject;
using Domain.Entity.Mill;


namespace Data.DAL.ADO
{
    public class MillReportsRepository : IMillReportsRepository
    {
        [Inject]
        public MillReportsRepository() { }
        private SqlConnection connection = null;


        public DataSet GetPipesByStatus(DateTime startDate, DateTime finalDate, List<Guid> categories, ReportType reportType, List <string> statuses)
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

                        //input search criteria value
                        command.Parameters.AddWithValue("@startDate", startDate);
                        command.Parameters.AddWithValue("@finalDate", finalDate);

                        switch (reportType)
                        {
                            case ReportType.ByCategories:
                                {
                                    var categoryParameters = new string[categories.Count];
                                    for (int i = 0; i < categories.Count; i++)
                                    {
                                        categoryParameters[i] = string.Format("@Category{0}", i);
                                        command.Parameters.AddWithValue(categoryParameters[i], categories[i]);
                                    }

                                    var statusParameters = new string[statuses.Count];
                                    for (int j = 0; j < statuses.Count; j++)
                                    {
                                        statusParameters[j] = string.Format("@Status{0}", j);
                                        command.Parameters.AddWithValue(statusParameters[j], statuses[j]);
                                    }

                                    command.CommandText = (categories.Count != 0) ? string.Format(SQLQueryString.GetAllActivePipesByDate + "AND PipeTest.categoryId IN ({0})", string.Join(", ", categoryParameters))
                                                                                 : SQLQueryString.GetAllActivePipesByDate;
                                    if(statuses.Count!=0)
                                        command.CommandText += string.Format("AND PipeTestResult.status IN ({0})", string.Join(", ", statusParameters));

                                }; break;
                            case ReportType.ByProducing:
                                command.CommandText =SQLQueryString.GetAllProduced; break;
                            case ReportType.ByShipped:
                                command.CommandText = SQLQueryString.GetAllShipped; break;
                            default:
                                { throw new Exception("Cannot form query"); }
                        }
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
