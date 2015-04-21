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

      public void  SetConflictDialog(string msg)
      {
          this.decision = ConflictDecision.Undefined;
          this.chkForAll.Checked = false;
          lblDesc.Text = msg;
      }

      #region --- Localization ---

      protected override List<LocalizedItem> CreateLocalizedItems()
      {
          return new List<LocalizedItem>()
          {
              new LocalizedItem(lblTitle, StringResources.ConflictDialog_ConflictLabel.Id),
              new LocalizedItem(btnReplace,StringResources.ConflictDialog_ReplaceButton.Id),
              new LocalizedItem(btnSkip, StringResources.ConflictDialog_SkipButton.Id),
              new LocalizedItem(btnPostpone, StringResources.ConflictDialog_PostponeButton.Id),
              new LocalizedItem(chkForAll, StringResources.ConflictDialog_ApplyForAllChechbox.Id),

              new LocalizedItem(this, localizedHeader, new string[] {StringResources.ConflictDialog_Title.Id} )
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
