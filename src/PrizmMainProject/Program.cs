using System;
using System.Configuration;
using System.Windows.Forms;

using Ninject;

using Prizm.Data.DAL.Hibernate;


using Prizm.Main.Forms.MainChildForm;
using Prizm.Main.Properties;
using Prizm.Main.Forms.Common;
using Prizm.Main.Security;
using Prizm.Data.DAL.Security;
using Prizm.Domain.Entity.Security;
using Prizm.Data.DAL;
using Prizm.Main.Forms.MainChildForm.FirstSetupForm;
using Prizm.Main.Forms.Settings;
using DevExpress.XtraSplashScreen;
using Prizm.Main.Languages;
using System.Collections.Generic;
using Prizm.Main.Common;
using Prizm.Domain.Entity.Setup;
using System.Threading;


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

        #region --- Language ---
        private static readonly ILanguageManager langManager = new LanguageManager();
        public static ILanguageManager LanguageManager { get { return langManager; } }

        private static void AddLocalizationTemplatesFromForm(System.Type type, List<string> templateStrings)
        {
            if (type.IsSubclassOf(typeof(PrizmForm)))
            {
                templateStrings.Add("-----------------------------------------------");
                foreach (ILocalizedItem item in (ILocalizable)Activator.CreateInstance(type))
                {
                    for (int index = 0; index < item.Count; index++)
                    {
                        templateStrings.Add(item.GetResourceId(index));
                    }
                }
            }
        }

        #endregion // --- Language ---

        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ru-RU");
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ru-RU");
            foreach(var arg in args)
            {
                if(arg.Equals("seed"))
                {
                    isSeed = true;
                }
                if (arg.Equals("template"))
                {
                    LocalizedItem.IsCreatingTemplate = true;
                    List<string> templateStrings = new List<string>();
                    AddLocalizationTemplatesFromForm(typeof(PrizmApplicationXtraForm), templateStrings);
                    // TODO: add all other forms here

                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(
                        System.IO.Path.Combine(Directories.LanguagesFolderName, "Strings.template.txt"), append:false))
                    {
                        foreach (var line in templateStrings)
                        {
                            file.WriteLine(line);
                        }
                    }
                    return;
                }
            }

            bool cmdLineMode = false;
            try
            {
                // Splash screen
                SplashScreenManager.ShowForm(typeof(AppSplashScreen), true, false);

                // Database
                ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["PrizmDatabase"];

                HibernateUtil.Initialize(settings.ConnectionString);

                // Ninject
                Kernel = new StandardKernel(new PrizmModule());

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                // Hide splash screen
                SplashScreenManager.CloseForm(false);

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
                            MessageBox.Show(failMessage, "PRIZMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }

                mainForm = new PrizmApplicationXtraForm();
                Application.Run(mainForm);
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
            finally
            {
                // Hide splash screen
                SplashScreenManager.CloseForm(false);
            }
        }

        static LoginResult Login(ref string failMessage)
        {
           failMessage = Resources.AuthenticationFailed;
           LoginForm dlg = new LoginForm();
           if (dlg.ShowDialog() == DialogResult.OK)
           {

              string login = dlg.Login;
              string password = dlg.Password;

               #if DEBUG
              if(string.IsNullOrWhiteSpace(dlg.Login) && string.IsNullOrWhiteSpace(dlg.Password))
              {
                  login = "admin";
                  password = "admin";
              }
               #endif

              User user = new User() { IsActive = false, Login = "system" };


              IUserRepository userRepo;


              using ( userRepo = Kernel.Get<IUserRepository>())
              {
                  user = userRepo.FindByLogin(login);

                  if (user == null)
                      return LoginResult.Failed;
                  if (!user.IsActive)
                  {
                      failMessage = string.Format(Resources.AuthenticationFailedUserInactive, login);
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
                      user.PasswordHash = dlgPassChange.NewPasswordHash;
                      user.PasswordExpires = DateTime.Now.AddMonths(monthsCountPasswordProlongation);

                      userRepo.BeginTransaction();
                      userRepo.SaveOrUpdate(user);
                      userRepo.Commit();
                      userRepo.Evict(user);
                  }
                  else
                  {
                      return LoginResult.Failed;
                  }
              }
              
              ISecurityContext ctx = Kernel.Get<ISecurityContext>();
              ctx.LoggedUser = user;

              HibernateUtil.CurrentUser = ctx.GetLoggedPerson();
              return LoginResult.LoggedIn;
           }
           else
           {
              System.Environment.Exit(0);
           }

           return LoginResult.Failed;
        }

        static bool CreateProject()
        {
            bool result = false;
            IProjectRepository repo = (IProjectRepository)Program.Kernel.Get(typeof(IProjectRepository));

            Domain.Entity.Project pj = repo.GetSingle();

            if(pj == null)
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
                        throw new ApplicationException("Could not find project settings");
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

        private static void CreatePermissions()
        {
            IPermissionRepository repo = (IPermissionRepository)Program.Kernel.Get(typeof(IPermissionRepository));
            if (repo.GetAll().Count == 0)
            {
                repo.SeedPermissions();
            }
        }


        //Global data
        private static PrizmApplicationXtraForm mainForm;
        private static WorkstationType workstationType;
        /// <summary>
        /// Global access to main form need to update statusbar texts
        /// </summary>
        public static PrizmApplicationXtraForm MainForm { get { return mainForm; } }
        public static WorkstationType ThisWorkstationType { get { return workstationType; } }
    }
}