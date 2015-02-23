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
using Prizm.Domain.Entity;
using Prizm.Main.Forms.MainChildForm;
using Prizm.Main.Languages;
using Prizm.Main.Properties;

namespace Prizm.Main.Forms.Joint
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class JointCutDialog : PrizmForm
    {
        private Part part1;
        private Part part2;

        public JointCutDialog()
        {
            InitializeComponent();
        }

        public JointCutDialog(Part part1, Part part2) 
            :this()
        {
            this.InitializeJointCut(part1, part2);
        }

        public void InitializeJointCut(Part part1, Part part2)
        {
            this.part1 = part1;
            this.part2 = part2;
        }

        private void JointCutDialog_Load(object sender, EventArgs e)
        {
            firstJoinedPartNumber.DataBindings
                .Add("EditValue", part1, "Number");

            secondJoinedPartNumber.DataBindings
                .Add("EditValue", part2, "Number");

            firstJoinedPartLength.DataBindings
                .Add("EditValue", part1, "Length");

            secondJoinedPartLength.DataBindings
                .Add("EditValue", part2, "Length");
        }

        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
                new LocalizedItem(firstJoinedPartGroup, StringResources.JointCutDialog_FirstJoinedPartGroup.Id),
                new LocalizedItem(firstJoinedPartNumberLayout, StringResources.JointCutDialog_FirstJoinedPartNumberLayout.Id),
                new LocalizedItem(firstJoinedPartLengthLayout, StringResources.JointCutDialog_FirstJoinedPartLengthLayout.Id),

                new LocalizedItem(secondJoinedPartGroup, StringResources.JointCutDialog_SecondJoinedPartGroup.Id),
                new LocalizedItem(secondJoinedPartNumberLayout, StringResources.JointCutDialog_SecondJoinedPartNumberLayout.Id),
                new LocalizedItem(secondJoinedPartLengthLayout, StringResources.JointCutDialog_SecondJoinedPartLengthLayout.Id),

                new LocalizedItem(cutJointButton, StringResources.JointCutDialog_CutJointButton.Id),
                new LocalizedItem(cancelButton, StringResources.JointCutDialog_CancelButton.Id),

                // header
                new LocalizedItem(this, localizedHeader, new string[] {
                    StringResources.JointCutDialog_Title.Id} )
            };
        }

        #endregion // --- Localization ---

        private void JointCutDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            firstJoinedPartNumber.DataBindings.Clear();
            secondJoinedPartNumber.DataBindings.Clear();
            firstJoinedPartLength.DataBindings.Clear();
            secondJoinedPartLength.DataBindings.Clear();
        }
    
    }
}