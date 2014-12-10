using DevExpress.XtraEditors;
using PrizmMain.Forms.ExternalFile;
using PrizmMain.Forms.MainChildForm;

namespace PrizmMain.Forms.Component.NewEdit
{
    [System.ComponentModel.DesignerCategory("Form")] 
    public partial class ComponentNewEditXtraForm : ChildForm
    {
        public ComponentNewEditXtraForm()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, System.EventArgs e)
        {
            ExternalFilesXtraForm attachments = new ExternalFilesXtraForm();
            attachments.ShowDialog();
        }
    }
}