using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Ninject;
using Ninject.Parameters;
using PrizmMain.Forms.MainChildForm;
using System.Linq;
using System.Collections.Generic;
using Domain.Entity.Mill;

namespace PrizmMain.Forms.PipeMill.Heat
{
    public partial class HeatXtraForm : ChildForm
    {

        private HeatViewModel viewModel;

        public HeatXtraForm() : this("")
        {

        }

        public HeatXtraForm(string heatNumber)
        {
            InitializeComponent();
            viewModel = (HeatViewModel)Program.Kernel.Get<HeatViewModel>(new ConstructorArgument("heatNumber", heatNumber));
        }

        private void HeatXtraForm_Load(object sender, EventArgs e)
        {
            BindCommands();
            BindToViewModel();
        }

        private void BindToViewModel()
        {
            bindingSource.DataSource = viewModel;
            steelGrade.DataBindings.Add("EditValue", bindingSource, "SteelGrade");

            //number.Properties.DataSource = viewModel.Heats;
            //number.EditValue = number.Properties.GetKeyValue(0);

            //plateManufacturer.Properties.DataSource = viewModel.Manufacrurers;
            plateManufacturer.DataBindings.Add("EditValue", bindingSource, "Manufacturers");
            number.DataBindings.Add("EditValue", bindingSource, "Heats");

        }

        private void BindCommands()
        {
            saveButton.BindCommand(() => viewModel.SaveCommand.Execute(), viewModel.SaveCommand);
        }

        private void HeatXtraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            viewModel.Dispose();
            viewModel = null;
        }

        private void number_EditValueChanged(object sender, EventArgs e)
        {
            Guid id = (Guid)(sender as GridLookUpEdit).EditValue;
            viewModel.SetHeat(id);
        }
    }
}