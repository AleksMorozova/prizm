using System;
using System.ComponentModel;
using DevExpress.XtraEditors;
using PrizmMain.DummyData;
using PrizmMain.Forms.PipeMill.Heat;
using Ninject;
using Ninject.Parameters;
using System.Windows.Forms;

namespace PrizmMain.Forms.PipeMill.NewEdit
{
    public partial class MillPipeNewEditXtraForm : XtraForm
    {

        MillPipeNewEditViewModel viewModel;

        public MillPipeNewEditXtraForm(Guid pipeId)
        {
            InitializeComponent();

            viewModel = (MillPipeNewEditViewModel)Program
                .Kernel
                .Get<MillPipeNewEditViewModel>(
                new ConstructorArgument("pipeId", pipeId));
        }

        public MillPipeNewEditXtraForm() : this(Guid.Empty) { }


        private void MillPipeNewEditXtraForm_Load(object sender, EventArgs e)
        {
            BindCommands();
            BindToViewModel();
        }


        private void BindToViewModel()
        {
            pipeNewEditBindingSource.DataSource = viewModel;

            //TODO: Please change the combo box filling 
            // after introduction the logic of new heat creating
            foreach (var h in viewModel.Heats)
                heatNumber.Properties.Items.Add(h);

            //TODO: Please change the combo box filling 
            // after introduction the logic of new PurchaseOrders creating
            foreach (var p in viewModel.PurchaseOrders)
                purchaseOrder.Properties.Items.Add(p);

            //TODO: Please change the combo box filling 
            // after introduction the logic of new pipeSize creating
            foreach (var t in viewModel.PipeTypes)
                pipeSize.Properties.Items.Add(t);

            

            pipeNumber.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "Number");
            length.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "Length");
            weight.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "Weight");
            diameter.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "Diameter");
            thickness.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "WallThickness");
            deactivate.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "PipeIsActive");
            plateThickness.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "PlateThickness");


            pipeSize.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "PipeMillSizeType");


            heatNumber.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "Heat");


            steelGrade.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "SteelGrade");

            purchaseOrder.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "PipePurchaseOrder");
            purchaseOrderDate.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "PurchaseOrderDate");

            
            railcarNumber.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "RailcarNumber");
            shippedDate.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "RailcarShippingDate");
            certificateNumber.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "RailcarCertificate");
            destanation.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "RailcarDestination");
            









        }

        private void editHeatButton_Click(object sender, EventArgs e)
        {
            using (var heatForm = (HeatXtraForm)Program.Kernel.Get<HeatXtraForm>(new ConstructorArgument("heatNumber", heatNumber.Text)))
            {
                if (heatForm.ShowDialog() == DialogResult.OK)
                {
                    //TODO: refresh Heat data
                }
            }
           
        }
    


        private void BindCommands()
        {
            saveButton.BindCommand(() => viewModel.NewEditCommand.Execute(), viewModel.NewEditCommand);
        }



    }

}