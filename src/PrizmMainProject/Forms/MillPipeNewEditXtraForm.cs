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
    public partial class MillPipeNewEditXtraForm : DevExpress.XtraEditors.XtraForm
    {
        public MillPipeNewEditXtraForm()
        {
            InitializeComponent();
            pipeNumber.Text = "125276";
            pipeSize.Text = "1219х17,5; 20,6; 27,0мм";
            heatNumber.Text = "4573278";
            purchaseOrder.Text = "3647787";
            purchaseOrderDate.Text = "10.10.2014";
            pipeCreationDate.Text = "04.11.2014";
            millStatus.Text = "на складе";
            length.Text = "4215";
            weight.Text = "2414";
            diameter.Text = "525";
            thickness.Text = "63";


            var inspectionDs = new PrizmMain.DummyData.InspectionDummy();
            var inspectionData = inspectionDs.GetDummyInspection();
            inspectionOperation.DataSource = inspectionData;

        }
    }
}