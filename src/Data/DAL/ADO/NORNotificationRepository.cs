using Prizm.Domain.Entity;
using Prizm.Domain.Entity.Setup;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.ADO
{
    public class NORNotificationRepository : INORNotificationRepository, IDisposable
    {
        private SqlConnection connection = null;
        public List<NotRequiredOperation> GetAllNotRequiredOperation()
        {
            CreateConnection();
            List<NotRequiredOperation> inspectionOperations = new List<NotRequiredOperation>();

            try
            {
                using (SqlCommand command = new System.Data.SqlClient.SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;

                    command.CommandText = @"Select t.id, t.code,t.name,t.frequency,t.frequencyMeasure, s.type
                                                    From PipeTest t, PipeMillSizeType s 
                                                    where t.isRequired=0 and t.pipeMillSizeTypeId=s.id";

                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        inspectionOperations.Add(new NotRequiredOperation()
                        {
                            operationId = (Guid)dr[0],
                            operationCode=(string)dr[1],
                            operationName = (string)dr[2],
                            frequency = (int)dr[3],
                            measure = (string)dr[4],// problem with convertation to enum type
                            pipeSizeTypeName = (string)dr[5]
                        });
                    }
                }


            }
            catch (SqlException ex)
            {
                throw new RepositoryException("Get all not required operation", ex);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return inspectionOperations;
        }

        public List<KeyValuePair<DateTime, Guid>> GetAllNotRequiredOperationResult()
        {
            CreateConnection();
            List<KeyValuePair<DateTime, Guid>> inspectionOperationsResult = new List<KeyValuePair<DateTime, Guid>>();

            try
            {
                using (SqlCommand command = new System.Data.SqlClient.SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;

                    command.CommandText = @"Select Max(r.Date), t.id From PipeTestResult r
right join PipeTest t on r.pipeTestId=t.id where t.isRequired=0
  group by t.id";

                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        inspectionOperationsResult.Add(new KeyValuePair<DateTime, Guid>(
                        dr[0] == System.DBNull.Value ? (DateTime)(new DateTime(1950, 6, 10, 15, 24, 16)) : (DateTime)dr[0],
                        (Guid)dr[1]
                        ));
                    }
                }


            }
            catch (SqlException ex)
            {
                throw new RepositoryException("Get all not required operation", ex);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return inspectionOperationsResult;
        }

        public KeyValuePair<Guid, float> GetAllUnitsProducedSinceLastDate(Guid testId, DateTime maxDate, string measure)
        {
            CreateConnection();
            KeyValuePair<Guid, float> unitsProducedSinceLastDate = new KeyValuePair<Guid,float>();

            try
            {
                using (SqlCommand command = new System.Data.SqlClient.SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@testId", testId);
                    command.Parameters.AddWithValue("@maxDate", maxDate);

                    if (measure == "Pipes")
                    {
                        command.CommandText = @"Select count(p.number) amount, t.id 
                                                From Pipe p, PipeTest t where t.pipeMillSizeTypeId=p.typeId and
                                                        t.id =@testId and p.productionDate>@maxDate and p.isActive=1 
                                                            group by   t.id ";
                        SqlDataReader dr = command.ExecuteReader();
                        while (dr.Read())
                        {
                            unitsProducedSinceLastDate = new KeyValuePair<Guid, float>(

                                (Guid)dr[1],
                                dr[0] == System.DBNull.Value ? 0 : (float)(int)dr[0]
                            );
                        }

                    }
                    else if (measure == "Tons")
                    {
                        command.CommandText = @"Select sum(p.weight) amount, t.id 
                                                From Pipe p, PipeTest t where t.pipeMillSizeTypeId=p.typeId and
                                                        t.id =@testId and p.productionDate>@maxDate and p.isActive=1 
                                                            group by   t.id ";
                        SqlDataReader dr = command.ExecuteReader();
                        while (dr.Read())
                        {
                            unitsProducedSinceLastDate = new KeyValuePair<Guid, float>(

                                (Guid)dr[1],
                                dr[0] == System.DBNull.Value ? 0 : (float)(double)dr[0]

                            );
                        }
                    }

                    else if (measure == "Meters")
                    {
                        command.CommandText = @"Select sum(p.length) amount, t.id 
                                                From Pipe p, PipeTest t where t.pipeMillSizeTypeId=p.typeId and
                                                        t.id =@testId and p.productionDate>@maxDate and p.isActive=1 
                                                            group by   t.id ";
                        SqlDataReader dr = command.ExecuteReader();
                        while (dr.Read())
                        {
                            unitsProducedSinceLastDate = new KeyValuePair<Guid, float>
                                ((Guid)dr[1],
                                dr[0] == System.DBNull.Value ? 0 : (float)(double)dr[0]);
                        }
                    }
                    else 
                    {
                        command.CommandText = @"Select 0 amount, t.id 
                                                From Pipe p, PipeTest t where t.pipeMillSizeTypeId=p.typeId and
                                                        t.id =@testId and p.productionDate>@maxDate and p.isActive=1 
                                                            group by   t.id ";
                        SqlDataReader dr = command.ExecuteReader();
                        while (dr.Read())
                        {
                            unitsProducedSinceLastDate = new KeyValuePair<Guid, float>
                                ((Guid)dr[1],
                                dr[0] == System.DBNull.Value ? 0 : (float)(int)dr[0]);
                        }
                    }
                }
            }

            catch (SqlException ex)
            {
                throw new RepositoryException("Get all not required operation", ex);
            }

            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return unitsProducedSinceLastDate;
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
