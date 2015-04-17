using NHibernate;
using NHibernate.Transform;
using Ninject;
using Prizm.Domain.Entity;
using Prizm.Domain.Entity.Setup;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.ADO
{
    public class SelectiveNotificationRepository : ISelectiveNotificationRepository
    {
        private SqlConnection connection = null;
        public SqlConnection CreateConnection()
        {
            if (connection == null)
            {
                ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["PrismDatabase"];
                connection = new System.Data.SqlClient.SqlConnection(settings.ConnectionString);
            }

            return connection;
        }



        public IList<SelectiveOperation> GetAllSelectiveOperation()
        {
            CreateConnection();
            List<SelectiveOperation> results = new List<SelectiveOperation>();

            try
            {
                using (SqlCommand command = new System.Data.SqlClient.SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"select  pmst.id, pt.id, pt.code, pt.name, pmst.[type], pt.selectivePercent, count(distinct(ptr.pipeId)) as pipesCount from PipeTest  pt
                  left join PipeTestResult  ptr  on ptr.pipeTestId = pt.Id  AND ptr.status not in ('Scheduled')
                 left join Pipe p on ptr.pipeId = p.id AND p.isActive = 1
                  left join PipeMillSizeType pmst on pt.pipeMillSizeTypeId = pmst.id
                  where pt.isActive = 1
                  AND pt.frequencyType = '" + InspectionFrequencyType.S.ToString() + @"'
                  Group by pmst.id, pt.id, pt.code, pt.name,pmst.[type], pt.name, pt.selectivePercent";
                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        results.Add(new SelectiveOperation()
                        {
                            PipeSizeTypeId = (Guid)dr[0],
                            OperationId = (Guid)dr[1],
                            OperationCode = (string)dr[2],
                            OperationName = (string)dr[3],
                            PipeSizeTypeName = (string)dr[4],
                            SelectivePercent = (int)dr[5],
                            PipesCount = (int)dr[6]
                        });
                    }
                }


            }
            catch (SqlException ex)
            {
                throw new RepositoryException("Get seelective operations", ex);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return results;
        }


        public IList<KeyValuePair<Guid, int>> GetPipesCountPerMillSizeType()
        {
            CreateConnection();
            List<KeyValuePair<Guid, int>> pipesCountPerMillSizeType = new List<KeyValuePair<Guid, int>>();

            try
            {
                using (SqlCommand command = new System.Data.SqlClient.SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;

                    command.CommandText = @"select typeId, count(id) from pipe
                     where isActive = 1 
                     group by typeId";

                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        pipesCountPerMillSizeType.Add(new KeyValuePair<Guid, int>(
                        (Guid)dr[0],
                        (int)dr[1]
                        ));
                    }
                }


            }
            catch (SqlException ex)
            {
                throw new RepositoryException("Get pipes per mill size type", ex);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return pipesCountPerMillSizeType;

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
        private class SelectiveOperationQuery : IResultTransformer
        {
            public static readonly SelectiveOperationQuery Transformer = new SelectiveOperationQuery();
            private SelectiveOperationQuery () { }
            #region IResultTransformer Members

            public IList TransformList(IList collection)
            {
                return collection;
            }

            public object TransformTuple(object[] tuple, string[] aliases)
            {

                return new SelectiveOperation()
                {
                    PipeSizeTypeId = (Guid)tuple[0],
                    OperationId = (Guid)tuple[1],
                    OperationCode = tuple[2].ToString(),
                    OperationName = tuple[3].ToString(),
                    PipeSizeTypeName = tuple[4].ToString(),
                    SelectivePercent = (int)tuple[5],
                    PipesCount = (int)tuple[6]
                };
            }
            #endregion
        }
    }
}
