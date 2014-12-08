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
using PrizmMain.Common;

namespace PrizmMain.Forms.PipeMill.Heat
{
    public partial class HeatNumberXtraForm : DevExpress.XtraEditors.XtraForm
    {

        public HeatNumberXtraForm()
        {
            InitializeComponent();
            SetControlsTextLength();
        }

        public string Number { get { return number.Text; } }

        private void SetControlsTextLength()
        {
            number.Properties.MaxLength = LengthLimit.MaxHeatNumber;
        }
    }
}