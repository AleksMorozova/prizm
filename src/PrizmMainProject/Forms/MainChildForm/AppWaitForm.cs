using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraWaitForm;
using Prizm.Main.Languages;

namespace Prizm.Main.Forms.MainChildForm
{
    public partial class AppWaitForm : WaitForm, ILocalizable
    {
        public AppWaitForm()
        {
            InitializeComponent();
            this.progressPanel.AutoHeight = true;
        }

        #region --- Localization ---

        private List<LocalizedItem> localizedItems = null;

        public IEnumerator<ILocalizedItem> GetEnumerator()
        {
            if (localizedItems == null)
            {
                localizedItems = new List<LocalizedItem>()
                {
                    new LocalizedItem(progressPanel, "WaitScreen_Caption", "WaitScreen_Description"),
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


        #region Overrides

        public override void SetCaption(string caption)
        {
            base.SetCaption(caption);
            this.progressPanel.Caption = caption;
        }
        public override void SetDescription(string description)
        {
            base.SetDescription(description);
            this.progressPanel.Description = description;
        }
        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

    }
}