using NHibernate;
using Prizm.Data.DAL.Hibernate;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prizm.Main.Common
{
    public static class DbUtils
    {
        public static void LogOptimize()
        {
            

            string connectionString = ConfigurationManager.ConnectionStrings["PrismDatabase"].ConnectionString;
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectionString);
            string database = builder.InitialCatalog;
            string logName = database + "_log";

            string query = string.Format(@"checkpoint; DBCC SHRINKFILE ({0});", logName);
            using(var session = HibernateUtil.OpenSession(false))
            {
                session.CreateSQLQuery(query).ExecuteUpdate();
            }
        }
    }
}
