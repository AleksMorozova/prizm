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


        private void CreateFormChild(DevExpress.XtraEditors.XtraForm frmChild)
        {
            if (FramesCanOpen > 0)
            {
                childForms.Add(frmChild);
                frmChild.MdiParent = this;
                frmChild.Show();
                frmChild.WindowState = FormWindowState.Normal;
                frmChild.WindowState = FormWindowState.Maximized;
                FramesCanOpen--;
            }
        }

        private void CreateSettingsFormChild(SettingsXtraForm frmChild, int tabpage) 
        {
            frmChild.TabControlSettings.SelectedTabPage = frmChild.TabControlSettings.TabPages[tabpage];
            CreateFormChild(frmChild);
        }

        private void barButtonItemSettingsPipe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.SettingsXtraForm frmChild = new Forms.SettingsXtraForm();
            CreateSettingsFormChild(frmChild, 0);
          
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

            CreateFormChild(frmChild);
        }

        private void barButtonItemNewComponent_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.ComponentNewEditXtraForm frmChild = new Forms.ComponentNewEditXtraForm();
            CreateFormChild(frmChild);
        }

        private void barButtonItemNewJoint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.JointNewEditXtraForm frmChild = new Forms.JointNewEditXtraForm();
            CreateFormChild(frmChild);
        }

        private void barButtonItemSettingsPipeline_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.SettingsXtraForm frmChild = new Forms.SettingsXtraForm();
            CreateSettingsFormChild(frmChild, 1);

        }

        private void barButtonItemSettingsUsers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.SettingsXtraForm frmChild = new Forms.SettingsXtraForm();
            CreateSettingsFormChild(frmChild, 2);
        }

        private void barButtonItemSettingsDictionaries_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.SettingsXtraForm frmChild = new Forms.SettingsXtraForm();
            CreateSettingsFormChild(frmChild, 3);
        }

        private void barButtonItemFindComponentry_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.ComponentSearchXtraForm frmChild = new Forms.ComponentSearchXtraForm();
            CreateFormChild(frmChild);
        }

        private void barButtonItemReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.ReportsXtraForm frmChild = new Forms.ReportsXtraForm();
            CreateFormChild(frmChild);
        }

        private void barButtonItemFindJoints_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.JointSearchXtraForm frmChild = new Forms.JointSearchXtraForm();
            CreateFormChild(frmChild);
        }

        private void barButtonItemFindPipes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.PipeSearchXtraForm frmChild = new Forms.PipeSearchXtraForm();
            CreateFormChild(frmChild);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}