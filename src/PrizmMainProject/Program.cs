using System;
using System.Configuration;
using System.Windows.Forms;
using Data.DAL.Hibernate;
using Ninject;
using PrizmMain.Forms.MainChildForm;

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
            
            // Database
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["PrizmDatabase"];

            try
            {
                HibernateUtil.Initialize(settings.ConnectionString);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

            // Ninject
            Kernel = new StandardKernel(new PrizmModule());


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PrizmApplicationXtraForm());
        }
    }
}