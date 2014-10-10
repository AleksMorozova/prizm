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

        private void CreateSettingsFormChild(SettingsXtraForm frmChild, int tabPage) 
        {
            frmChild.settings.SelectedTabPage = frmChild.settings.TabPages[tabPage];
            CreateFormChild(frmChild);
        }

        private void barButtonItemSettingsPipe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreateSettingsFormChild(new Forms.SettingsXtraForm(), 1);
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
            CreateFormChild(new Forms.PipeNewEditXtraForm());
        }

        private void barButtonItemNewComponent_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreateFormChild(new Forms.ComponentNewEditXtraForm());
        }

        private void barButtonItemNewJoint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreateFormChild(new Forms.JointNewEditXtraForm());
        }

        private void barButtonItemSettingsPipeline_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreateSettingsFormChild(new Forms.SettingsXtraForm(), 2);
        }

        private void barButtonItemSettingsUsers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreateSettingsFormChild(new Forms.SettingsXtraForm(), 3);
        }

        private void barButtonItemSettingsDictionaries_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreateSettingsFormChild(new Forms.SettingsXtraForm(), 4);
        }

        private void barButtonItemFindComponentry_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreateFormChild(new Forms.ComponentSearchXtraForm());
        }

        private void barButtonItemReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreateFormChild(new Forms.ReportsXtraForm());
        }

        private void barButtonItemFindJoints_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreateFormChild(new Forms.JointSearchXtraForm());
        }

        private void barButtonItemFindPipes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreateFormChild(new Forms.PipeSearchXtraForm());
        }

        private void barButtonItemExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItemFindRailcar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreateFormChild(new Forms.RailcarSearchXtraForm ());
        }

        private void barButtonItemNewRailcar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreateFormChild(new Forms.RailcarNewEditXtraForm());
        }

        private void barButtonItemSetingsProject_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreateSettingsFormChild(new Forms.SettingsXtraForm(), 0);
        }

    }
}