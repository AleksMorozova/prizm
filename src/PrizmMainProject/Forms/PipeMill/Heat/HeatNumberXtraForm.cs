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
using Prizm.Main.Common;

namespace Prizm.Main.Forms.PipeMill.Heat
{
    public partial class HeatNumberXtraForm : DevExpress.XtraEditors.XtraForm
    {
        private ComboBoxEdit number1;


        public HeatNumberXtraForm(string number)
        {
            InitializeComponent();
            SetControlsTextLength();
            this.number.Text = number;
        }

        public HeatNumberXtraForm(ComboBoxEdit number1)
        {
            // TODO: Complete member initialization
            this.number1 = number1;
        }

        public string Number { get { return number.Text; } }

        private void SetControlsTextLength()
        {
            number.Properties.MaxLength = LengthLimit.MaxHeatNumber;
            number.SetAsIdentifier();
        }
    }
}