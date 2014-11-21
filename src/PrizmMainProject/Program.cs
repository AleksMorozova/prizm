using System;
using System.Configuration;
using System.Windows.Forms;

using Ninject;

using Data.DAL.Hibernate;

using PrizmMain.Forms.MainChildForm;
using PrizmMain.Properties;

namespace PrizmMain
{
    internal static class Program
    {
        public static IKernel Kernel { get; private set; }

        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            bool cmdLineMode = false;
            try
            {
                // Database
                ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["PrizmDatabase"];

                HibernateUtil.Initialize(settings.ConnectionString);

                // Ninject
                Kernel = new StandardKernel(new PrizmModule());


                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new PrizmApplicationXtraForm());
            }
            catch (Exception ex)
            {
                String error = String.Format(Resources.IDS_ERROR + "\n{0}", ex.Message);
                if (cmdLineMode)
                {
                    Console.Error.WriteLine(error);
                }
                else
                {
                    MessageBox.Show(error);
                }
            }
        }
    }
}