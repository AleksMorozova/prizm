using System;
using System.ComponentModel;
using DevExpress.XtraEditors;
using PrizmMain.DummyData;

using Ninject.Parameters;
using Ninject;

namespace PrizmMain.Forms.PipeMill.NewEdit
{
    public partial class MillPipeNewEditXtraForm : XtraForm
    {

        private MillPipeNewEditViewModel viewModel;

        public MillPipeNewEditXtraForm(string pipeNumber)
            : this()
        {
            viewModel = (MillPipeNewEditViewModel)Program
                .Kernel
                .Get<MillPipeNewEditViewModel>(
                new ConstructorArgument("pipeNumber", pipeNumber));
        }

        public MillPipeNewEditXtraForm()
        {
            InitializeComponent();
            
            #region
            
            pipeSize.Text = "1219х17,5; 20,6; 27,0мм";
            heatNumber.Text = "4573278";
            purchaseOrder.Text = "3647787";
            purchaseOrderDate.Text = "10.10.2014";
            pipeCreationDate.Text = "04.11.2014";
            millStatus.Text = "на складе";

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

            var inspectionDs = new InspectionDummy();
            BindingList<Inspection> inspectionData = inspectionDs.GetDummyInspection();
            inspectionOperation.DataSource = inspectionData;

            var coatingList = new BindingList<Coating>
            {
                new Coating {Date = "18.10.2014", Type = "наружное"},
                new Coating {Date = "20.10.2014", Type = "внутреннее"}
            };

            coatingHistory.DataSource = coatingList;

            var weldingDs = new WeldersDummy();
            BindingList<weldHistory> weldingData = weldingDs.GetCmpDummy();
            weldingHistory.DataSource = weldingData;
            #endregion


       
        }

        private void MillPipeNewEditXtraForm_Load(object sender, EventArgs e)
        {
            if (viewModel != null)
            {
                BindCommands();
                BindToViewModel();
            }

        }


        private void BindToViewModel()
        {
            pipeNewEditBindingSource.DataSource = viewModel;

            pipeNumber.DataBindings.Add("EditValue", pipeNewEditBindingSource, "Number");

            length.DataBindings.Add("EditValue", pipeNewEditBindingSource, "Length");
            weight.DataBindings.Add("EditValue", pipeNewEditBindingSource, "Weight");
            diameter.DataBindings.Add("EditValue", pipeNewEditBindingSource, "Diameter");
            thickness.DataBindings.Add("EditValue", pipeNewEditBindingSource, "WallThickness");

            plateManufacturer.DataBindings.Add("EditValue", pipeNewEditBindingSource, "Mill");

        }

        private void BindCommands()
        {
            saveButton.BindCommand(() => viewModel.NewEditCommand.Execute(), viewModel.NewEditCommand);
        }




    }


    public class Coating
    {
        public string date;
        public string type;

        public String Date
        {
            get { return date; }
            set { date = value; }
        }

        public String Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}