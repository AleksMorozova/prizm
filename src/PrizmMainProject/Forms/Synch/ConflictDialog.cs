using DevExpress.XtraEditors;
using Prizm.Main.Forms.MainChildForm;
using Prizm.Main.Languages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prizm.Main.Forms.Synch
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class ConflictDialog : PrizmForm
   {
      ConflictDecision decision = ConflictDecision.Undefined;

      public ConflictDialog()
      {
         InitializeComponent();
      }

      public ConflictDialog(string msg)
      {
         InitializeComponent();

         lblDesc.Text = msg;
      }

      #region --- Localization ---

      protected override List<LocalizedItem> CreateLocalizedItems()
      {
          return new List<LocalizedItem>()
          {
              new LocalizedItem(lblTitle, "ConflictDialog_ConflictLabel"),
              new LocalizedItem(btnReplace, "ConflictDialog_ReplaceButton"),
              new LocalizedItem(btnSkip, "ConflictDialog_SkipButton"),
              new LocalizedItem(btnPostpone, "ConflictDialog_PostponeButton"),
              new LocalizedItem(chkForAll, "ConflictDialog_ApplyForAllChechbox"),
          };
      }

      #endregion // --- Localization ---

      private void btnReplace_Click(object sender, EventArgs e)
      {
         decision = ConflictDecision.Replace;
      }

      private void btnSkip_Click(object sender, EventArgs e)
      {
         decision = ConflictDecision.Skip;
      }

      private void btnPostpone_Click(object sender, EventArgs e)
      {
         decision = ConflictDecision.Postpone;
      }

      public ConflictDecision Decision
      {
         get { return decision; }
      }

      public bool ForAll
      {
         get { return chkForAll.Checked; }
      }
   }
}
