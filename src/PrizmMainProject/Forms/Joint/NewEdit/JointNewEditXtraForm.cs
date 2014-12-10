using System.ComponentModel;
using DevExpress.XtraEditors;
using PrizmMain.Forms.MainChildForm;
using PrizmMain.Forms.ExternalFile;

namespace PrizmMain.Forms.Joint.NewEdit
{
    public partial class JointNewEditXtraForm : ChildForm
    {
        public JointNewEditXtraForm()
        {
            InitializeComponent();
        }

        private void extraFiles_Click(object sender, System.EventArgs e)
        {
            ExternalFilesXtraForm attachments = new ExternalFilesXtraForm();
            attachments.ShowDialog();
        }
    }
}