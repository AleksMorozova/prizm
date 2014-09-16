using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace PrizmMain.Forms
{
    public class ChildForm : DevExpress.XtraEditors.XtraForm
    {
        // TOREMOVE:
        private class Document : Documents.IDocument {
            private bool needToSave = false;
            public bool NeedToSave { get { return needToSave; } }
            public void Save() { } 
        };
        private Documents.IDocument doc = new Document();

        private void InitializeComponent()
        {

        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            // TODO: if doc doesn't exist it should be handled

            if (doc.NeedToSave)
            {
                System.Windows.Forms.DialogResult result =
                    DevExpress.XtraEditors.XtraMessageBox.Show(
                        PrizmMain.Properties.Resources.IDS_QUESTION_SAVE, 
                        PrizmMain.Properties.Resources.IDS_QUESTION_SAVE,
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Warning);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    doc.Save();
                }
                else if (result == System.Windows.Forms.DialogResult.No)
                {
                    // TODO: should this be audited?
                }
                else // consider everything else as Cancel (don't save, don't close)
                {
                    e.Cancel = true;
                }
            }
            base.OnClosing(e);
        }
    }
}
