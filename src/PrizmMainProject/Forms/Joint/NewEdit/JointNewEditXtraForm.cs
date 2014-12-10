using System.ComponentModel;
using DevExpress.XtraEditors;
using PrizmMain.Forms.MainChildForm;
using PrizmMain.Forms.ExternalFile;
using System;
using Ninject;
using Ninject.Parameters;

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

        }

        public JointNewEditXtraForm() : this(Guid.Empty) { }



        private void extraFiles_Click(object sender, System.EventArgs e)
        {
            ExternalFilesXtraForm attachments = new ExternalFilesXtraForm();
            attachments.ShowDialog();
        }

        private void JointNewEditXtraForm_Load(object sender, EventArgs e)
        {
            BindCommands();
            BindToViewModel();
        }
        private void BindToViewModel()
        {
            jointNewEditBindingSoure.DataSource = viewModel;

            jointNumber.DataBindings
                .Add("EditValue", jointNewEditBindingSoure, "Number");
            deactivated.DataBindings
               .Add("EditValue", jointNewEditBindingSoure, "IsNotActive");

        }

        private void BindCommands()
        {
            saveButton.BindCommand(() => viewModel.SaveJointCommand.Execute(), viewModel.SaveJointCommand);
        }
    }
}