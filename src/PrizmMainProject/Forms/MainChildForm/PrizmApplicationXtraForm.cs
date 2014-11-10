using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using PrizmMain.Forms.Railcar.Edit;

namespace PrizmMain.Forms
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


        private void CreateFormChild(XtraForm frmChild)
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
            CreateFormChild(new MillPipeNewEditXtraForm());
        }

        private void barButtonItemNewRailcar_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateFormChild(new RailcarNewEditXtraForm());
        }

        private void barButtonItemMillFindEditPipes_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateFormChild(new MillPipeSearchXtraForm());
        }

        private void barButtonItemMillReports_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateFormChild(new MillReportsXtraForm());
        }

        private void barButtonItemNewComponent_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateFormChild(new ComponentNewEditXtraForm());
        }

        private void barButtonItemInspectionReports_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateFormChild(new InspectionReportsXtraForm());
        }

        private void barButtonItemInspectionFindComponentry_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateFormChild(new ComponentSearchXtraForm());
        }

        private void barButtonItemNewJoint_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateFormChild(new JointNewEditXtraForm());
        }

        private void barButtonItemFindEditJoints_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateFormChild(new JointSearchXtraForm());
        }

        private void barButtonItemConstructionReports_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateFormChild(new ConstructionReportsXtraForm());
        }

        private void barButtonItemSetingsProject_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateSettingsFormChild(new SettingsXtraForm(), 0);
        }

        private void barButtonItemSettingsPipeline_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateSettingsFormChild(new SettingsXtraForm(), 2);
        }

        private void barButtonItemSettingsPipe_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateSettingsFormChild(new SettingsXtraForm(), 1);
        }

        private void barButtonItemSettingsUsers_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateSettingsFormChild(new SettingsXtraForm(), 3);
        }

        private void barButtonItemSettingsDictionaries_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateSettingsFormChild(new SettingsXtraForm(), 5);
        }

        private void barButtonItemFindEditShipRailcars_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateFormChild(new RailcarSearchXtraForm());
        }

        private void barButtonItemInspectionFindEditPipes_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateFormChild(new InspectionPipeSearchEditXtraForm());
        }

        private void barButtonItemSpool_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateFormChild(new SpoolsXtraForm());
        }

        private void barButtonItemConstructionFindEditPipes_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateFormChild(new InspectionPipeSearchEditXtraForm());
        }

        private void barButtonItemConstructionFindEditComponentry_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateFormChild(new ComponentSearchXtraForm());
        }

        private void barButtonItemRoles_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateSettingsFormChild(new SettingsXtraForm(), 4);
        }
    }
}