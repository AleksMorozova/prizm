using System;
using System.Configuration;
using System.IO;
using FluentMigrator.Runner.Announcers;
using FluentMigrator.Runner.Initialization;
using System.Reflection;
using System.Globalization;

namespace Prizm.DatabaseMigrator
{
    class Program
    {
        private const string DATABASE = "SqlServer2008";
        private const string MIGRATE_TASK_NAME = "migrate";
        private const string ROLLBACK_TASK_NAME = "rollback";
        private const string ROLLBACK_ALL_TASK_NAME = "rollback:all";
        private const string ROLLBACK_TOVERSION_TASK_NAME = "rollback:toversion";
        private const string CONNECTION_NAME = "PrizmDatabase";
        private const string CONFIG_FILE_LOCATION = "PrizmConfig";
        
        static void Main(string[] args)
        {
            bool silentMode = false;
            int retValue = 0;
            try
            {
                var currDir = new Uri(Assembly.GetAssembly(typeof(Program)).CodeBase).LocalPath;
                var exeConfigurationFileMap = new ExeConfigurationFileMap
                {
                    ExeConfigFilename = Path.Combine(Path.GetDirectoryName(currDir), ConfigurationManager.AppSettings[CONFIG_FILE_LOCATION])
                };

                if (!File.Exists(exeConfigurationFileMap.ExeConfigFilename))
                {
                    throw new Exception("Can't find configuration file: " + exeConfigurationFileMap);
                }
                var configuration = ConfigurationManager.OpenMappedExeConfiguration(exeConfigurationFileMap, ConfigurationUserLevel.None);
                var connectionString = configuration.ConnectionStrings.ConnectionStrings[CONNECTION_NAME].ConnectionString;
                
                var consoleAnnouncer = new TextWriterAnnouncer(Console.Out)
                {
                    ShowElapsedTime = false,
                    ShowSql = true
                };

                var runnerContext = new RunnerContext(consoleAnnouncer)
                {
                    Database = DATABASE,
                    Connection = connectionString,
                    Target = Assembly.GetEntryAssembly().Location,
                    PreviewOnly = false,
                    Task = MIGRATE_TASK_NAME
                };

                Console.WriteLine("Target: {0}", runnerContext.Target);

                string selectedOption;
                if (args.Length > 0)
                {
                    selectedOption = args[0];
                    silentMode = true;
                }
                else
                {
                    Console.WriteLine("Got ConnectionString: [{0}]", connectionString);
                    Console.WriteLine();

                    Console.WriteLine("Choose task for migrator:");
                    Console.WriteLine("Press 1 for \"migrate\" task. (Migrate the database to the latest version)");
                    Console.WriteLine("Press 2 for \"rollback\" task. (Migrate the database back one version)");
                    Console.WriteLine(
                        "Press 3 for \"rollback:all\" task. (Migrates the database back to original state prior to applying migrations)");
                    Console.WriteLine("Press 4 for \"rollback:toversion\" task. (Migrates the database to the specific version)");
                    Console.WriteLine("Press 0 for exit");
                    var key = Console.ReadKey();
                    Console.WriteLine();

                    selectedOption = key.KeyChar.ToString(CultureInfo.InvariantCulture);
                }

                switch (selectedOption)
                {
                    case "1":
                        if (args.Length > 1)
                        {
                            runnerContext.ApplicationContext = args[1];
                        }

                        break;
                    case "2":
                        runnerContext.Task = ROLLBACK_TASK_NAME;
                        break;
                    case "3":
                        runnerContext.Task = ROLLBACK_ALL_TASK_NAME;
                        break;
                    case "4":
                        Console.WriteLine("Input number of version for migration:");
                        var versionKey = Console.ReadLine();
                        Console.WriteLine();

                        long version = 0;
                        if (long.TryParse(versionKey, out version))
                        {
                            runnerContext.Task = MIGRATE_TASK_NAME; //ROLLBACK_TOVERSION_TASK_NAME;
                            runnerContext.Version = version;
                        }

                        break;
                    case "0":
                        Environment.Exit(retValue);
                        break;
                }

                // check local database
                Utils.CheckLocalDB(connectionString);

                new TaskExecutor(runnerContext).Execute();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                retValue = 1;
            }

            if (!silentMode)
            {
                Console.WriteLine("Migrator has finished, press any key to exit.");
                Console.WriteLine();
                Console.ReadKey();
            }

            Environment.Exit(retValue);
        }
    }
}
