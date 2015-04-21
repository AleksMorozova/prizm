using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ninject;
using Prizm.Main;
using Prizm.Main.Forms.MainChildForm;
using Prizm.Main.Forms.Notifications;
using Prizm.Main.Forms.PipeMill.NewEdit;
using Prizm.Main.Forms.Settings;
using Prizm.Main.Languages;
using Prizm.Main.Properties;
using Prizm.Main.Synch.Import;
using Prizm.UnitTests.Synch.SerializableEntities;
using System.IO;
using Prizm.Main.Common;
using Prizm.Main.Forms.Synch;


namespace PrizmMain.Forms.Notifications
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class NotificationXtraForm : ChildForm
    {
        private ConflictDialog singleConflictDialog = null;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(NotificationXtraForm));
        // Fields
        private NotificationViewModel viewModel;
        private DataImporter importer;
        // Methods
        public NotificationXtraForm()
        {
            this.components = null;
            this.InitializeComponent();
            importer = Program.Kernel.Get<DataImporter>();
            importer.OnConflict += importer_OnConflict;
        }

        private void NotificationXtraForm_Load(object sender, EventArgs e)
        {
            viewModel = (NotificationViewModel)Program.Kernel.GetService(typeof(NotificationViewModel));
            BindToViewModel();
        }

        private void BindToViewModel()
        {
            notificationBindingSource.DataSource = viewModel;
            gridControlMessage.DataBindings.Add("DataSource", notificationBindingSource, "Notification");
        }

        private void gridControlMessage_DoubleClick(object sender, EventArgs e)
        {
            int selectedItem = gridViewNotification.GetFocusedDataSourceRowIndex();
            if (selectedItem >= 0)
            {
                var parent = this.MdiParent as PrizmApplicationXtraForm;
                var id = viewModel.Notification[selectedItem].Id;


                OpenEditorForm(id, viewModel.Notification[selectedItem].TypeNotification, viewModel.Notification[selectedItem].AdditionalInformation);
            }
    
        }

        private void OpenEditorForm(Guid id, TypeNotification typeNotification, string additionalInformation)
        {
            switch (typeNotification)
            {
                case TypeNotification.DuplicatePipeNumber:
                    OpenForm(DocumentTypes.MillPipe, id);
                    break;
                case TypeNotification.DuplicateLogin:
                    OpenForm(DocumentTypes.Settings, id, 6);
                    break;
                case TypeNotification.ExpiredInspectorCertificate:
                    OpenForm(DocumentTypes.Settings, id, 5);
                    break;
                case TypeNotification.ExpiredWelderCertificate:
                    OpenForm(DocumentTypes.Settings, id, 4);
                    break;
                case TypeNotification.NotRequiredInspectionOperation:
                    OpenForm(DocumentTypes.Settings, id, 2);
                    break;
                case TypeNotification.SelectiveInspectionOperation:
                    OpenForm(DocumentTypes.Settings, id, 1);
                    break;
                case TypeNotification.PostponeConflict:
                    importer.Postpone_PipeImport(additionalInformation);
                    RefreshNitifications();
                    break;
                default:
                    var ex = new NotImplementedException(String.Format("Type editor not set for notification code {0}", typeNotification));
                    log.Error(ex.Message);
                    throw ex;
                    //break; // unreachable code
            }
        }

        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
                new LocalizedItem(layoutControlItemNotification, StringResources.NotificationXtraForm_LayoutControlItemNotification.Id),
                new LocalizedItem(colDate, StringResources.NotificationXtraForm_ColDate.Id),
                new LocalizedItem(colNotification, StringResources.NotificationXtraForm_ColNotification.Id),
                new LocalizedItem(colName, StringResources.NotificationXtraForm_ColName.Id),
                
                // header
                new LocalizedItem(this, localizedHeader, new string[] {
                    StringResources.NotificationXtraForm_Title.Id} )
            };
        }

        #endregion // --- Localization ---

        private void NotificationXtraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            viewModel.Dispose();
            viewModel = null;
        }

        private void NotificationXtraForm_Activated(object sender, EventArgs e)
        {
            RefreshNitifications();
        }

        private void OpenForm(DocumentTypes type, Guid id, int pageNumber =0) 
        {
            if (type == DocumentTypes.Settings && pageNumber >= 0)
            {
                FormManager.Instance.OpenSettingsChildForm(pageNumber);
            }
            else
            {
                FormManager.Instance.OpenChildForm(type, id);
            }
        }

        void importer_OnConflict(ConflictEventArgs args)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => { ConflictDialogCreation(args); }));
            }
            else
            {
                ConflictDialogCreation(args);
            }
        }

        private void ConflictDialogCreation(ConflictEventArgs args)
        {
            if (singleConflictDialog == null)
            {
                singleConflictDialog = new ConflictDialog(args.Message);
            }
            else
            {
                singleConflictDialog.SetConflictDialog(args.Message);
            }

            singleConflictDialog.ShowDialog();
            args.Decision = singleConflictDialog.Decision;
            args.ForAll = singleConflictDialog.ForAll;
        }

        /// <summary>
        /// Refresh list of notification and grid DataSource
        /// </summary>
        void RefreshNitifications() 
        {
            NotificationService.Instance.LoadAllNotifications();
            gridControlMessage.DataSource = NotificationService.Instance.Notifications;
        }

    }
}
