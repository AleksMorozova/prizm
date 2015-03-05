using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Prizm.Main.Forms.MainChildForm;
using Prizm.Main.Languages;

namespace Prizm.Main.Forms.Common
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class YesNoDialog : PrizmForm
    {
        public YesNoDialog(string text, string header)
        {
            InitializeComponent();
            this.questionLabel.Text = text;
            this.Text = header;
        }

        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
          {
              new LocalizedItem(yesButton, StringResources.Yes.Id),
              new LocalizedItem(noButton, StringResources.No.Id),
          };
        }

        #endregion // --- Localization ---
        private void yesButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

    }
}