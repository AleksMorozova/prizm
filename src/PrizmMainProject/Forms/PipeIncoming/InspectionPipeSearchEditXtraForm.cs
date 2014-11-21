using DevExpress.XtraEditors;

using PrizmMain.Forms.MainChildForm;

namespace PrizmMain.Forms.PipeIncoming
{
    public partial class InspectionPipeSearchEditXtraForm : ChildForm
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