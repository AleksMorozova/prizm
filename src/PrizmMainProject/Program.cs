using Domain.DAL.Hibernate;
using Ninject;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrizmMain
{
    static class Program
    {
        public static IKernel Kernel { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Database
            ConnectionStringSettings settings = System.Configuration.ConfigurationManager.ConnectionStrings["PrizmDatabase"];

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
            Application.Run(new Forms.PrizmApplicationXtraForm());
            
        }
    }
}
