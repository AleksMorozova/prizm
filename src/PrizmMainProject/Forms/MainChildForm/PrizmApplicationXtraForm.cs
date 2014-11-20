using System;
using System.Collections.Generic;
using System.Windows.Forms;

using DevExpress.XtraBars;
using DevExpress.XtraEditors;

using Ninject.Parameters;
using Ninject;

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

using PrizmMain.Properties;

namespace PrizmMain.Forms.MainChildForm
{
    public partial class PrizmApplicationXtraForm : XtraForm
    {
        private static uint FramesCanOpen = 20;
        private readonly Dictionary<string, List<ChildForm>> childForms = new Dictionary<string, List<ChildForm>>();

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

        private bool IsSingle(string formTypeName)
        {
            bool isSingle = false;

            switch (formTypeName)
            { 
                case "SettingsXtraForm":
                    isSingle = true;
                    break;
                default:
                    break;
            }
            return isSingle;
        }

        private ChildForm CreateReturnChildForm(System.Type formType, params IParameter[] parameters)
        {
            ChildForm newlyCreatedForm = null;

            if (typeof(ChildForm).IsAssignableFrom(formType))
            {
                if (!childForms.ContainsKey(formType.Name))
                {
                    childForms.Add(formType.Name, new List<ChildForm>());
                }
                List<ChildForm> forms = childForms[formType.Name];

                if (IsSingle(formType.Name) && forms.Count > 0)
                {
                    // no more forms could be created. activate existing form
                    forms[0].Activate();
                }
                else if (FramesCanOpen < 1)
                {
                    XtraMessageBox.Show(
                        Resources.IDS_NO_MORE_DOCUMENTS,
                        Resources.IDS_NO_MORE_DOCUMENTS,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    newlyCreatedForm = (ChildForm)Program.Kernel.Get(formType, parameters);
                    childForms[formType.Name].Add(newlyCreatedForm);
                    newlyCreatedForm.MdiParent = this;
                    FramesCanOpen--;
                }
            }
            else
            {
                throw new ApplicationException(String.Format("Could not create child form {0} because not of child type.", formType.Name));
            }
            return newlyCreatedForm;
        }

        private void ShowChildForm(XtraForm form)
        {
            form.Show();
            form.WindowState = FormWindowState.Normal;
            form.WindowState = FormWindowState.Maximized;
        }

        public void CreateChildForm(System.Type formType, params IParameter[] parameters)
        {
            ChildForm form = CreateReturnChildForm(formType, parameters);
            if (form != null)
            {
                ShowChildForm(form);
            }
        }

        public void CreateSettingsChildForm(int page, params IParameter[] parameters)
        {
            SettingsXtraForm form = (SettingsXtraForm)CreateReturnChildForm(typeof(SettingsXtraForm), parameters);

            if (form != null)
            {
                form.settings.SelectedTabPage = form.settings.TabPages[page];
                ShowChildForm(form);
            }
        }

        private void barButtonItemNewPipe_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateChildForm(typeof(MillPipeNewEditXtraForm));
        }

        private void barButtonItemNewRailcar_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateChildForm(typeof(RailcarNewEditXtraForm));
        }

        private void barButtonItemMillFindEditPipes_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateChildForm(typeof(MillPipeSearchXtraForm));
        }

        private void barButtonItemMillReports_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateChildForm(typeof(MillReportsXtraForm));
        }

        private void barButtonItemNewComponent_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateChildForm(typeof(ComponentNewEditXtraForm));
        }

        private void barButtonItemInspectionReports_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateChildForm(typeof(InspectionReportsXtraForm));
        }

        private void barButtonItemInspectionFindComponentry_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateChildForm(typeof(ComponentSearchXtraForm));
        }

        private void barButtonItemNewJoint_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateChildForm(typeof(JointNewEditXtraForm));
        }

        private void barButtonItemFindEditJoints_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateChildForm(typeof(JointSearchXtraForm));
        }

        private void barButtonItemConstructionReports_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateChildForm(typeof(ConstructionReportsXtraForm));
        }

        private void barButtonItemSetingsProject_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateSettingsChildForm(page: 0);
        }

        private void barButtonItemSettingsPipeline_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateSettingsChildForm(page: 2);
        }

        private void barButtonItemSettingsPipe_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateSettingsChildForm(page: 1);
        }

        private void barButtonItemSettingsUsers_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateSettingsChildForm(page: 3);
        }

        private void barButtonItemRoles_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateSettingsChildForm(page: 4);
        }

        private void barButtonItemSettingsDictionaries_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateSettingsChildForm(page: 5);
        }

        private void barButtonItemFindEditShipRailcars_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateChildForm(typeof(RailcarSearchXtraForm));
        }

        private void barButtonItemInspectionFindEditPipes_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateChildForm(typeof(InspectionPipeSearchEditXtraForm));
        }

        private void barButtonItemSpool_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateChildForm(typeof(SpoolsXtraForm));
        }

        private void barButtonItemConstructionFindEditComponentry_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateChildForm(typeof(ComponentSearchXtraForm));
        }

        private void barButtonItemConstructionFindEditPipes_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateChildForm(typeof(InspectionPipeSearchEditXtraForm));
        }
    }
}