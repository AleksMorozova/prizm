using System;
using System.ComponentModel;
using System.Windows.Forms;

using DevExpress.XtraEditors;

using Ninject;
using Ninject.Parameters;

using Domain.Entity.Setup;
using Domain.Entity.Mill;
using PrizmMain.DummyData;
using PrizmMain.Forms.PipeMill.Heat;
using PrizmMain.Forms.MainChildForm;

namespace PrizmMain.Forms.PipeMill.NewEdit
{
    public partial class MillPipeNewEditXtraForm : ChildForm
    {

        MillPipeNewEditViewModel viewModel;

        public MillPipeNewEditXtraForm(Guid pipeId)
        {
            InitializeComponent();

            viewModel = (MillPipeNewEditViewModel)Program
                .Kernel
                .Get<MillPipeNewEditViewModel>(
                new ConstructorArgument("pipeId", pipeId));

            purchaseOrderDate.Properties.NullDate = DateTime.MinValue;
            purchaseOrderDate.Properties.NullText = string.Empty;

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


            foreach (var h in viewModel.Heats)
            {
                heatNumber.Properties.Items.Add(h);
            }

            foreach (var p in viewModel.PurchaseOrders)
            {
                purchaseOrder.Properties.Items.Add(p);
            }

            foreach (var t in viewModel.PipeTypes)
            {
                pipeSize.Properties.Items.Add(t);
            }


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


            steelGrade.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "SteelGrade");


            heatNumber.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "Heat");
            pipeSize.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "PipeMillSizeType");
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


        private void heatNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewModel.Heat = heatNumber.SelectedItem as Domain.Entity.Mill.Heat;
            ((MillPipeNewEditCommand)viewModel.NewEditCommand).IsExecutable =
                !((MillPipeNewEditCommand)viewModel.NewEditCommand).IsExecutable;
        }

        private void pipeSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewModel.PipeMillSizeType = pipeSize.SelectedItem as PipeMillSizeType;
            ((MillPipeNewEditCommand)viewModel.NewEditCommand).IsExecutable =
                !((MillPipeNewEditCommand)viewModel.NewEditCommand).IsExecutable;
        }

        private void purchaseOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewModel.PipePurchaseOrder = purchaseOrder.SelectedItem as PurchaseOrder;
            ((MillPipeNewEditCommand)viewModel.NewEditCommand).IsExecutable =
                !((MillPipeNewEditCommand)viewModel.NewEditCommand).IsExecutable;
        }

        private void pipeNumber_EditValueChanged(object sender, EventArgs e)
        {
            viewModel.Number = pipeNumber.Text;
            ((MillPipeNewEditCommand)viewModel.NewEditCommand).IsExecutable =
                !((MillPipeNewEditCommand)viewModel.NewEditCommand).IsExecutable;
        }
    }
}