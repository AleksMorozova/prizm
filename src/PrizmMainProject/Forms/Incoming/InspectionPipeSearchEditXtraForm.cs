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
using DevExpress.XtraEditors.Controls;

namespace PrizmMain.Forms
{
    public partial class InspectionPipeSearchEditXtraForm : DevExpress.XtraEditors.XtraForm
    {
        public InspectionPipeSearchEditXtraForm()
        {
            InitializeComponent();
            pipeNumber.Text = "2434637";
            certificateNumber.Text = "73426376";
            unloadedDate.Text = "11.09.2014";
            millLength.Text = "10";
            millThickness.Text = "3";
            millDiameter.Text = "20";
            millWeight.Text = "3";
            millHeatNumber.Text = "142526";
            inspectionLength.Text = "10";
            inspectionThickness.Text = "3";
            inspectionDiameter.Text = "20";
            inspectionWeight.Text = "3";
            inspectionHeatNumber.Text = "142526";

        }
    }
}