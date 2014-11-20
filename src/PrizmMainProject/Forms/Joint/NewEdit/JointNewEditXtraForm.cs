using System.ComponentModel;
using DevExpress.XtraEditors;
using PrizmMain.DummyData;

namespace PrizmMain.Forms.Joint.NewEdit
{
    public partial class JointNewEditXtraForm : XtraForm
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
            inspectorName.Text = "Иванов Иван";
            controlDate.Text = "10/10/2014";
            result.Text = "Принят";
            controlType.Text = "Изоляция стыка";
        }
    }
}