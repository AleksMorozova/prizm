using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PrizmMain.Forms
{
    public partial class JointNewEditXtraForm : DevExpress.XtraEditors.XtraForm
    {
        public JointNewEditXtraForm()
        {
            InitializeComponent();
            jointNumber.Text = "1234556";
            loweringDate.Text = "10/17/2014";
            GPSLat.Text = "55.75972";
            GPSLong.Text = "37.61777";
            seaLevel.Text = "115";           
            BindingList<string> pipeList = new BindingList<string>() { "123", "556", "344" };
            BindingList<string> componentList = new BindingList<string>() { "567", "865", "677" };
            controls.DataSource = PrizmMain.DummyData.JointsDummy.GetAllControlTypes();
            inspectorName.Text = "Ivanov Ivan";
            controlDate.Text = "10/10/2014";
            result.Text = "Accepted";
            controlType.Text = "Joint isolation";
        }
    }
}