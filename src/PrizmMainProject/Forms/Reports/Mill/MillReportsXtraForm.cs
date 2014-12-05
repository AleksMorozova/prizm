using System;
using System.Collections.Generic;

using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraReports.UI;

using PrizmMain.DummyData;
using PrizmMain.Forms.MainChildForm;
using DevExpress.XtraReports.Parameters;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using Domain.Entity.Mill;
using System.Text;
using DevExpress.XtraEditors.Controls;
using PrizmMain.Common;

namespace PrizmMain.Forms.Reports.Mill
{
    public partial class MillReportsXtraForm : ChildForm
    {
        private MillReportsViewModel viewModel;

        public MillReportsXtraForm()
        {
            InitializeComponent();
        }

        private void BindToViewModel()
        {
            millReportsBindingSource.DataSource = viewModel;
            startDate.DataBindings.Add("EditValue", millReportsBindingSource, "StartDate");
            endDate.DataBindings.Add("EditValue", millReportsBindingSource, "EndDate");
            previewReportDocument.DataBindings.Add("DocumentSource", millReportsBindingSource, "PreviewSource");
            testCategories.DataSource = viewModel.InspectionCategories;
            testCategories.DisplayMember = "Name";
            testCategories.ValueMember = "Id";
            statuses.DataSource = viewModel.Statuses;
            statuses.DisplayMember = "Text";
            statuses.ValueMember = "Name";
            foreach (EnumWrapper<ReportType> item in viewModel.ReportTypes)
            {
                reportTypes.Properties.Items.Add(new RadioGroupItem(item.Value, item.Text));
            }

            reportTypes.DataBindings.Add("EditValue", millReportsBindingSource, "SelectedReportType");

        }

        private void BindCommands()
        {
            createReportButton.BindCommand(() => viewModel.CreateCommand.Execute(), viewModel.CreateCommand);
            previewButton.BindCommand(() => viewModel.PreviewCommand.Execute(), viewModel.PreviewCommand);
        }

        private void MillReportsXtraForm_Load(object sender, EventArgs e)
        {
            viewModel = (MillReportsViewModel)Program.Kernel.GetService(typeof(MillReportsViewModel));
            BindToViewModel();
            BindCommands();
            viewModel.StartDate = DateTime.Now.Date;
            viewModel.EndDate = DateTime.Now.Date;
        }

        private void generalReportTypes_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            List<Guid> checkedItems = new List<Guid>();
            foreach (var item in testCategories.CheckedItems)
            {
                var category = item as Category;
                if (category != null)
                    checkedItems.Add(category.Id);
            }
            viewModel.SearchIds = checkedItems;
        }

        private void reportTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = (ReportType)reportTypes.Properties.Items[reportTypes.SelectedIndex].Value;
            viewModel.SelectedReportType = selected;
            testCategories.Enabled = true;
            statuses.Enabled = true;
            if (selected != ReportType.ByCategories)
            {
                testCategories.Enabled = false;
                statuses.Enabled = false;
            }
            
        }

        private void statuses_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            List<string> statusList = new List<string>();
            foreach (var item in statuses.CheckedItems)
            {
                var status = item as EnumWrapper<PipeTestResultStatus>;
                if (status != null)
                    statusList.Add(status.Value.ToString());
            }
            viewModel.SearchStatuses = statusList;
        }


    }
}