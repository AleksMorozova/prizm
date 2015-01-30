using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using Prizm.Main.Languages;

namespace Prizm.Main.Forms.MainChildForm
{
    public partial class AppSplashScreen : SplashScreen, ILocalizable
    {
        public AppSplashScreen()
        {
            InitializeComponent();
            version.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        #region --- Localization ---

        private List<LocalizedItem> localizedItems = null;

        public IEnumerator<ILocalizedItem> GetEnumerator()
        {
            if (localizedItems == null)
            {
                localizedItems = new List<LocalizedItem>()
                {
                    new LocalizedItem(labelMessage, "InitialSplashScreen_Label"),

                    new LocalizedItem(versionLabel, StringResources.AppSplashScreen_VersionLabel.Id),
                };
            }
            return localizedItems.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (!DesignMode)
            {
                Program.LanguageManager.ChangeLanguage(this);
            }
        }
        #endregion // --- Localization ---
    
    }
}