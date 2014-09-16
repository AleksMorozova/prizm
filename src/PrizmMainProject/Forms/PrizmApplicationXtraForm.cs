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

namespace PrizmMain.Forms
{
    public partial class PrizmApplicationXtraForm : DevExpress.XtraEditors.XtraForm
    {
        private HashSet<Form> childForms = new HashSet<Form>();
        private static uint FramesCanOpen = 1;

        public PrizmApplicationXtraForm()
        {
            InitializeComponent();
        }

        private void barButtonItemSettingsPipe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FramesCanOpen > 0)
            {
                Forms.SettingsXtraForm frmChild = new Forms.SettingsXtraForm();
                childForms.Add(frmChild);
                frmChild.MdiParent = this;
                frmChild.Show();
                frmChild.WindowState = FormWindowState.Maximized;
                FramesCanOpen--;
            }
        }

        private void barButtonClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // TODO: documents manager
            Form child = this.ActiveMdiChild;
            if (child != null)
            {
                child.Close();
                childForms.Remove(child);
                FramesCanOpen++;
            }
        }
    }
}