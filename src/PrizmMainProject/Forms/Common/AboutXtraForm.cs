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
using System.Reflection;
using Prizm.Main.Properties;

namespace Prizm.Main.Forms.Common
{
    public partial class AboutXtraForm : XtraForm
    {
        public AboutXtraForm()
        {
            InitializeComponent();
        }

        private void AboutXtraForm_Load(object sender, EventArgs e)
        {
            this.titleLabel.Text = Resources.AboutForm_TitleLabel;
        }
    }
}