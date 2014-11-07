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
            plateManufacturer.Text = "Завод 1";
            plateThickness.Text = "124";
            steelGrade.Text = "10Г2А";

            coatingType.Properties.Items.Add("наружное");
            coatingType.Properties.Items.Add("внутреннее");

            millStatus.Properties.Items.Add("в производстве");
            millStatus.Properties.Items.Add("на складе");
            millStatus.Properties.Items.Add("отгружена");

            pipeSize.Properties.Items.Add("1100х20; 15 15,0мм");
            pipeSize.Properties.Items.Add("1219х17,5; 20,6; 27,0мм");

            heatNumber.Properties.Items.Add("2136215");
            heatNumber.Properties.Items.Add("2363634");

            purchaseOrder.Properties.Items.Add("2576214");
            purchaseOrder.Properties.Items.Add("3682554");

            var inspectionDs = new PrizmMain.DummyData.InspectionDummy();
            var inspectionData = inspectionDs.GetDummyInspection();
            inspectionOperation.DataSource = inspectionData;

            BindingList<Coating> coatingList = new BindingList<Coating>();
            coatingList.Add(new Coating { Date = "18.10.2014", Type = "наружное" });
            coatingList.Add(new Coating { Date = "20.10.2014", Type = "внутреннее" });

            coatingHistory.DataSource = coatingList;

            var weldingDs = new PrizmMain.DummyData.WeldersDummy();
            var weldingData = weldingDs.GetCmpDummy();
            weldingHistory.DataSource = weldingData;

        }
    }


    public class Coating
    {
        public string date;
        public string type;

        public String Date
        {
            get { return this.date; }
            set { this.date = value; }
        }
        public String Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
    }
}