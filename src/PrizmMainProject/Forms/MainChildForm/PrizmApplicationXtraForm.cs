using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using PrizmMain.Forms.Component.NewEdit;
using PrizmMain.Forms.Component.Search;
using PrizmMain.Forms.Joint.NewEdit;
using PrizmMain.Forms.Joint.Search;
using PrizmMain.Forms.PipeIncoming;
using PrizmMain.Forms.PipeMill.NewEdit;
using PrizmMain.Forms.PipeMill.Search;
using PrizmMain.Forms.Railcar.NewEdit;
using PrizmMain.Forms.Railcar.Search;
using PrizmMain.Forms.Reports.Construction;
using PrizmMain.Forms.Reports.Incoming;
using PrizmMain.Forms.Reports.Mill;
using PrizmMain.Forms.Settings;
using PrizmMain.Forms.Spool;

namespace PrizmMain.Forms.MainChildForm
{
    public partial class PrizmApplicationXtraForm : XtraForm
    {
        private static uint FramesCanOpen = 20;
        private readonly HashSet<Form> childForms = new HashSet<Form>();

        public PrizmApplicationXtraForm()
        {
            InitializeComponent();

            //TODO
            // should be deleted after demo test
            //==========================================================
            languageBarListItem.ShowChecks = true;
            languageBarListItem.Strings.Add("English (customizable)");
            languageBarListItem.Strings.Add("English (US)");
            languageBarListItem.Strings.Add("Русский");
            languageBarListItem.Strings.Add("Chinese (中國)");
            languageBarListItem.DataIndex = 2;
            //==========================================================
        }


        public void CreateFormChild(XtraForm frmChild)
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
            else
            {
                // TODO
                MessageBox.Show("No more could be opened. Close some documents.");
            }
        }

        private void CreateSettingsFormChild(SettingsXtraForm frmChild, int tabPage)
        {
            frmChild.settings.SelectedTabPage = frmChild.settings.TabPages[tabPage];
            CreateFormChild(frmChild);
        }

        private void barButtonClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            // TODO: documents manager
            Form child = ActiveMdiChild;
            if (child != null)
            {
                child.Close();
                childForms.Remove(child);
                FramesCanOpen++;
            }
        }

        private void barButtonItemNewPipe_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateFormChild((XtraForm)Program.Kernel.GetService(typeof(MillPipeNewEditXtraForm)));
        }

        private void barButtonItemNewRailcar_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateFormChild((XtraForm)Program.Kernel.GetService(typeof(RailcarNewEditXtraForm)));
        }

        private void barButtonItemMillFindEditPipes_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateFormChild((XtraForm)Program.Kernel.GetService(typeof(MillPipeSearchXtraForm)));
        }

        private void barButtonItemMillReports_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateFormChild((XtraForm)Program.Kernel.GetService(typeof(MillReportsXtraForm)));
        }

        private void barButtonItemNewComponent_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateFormChild((XtraForm)Program.Kernel.GetService(typeof(ComponentNewEditXtraForm)));
        }

        private void barButtonItemInspectionReports_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateFormChild((XtraForm)Program.Kernel.GetService(typeof(InspectionReportsXtraForm)));
        }

        private void barButtonItemInspectionFindComponentry_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateFormChild((XtraForm)Program.Kernel.GetService(typeof(ComponentSearchXtraForm)));
        }

        private void barButtonItemNewJoint_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateFormChild((XtraForm)Program.Kernel.GetService(typeof(JointNewEditXtraForm)));
        }

        private void barButtonItemFindEditJoints_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateFormChild((XtraForm)Program.Kernel.GetService(typeof(JointSearchXtraForm)));
        }

        private void barButtonItemConstructionReports_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateFormChild((XtraForm)Program.Kernel.GetService(typeof(ConstructionReportsXtraForm)));
        }

        private void barButtonItemSetingsProject_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateSettingsFormChild((SettingsXtraForm)Program.Kernel.GetService(typeof(SettingsXtraForm)), 0);
        }

        private void barButtonItemSettingsPipeline_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateSettingsFormChild((SettingsXtraForm)Program.Kernel.GetService(typeof(SettingsXtraForm)), 2);
        }

        private void barButtonItemSettingsPipe_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateSettingsFormChild((SettingsXtraForm)Program.Kernel.GetService(typeof(SettingsXtraForm)), 1);
        }

        private void barButtonItemSettingsUsers_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateSettingsFormChild((SettingsXtraForm)Program.Kernel.GetService(typeof(SettingsXtraForm)), 3);
        }

        private void barButtonItemRoles_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateSettingsFormChild((SettingsXtraForm)Program.Kernel.GetService(typeof(SettingsXtraForm)), 4);
        }

        private void barButtonItemSettingsDictionaries_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateSettingsFormChild((SettingsXtraForm)Program.Kernel.GetService(typeof(SettingsXtraForm)), 5);
        }

        private void barButtonItemFindEditShipRailcars_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateFormChild((XtraForm)Program.Kernel.GetService(typeof(RailcarSearchXtraForm)));
        }

        private void barButtonItemInspectionFindEditPipes_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateFormChild((XtraForm)Program.Kernel.GetService(typeof(InspectionPipeSearchEditXtraForm)));
        }

        private void barButtonItemSpool_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateFormChild((XtraForm)Program.Kernel.GetService(typeof(SpoolsXtraForm)));
        }

        private void barButtonItemConstructionFindEditComponentry_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateFormChild((XtraForm)Program.Kernel.GetService(typeof(ComponentSearchXtraForm)));
        }

        private void barButtonItemConstructionFindEditPipes_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateFormChild((XtraForm)Program.Kernel.GetService(typeof(InspectionPipeSearchEditXtraForm)));
        }


    }
}