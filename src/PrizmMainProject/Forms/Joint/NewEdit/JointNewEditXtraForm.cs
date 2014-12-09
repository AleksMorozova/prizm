using System.ComponentModel;

using DevExpress.XtraEditors;

using PrizmMain.DummyData;

using PrizmMain.Forms.MainChildForm;
using PrizmMain.Forms.ExternalFile;

namespace PrizmMain.Forms.Joint.NewEdit
{
    public partial class JointNewEditXtraForm : ChildForm
    {
        public JointNewEditXtraForm()
        {
            InitializeComponent();
            jointNumber.Text = "1234556";
            loweringDate.Text = "10/17/2014";
            GPSLat.Text = "55.75972";
            GPSLong.Text = "37.61777";
            seaLevel.Text = "115";
            var pipeList = new BindingList<string> {"123", "556", "344"};
            var componentList = new BindingList<string> {"567", "865", "677"};
            controls.DataSource = JointsDummy.GetAllControlTypes();
        }

        private void extraFiles_Click(object sender, System.EventArgs e)
        {
            ExternalFilesXtraForm attachments = new ExternalFilesXtraForm();
            attachments.ShowDialog();
        }
    }
}