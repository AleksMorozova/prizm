using DevExpress.XtraEditors;
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
   public partial class ConflictDialog : XtraForm
   {
      ConflictDecision decision = ConflictDecision.Undef;

      public ConflictDialog()
      {
         InitializeComponent();
      }

      public ConflictDialog(string msg)
      {
         InitializeComponent();

         lblDesc.Text = msg;
      }

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
