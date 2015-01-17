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

namespace Prizm.Main.Forms.Joint
{
    public partial class JointCutDialog : DevExpress.XtraEditors.XtraForm
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
    }
}