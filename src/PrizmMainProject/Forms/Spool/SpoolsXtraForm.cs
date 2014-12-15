using DevExpress.XtraEditors;
using Domain.Entity.Construction;
using Domain.Entity.Mill;
using PrizmMain.Forms.ExternalFile;
using PrizmMain.Forms.MainChildForm;
using PrizmMain.Properties;
using System.Collections.Generic;

namespace PrizmMain.Forms.Spool
{
    [System.ComponentModel.DesignerCategory("Form")] 
    public partial class SpoolsXtraForm : ChildForm
    {         
        private SpoolViewModel viewModel;
        private Dictionary<PartInspectionStatus, string> inspectionStatusDict
           = new Dictionary<PartInspectionStatus, string>();

        public SpoolsXtraForm()
        {
            InitializeComponent();
            viewModel = (SpoolViewModel)Program.Kernel.GetService(typeof(SpoolViewModel));
            viewModel.ModifiableView = this;
            IsEditMode = true;
        }

        private void BindToViewModel()
        {
            SpoolBindingSource.DataSource = viewModel;

            pipeNumber.DataBindings
                .Add("EditValue", SpoolBindingSource, "PipeNumber");

            pipeLength.DataBindings
                .Add("EditValue", SpoolBindingSource, "PipeLength");

            spoolNumber.DataBindings
                .Add("EditValue", SpoolBindingSource, "SpoolNumber");

            spoolLength.DataBindings
                .Add("EditValue", SpoolBindingSource, "SpoolLength");

            pipeNumber.Properties.DataSource = viewModel.allPipes;

            inspectionHistory.DataBindings
               .Add("DataSource", SpoolBindingSource, "InspectionTestResults");

            inspectionStatusDict.Clear();
            inspectionStatusDict.Add(PartInspectionStatus.Accepted, Resources.Accepted);
            inspectionStatusDict.Add(PartInspectionStatus.Hold, Resources.Hold);
            inspectionStatusDict.Add(PartInspectionStatus.Rejected, Resources.Rejected);
            inspectionStatusDict.Add(PartInspectionStatus.Pending, Resources.Pending);
            resultLookUpEdit.DataSource = inspectionStatusDict;

            //inspectorsPopupContainerEdit.DataSource = viewModel.Inspectors;
            //inspectorsPopupContainerEdit.ListChanged += (s, eve) => IsModified = true;
            //inspectorSelectionControl.DataSource = inspectorsDataSource;
            //var inspectorsPopup = new PopupContainerControl();
            //inspectorsPopup.Controls.Add(inspectorSelectionControl);
            //inspectorSelectionControl.Dock = DockStyle.Fill;
            //inspectorsPopupContainerEdit.PopupControl = inspectorsPopup;
            //inspectorsPopupContainerEdit.PopupControl.MaximumSize = inspectorsPopup.MaximumSize;

        }

        private void BindCommands()
        {
            searchButton.BindCommand(() => viewModel.SearchCommand.Execute(), viewModel.SearchCommand);
            cutButton.BindCommand(() => viewModel.CutCommand.Execute(), viewModel.CutCommand);
            saveButton.BindCommand(() => viewModel.SaveCommand.Execute(), viewModel.SaveCommand);
        }

        private void SpoolsXtraForm_Load(object sender, System.EventArgs e)
        {
            BindCommands();
            BindToViewModel();

            viewModel.PropertyChanged += (s, eve) => IsModified = true;
            pipeLength.Properties.ReadOnly = true;
        }

        private void cutButton_Click(object sender, System.EventArgs e)
        {
            Domain.Entity.Construction.Spool s = viewModel.Spool;
        }

        private void attachmentsButton_Click(object sender, System.EventArgs e)
        {
            ExternalFilesXtraForm attachments = new ExternalFilesXtraForm();
            attachments.ShowDialog();
        }

    }
}