using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Prizm.Main.Forms.MainChildForm;
using construction = Prizm.Domain.Entity.Construction;
using Prizm.Main.Languages;

namespace Prizm.Main.Forms.Joint.NewEdit
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class JointSelectDialog : PrizmForm
    {
        BindingList<construction.Joint> joints;
        JointNewEditViewModel viewModel;
        public JointSelectDialog(IList<construction.Joint> joints, JointNewEditViewModel viewModel)
        {
            InitializeComponent();
            SetupForm(joints, viewModel);
        }
        public void SetupForm(IList<construction.Joint> joints, JointNewEditViewModel viewModel)
        {
           BindingList<construction.Joint> bindingList = new BindingList<construction.Joint>(joints);
           this.joints = bindingList;
            this.viewModel = viewModel;
        }

        private void JointSelectDialog_Load(object sender, EventArgs e)
        {
            resultsGrid.DataSource = joints;
        }

        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
        
                // header
                new LocalizedItem (this, localizedHeader, new string[] {
                    StringResources.JointSelectDialog_Header.Id} ),
               new LocalizedItem (cancelButton, StringResources.JointSelectDialog_CancelButton.Id),
               new LocalizedItem (editButton, StringResources.JointSelectDialog_EditButton.Id),
               new LocalizedItem (resultsGridLayout, StringResources.JointSelectDialog_ResultsLayout.Id),
               new LocalizedItem (numberGridColumn, StringResources.JointSelectDialog_NumberGridColumn.Id)
            };
        }

        #endregion // --- Localization ---

        private void editButton_Click(object sender, EventArgs e)
        {
            construction.Joint selectedJoint = resultsGridView.GetRow(resultsGridView.FocusedRowHandle) as construction.Joint;
            if (selectedJoint != null)
            {
                viewModel.ChangeJoint(selectedJoint);
            }
            this.Close();
        }
    }
}