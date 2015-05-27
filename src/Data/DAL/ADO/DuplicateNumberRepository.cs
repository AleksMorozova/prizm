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
        public List<Entities> GetAllEntitites() 
        { 
            CreateConnection();
            List<Entities> allEntities = new List<Entities>();

            try
            {
                using (SqlCommand command = new System.Data.SqlClient.SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;

                    command.CommandText = String.Format
                        (@" select r.number, r.id, r.type from 
 (Select p.number, p.id, 'Pipe' as type From Pipe p union all Select c.Number, c.id, 
'Component' as type from Component c 
 union all Select s.Number, s.id , 'Spool' as type from Spool s union all  Select j.number, j.id, 'Joint' as type From Joint j) r");

                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        allEntities.Add(new Entities()
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
        public List<string> GetAllDuplicateNumber()
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
 Select p.number From Pipe p union all Select c.Number from Component c 
 union all Select s.Number from Spool s union all Select j.number From Joint j) r group by number having count(*) >1");

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
        ///  Reaturn all duplicate number
        /// </summary>
        /// <param name="testId">
        /// Number of entity for checking duplicate
        /// </param>
        /// <returns>
        /// List of DuplicateNumber
        /// </returns>
        public List<Entities> GetAllDuplicateEntityByNumber(string entityNumber)
        {
            CreateConnection();
            List<Entities> allEntities = new List<Entities>();

            try
            {
                using (SqlCommand command = new System.Data.SqlClient.SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@entityNumber", entityNumber);
                    command.CommandText = String.Format
                        (@"select r.number, r.id, r.type From(
 Select p.number From Pipe p union all Select c.Number from Component c 
 union all Select s.Number from Spool s union all Select j.number From Joint j) r where r.number=@entityNumber");

                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        allEntities.Add(new Entities()
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
