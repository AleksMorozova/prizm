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
            generalReportTypes.DataSource = viewModel.InspectionCategories;
            generalReportTypes.DisplayMember = "Name";
            generalReportTypes.ValueMember = "Id";
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
            StringBuilder ids = new StringBuilder();
            foreach (var item in generalReportTypes.CheckedItems)
            {
                var category = item as Category;
                if (category != null)
                    checkedItems.Add(category.Id);
                    //ids.Append("N'" + category.Id + "',");
            }
          //  ids.Remove(ids.Length - 1, 1);
            viewModel.SearchIds = checkedItems;
                //ids.ToString();
        }
    }
}