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

                    command.CommandText = @"Select t.code,t.name,t.frequency,t.frequencyMeasure, s.type
                                                    From PipeTest t, PipeMillSizeType s 
                                                    where t.isRequired=0 and t.pipeMillSizeTypeId=s.id";

                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        inspectionOperations.Add(new NotRequiredOperation()
                        {
                            operationCode=(string)dr[0],
                            operationName = (string)dr[1],
                            frequency = (int)dr[2],
                            measure = (string)dr[3],// problem with convertation to enum type
                            pipeSizeTypeName = (string)dr[4]
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

//        public List<NotRequiredOperation> GetAllNotRequiredOperation()
//        {
//            CreateConnection();
//            List<NotRequiredOperation> inspectionOperations = new List<NotRequiredOperation>();

//            try
//            {
//                using (SqlCommand command = new System.Data.SqlClient.SqlCommand())
//                {
//                    connection.Open();
//                    command.Connection = connection;

//                    command.CommandText = @"Select t.code,t.name,t.frequency,t.frequencyMeasure, s.type
//                                                    From PipeTest t, PipeMillSizeType s 
//                                                    where t.isRequired=0 and t.pipeMillSizeTypeId=s.id";

//                    SqlDataReader dr = command.ExecuteReader();
//                    while (dr.Read())
//                    {
//                        inspectionOperations.Add(new NotRequiredOperation()
//                        {
//                            operationCode = (string)dr[0],
//                            operationName = (string)dr[1],
//                            frequency = (int)dr[2],
//                            measure = (string)dr[3],// problem with convertation to enum type
//                            pipeSizeTypeName = (string)dr[4]
//                        });
//                    }
//                }


//            }
//            catch (SqlException ex)
//            {
//                throw new RepositoryException("Get all not required operation", ex);
//            }
//            finally
//            {
//                if (connection.State == System.Data.ConnectionState.Open)
//                {
//                    connection.Close();
//                }
//            }

//            return inspectionOperations;
//        }

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
