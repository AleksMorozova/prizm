using System;
using System.Collections.Generic;
using System.Windows.Forms;

using DevExpress.XtraBars;
using DevExpress.XtraEditors;

using Ninject.Parameters;
using Ninject;

using Prizm.Main.Forms.Component.NewEdit;
using Prizm.Main.Forms.Joint.NewEdit;
using Prizm.Main.Forms.Joint.Search;
using Prizm.Main.Forms.PipeMill.NewEdit;
using Prizm.Main.Forms.PipeMill.Search;
using Prizm.Main.Forms.ReleaseNote.NewEdit;
using Prizm.Main.Forms.ReleaseNote.Search;
using Prizm.Main.Forms.Reports.Construction;
using Prizm.Main.Forms.Reports.Incoming;
using Prizm.Main.Forms.Reports.Mill;
using Prizm.Main.Forms.Settings;
using Prizm.Main.Forms.Spool;

using Prizm.Main.Properties;
using DevExpress.XtraBars.Alerter;
using Prizm.Main.Forms.PipeMill.Heat;
using Prizm.Main.Forms.Audit;
using Prizm.Main.Forms.Parts.Search;
using Prizm.Main.Forms.Parts.Inspection;
using Prizm.Main.Forms.Common;
using PrizmMain.Forms.Notifications;
using DevExpress.XtraSplashScreen;
using Prizm.Main.Forms.Notifications;
using Prizm.Main.Security;
using Domain.Entity.Security;
using Prizm.Main.Forms.Synch;
using System.Linq;
using Prizm.Main.Forms.Reports.Construction.PipeReport;
using System.Globalization;
using System.Resources;
using Prizm.Main.Forms.Reports.Construction.WeldDateReports;
using Prizm.Main.Languages;
using Prizm.Domain.Entity.Setup;
using System.Drawing;
using Prizm.Main.Common;

