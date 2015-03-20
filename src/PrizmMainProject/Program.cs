using DevExpress.XtraSplashScreen;
using Ninject;
using Prizm.Data.DAL;
using Prizm.Data.DAL.Hibernate;
using Prizm.Data.DAL.Security;
using Prizm.Domain.Entity.Security;
using Prizm.Domain.Entity.Setup;
using Prizm.Main.Common;
using Prizm.Main.Forms.Common;
using Prizm.Main.Forms.MainChildForm;
using Prizm.Main.Forms.MainChildForm.FirstSetupForm;
using Prizm.Main.Forms.Settings;
using Prizm.Main.Languages;
using Prizm.Main.Properties;
using Prizm.Main.Security;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace Prizm.Main
{
    internal static class Program
    {
        public static IKernel Kernel { get; private set; }

        private static bool isSeed = false;
        public static bool IsSeed { get { return isSeed; } }
        /// <summary>
        /// the months count of user password prolongation
        /// </summary>
        private const int monthsCountPasswordProlongation = 3;

        private enum LoginResult { None = -1, LoggedIn = 0, Failed = 1, FailedUserInactive = 2 }


        //Global data
        private static PrizmApplicationXtraForm mainForm;
        private static WorkstationType workstationType = WorkstationType.Undefined;
        /// <summary>
        /// Global access to main form need to update statusbar texts
        /// </summary>
        public static PrizmApplicationXtraForm MainForm { get { return mainForm; } }
        public static WorkstationType ThisWorkstationType { get { return workstationType; } }

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));

        #region --- Language ---

        private static readonly ILanguageManager langManager;
        public static ILanguageManager LanguageManager { get { return langManager; } }

        #endregion // --- Language ---

        /// <summary>
        /// Initialize all static data. Log configuration should be performed earlier than any other initializations.
        /// </summary>
        static Program()
        {
            log4net.Config.XmlConfigurator.Configure();
            langManager = new LanguageManager();
        }

        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            #region SingleInstance
            if(!SingleInstance.Start())
            {
                SingleInstance.ShowFirstInstance();
                return;
            } 
            #endregion
 
            foreach (var arg in args)
            {
                if (arg.Equals("seed"))
                {
                    isSeed = true;
                }
                if (arg.Equals("template"))
                {
                    using (StreamWriter file = new StreamWriter(
                        Path.Combine(Directories.LanguagesFolderName, "Strings.template.txt"), append: false, encoding: Encoding.UTF8))
                    {
                        foreach (var item in LanguageManager.EnumerateStringResources(typeof(StringResources)))
                        {
                            file.WriteLine(Environment.NewLine + ";" + item.Description + Environment.NewLine + item.Id + "=");
                        }
                    }
                    return;
                }
            }

            bool cmdLineMode = false;
            LanguageManager.LoadTranslation(new CultureInfo(Settings.Default.UsersLanguage));
            
            Thread.CurrentThread.CurrentCulture = LanguageManager.CurrentCulture;
            Thread.CurrentThread.CurrentUICulture = LanguageManager.CurrentCulture; 

            try
            {
                // Splash screen
                SplashScreenManager.ShowForm(typeof(AppSplashScreen), true, false);

                // Database
                ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["PrismDatabase"];

                HibernateUtil.Initialize(settings.ConnectionString, false);

                // Ninject
                Kernel = new StandardKernel(new PrizmModule());

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                // Hide splash screen
                SplashScreenManager.CloseForm(false);

                //Event before closing program
                AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);

                //Permissions setup
                CreatePermissions();

                while (!CreateProject())
                { }

                //Login
                string failMessage = String.Empty;
                LoginResult loginResult = LoginResult.None;
                while (loginResult != LoginResult.LoggedIn)
                {
                    loginResult = Login(ref failMessage);
                    switch (loginResult)
                    {
                        case LoginResult.Failed:
                        case LoginResult.FailedUserInactive:
                            log.Warn(string.Format("Failed to login for the reason: {0}", failMessage));
                            MessageBox.Show(failMessage,
                                Program.LanguageManager.GetString(StringResources.MainWindowHeader_Title),
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }

                mainForm = new PrizmApplicationXtraForm();
                Application.Run(mainForm);

            }
            catch (Exception ex)
            {
                String error = ex.ToString();
                if (cmdLineMode)
                {
                    Console.Error.WriteLine(error);
                }
                else
                {
                    MessageBox.Show(error);
                }
                log.Fatal(error);
            }
            finally
            {
                // Hide splash screen
                SplashScreenManager.CloseForm(false);
            }
        }

        /// <summary>
        /// Try to log in
        /// </summary>
        /// <param name="failMessage">message for user, when login has been failed</param>
        /// <returns>status of logging in attempt</returns>
        private static LoginResult Login(ref string failMessage)
        {
            failMessage = Program.LanguageManager.GetString(StringResources.Message_AuthentificationFailed);
            LoginForm dlg = new LoginForm();
            if (dlg.ShowDialog() == DialogResult.OK)
            {

                string login = dlg.Login;
                string password = dlg.Password;

#if DEBUG
                if (string.IsNullOrWhiteSpace(dlg.Login) && string.IsNullOrWhiteSpace(dlg.Password))
                {
                    login = "admin";
                    password = "admin";
                }
#endif

                User user = new User() { IsActive = false, Login = "system" };


                IUserRepository userRepo;


                using (userRepo = Kernel.Get<IUserRepository>())
                {
                    user = userRepo.FindByLogin(login);

                    if (user == null)
                        return LoginResult.Failed;
                    if (!user.IsActive)
                    {
                        failMessage = string.Format(
                            Program.LanguageManager.GetString(StringResources.Message_AuthentificationFailedUserInactive), login);
                        return LoginResult.FailedUserInactive;
                    }
                }

                userRepo = (UserRepository)Program.Kernel.GetService(typeof(UserRepository));

                string hash = PasswordEncryptor.EncryptPassword(password);

                if (user.PasswordHash != hash)
                    return LoginResult.Failed;

                if (user.PasswordExpires != null && user.PasswordExpires < DateTime.Now)
                {
                    PasswordChangeDialog dlgPassChange = new PasswordChangeDialog();

                    if (dlgPassChange.ShowPasswordDialog(user.PasswordHash) ==
                        System.Windows.Forms.DialogResult.OK)
                    {
                        try
                        {
                            user.PasswordHash = dlgPassChange.NewPasswordHash;
                            user.PasswordExpires = DateTime.Now.AddMonths(monthsCountPasswordProlongation);

                            userRepo.BeginTransaction();
                            userRepo.SaveOrUpdate(user);
                            userRepo.Commit();
                            userRepo.Evict(user);
                        }
                        catch (RepositoryException ex)
                        {
                            log.Error(ex.Message);
                        }
                    }
                    else
                    {
                        return LoginResult.Failed;
                    }
                }

                ISecurityContext ctx = Kernel.Get<ISecurityContext>();
                ctx.LoggedUser = user;

                HibernateUtil.CurrentUser = ctx.LoggedUser;
                return LoginResult.LoggedIn;
            }
            else
            {
                System.Environment.Exit(0);
            }

            return LoginResult.Failed;
        }

        /// <summary>
        /// if no project settings available, it will be created if user enters all necessary data
        /// </summary>
        /// <returns>status if project settings were created</returns>
        private static bool CreateProject()
        {
            bool result = false;
            IProjectRepository repo = (IProjectRepository)Program.Kernel.Get(typeof(IProjectRepository));

            Domain.Entity.Project pj = repo.GetSingle();

            if (pj == null)
            {
                using (var setupDialog = (FirstSetupXtraForm)Program.Kernel.Get(typeof(FirstSetupXtraForm)))
                {
                    setupDialog.ShowDialog();
                    if (setupDialog.DialogResult == DialogResult.Cancel)
                    {
                        System.Environment.Exit(0);
                    }
                    pj = repo.GetSingle();
                    if (pj == null)
                    {
                        ApplicationException e = new ApplicationException("Could not find project settings");
                        log.Error(e.Message);
                        throw e;
                    }
                }
            }
            else
            {
                result = true;
            }
            workstationType = pj.WorkstationType;
            return result;
        }

        /// <summary>
        /// If there are no permissions available, they will be written to system.
        /// </summary>
        private static void CreatePermissions()
        {
            IPermissionRepository repo = (IPermissionRepository)Program.Kernel.Get(typeof(IPermissionRepository));
            if (repo.GetAll().Count == 0)
            {
                repo.SeedPermissions();
            }
        }

        private static void OnProcessExit(object sender, EventArgs e)
        {
            if (Settings.Default.UsersLanguage != LanguageManager.CurrentCulture.Name)
            {
                Settings.Default.UsersLanguage = LanguageManager.CurrentCulture.Name;
                Settings.Default.Save();
            }
        }

    }


}