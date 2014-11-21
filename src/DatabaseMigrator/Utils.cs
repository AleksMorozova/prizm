namespace Prizm.DatabaseMigrator
{
    using System;
    using System.Data.SqlClient;
    using System.IO;

    class Utils
    {
        private static string dataSourcePattern = "Data Source=";
        private static string initialCatalogPattern= "Initial Catalog=";
        private static string attachedDbFileNamePattern = "AttachDBFileName=";

        /// <summary>
        /// The check local db.
        /// </summary>
        /// <param name="connectionString">
        /// The connection string.
        /// </param>
        public static void CheckLocalDB(string connectionString)
        {
            try
            {
                var databaseFileName = GetDatabaseFileName(connectionString);

                if (!File.Exists(databaseFileName))
                {
                    // Create Data Directory If It Doesn't Already Exist.
                    if (!Directory.Exists(Path.GetDirectoryName(databaseFileName)))
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName(databaseFileName));
                    }

                    var databaseName = GetDatabaseName(connectionString);
                    var datasourceName = GetDataSourceName(connectionString);
                    Console.WriteLine("Database does not exist. Create new database");
                    CreateDatabase(datasourceName, databaseName, databaseFileName);
                }

                // Open newly created, or old database.
                Console.WriteLine("Ping database: " + connectionString);
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    connection.Close();
                }

                Console.WriteLine("Ping successfully");
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Create new database.
        /// </summary>
        /// <param name="dbDataSource">
        /// The db data source.
        /// </param>
        /// <param name="dbName">
        /// The db name.
        /// </param>
        /// <param name="dbFileName">
        /// The db file name.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public static bool CreateDatabase(string dbDataSource, string dbName, string dbFileName)
        {
            try
            {
                var connectionString = String.Format(@"Data Source={0};Initial Catalog=master;Integrated Security=True;Connection Timeout=60", dbDataSource);
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();

                    DetachDatabase(dbDataSource, dbName); // why???

                    cmd.CommandText = String.Format("CREATE DATABASE {0} ON (NAME = N'{0}', FILENAME = '{1}')", dbName, dbFileName);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }

                return File.Exists(dbFileName);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Detach database.
        /// </summary>
        /// <param name="dbDataSource">
        /// The db data source.
        /// </param>
        /// <param name="dbName">
        /// The db name.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public static bool DetachDatabase(string dbDataSource, string dbName)
        {
            try
            {
                var connectionString = String.Format(@"Data Source={0};Initial Catalog=master;Integrated Security=True;Connection Timeout=60", dbDataSource);
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = String.Format("exec sp_detach_db '{0}'", dbName);
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static string GetDataSourceName(string connectionString)
        {
            var ind = connectionString.IndexOf(dataSourcePattern, StringComparison.CurrentCultureIgnoreCase);
            if (ind > -1)
            {
                var ind2 = connectionString.IndexOf(";", ind, StringComparison.CurrentCultureIgnoreCase);
                if (ind2 > -1)
                {
                    return connectionString.Substring(ind + dataSourcePattern.Length, ind2 - ind - dataSourcePattern.Length);
                }

                return connectionString.Substring(ind + dataSourcePattern.Length);
            }
            else
            {
                throw new Exception("Connection string does not contain attribute: " + dataSourcePattern);
            }
        }

        public static string GetDatabaseName(string connectionString)
        {
            var ind = connectionString.IndexOf(initialCatalogPattern, StringComparison.CurrentCultureIgnoreCase);
            if (ind > -1)
            {
                var ind2 = connectionString.IndexOf(";", ind, StringComparison.CurrentCultureIgnoreCase);
                if (ind2 > -1)
                {
                    return connectionString.Substring(ind + initialCatalogPattern.Length, ind2 - ind - initialCatalogPattern.Length);
                }

                return connectionString.Substring(ind + initialCatalogPattern.Length);
            }
            else
            {
                throw new Exception("Connection string does not contain attribute: " + initialCatalogPattern);
            }
        }

        public static string GetDatabaseFileName(string connectionString)
        {
            var ind = connectionString.IndexOf(attachedDbFileNamePattern, StringComparison.CurrentCultureIgnoreCase);
            if (ind > -1)
            {
                var ind2 = connectionString.IndexOf(";", ind, StringComparison.CurrentCultureIgnoreCase);
                if (ind2 > -1)
                {
                    return connectionString.Substring(ind + attachedDbFileNamePattern.Length, ind2 - ind - attachedDbFileNamePattern.Length);
                }

                return connectionString.Substring(ind + attachedDbFileNamePattern.Length);
            }
            else
            {
                throw new Exception("Connection string does not contain attribute: " + attachedDbFileNamePattern);
            }
        }

        public static string BuildConnectionString(string dbDataSource, string dbName, string dbFileName)
        {
            return String.Format(@"Data Source={0};AttachDBFileName={2};Initial Catalog={1};Integrated Security=True;", dbDataSource, dbName, dbFileName);
        }
    }
}
