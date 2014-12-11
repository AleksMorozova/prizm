using System.ComponentModel;
using DevExpress.XtraEditors;
using PrizmMain.Forms.MainChildForm;
using PrizmMain.Forms.ExternalFile;
using System;
using Ninject;
using Ninject.Parameters;
using DevExpress.XtraEditors.Controls;
using PrizmMain.Properties;

namespace PrizmMain.Forms.Joint.NewEdit
{
    public partial class JointNewEditXtraForm : ChildForm
    {
        JointNewEditViewModel viewModel;

        public JointNewEditXtraForm(Guid jointId)
        {
            InitializeComponent();
            viewModel = (JointNewEditViewModel)Program
               .Kernel
               .Get<JointNewEditViewModel>(
               new ConstructorArgument("jointId", jointId));
            viewModel.ModifiableView = this;
            loweringDate.Properties.NullText = String.Empty;
            loweringDate.Properties.NullDate = DateTime.MinValue;
        }

        public JointNewEditXtraForm() : this(Guid.Empty) { }



        private void extraFiles_Click(object sender, System.EventArgs e)
        {
            ExternalFilesXtraForm attachments = new ExternalFilesXtraForm();
            attachments.ShowDialog();
        }


        private void BindToViewModel()
        {
            jointNewEditBindingSoure.DataSource = viewModel;

            jointNumber.DataBindings
                .Add("EditValue", jointNewEditBindingSoure, "Number");
            deactivated.DataBindings
               .Add("EditValue", jointNewEditBindingSoure, "IsNotActive");
            loweringDate.DataBindings
               .Add("EditValue", jointNewEditBindingSoure, "LoweringDate");
            GPSLat.DataBindings
                .Add("EditValue", jointNewEditBindingSoure, "GpsLatitude");
            GPSLong.DataBindings
                .Add("EditValue", jointNewEditBindingSoure, "GpsLongitude");
            seaLevel.DataBindings
                .Add("EditValue", jointNewEditBindingSoure, "GpsHeight");
            PKNumber.DataBindings
                .Add("EditValue", jointNewEditBindingSoure, "NumberKP");
            distanceFromPK.DataBindings
                .Add("EditValue", jointNewEditBindingSoure, "DistanceFromKP");
            pipelinePiecesBindingSource.DataSource = viewModel.Pieces;
            SetLookup(firstJointElement);
            SetLookup(secondJointElement);

        }

        /// <summary>
        /// Grid columns lookup setup
        /// </summary>
        private void SetLookup(LookUpEdit lookup)
        {
            lookup.Properties.DataSource = pipelinePiecesBindingSource;
            LookUpColumnInfoCollection firstEllementColumns = lookup.Properties.Columns;
            firstEllementColumns.Add(new LookUpColumnInfo("number", Resources.Number));
            firstEllementColumns.Add(new LookUpColumnInfo("type", Resources.Type));
            firstEllementColumns.Add(new LookUpColumnInfo("diameter", Resources.Diameter));
            firstEllementColumns.Add(new LookUpColumnInfo("wallThickness", Resources.WallThickness));
            firstEllementColumns.Add(new LookUpColumnInfo("length", Resources.Length));
            firstEllementColumns.Add(new LookUpColumnInfo("id", Resources.Id));
            firstEllementColumns[5].Visible = false;
            lookup.Properties.DisplayMember = "number";
            lookup.Properties.ValueMember = "id";
        }

        private void BindCommands()
        {
            saveButton.BindCommand(() => viewModel.SaveJointCommand.Execute(), viewModel.SaveJointCommand);
        }

        private void JointNewEditXtraForm_Load(object sender, EventArgs e)
        {
            BindCommands();
            BindToViewModel();
        }

        private void jointNumber_EditValueChanged(object sender, EventArgs e)
        {
            viewModel.Number = jointNumber.Text;
            viewModel.SaveJointCommand.IsExecutable ^= true;
        }

    }
}