using System;
using System.Windows.Forms;

using DevExpress.XtraEditors;

using Ninject;
using Ninject.Parameters;

using Prizm.Domain.Entity.Mill;
using Prizm.Domain.Entity;
using Prizm.Main.Forms.MainChildForm;
using System.Collections.Generic;
using Prizm.Main.Properties;
using Prizm.Main.Common;
using Prizm.Main.Forms.ExternalFile;
using Prizm.Main.Commands;
using Prizm.Main.Documents;
using Prizm.Main.Security;
using DevExpress.XtraGrid.Views.Base;
using Prizm.Main.Languages;
using System.Drawing;
using Prizm.Main.Controls;

namespace Prizm.Main.Forms.ReleaseNote.NewEdit
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class ReleaseNoteNewEditXtraForm : ChildForm, IValidatable, INewEditEntityForm
    {
        private bool formLeave = false;
        private ICommandManager commandManager = new CommandManager();
        private ReleaseNoteViewModel viewModel;
        private ExternalFilesXtraForm filesForm = null;
        ISecurityContext ctx = Program.Kernel.Get<ISecurityContext>();
        public bool IsMatchedByGuid(Guid id) { return this.Id == id; }
        private List<string> localizedAllShipStatus = new List<string>(2) { "unshipped", "shipped" };
        private void UpdateTextEdit()
        {
            bindingSource.CancelEdit();
        }
        public ReleaseNoteNewEditXtraForm(Guid id)
        {
            this.Id = id;

            InitializeComponent();
            viewModel = (ReleaseNoteViewModel)Program.Kernel.Get<ReleaseNoteViewModel>(new ConstructorArgument("id", id));
            viewModel.ModifiableView = this;
            viewModel.validatableView = this;
            viewModel.PropertyChanged += (s, e) => IsModified = true;

            releaseNoteDate.Properties.NullDate = DateTime.MinValue;
            releaseNoteDate.Properties.NullText = string.Empty;

            this.releaseNoteDate.SetRequiredText();
            this.releaseNoteNumber.SetRequiredText();
            SetControlsTextLength();
            this.certificateNumber.SetAsIdentifier();
            this.pipeNumberLookUp.SetAsLookUpIdentifier();
            this.releaseNoteNumber.SetAsIdentifier();
            this.railcarNumber.SetAsLookUpIdentifier();

            SetAlwaysReadOnly(textEditReleaseNoteStatus);
            IsEditMode = true; //do not remove until IsEditMode logic is changed
            IsEditMode = ctx.HasAccess(global::Domain.Entity.Security.Privileges.EditReleaseNote);
            attachmentsButton.Enabled = true;

            CannotOpenForViewing = id == Guid.Empty;
        }

        public ReleaseNoteNewEditXtraForm() : this(Guid.Empty) { }

        private void RailcarNewEditXtraForm_Load(object sender, EventArgs e)
        {
            foreach(var item in EnumWrapper<PipeMillStatus>.EnumerateItems())
            {
                localizedAllPipeMillStatus.Add(item.Item2);
            }

            BindCommands();
            BindToViewModel();
            IsModified = false;
            IsEditMode = !viewModel.Shipped && ctx.HasAccess(global::Domain.Entity.Security.Privileges.EditReleaseNote);

            releaseNoteDate.SetLimits();
        }

        #region --- Localization ---

        private List<string> localizedAllPipeMillStatus = new List<string>();

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
                // layout items
                new LocalizedItem(releasedNoteNumberLayout, StringResources.ReleaseNoteNewEdit_ReleaseNumberLabel.Id),
                new LocalizedItem(releasedNoteDateLayout, StringResources.ReleaseNoteNewEdit_ReleaseDateLabel.Id),
                new LocalizedItem(railcarNumberLayout, StringResources.ReleaseNoteNewEdit_RailcarNumberLabel.Id),
                new LocalizedItem(certificateNumberLayout, StringResources.ReleaseNoteNewEdit_CertificateLabel.Id),
                new LocalizedItem(layoutControlDestination, StringResources.ReleaseNoteNewEdit_DestinationLabel.Id),
                new LocalizedItem(pipeNumberLayout, StringResources.ReleaseNoteNewEdit_PipeNumberLayout.Id),
                new LocalizedItem(layoutReleaseNoteStatus, StringResources.ReleaseNoteNewEdit_StatusLayout.Id),

                //buttons
                new LocalizedItem(addPipeButton, StringResources.ReleaseNoteNewEdit_AddPipeButton.Id),
                new LocalizedItem(removePipe, StringResources.ReleaseNoteNewEdit_RemovePipeButton.Id),
                new LocalizedItem(attachmentsButton, StringResources.ReleaseNoteNewEdit_AttachmentsButton.Id),
                new LocalizedItem(shipButton, StringResources.ReleaseNoteNewEdit_ShipButton.Id),
                new LocalizedItem(unshipButton, StringResources.ReleaseNoteNewEdit_UnshipButton.Id),
                new LocalizedItem(saveButton, StringResources.ReleaseNoteNewEdit_SaveButton.Id),

                //columns
                new LocalizedItem(pipeNumberGridColumn, StringResources.ReleaseNoteNewEdit_PipeNumberColumn.Id),
                new LocalizedItem(pipeSizeGridColumn, StringResources.ReleaseNoteNewEdit_PipeTypeSizeColumn.Id),
                new LocalizedItem(pipeStatusGridColumn, StringResources.ReleaseNoteNewEdit_PipeStatusColumn.Id),
                new LocalizedItem(railcarNumberGridColumn, StringResources.ReleaseNoteNewEdit_RailcarNumberColumn.Id),
                new LocalizedItem(railcarCertificateGridColumn, StringResources.ReleaseNoteNewEdit_RailcarCertificateColumn.Id),
                new LocalizedItem(railcarDestinationGridColumn, StringResources.ReleaseNoteNewEdit_RailcarDestinationColumn.Id),

                new LocalizedItem(railcarLayoutControlGroup, StringResources.ReleaseNoteNewEdit_RailcarLayoutControlGroup.Id),
                new LocalizedItem(addPipeLayoutGroup, StringResources.ReleaseNoteNewEdit_AddPipeLayoutGroup.Id),
                new LocalizedItem(pipesListLayoutGroup, StringResources.ReleaseNoteNewEdit_PipesListLayoutGroup.Id),
                new LocalizedItem(releaseNoteLayoutGroup, StringResources.ReleaseNoteNewEdit_ReleaseNoteLayoutGroup.Id),

                 // one-way by-column transformation statuses.
                // See grid's CustomColumnDisplayText for all grid's columns, to understand the connection.
                // one localized item per column. 
                // the same ...CustomColumnDisplayText method must be used for all columns,
                // but private localized list (f.e. localizedAllPipeMillStatus) is different for each column. 
                new LocalizedItem(pipesListView, localizedAllPipeMillStatus,
                    new string [] { 
                        StringResources.SearchPipe_MillStatusUndefined.Id, 
                        StringResources.SearchPipe_MillStatusProduced.Id, 
                        StringResources.SearchPipe_MillStatusStocked.Id, 
                        StringResources.SearchPipe_MillStatusShipped.Id, 
                        StringResources.SearchPipe_ReadyToShip.Id }),

                new LocalizedItem(this, localizedHeader, new string[] {StringResources.ReleaseNoteNewEdit_Title.Id} ),

                new LocalizedItem(UpdateTextEdit, localizedAllShipStatus,
                        new string [] {StringResources.ReleaseNoteNewEdit_PendingStatus.Id, StringResources.ReleaseNoteNewEdit_ShippedStatus.Id })
            };
        }

        #endregion // --- Localization ---

        private void BindToViewModel()
        {
            bindingSource.DataSource = viewModel;

            railcarNumber.Properties.DataSource = viewModel.Railcars;
            railcarNumber.DataBindings.Add("EditValue", bindingSource, "Railcar");

            certificateNumber.DataBindings.Add("EditValue", bindingSource, "Certificate");
            destination.DataBindings.Add("EditValue", bindingSource, "Destination");
            pipesList.DataBindings.Add("DataSource", bindingSource, "ReleaseNotePipes");
            releaseNoteNumber.DataBindings.Add("EditValue", bindingSource, "Number");
            releaseNoteDate.DataBindings.Add("EditValue", bindingSource, "Date");

            textEditReleaseNoteStatus.DataBindings.Add(BindingHelper.CreateOneWayReadToString("Text", bindingSource, "Shipped",
                (value) =>
                {
                    return (bool)value ? localizedAllShipStatus[1] : localizedAllShipStatus[0];
                }));

            pipeNumberLookUp.Properties.DataSource = viewModel.AllPipesToAdd;
            pipeNumberLookUp.Properties.DisplayMember = "Number";
            pipeNumberLookUp.Properties.ValueMember = "Id";
        }

        private void BindCommands()
        {
            commandManager["Save"].Executor(viewModel.SaveCommand).AttachTo(saveButton);
            commandManager["Ship"].Executor(viewModel.ShipCommand).AttachTo(shipButton);
            commandManager["Unship"].Executor(viewModel.UnshipCommand).AttachTo(unshipButton);
            commandManager.RefreshVisualState();
            //refresh state of railcar information only at save because at save command we remove empty railcar
            viewModel.SaveCommand.RefreshVisualStateEvent += railcarNumber.Refresh;
            viewModel.SaveCommand.RefreshVisualStateEvent += certificateNumber.Refresh;
            viewModel.SaveCommand.RefreshVisualStateEvent += destination.Refresh;
            viewModel.SaveCommand.RefreshVisualStateEvent += commandManager.RefreshVisualState;
            viewModel.ShipCommand.RefreshVisualStateEvent += commandManager.RefreshVisualState;
            viewModel.UnshipCommand.RefreshVisualStateEvent += commandManager.RefreshVisualState;

        }

        private void RailcarNewEditXtraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            commandManager.Dispose();
            viewModel.Dispose();
            viewModel = null;
        }

        private void addPipeButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(pipeNumberLookUp.Text))
            {
                viewModel.AddPipe((Guid)pipeNumberLookUp.EditValue);
                pipesList.RefreshDataSource();
                pipeNumberLookUp.EditValue = null;
                pipeNumberLookUp.Properties.DataSource = viewModel.AllPipesToAdd;
                IsModified = true;
                commandManager.RefreshVisualState();
                pipeNumberLookUp.ClosePopup();
            }

        }

        private void removePipe_Click(object sender, EventArgs e)
        {
            Prizm.Main.Forms.ReleaseNote.NewEdit.ReleaseNoteViewModel.PlainPipe pipe =
                pipesListView.GetRow(pipesListView.FocusedRowHandle) as Prizm.Main.Forms.ReleaseNote.NewEdit.ReleaseNoteViewModel.PlainPipe;
            if(pipe != null)
            {
                viewModel.RemovePipe(pipe);
                pipesList.RefreshDataSource();
                pipeNumberLookUp.Properties.DataSource = viewModel.AllPipesToAdd;
                IsModified = true;
                commandManager.RefreshVisualState();
            }
        }

        private void SetControlsTextLength()
        {
            railcarNumber.Properties.MaxLength = LengthLimit.MaxRailcarNumber;
            destination.Properties.MaxLength = LengthLimit.MaxRailcarDestination;
            certificateNumber.Properties.MaxLength = LengthLimit.MaxRailcarCertificate;
            releaseNoteNumber.Properties.MaxLength = LengthLimit.MaxReleaseNoteNumber;
        }

        private void RailcarNewEditXtraForm_Activated(object sender, EventArgs e)
        {
            if(formLeave)
            {
                viewModel.GetStoredPipes();
                // pipeNumberLookUp.Properties.DataSource = viewModel.AllPipesToAdd;
                pipeNumberLookUp.Refresh();
            }
        }

        private void AttachmentsButton_Click(object sender, EventArgs e)
        {
            if(filesForm == null)
            {
                filesForm = new ExternalFilesXtraForm();
                viewModel.FilesFormViewModel = filesForm.ViewModel;
            }
            viewModel.FilesFormViewModel.RefreshFiles(viewModel.ReleaseNote.Id);
            filesForm.SetData(IsEditMode);
            filesForm.ShowDialog();
        }

        #region IValidatable Members

        bool IValidatable.Validate()
        {
            return dxValidationProvider.Validate();
        }

        #endregion

        private void railcarNumber_EditValueChanged(object sender, EventArgs e)
        {
            certificateNumber.Refresh();
            destination.Refresh();
        }

        private void releaseNoteNumber_EditValueChanged(object sender, EventArgs e)
        {

            commandManager.RefreshVisualState();
        }

        private void releaseNoteDate_EditValueChanged(object sender, EventArgs e)
        {

            commandManager.RefreshVisualState();
        }

        private void railcarNumber_QueryCloseUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var currentRailcar = sender as LookUpEdit;
            viewModel.Railcar = currentRailcar.EditValue as Prizm.Domain.Entity.Mill.Railcar;

        }

        private void railcarNumber_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e)
        {
            Prizm.Domain.Entity.Mill.Railcar r = new Prizm.Domain.Entity.Mill.Railcar
            {
                Number = railcarNumber.Text,
                Certificate = "",
                Destination = ""
            };

            viewModel.Railcars.Add(r);
            railcarNumber.EditValue = viewModel.Railcar = r;
            e.Handled = true;
        }

        private void pipesListView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if(e.Column.Name == pipeStatusGridColumn.Name)
            {
                PipeMillStatus result;
                if(Enum.TryParse<PipeMillStatus>(e.Value.ToString(), out result))
                {
                    e.DisplayText = localizedAllPipeMillStatus[(int)result];
                }
            }
        }

        private void ReleaseNoteNewEditXtraForm_Leave(object sender, EventArgs e)
        {
            formLeave = true;
        }

    }
}
