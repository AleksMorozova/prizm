using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PrizmMain.Documents;
using PrizmMain.Properties;

namespace PrizmMain.Forms
{
    public class ChildForm : XtraForm
    {
        // TOREMOVE:

        private readonly IDocument doc = new Document();

        private void InitializeComponent()
        {
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            // TODO: if doc doesn't exist it should be handled

            if (doc.NeedToSave)
            {
                DialogResult result =
                    XtraMessageBox.Show(
                        Resources.IDS_QUESTION_SAVE,
                        Resources.IDS_QUESTION_SAVE,
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    doc.Save();
                }
                else if (result == DialogResult.No)
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

        private class Document : IDocument
        {
            private bool needToSave = false;

            public bool NeedToSave
            {
                get { return needToSave; }
            }

            public void Save()
            {
            }
        };
    }
}