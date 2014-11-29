﻿using System;
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
            number.DataBindings.Add("EditValue", bindingSource, "Heat");
            plateManufacturer.DataBindings.Add("EditValue", bindingSource, "PlateManufacturer");

            foreach (var item in viewModel.Heats)
            {
                number.Properties.Items.Add(item);
            }

            foreach (var item in viewModel.Manufacrurers)
            {
                plateManufacturer.Properties.Items.Add(item);
            }
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

        private void RefreshControls()
        {
            number.Refresh();
            plateManufacturer.Refresh();
            steelGrade.Refresh();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            viewModel.NewHeat("");
            number.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
        }
    }
}