namespace Prizm.Main.Forms.MainChildForm
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class PrizmApplicationXtraForm : PrizmForm, IUserNotify
    {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(PrizmApplicationXtraForm));
        private PrizmApplicationViewModel viewModel;

        private const string emptyString = "";

        private int previousLanguageBarItemIndex = -1;

        public PrizmApplicationXtraForm()
        {
            InitializeComponent();
        }

        #region Menu buttons
        private void barButtonItemNewPipe_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormManager.Instance.OpenChildForm(DocumentTypes.MillPipe);
        }

        private void barButtonItemNewRailcar_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormManager.Instance.OpenChildForm(DocumentTypes.MillReleaseNote);
        }

        private void barButtonItemMillFindEditPipes_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormManager.Instance.OpenChildForm(DocumentTypes.MillPipeSearch);
        }

        private void barButtonItemMillReports_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormManager.Instance.OpenChildForm(DocumentTypes.MillReport);
        }

        private void barButtonItemNewComponent_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormManager.Instance.OpenChildForm(DocumentTypes.ConstructionComponent);
        }

        private void barButtonItemInspectionReports_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormManager.Instance.OpenChildForm(DocumentTypes.InspectionReport);
        }

        private void barButtonItemNewJoint_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormManager.Instance.OpenChildForm(DocumentTypes.ConstructionJoint);
        }

        private void barButtonItemFindEditJoints_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormManager.Instance.OpenChildForm(DocumentTypes.ConstructionJointSearch);
        }

        private void barButtonItemPartIncomingInspection_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormManager.Instance.OpenChildForm(DocumentTypes.InspectionPart);
        }

        private void pipeConstructionRepoBarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormManager.Instance.OpenChildForm(DocumentTypes.ConstructionPipeReport);
        }

        private void weldConstructionRepoBarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormManager.Instance.OpenChildForm(DocumentTypes.ConstructionWeldDateReport);
        }

        private void barButtonItemConstructionReports_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormManager.Instance.OpenChildForm(DocumentTypes.ConstructionTracingReport);
        }

        private void barButtonItemSettingsProject_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormManager.Instance.OpenSettingsChildForm(page: 0);
        }

        private void barButtonItemSettingsPipeline_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormManager.Instance.OpenSettingsChildForm(page: 2);
        }

        private void barButtonItemSettingsPipe_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormManager.Instance.OpenSettingsChildForm(page: 1);
        }

        private void barButtonItemSettingsUsers_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormManager.Instance.OpenSettingsChildForm(page: 6);
        }

        private void barButtonItemRoles_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormManager.Instance.OpenSettingsChildForm(page: 7);
        }

        private void barButtonItemSettingsWelders_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormManager.Instance.OpenSettingsChildForm(page: 4);
        }

        private void barButtonItemSettingsInspectors_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormManager.Instance.OpenSettingsChildForm(page: 5);
        }

        private void barButtonItemComponentry_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormManager.Instance.OpenSettingsChildForm(page: 3);
        }

        private void barButtonItemFindEditShipRailcars_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormManager.Instance.OpenChildForm(DocumentTypes.MillReleaseNoteSearch);
        }

        private void barButtonItemInspectionFindEditPipes_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormManager.Instance.OpenChildForm(DocumentTypes.InspectionPartSearch);
        }

        private void barButtonItemSpool_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormManager.Instance.OpenChildForm(DocumentTypes.ConstructionSpool);
        }

        private void barButtonItemFindEditParts_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormManager.Instance.OpenChildForm(DocumentTypes.InspectionPartSearch);
        }

        private void barButtonItemAudit_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            FormManager.Instance.OpenChildForm(DocumentTypes.Audit);
        }

        private void btnHistoryExportImport_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormManager.Instance.OpenChildForm(DocumentTypes.ExportImportHistory);
        }
        #endregion


        #region IUserNotify
        /// <summary>
        /// Error message that requires user confirmation (OK)
        /// </summary>
        /// <param name="text"></param>
        /// <param name="header"></param>
        public void ShowError(string text, string header)
        {
            XtraMessageBox.Show(text, header, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// Warning message that requires user confirmation (OK)
        /// </summary>
        /// <param name="text">message body</param>
        /// <param name="header">message header</param>
        public void ShowWarning(string text, string header)
        {
            XtraMessageBox.Show(text, header, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        /// <summary>
        /// Informational message that requires user confirmation (OK)
        /// </summary>
        /// <param name="text">message body</param>
        /// <param name="header">message header</param>
        public void ShowInfo(string text, string header)
        {
            XtraMessageBox.Show(text, header, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Message that requires user confirmation or denial (yes/no)
        /// </summary>
        /// <param name="text">message body</param>
        /// <param name="header">message header</param>
        /// <returns>true if yes, false if no</returns>
        public bool ShowYesNo(string text, string header)
        {
            YesNoDialog dlg = new YesNoDialog(text, header);
            return dlg.ShowDialog() == DialogResult.Yes;
        }
        /// <summary>
        /// Message that requires user confirmation, denial or operation cancellation (yes/no/cancel)
        /// Now is not used. In case of using to avoid problems with localization it is better to
        /// create own dialog form, similar to YesNoDialog
        /// </summary>
        /// <param name="text">message body</param>
        /// <param name="header">message header</param>
        /// <returns>1 if yes, 0 if no, -1 if cancel</returns>
        public int ShowYesNoCancel(string text, string header)
        {
            DialogResult dlg = XtraMessageBox.Show(text, header, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            sbyte result;
            switch(dlg)
            {
                case DialogResult.Cancel:
                    result = -1;
                    break;
                case DialogResult.No:
                    result = 0;
                    break;
                case DialogResult.Yes:
                    result = 1;
                    break;
                default:
                    var e = new ArgumentOutOfRangeException(string.Format("Unknown dialog answer - {0}", dlg));
                    log.Error(e.Message);
                    throw e;
            }
            return result;
        }
        /// <summary>
        /// Message about success, that doesn't require user confirmation.
        /// </summary>
        /// <param name="text">message body</param>
        /// <param name="header">message header</param>
        public void ShowSuccess(string text, string header)
        {
            StatusNotifyText(text);

        }
        /// <summary>
        /// Message about failure, that doesn't require user confirmation.
        /// </summary>
        /// <param name="text">message body</param>
        /// <param name="header">message header</param>
        public void ShowFailure(string text, string header)
        {
            StatusNotifyText(text);
        }
        /// <summary>
        /// Informational message, that doesn't require user confirmation.
        /// </summary>
        /// <param name="text">message body</param>
        /// <param name="header">message header</param>
        public void ShowNotify(string text, string header)
        {
            StatusNotifyText(text);
        }

        private void StatusNotifyText(string text)
        {
            Program.MainForm.UpdateStatusBar(string.Format("[{0}] - {1}", DateTime.Now.ToShortTimeString().Trim(), text));
        }

        private int currentProcessingStep;
        private int targetProcessingSteps;

        /// <summary>
        /// Show wait form. Call it at times when UI thread will be unresponsible
        /// For now used 1. on Executing commands through the CommandManager
        ///              2. when creating and showing child forms
        /// </summary>
        /// <param name="text">message body, optional</param>
        /// <param name="header">message header, optional</param>
        /// <param name="steps">overall steps provide to show progress bar, and on each step call IncProcessingState(), optional</param>
        public void ShowProcessing(string text = "", string header = "", int steps = 0)
        {
            targetProcessingSteps = steps;
            currentProcessingStep = 0;
            SplashScreenManager.ShowForm(this, typeof(AppWaitForm), false, false, false);
            if(!string.IsNullOrEmpty(header))
                SplashScreenManager.Default.SetWaitFormCaption(header);
            if(!string.IsNullOrEmpty(text))
                SplashScreenManager.Default.SetWaitFormDescription(text);
            Application.DoEvents();
        }

        /// <summary>
        /// Hide wait form, when UI thread will be responsible again
        /// </summary>
        public void HideProcessing()
        {
            SplashScreenManager.CloseForm(false);
        }

        /// <summary>
        /// SavePipeState progress on wait form, should be called on each processing step
        /// of the long processing with known number of steps.
        /// To init progress on the wait form you should previously call ShowProcessing(, , steps) 
        /// </summary>
        public void IncProcessingState()
        {
            currentProcessingStep++;
            float percent = (float)currentProcessingStep / targetProcessingSteps * 100;
            SplashScreenManager.Default.SetWaitFormDescription(percent.ToString() + "%");
        }
        #endregion

        private void PrizmApplicationXtraForm_Load(object sender, EventArgs e)
        {
            viewModel = (PrizmApplicationViewModel)Program.Kernel.GetService(typeof(PrizmApplicationViewModel));

            localizedHeader.Clear();

            localizedHeader.Add(Resources.MainWindowHeader_Title);  // usage of Resources is OK - setting default values here
            localizedHeader.Add(WorkstationType.Mill.ToString());
            localizedHeader.Add(WorkstationType.Master.ToString());
            localizedHeader.Add(WorkstationType.Construction.ToString());

            CreateLanguageBarListItem();
            ProvideAccessToMenuItems();
            localizedNotificationPanelButton.Add(barButtonStatusNotifications.Caption);
            NotificationService.Instance.LoadAllNotifications();
            NotificationService.Instance.NotificationsChanged += OnNotificationRefresh;

            barVersionInfo.Caption = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            
        }
        
        private void barButtonItemAbout_ItemClick(object sender, ItemClickEventArgs e)
        {
            AboutXtraForm form = new AboutXtraForm();
            form.ShowDialog();
        }

        private void barButtonItemExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close(); //Application.Exit() causes  iteration the Application.OpenForms collection which is modified 
                          //similar problem: http://stackoverflow.com/questions/1312885/application-exit-vs-application-exitthread-vs-environment-exit
        }

        public void UpdateStatusBar(string text)
        {
            notifyBarStaticItem.Caption = text;
            notifyHistory.Items.Add(text);
            while(notifyHistory.Items.Count > Constants.StatusNotifyHistorySize)
            {
                notifyHistory.Items.RemoveAt(notifyHistory.ItemCount-1);
            }
        }

        private void notifyBarStaticItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(flyoutPanel.Visible)
            {
                flyoutPanel.HidePopup();
            }
            else
            {
                flyoutPanel.ShowPopup();
            }

        }

        private void barButtonStatusNotifications_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNotificationForm();
        }

        private void ShowNotificationForm()
        {
            FormManager.Instance.OpenChildForm(DocumentTypes.Notifications);
        }

        /// <summary>
        /// SavePipeState count system notification on status bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnNotificationRefresh(object sender, EventArgs e)
        {
            int NotificationCount = NotificationService.Instance.NotificationCount;
            UpdateNumberOfNotification();
        }

        private void importantMessages_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNotificationForm();
        }

        private void ProvideAccessToMenuItems()
        {
            ISecurityContext ctx = Program.Kernel.Get<ISecurityContext>();
            barButtonItemAudit.Enabled = ctx.HasAccess(Privileges.Audit);
            
            barButtonItemSettingsProject.Enabled =
                barButtonItemSettingsPipe.Enabled =
                barButtonItemSettingsPipeline.Enabled =
                barButtonItemComponentry.Enabled =
                barButtonItemSettingsWelders.Enabled =
                barButtonItemSettingsInspectors.Enabled =
                barButtonItemSettingsUsers.Enabled =
                barButtonItemRoles.Enabled = ctx.HasAccess(Privileges.ViewSettings) || ctx.HasAccess(Privileges.EditSettings);

            //Reports
            barButtonItemMillReports.Enabled = ctx.HasAccess(Privileges.PrintMillReports);
            pipeConstructionRepoBarButton.Enabled = ctx.HasAccess(Privileges.PrintConstructionReports);
            weldConstructionRepoBarButton.Enabled = ctx.HasAccess(Privileges.PrintWeldDateReport);
            barButtonItemConstructionReports.Enabled = ctx.HasAccess(Privileges.PrintWeldTracingReport);
            

            barButtonItemInspectionReports.Enabled = ctx.HasAccess(Privileges.PrintInspectionReports);
            barButtonItemNewPipe.Enabled = ctx.HasAccess(Privileges.CreatePipe);
            barButtonItemNewRailcar.Enabled = ctx.HasAccess(Privileges.CreateReleaseNote);
            barButtonItemNewJoint.Enabled = ctx.HasAccess(Privileges.CreateJoint);
            barButtonItemNewComponent.Enabled = ctx.HasAccess(Privileges.CreateComponent);
            barButtonItemSpool.Enabled = ctx.HasAccess(Privileges.CreateSpool) || ctx.HasAccess(Privileges.EditSpool);
            barButtonItemExport.Enabled = ctx.HasAccess(Privileges.ExportDataFromMaster) || ctx.HasAccess(Privileges.ExportDataFromConstruction) || ctx.HasAccess(Privileges.ExportDataFromMill);
            barButtonItemImport.Enabled = ctx.HasAccess(Privileges.ImportDataAtMaster) || ctx.HasAccess(Privileges.ImportDataAtConstruction);

            btnHistoryExportImport.Enabled = ctx.HasAccess(Privileges.ViewExportImportHistory);

            barButtonItemFindEditJoints.Enabled = ctx.HasAccess(Privileges.SearchJoints);

            barButtonItemFindEditParts.Enabled = ctx.HasAccess(Privileges.SearchParts);

            barButtonItemPartIncomingInspection.Enabled = ctx.HasAccess(Privileges.PartsInspection);

            barButtonItemMillFindEditPipes.Enabled = ctx.HasAccess(Privileges.SearchPipes);

            barButtonItemFindEditShipRailcars.Enabled = ctx.HasAccess(Privileges.SearchReleaseNotes);
        }

        private Dictionary<int, CultureInfo> cultures = new Dictionary<int, CultureInfo>();

        private void CreateLanguageBarListItem()
        {
            cultures.Clear();
            languageBarListItem.ShowChecks = true;
            int indexDefault = 0;
            var list = Program.LanguageManager.GetCultures(out indexDefault);
            foreach (var culture in list)
            {
                int index = languageBarListItem.Strings.Add(culture.EnglishName + ", " + culture.NativeName);
                cultures[index] = culture;
            }
            previousLanguageBarItemIndex = languageBarListItem.DataIndex = indexDefault;
        }

        private void barButtonItemExport_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormManager.Instance.OpenChildForm(DocumentTypes.Export);
        }

        private void barButtonItemImport_ItemClick(object sender, ItemClickEventArgs e)
        {
           ImportForm form = Program.Kernel.Get<ImportForm>();
           form.ShowDialog();
        }
        /// <summary>
        /// On choosing language in main program menu
        /// </summary>
        /// <param name="sender">menu item</param>
        /// <param name="e">list item click parameters</param>
        private void languageBarListItem_ListItemClick(object sender, ListItemClickEventArgs e)
        {
            int index = languageBarListItem.DataIndex;
            if (cultures.ContainsKey(e.Index) && Program.LanguageManager.LoadTranslation(cultures[e.Index]))
            {
                CascadeChangeLanguage();
            }
            else
            {
                languageBarListItem.DataIndex = previousLanguageBarItemIndex;
                // ShowError(); TODO: write message about being not able to change language
            }
        }

        /// <summary>
        /// Main window will modify own text according to current language, and impel it's children to do so.
        /// </summary>
        void CascadeChangeLanguage()
        {
            Program.LanguageManager.ChangeLanguage(this);
            System.Threading.Thread.CurrentThread.CurrentCulture = Program.LanguageManager.CurrentCulture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = Program.LanguageManager.CurrentCulture;

            foreach (var child in FormManager.Instance.ChildForms)
            {
                ILocalizable localizable = child as ILocalizable;
                Program.LanguageManager.ChangeLanguage(child as ILocalizable);
            }

        }


        #region --- Localization ---

        // do NOT re-create it because reference passed to localization item. Clean it instead.
        protected List<string> localizedNotificationPanelButton = new List<string>();
        void UpdateNumberOfNotification()
        {
            barButtonStatusNotifications.Caption = localizedNotificationPanelButton[0];
            barButtonStatusNotifications.Caption += " (" + NotificationService.Instance.NotificationCount+")";
        }

        public override void UpdateTitle()
        {
            // base.UpdateTitle(); should not be called
            this.Text = string.Concat(localizedHeader[0], " [", 
                viewModel.ProjectSettings.WorkstationType == WorkstationType.Mill 
                ? localizedHeader[1]
                : viewModel.ProjectSettings.WorkstationType == WorkstationType.Master
                    ? localizedHeader[2]
                    : viewModel.ProjectSettings.WorkstationType == WorkstationType.Construction
                        ? localizedHeader[3]
                        : ""
            , "]");

            if (!string.IsNullOrWhiteSpace(viewModel.ProjectSettings.Title))
            {
                this.Text = string.Concat(this.Text, " [", viewModel.ProjectSettings.Title, "]");
            }
        }

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
                // menu items
                new LocalizedItem(barSubItemApplication, "Menu_File"),
                new LocalizedItem(barButtonItemExport, "Menu_File_Export"),
                new LocalizedItem(barButtonItemImport, "Menu_File_Import"),
                new LocalizedItem(btnHistoryExportImport, StringResources.Menu_File_HistoryExportImport.Id),
                new LocalizedItem(barButtonItemExit, "Menu_File_Exit"),
                new LocalizedItem(barSubItemMill, "Menu_Mill"),
                new LocalizedItem(barButtonItemNewPipe, "Menu_Mill_NewPipe"),
                new LocalizedItem(barButtonItemMillFindEditPipes, "Menu_Mill_SearchPipes"),
                new LocalizedItem(barButtonItemNewRailcar, "Menu_Mill_NewReleaseNote"),
                new LocalizedItem(barButtonItemFindEditShipRailcars, "Menu_Mill_SearchReleaseNotes"),
                new LocalizedItem(barButtonItemMillReports, "Menu_Mill_Reports"),
                new LocalizedItem(barSubItemConstruction, "Menu_Construction"),
                new LocalizedItem(barButtonItemNewComponent, "Menu_Construction_NewComponent"),
                new LocalizedItem(barButtonItemNewJoint, "Menu_Construction_NewJoint"),
                new LocalizedItem(barButtonItemPartIncomingInspection, "Menu_Construction_PartIncomingInspection"),
                new LocalizedItem(barButtonItemFindEditParts, "Menu_Construction_FindParts"),
                new LocalizedItem(barButtonItemFindEditJoints, "Menu_Construction_FindJoints"),
                new LocalizedItem(barButtonItemSpool, "Menu_Construction_Spool"),
                new LocalizedItem(barButtonItemInspectionReports, "Menu_Construction_InspectionReports"),
                new LocalizedItem(pipeConstructionRepoBarButton, "Menu_Construction_PipeReports"),
                new LocalizedItem(weldConstructionRepoBarButton, "Menu_Construction_WeldReports"),
                new LocalizedItem(barButtonItemConstructionReports, "Menu_Construction_JointPKReports"),
                new LocalizedItem(barSubItemSettings, "Menu_Settings"),
                new LocalizedItem(barButtonItemSettingsProject, "Menu_Settings_Project"),
                new LocalizedItem(barButtonItemSettingsPipe, "Menu_Settings_Pipe"),
                new LocalizedItem(barButtonItemSettingsPipeline, "Menu_Settings_Pipeline"),
                new LocalizedItem(barButtonItemComponentry, "Menu_Settings_Componentry"),
                new LocalizedItem(barButtonItemSettingsWelders, "Menu_Settings_Welders"),
                new LocalizedItem(barButtonItemSettingsInspectors, "Menu_Settings_Inspectors"),
                new LocalizedItem(barButtonItemSettingsUsers, "Menu_Settings_Users"),
                new LocalizedItem(barButtonItemRoles, "Menu_Settings_Roles"),
                new LocalizedItem(barSubItemLanguage, "Menu_Settings_Language"),
                new LocalizedItem(barSubItemMisc, "Menu_Misc"),
                new LocalizedItem(barButtonItemAudit, "Menu_Misc_Audit"),
                new LocalizedItem(barButtonItemImportantMessages, "Menu_Misc_ImportantMessages"),
                new LocalizedItem(barSubItemHelp, "Menu_Help"),
                new LocalizedItem(barButtonItemAbout, "Menu_Help_About"),

                // header
                new LocalizedItem(this, localizedHeader, new string[] { "MainWindowHeader_Title", 
                    "MainWindowHeader_Mill", "MainWindowHeader_Master", "MainWindowHeader_Construction" } ),

                // status bar notifications panel button
                new LocalizedItem(barButtonStatusNotifications, localizedNotificationPanelButton, 
                    new string[] {StringResources.MainWindow_StatusNotificationsHeader.Id}, UpdateNumberOfNotification),//"MainWindow_StatusNotificationsHeader"
            };
        }

        #endregion // --- Localization ---

        #region SingleInstance
        protected override void WndProc(ref Message message)
        {
            if(message.Msg == SingleInstance.WM_SHOWFIRSTINSTANCE)
            {
                ShowWindow();
            }
            base.WndProc(ref message);
        }

        
        public void ShowWindow()
        {
            // Insert code here to make your form show itself.
            WinApi.ShowToFront(this.Handle);
            ShowInfo(Program.LanguageManager.GetString(StringResources.MainWindow_SecondCopyNotification),
                Program.LanguageManager.GetString(StringResources.MainWindow_SecondCopyNotificationHeader));
        } 
        #endregion

    }
}