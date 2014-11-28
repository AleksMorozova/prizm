using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PrizmMain.Documents;
using PrizmMain.Properties;

namespace PrizmMain.Forms.MainChildForm
{
    public class ChildForm : XtraForm, IModifiable
    {
        private void InitializeComponent()
        {
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (this.IsModified)
            {
                DialogResult result =
                    XtraMessageBox.Show(
                        Resources.IDS_QUESTION_DO_NOT_CLOSE,
                        Resources.IDS_QUESTION_DO_NOT_CLOSE_HEADER,
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
            base.OnFormClosing(e);
        }

        public virtual bool IsModified { get; set; }

        public event System.Action<bool> Modified;
    }
}