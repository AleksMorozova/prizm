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
                frmChild.TabControlSettings.SelectedTabPage = frmChild.TabControlSettings.TabPages[0];
                frmChild.Show();

                frmChild.WindowState = FormWindowState.Normal;
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

        private void barButtonItemNewPipe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.PipeNewEditXtraForm frmChild = new Forms.PipeNewEditXtraForm();
            childForms.Add(frmChild);
            frmChild.MdiParent = this;

            frmChild.Show();
        
            frmChild.WindowState = FormWindowState.Normal;
            frmChild.WindowState = FormWindowState.Maximized;
            FramesCanOpen--;

        }

        private void barButtonItemNewComponent_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.ComponentNewEditXtraForm frmChild = new Forms.ComponentNewEditXtraForm();
            childForms.Add(frmChild);
            frmChild.MdiParent = this;
     
            frmChild.Show();

            frmChild.WindowState = FormWindowState.Normal;
            frmChild.WindowState = FormWindowState.Maximized;

            FramesCanOpen--;

        }

        private void barButtonItemNewJoint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.JointNewEditXtraForm frmChild = new Forms.JointNewEditXtraForm();
            childForms.Add(frmChild);
            frmChild.MdiParent = this;

            frmChild.Show(); 
            frmChild.WindowState = FormWindowState.Normal;
            frmChild.WindowState = FormWindowState.Maximized;

            FramesCanOpen--;
        }

        private void barButtonItemSettingsPipeline_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.SettingsXtraForm frmChild = new Forms.SettingsXtraForm();

            childForms.Add(frmChild);
            frmChild.MdiParent = this;
            frmChild.TabControlSettings.SelectedTabPage = frmChild.TabControlSettings.TabPages[1];
            frmChild.Show();

            frmChild.WindowState = FormWindowState.Normal;
            frmChild.WindowState = FormWindowState.Maximized;

            FramesCanOpen--;
        }

        private void barButtonItemSettingsUsers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.SettingsXtraForm frmChild = new Forms.SettingsXtraForm();

            childForms.Add(frmChild);
            frmChild.MdiParent = this;
            frmChild.TabControlSettings.SelectedTabPage = frmChild.TabControlSettings.TabPages[2];
            frmChild.Show();

            frmChild.WindowState = FormWindowState.Normal;
            frmChild.WindowState = FormWindowState.Maximized;

            FramesCanOpen--;
        }

        private void barButtonItemSettingsDictionaries_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.SettingsXtraForm frmChild = new Forms.SettingsXtraForm();

            childForms.Add(frmChild);
            frmChild.MdiParent = this;
            frmChild.TabControlSettings.SelectedTabPage = frmChild.TabControlSettings.TabPages[3];
            frmChild.Show();

            frmChild.WindowState = FormWindowState.Normal;
            frmChild.WindowState = FormWindowState.Maximized;

            FramesCanOpen--;
        }

        private void barButtonItemFindComponentry_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.ComponentSearchXtraForm frmChild = new Forms.ComponentSearchXtraForm();
            childForms.Add(frmChild);
            frmChild.MdiParent = this;

            frmChild.Show();
            frmChild.WindowState = FormWindowState.Normal;
            frmChild.WindowState = FormWindowState.Maximized;

            FramesCanOpen--;
        }

        private void barButtonItemReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.ReportsXtraForm frmChild = new Forms.ReportsXtraForm();
            childForms.Add(frmChild);
            frmChild.MdiParent = this;

            frmChild.Show();
            frmChild.WindowState = FormWindowState.Normal;
            frmChild.WindowState = FormWindowState.Maximized;

            FramesCanOpen--;
        }
    }
}