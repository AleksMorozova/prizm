using DevExpress.XtraEditors;
using PrizmMain.DummyData;

namespace PrizmMain.Forms.Joint.Search
{
    public partial class JointSearchXtraForm : XtraForm
    {
        public JointSearchXtraForm()
        {
            InitializeComponent();
            gridControlSerchResult.DataSource = JointsDummy.GetAllJoints();
        }
    }
}