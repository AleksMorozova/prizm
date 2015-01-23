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

namespace Prizm.Main.Forms.Synch
{
    public partial class MissingPortionsDialog : DevExpress.XtraEditors.XtraForm
    {
        public MissingPortionsDialog(string portions, string millName)
        {
            InitializeComponent();
            message.Text = string.Format(@"Последовательность импортируемых данных из {0} нарушена.
Уже существуют порции с номерами:",millName);
            portionsDiapason.Text = portions;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Yes;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
        }

    }
}