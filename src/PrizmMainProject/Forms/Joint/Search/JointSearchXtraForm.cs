using DevExpress.XtraEditors;

using PrizmMain.DummyData;

using PrizmMain.Forms.MainChildForm;

namespace PrizmMain.Forms.Joint.Search
{
    public partial class JointSearchXtraForm : ChildForm
    {
        public JointSearchXtraForm()
        {
            InitializeComponent();
            gridControlSerchResult.DataSource = JointsDummy.GetAllJoints();
        }
    }
}