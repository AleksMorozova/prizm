using DevExpress.XtraEditors;
using PrizmMain.DummyData;

namespace PrizmMain.Forms
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