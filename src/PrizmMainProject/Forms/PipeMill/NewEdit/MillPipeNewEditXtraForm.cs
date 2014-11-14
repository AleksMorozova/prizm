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

        public MillPipeNewEditXtraForm(string pipeNumber)
        {
            InitializeComponent();

            viewModel = (MillPipeNewEditViewModel)Program
                .Kernel
                .Get<MillPipeNewEditViewModel>(
                new ConstructorArgument("pipeNumber", pipeNumber));
        }

        public MillPipeNewEditXtraForm(): this("") { }


        private void MillPipeNewEditXtraForm_Load(object sender, EventArgs e)
        {
            BindCommands();
            BindToViewModel();
        }


        private void BindToViewModel()
        {
            pipeNewEditBindingSource.DataSource = viewModel;

            pipeNumber.DataBindings.Add("EditValue", pipeNewEditBindingSource, "Number");

            length.DataBindings.Add("EditValue", pipeNewEditBindingSource, "Length");
            weight.DataBindings.Add("EditValue", pipeNewEditBindingSource, "Weight");
            diameter.DataBindings.Add("EditValue", pipeNewEditBindingSource, "Diameter");
            thickness.DataBindings.Add("EditValue", pipeNewEditBindingSource, "WallThickness");

            deactivate.DataBindings.Add("EditValue", pipeNewEditBindingSource, "PipeIsActive");
            plateThickness.DataBindings.Add("EditValue", pipeNewEditBindingSource, "PlateThickness");

            heatNumber.DataBindings.Add("EditValue", pipeNewEditBindingSource, "HeatNumber");

            viewModel.ExtractHeatsCommand.Execute();

            foreach (var h in viewModel.Heats)
            {
                heatNumber.Properties.Items.Add(h);
            }

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