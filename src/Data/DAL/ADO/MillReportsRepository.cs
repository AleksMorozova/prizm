using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Ninject;
using Prizm.Domain.Entity.Mill;
using System.ComponentModel;

namespace Prizm.Data.DAL.ADO
{
    public class MillReportsRepository : IMillReportsRepository, IDisposable
    {
        [Inject]
        public MillReportsRepository() { }
        private SqlConnection connection = null;
       
        public DataSet GetReleaseNotes(DateTime startDate, DateTime finalDate)
        {
            CreateConnection();
            DataSet releaseNoteDataSet = new DataSet();

            try
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {

                    using (SqlCommand command = new System.Data.SqlClient.SqlCommand())
                    {
                        connection.Open();
                        adapter.TableMappings.Add("Table", "ReleaseNote");
                        command.Connection = connection;
                        command.Parameters.AddWithValue("@startDate", startDate);
                        command.Parameters.AddWithValue("@finalDate", finalDate);
                        command.CommandText = SQLProvider.GetQuery(SQLProvider.SQLStatic.GetReleaseNotes).ToString();
                        adapter.SelectCommand = command;
                        adapter.Fill(releaseNoteDataSet);
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

            return releaseNoteDataSet;
        }

        public DataSet GetPipesByStatus(DateTime startDate, DateTime finalDate, List<Guid> categories, MillReportType reportType, List<string> statuses, bool previewFlag = false)
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

                        //temporary SQLobject
                        ISQLFlexible tempSQLObject;

                        switch (reportType)
                        {
                            case MillReportType.ByCategories:
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

                                    tempSQLObject = SQLProvider.GetQuery(SQLProvider.SQLStatic.GetAllActivePipesByDate).WhereAnd().Where("Pipe.isActive", "=", "1").WhereAnd().Where("PipeTest.isRequired", "=", "1");

                                    if (previewFlag)
                                    {
                                        tempSQLObject.Top(1);
                                    }

                                    tempSQLObject = (categories.Count != 0) ? tempSQLObject.WhereAnd().Where("PipeTest.categoryId", "IN", "(" + string.Join(", ", categoryParameters) + ")")
                                                                                 : tempSQLObject;
                                    if (statuses.Count != 0)
                                        tempSQLObject = tempSQLObject.WhereAnd().Where("PipeTestResult.status", "IN", "(" + string.Join(", ", statusParameters) + ")");

                                    command.CommandText = tempSQLObject.ToString(); 

                                }; break;
                            case MillReportType.ByProducing:
                                tempSQLObject = SQLProvider.GetQuery(SQLProvider.SQLStatic.GetAllProduced).WhereAnd().Where("PipeMillStatus", "=", "'Produced'").WhereAnd().Where("Pipe.isActive", "=", "1");
                                if (previewFlag)
                                    {
                                        tempSQLObject.Top(1);
                                    }
                                command.CommandText =tempSQLObject.ToString(); 
                                break;
                            case MillReportType.ByShipped:
                                tempSQLObject = SQLProvider.GetQuery(SQLProvider.SQLStatic.GetAllShipped).WhereAnd().Where("PipeMillStatus", "=", "'Shipped'").WhereAnd().Where("Pipe.isActive", "=", "1");
                                    if (previewFlag)
                                    {
                                        tempSQLObject.Top(1);
                                    }
                                command.CommandText =tempSQLObject.ToString();
                                break;
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

        public DataSet GetPipes(DateTime startDate, DateTime finalDate)
        {
            CreateConnection();
            DataSet pipeDataSet = new DataSet();
            BindingList<Pipe> pipes = new BindingList<Pipe>();
            try
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {

                    using (SqlCommand command = new System.Data.SqlClient.SqlCommand())
                    {
                        connection.Open();
                        adapter.TableMappings.Add("Table", "Pipe");
                        command.Connection = connection;
                        command.Parameters.AddWithValue("@startDate", startDate);
                        command.Parameters.AddWithValue("@finalDate", finalDate);
                        command.CommandText = SQLProvider.GetQuery(SQLProvider.SQLStatic.GetAllProducedPipesByDate).ToString();
                        adapter.SelectCommand = command;
                        adapter.Fill(pipeDataSet);
                    }
                }

            }
            catch (SqlException ex)
            {
                throw new RepositoryException("GetPipesFromInspection", ex);
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

        public DataSet CountWeldInf(DateTime startDate, DateTime finalDate)
        {
            CreateConnection();
            DataSet pipeDataSet = new DataSet();
            BindingList<Pipe> pipes = new BindingList<Pipe>();
            try
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {

                    using (SqlCommand command = new System.Data.SqlClient.SqlCommand())
                    {
                        connection.Open();
                        adapter.TableMappings.Add("Table", "Pipe");
                        command.Connection = connection;
                        command.Parameters.AddWithValue("@startDate", startDate);
                        command.Parameters.AddWithValue("@finalDate", finalDate);
                        command.CommandText = SQLProvider.GetQuery(SQLProvider.SQLStatic.CountPipesWeldInformation).ToString();
                        adapter.SelectCommand = command;
                        adapter.Fill(pipeDataSet);
                    }
                }

            }
            catch (SqlException ex)
            {
                throw new RepositoryException("GetPipesFromInspection", ex);
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
        public DataSet GetPipesFromInspection(DateTime startDate, DateTime finalDate)
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
                        command.Parameters.AddWithValue("@startDate", startDate);
                        command.Parameters.AddWithValue("@finalDate", finalDate);
                        command.CommandText = SQLProvider.GetQuery(SQLProvider.SQLStatic.GetAllPipesFromInspection).ToString();
                        adapter.SelectCommand = command;
                        adapter.Fill(pipeDataSet);
                    }
                }

            }
            catch (SqlException ex)
            {
                throw new RepositoryException("GetPipesFromInspection", ex);
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

        public DataSet GetUsedProducts(int startPK, int endPK, string queryString)
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
                        adapter.TableMappings.Add("Table", "Joint");
                        command.Connection = connection;
                        command.Parameters.AddWithValue("@startPK", startPK);
                        command.Parameters.AddWithValue("@endPK", endPK);
                        command.CommandText = queryString;
                        adapter.SelectCommand = command;
                        adapter.Fill(pipeDataSet);
                    }
                }

            }
            catch (SqlException ex)
            {
                throw new RepositoryException("Get Used Products", ex);
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

        public DataTable GetPipelineElements()
        { 
            return GetPipelineElements(SQLProvider.GetQuery(SQLProvider.SQLStatic.GetPipelinePieces).ToString());
        }

        public DataTable GetPipelineElements(string sqlQueryString)
        {
            CreateConnection();
            DataTable resultsTable = new DataTable();
            try
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {

                    using (SqlCommand command = new System.Data.SqlClient.SqlCommand())
                    {
                        connection.Open();
                        command.Connection = connection;
                        command.CommandText = sqlQueryString;
                        adapter.SelectCommand = command;
                        adapter.Fill(resultsTable);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new RepositoryException("GetAuditResults", ex);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return resultsTable;
        }

        public SqlConnection CreateConnection()
        {
            if (connection == null)
            {
                ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["PrismDatabase"];
                connection = new System.Data.SqlClient.SqlConnection(settings.ConnectionString);
            }

            return connection;
        }

        public BindingList<int> GetAllKP() 
        {
            CreateConnection();
            BindingList<int> PKList = new BindingList<int>();
         
            try
            {
                using (SqlCommand command = new System.Data.SqlClient.SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = SQLProvider.GetQuery(SQLProvider.SQLStatic.GettAllKP).ToString();
                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {  
                        PKList.Add((int)dr[0]);
                    }
                }

              
            }
            catch (SqlException ex)
            {
                throw new RepositoryException("Get Used Products", ex);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return PKList;
        }

        public BindingList<double> CountPipe(DateTime startDate, DateTime finalDate)
        {
            CreateConnection();
            BindingList<double> countPipe = new BindingList<double>();

            try
            {
                using (SqlCommand command = new System.Data.SqlClient.SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@finalDate", finalDate);
                    command.CommandText = SQLProvider.GetQuery(SQLProvider.SQLStatic.CountPipesInformation).ToString();
                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        countPipe.Add(dr[0] == System.DBNull.Value ? (double)(0) : (double)((int)dr[0]));

                        countPipe.Add(dr[1] == System.DBNull.Value ? (double)(0) : (double)((int)dr[1]));

                        countPipe.Add(dr[2] == System.DBNull.Value ? (double)(0) : (double)dr[2]);   
                    }
                }


            }
            catch (SqlException ex)
            {
                throw new RepositoryException("Get Used Products", ex);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return countPipe;
        }

        public DataTable GetPipelineElements(string pipeNumber, string[] pipeTypes)
        {
            ISQLFlexible tempSQLObject;


            string types = string.Concat(" N'", Guid.NewGuid(), "'");

            foreach (var cpt in pipeTypes)
            {
                types = string.Concat(types, ", N'", cpt, "'");
            }

            types = string.Concat("(", types, ")");

            tempSQLObject = SQLProvider.GetQuery(
                SQLProvider.SQLStatic.GetPipeByParametersPieces)
                .WhereAnd().Where("p.number", "LIKE", string.Concat(" N'%", pipeNumber, "%'"))
                .WhereAnd().Where("PmSt.type", "IN", types);

            return GetPipelineElements(tempSQLObject.ToString());

        }


        public DataTable GetPipelineElements(DateTime? weldDateFrom, DateTime? weldDateTo)
        {
            ISQLFlexible tempSQLObject;

            tempSQLObject = SQLProvider.GetQuery(
                SQLProvider.SQLStatic.GetJointsByDate)
                .WhereAnd().Where("wr.MinDate", "<=", string.Format("N'{0}-{1}-{2}'", weldDateTo.Value.Year, weldDateTo.Value.Month, weldDateTo.Value.Day))
                .WhereAnd().Where("wr.MinDate", ">=", string.Format("N'{0}-{1}-{2}'", weldDateFrom.Value.Year, weldDateFrom.Value.Month, weldDateFrom.Value.Day));

            return GetPipelineElements(tempSQLObject.ToString());

        }

        public void Dispose()
        {
            try
            {
                connection.Dispose();
            }
            catch (SqlException ex)
            {
                throw new RepositoryException("Dispose", ex);
            }
        }
    }
}
