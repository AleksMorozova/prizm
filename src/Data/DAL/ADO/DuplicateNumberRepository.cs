using Prizm.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.ADO
{
    public class DuplicateNumberRepository : IDuplicateNumberRepository, IDisposable
    {
        private SqlConnection connection = null;

        /// <summary>
        ///  Read all entities
        /// </summary>
        /// <returns>
        /// List of AllEntity
        /// </returns>
        public List<DuplicateNumberEntity> GetAllActiveEntitites() 
        { 
            CreateConnection();
            List<DuplicateNumberEntity> allEntities = new List<DuplicateNumberEntity>();

            try
            {
                using (SqlCommand command = new System.Data.SqlClient.SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;

                    command.CommandText = String.Format
                        (@" select r.number, r.id, r.type from 
 (Select p.number, p.id,'" + DuplicateNumberEntityType.Pipe + @"' as type From Pipe p where p.isActive='1'
union all Select c.Number, c.id, '" + DuplicateNumberEntityType.Component + @"' as type from Component c where c.isActive='1'
 union all Select s.Number, s.id , '" + DuplicateNumberEntityType.Spool + @"' as type from Spool s where s.isActive='1'
union all  Select j.number, j.id, '" + DuplicateNumberEntityType.Joint + @"' as type From Joint j where j.isActive='1') r");

                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        allEntities.Add(new DuplicateNumberEntity()
                        {
                            EntityNumber = (string)dr[0],
                            EntityID = (Guid)dr[1],
                            EntityType = (string)dr[2],
                        });
                    }
                   
                }
            }

            catch (SqlException ex)
            {
                throw new RepositoryException("Get all entities", ex);
            }

            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return allEntities;
        }

        /// <summary>
        ///  Reaturn all duplicate number
        /// </summary>
        /// <returns>
        /// List of DuplicateNumber
        /// </returns>
        public List<string> GetAllActiveDuplicateNumber()
        {
            CreateConnection();
            List<string> allDuplicateNumber = new List<string>();

            try
            {
                using (SqlCommand command = new System.Data.SqlClient.SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;

                    command.CommandText = String.Format
                        (@"select r.number From(
 Select p.number From Pipe p where p.isActive='1' union all Select c.Number from Component c where c.isActive='1'
 union all Select s.Number from Spool s where s.isActive='1'union all Select j.number From Joint j where j.isActive='1') r group by number having count(*) >1");

                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        allDuplicateNumber.Add((string)dr[0]);
                    }

                }
            }

            catch (SqlException ex)
            {
                throw new RepositoryException("Get all entities", ex);
            }

            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return allDuplicateNumber;
        }

        /// <summary>
        ///  Reaturn all duplicate entities with entered number
        /// </summary>
        /// <param name="testId">
        /// Number of entity for checking duplicate
        /// </param>
        /// <returns>
        /// List of DuplicateEntities
        /// </returns>
        public List<DuplicateNumberEntity> GetAllActiveDuplicateEntityByNumber(string entityNumber)
        {
            CreateConnection();
            List<DuplicateNumberEntity> allEntities = new List<DuplicateNumberEntity>();

            try
            {
                using (SqlCommand command = new System.Data.SqlClient.SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@entityNumber", entityNumber);
                    command.CommandText = String.Format
                        (@"select r.number, r.id, r.type From(
 Select p.number From Pipe p where p.isActive='1' union all Select c.Number from Component c where c.isActive='1'
 union all Select s.Number from Spool s where s.isActive='1' union all Select j.number From Joint j where j.isActive='1') r where r.number=@entityNumber");

                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        allEntities.Add(new DuplicateNumberEntity()
                        {
                            EntityNumber = (string)dr[0],
                            EntityID = (Guid)dr[1],
                            EntityType = (string)dr[2],
                        });
                    }

                }
            }

            catch (SqlException ex)
            {
                throw new RepositoryException("Get all entities", ex);
            }

            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return allEntities;
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
