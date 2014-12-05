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
                String error = ex.ToString();//String.Format(Resources.IDS_ERROR + Environment.NewLine + "{0}\n{01}", ex.InnerException.Message + Environment.NewLine, ex.InnerException.InnerException.Message + Environment.NewLine);
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