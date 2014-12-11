using DevExpress.XtraEditors;

using PrizmMain.DummyData;

using PrizmMain.Forms.MainChildForm;

namespace PrizmMain.Forms.Joint.Search
{
    [System.ComponentModel.DesignerCategory("Form")] 
    public partial class JointSearchXtraForm : ChildForm
    {
        public JointSearchXtraForm()
        {
            InitializeComponent();
            gridControlSerchResult.DataSource = JointsDummy.GetAllJoints();
        }
    }
}