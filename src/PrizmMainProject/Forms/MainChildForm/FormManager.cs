using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ninject.Parameters;
using Prizm.Main.Languages;
using Ninject;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using log4net;
using Prizm.Main.Security;
using System.Collections;

namespace Prizm.Main.Forms.MainChildForm
{
    /// <summary>
    /// adding new items here, please add to --- Creating dictionary --- below
    /// </summary>
    public enum DocumentTypes
    {
        MillPipe,
        MillPipeSearch,
        MillReleaseNote,
        MillReleaseNoteSearch,
        MillReport,
        InspectionPart,
        InspectionPartSearch,
        InspectionReport,
        ConstructionComponent,
        ConstructionJoint,
        ConstructionJointSearch,
        ConstructionSpool,
        ConstructionPipeReport,
        ConstructionWeldDateReport,
        ConstructionTracingReport,
        Settings,
        Audit,
        Notifications,
        Export,
        Import,
        ExportImportHistory
    }

    public class FormManager
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(FormManager));

        private readonly FormsReference childForms = new FormsReference();
        private static uint FramesCanOpen = 20;

        #region --- Instance, initialization, notify, context ---
        private static FormManager InstanceField = (FormManager)Program.Kernel.GetService(typeof(FormManager));
        private IUserNotify notify;
        private readonly ISecurityContext ctx;

        public static FormManager Instance { get { return InstanceField; } }

        public FormManager(IUserNotify notify, ISecurityContext ctx)
        {
            this.notify = notify;
            this.ctx = ctx;
        }
        #endregion // --- Instance, initialization, notify, context ---

        private class FormsReference : IEnumerable<DocumentTypes>
        {
            private readonly Dictionary<DocumentTypes, PrizmFormProperties> formsDictionary = new Dictionary<DocumentTypes, PrizmFormProperties>();

            private class PrizmFormProperties
            {
                public System.Type type;
                public global::Domain.Entity.Security.Privileges readPrivilege;
                public global::Domain.Entity.Security.Privileges editPrivilege;
                public List<ChildForm> forms;
            }

            #region --- Creating dictionary ---
            public FormsReference()
            {
                formsDictionary.Add(DocumentTypes.MillPipe, new PrizmFormProperties()
                {
                    type = typeof(Prizm.Main.Forms.PipeMill.NewEdit.MillPipeNewEditXtraForm),
                    readPrivilege = global::Domain.Entity.Security.Privileges.ViewPipe,
                    editPrivilege = global::Domain.Entity.Security.Privileges.EditPipe
                });

                formsDictionary.Add(DocumentTypes.MillPipeSearch, new PrizmFormProperties()
                {
                    type = typeof(Prizm.Main.Forms.PipeMill.Search.MillPipeSearchXtraForm),
                    readPrivilege = global::Domain.Entity.Security.Privileges.SearchPipes,
                    editPrivilege = global::Domain.Entity.Security.Privileges.SearchPipes
                });

                formsDictionary.Add(DocumentTypes.MillReleaseNote, new PrizmFormProperties()
                {
                    type = typeof(Prizm.Main.Forms.ReleaseNote.NewEdit.ReleaseNoteNewEditXtraForm),
                    readPrivilege = global::Domain.Entity.Security.Privileges.ViewReleaseNote,
                    editPrivilege = global::Domain.Entity.Security.Privileges.EditReleaseNote
                });

                formsDictionary.Add(DocumentTypes.MillReleaseNoteSearch, new PrizmFormProperties()
                {
                    type = typeof(Prizm.Main.Forms.ReleaseNote.Search.ReleaseNoteSearchXtraForm),
                    readPrivilege = global::Domain.Entity.Security.Privileges.SearchReleaseNotes,
                    editPrivilege = global::Domain.Entity.Security.Privileges.SearchReleaseNotes
                });

                formsDictionary.Add(DocumentTypes.MillReport, new PrizmFormProperties()
                {
                    type = typeof(Prizm.Main.Forms.Reports.Mill.MillReportsXtraForm),
                    readPrivilege = global::Domain.Entity.Security.Privileges.PrintMillReports,
                    editPrivilege = global::Domain.Entity.Security.Privileges.PrintMillReports
                });

                formsDictionary.Add(DocumentTypes.InspectionPart, new PrizmFormProperties()
                {
                    type = typeof(Prizm.Main.Forms.Parts.Inspection.PartInspectionXtraForm),
                    readPrivilege = global::Domain.Entity.Security.Privileges.PartsInspection,
                    editPrivilege = global::Domain.Entity.Security.Privileges.PartsInspection
                });

                formsDictionary.Add(DocumentTypes.InspectionPartSearch, new PrizmFormProperties()
                {
                    type = typeof(Prizm.Main.Forms.Parts.Search.PartSearchXtraForm),
                    readPrivilege = global::Domain.Entity.Security.Privileges.SearchParts,
                    editPrivilege = global::Domain.Entity.Security.Privileges.SearchParts
                });

                formsDictionary.Add(DocumentTypes.InspectionReport, new PrizmFormProperties()
                {
                    type = typeof(Prizm.Main.Forms.Reports.Incoming.InspectionReportsXtraForm),
                    readPrivilege = global::Domain.Entity.Security.Privileges.PrintInspectionReports,
                    editPrivilege = global::Domain.Entity.Security.Privileges.PrintInspectionReports
                });

                formsDictionary.Add(DocumentTypes.ConstructionComponent, new PrizmFormProperties()
                {
                    type = typeof(Prizm.Main.Forms.Component.NewEdit.ComponentNewEditXtraForm),
                    readPrivilege = global::Domain.Entity.Security.Privileges.ViewComponent,
                    editPrivilege = global::Domain.Entity.Security.Privileges.EditComponent
                });

                formsDictionary.Add(DocumentTypes.ConstructionJoint, new PrizmFormProperties()
                {
                    type = typeof(Prizm.Main.Forms.Joint.NewEdit.JointNewEditXtraForm),
                    readPrivilege = global::Domain.Entity.Security.Privileges.ViewJoint,
                    editPrivilege = global::Domain.Entity.Security.Privileges.EditJoint
                });

                formsDictionary.Add(DocumentTypes.ConstructionJointSearch, new PrizmFormProperties()
                {
                    type = typeof(Prizm.Main.Forms.Joint.Search.JointSearchXtraForm),
                    readPrivilege = global::Domain.Entity.Security.Privileges.SearchJoints,
                    editPrivilege = global::Domain.Entity.Security.Privileges.SearchJoints
                });

                formsDictionary.Add(DocumentTypes.ConstructionSpool, new PrizmFormProperties()
                {
                    type = typeof(Prizm.Main.Forms.Spool.SpoolsXtraForm),
                    readPrivilege = global::Domain.Entity.Security.Privileges.ViewSpool,
                    editPrivilege = global::Domain.Entity.Security.Privileges.EditSpool
                });

                formsDictionary.Add(DocumentTypes.ConstructionPipeReport, new PrizmFormProperties()
                {
                    type = typeof(Prizm.Main.Forms.Reports.Construction.PipeReport.PipeConstractionReportXtraForm),
                    readPrivilege = global::Domain.Entity.Security.Privileges.PrintConstructionReports,
                    editPrivilege = global::Domain.Entity.Security.Privileges.PrintConstructionReports
                });

                formsDictionary.Add(DocumentTypes.ConstructionWeldDateReport, new PrizmFormProperties()
                {
                    type = typeof(Prizm.Main.Forms.Reports.Construction.WeldDateReports.WeldDateReportXtraForm),
                    readPrivilege = global::Domain.Entity.Security.Privileges.PrintConstructionReports,
                    editPrivilege = global::Domain.Entity.Security.Privileges.PrintConstructionReports
                });

                formsDictionary.Add(DocumentTypes.ConstructionTracingReport, new PrizmFormProperties()
                {
                    type = typeof(Prizm.Main.Forms.Reports.Construction.ConstructionReportsXtraForm),
                    readPrivilege = global::Domain.Entity.Security.Privileges.PrintConstructionReports,
                    editPrivilege = global::Domain.Entity.Security.Privileges.PrintConstructionReports
                });

                formsDictionary.Add(DocumentTypes.Settings, new PrizmFormProperties()
                {
                    type = typeof(Prizm.Main.Forms.Settings.SettingsXtraForm),
                    readPrivilege = global::Domain.Entity.Security.Privileges.ViewSettings,
                    editPrivilege = global::Domain.Entity.Security.Privileges.EditSettings
                });

                formsDictionary.Add(DocumentTypes.Audit, new PrizmFormProperties()
                {
                    type = typeof(Prizm.Main.Forms.Audit.AuditXtraForm),
                    readPrivilege = global::Domain.Entity.Security.Privileges.Audit,
                    editPrivilege = global::Domain.Entity.Security.Privileges.Audit
                });

                formsDictionary.Add(DocumentTypes.Notifications, new PrizmFormProperties()
                {
                    type = typeof(PrizmMain.Forms.Notifications.NotificationXtraForm),
                    readPrivilege = global::Domain.Entity.Security.Privileges.NullPrivilegeAllowed,
                    editPrivilege = global::Domain.Entity.Security.Privileges.NullPrivilegeAllowed
                });

                formsDictionary.Add(DocumentTypes.Export, new PrizmFormProperties()
                {
                    type = typeof(Prizm.Main.Forms.Synch.ExportForm),
                    readPrivilege = GetExportPrivilegeByWorkstation(),
                    editPrivilege = GetExportPrivilegeByWorkstation()
                });

                formsDictionary.Add(DocumentTypes.Import, new PrizmFormProperties()
                {
                    type = typeof(Prizm.Main.Forms.Synch.ImportForm),
                    readPrivilege = GetImportPrivilegeByWorkstation(),
                    editPrivilege = GetImportPrivilegeByWorkstation()
                });

                formsDictionary.Add(DocumentTypes.ExportImportHistory, new PrizmFormProperties()
                {
                    type = typeof(Prizm.Main.Forms.Synch.HistoryExportImport),
                    readPrivilege = global::Domain.Entity.Security.Privileges.ViewExportImportHistory,
                    editPrivilege = global::Domain.Entity.Security.Privileges.ViewExportImportHistory
                });
            }

            private global::Domain.Entity.Security.Privileges GetExportPrivilegeByWorkstation()
            {
                global::Domain.Entity.Security.Privileges result = global::Domain.Entity.Security.Privileges.NullPrivilegeRestricted;
                switch (Program.ThisWorkstationType)
                { 
                    case Domain.Entity.Setup.WorkstationType.Construction:
                        result = global::Domain.Entity.Security.Privileges.ExportDataFromConstruction;
                        break;
                    case Domain.Entity.Setup.WorkstationType.Mill:
                        result = global::Domain.Entity.Security.Privileges.ExportDataFromMill;
                        break;
                    case Domain.Entity.Setup.WorkstationType.Master:
                        result = global::Domain.Entity.Security.Privileges.ExportDataFromMaster;
                        break;
                    default:
                        string msg = "Wrong workstation type at choosing export privilege by workstation: " + Program.ThisWorkstationType;
                        log.Error(msg);
                        throw new ApplicationException(msg);
                        //break; // uncomment when throw will be removed
                }
                return result;
            }

            private global::Domain.Entity.Security.Privileges GetImportPrivilegeByWorkstation()
            {
                global::Domain.Entity.Security.Privileges result = global::Domain.Entity.Security.Privileges.NullPrivilegeRestricted;
                switch (Program.ThisWorkstationType)
                {
                    case Domain.Entity.Setup.WorkstationType.Construction:
                        result = global::Domain.Entity.Security.Privileges.ImportDataAtConstruction;
                        break;
                    case Domain.Entity.Setup.WorkstationType.Mill:
                        result = global::Domain.Entity.Security.Privileges.NullPrivilegeRestricted;
                        break;
                    case Domain.Entity.Setup.WorkstationType.Master:
                        result = global::Domain.Entity.Security.Privileges.ImportDataAtMaster;
                        break;
                    default:
                        string msg = "Wrong workstation type at choosing import privilege by workstation: " + Program.ThisWorkstationType;
                        log.Error(msg);
                        throw new ApplicationException(msg);
                    //break; // uncomment when throw will be removed
                }
                return result;
            }

            #endregion ///--- Creating dictionary ---

            private void CheckDocumentTypePresence(DocumentTypes documentType)
            {
                if (!formsDictionary.ContainsKey(documentType))
                {
                    throw new ApplicationException("No entry available for document type " + documentType.ToString());
                }
            }
            private List<ChildForm> GetChildFormList(DocumentTypes documentType)
            {
                if (formsDictionary[documentType].forms == null)
                {
                    formsDictionary[documentType].forms = new List<ChildForm>();
                }
                return formsDictionary[documentType].forms;
            }

            public ChildForm CreateNew(DocumentTypes documentType, List<KeyValuePair<string, object>> parameters)
            {
                ChildForm newlyCreatedForm = null;
                CheckDocumentTypePresence(documentType);

                if (parameters != null)
                {
                    newlyCreatedForm = (ChildForm)Program.Kernel.Get(this.GetFormType(documentType),
                       parameters.Select(kvp => new ConstructorArgument(kvp.Key, kvp.Value)).ToArray());
                }
                else
                {
                    newlyCreatedForm = (ChildForm)Program.Kernel.Get(this.GetFormType(documentType));
                }
                GetChildFormList(documentType).Add(newlyCreatedForm);
                return newlyCreatedForm;
            }

            public bool Remove(ChildForm childForm)
            {
                bool removed = false;
                foreach (var entry in formsDictionary)
                {
                    foreach (var form in GetChildFormList(entry.Key))
                    {
                        if (form == childForm)
                        {
                            removed = entry.Value.forms.Remove(childForm);
                            break;
                        }
                    }
                    if (removed)
                    {
                        break;
                    }
                }
                return removed;
            }

            public System.Type GetFormType(DocumentTypes documentType)
            {
                CheckDocumentTypePresence(documentType);
                return formsDictionary[documentType].type;
            }

            public global::Domain.Entity.Security.Privileges GetAccessOption(DocumentTypes documentType, bool editMode)
            {
                CheckDocumentTypePresence(documentType);
                return editMode ? formsDictionary[documentType].editPrivilege : formsDictionary[documentType].readPrivilege;
            }

            public IReadOnlyList<ChildForm> this[DocumentTypes documentType]
            {
                get
                {
                    CheckDocumentTypePresence(documentType);
                    if (formsDictionary[documentType].forms == null)
                    {
                        formsDictionary[documentType].forms = new List<ChildForm>();
                    }
                    return formsDictionary[documentType].forms;
                }
            }

            public IEnumerable<ChildForm> GetEnumerable()
            {
                return formsDictionary.SelectMany(k => k.Value.forms);
            }

            public ChildForm GetById(Guid id)
            {
                ChildForm found = null;
                if (id != Guid.Empty)
                {
                    foreach (var list in formsDictionary)
                    {
                        foreach (var form in list.Value.forms)
                        {
                            if (form.Is(id))
                            {
                                found = form;
                                break;
                            }
                        }
                    }
                }
                return found;
            }

            public IEnumerator<DocumentTypes> GetEnumerator()
            {
                return formsDictionary.Keys.GetEnumerator();
            }

            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

        }

        #region --- Conditions ---
        private bool IsSingleDocumentPerProgram(DocumentTypes type)
        {
            bool result = false;
            switch (type)
            {
                case DocumentTypes.Settings:
                case DocumentTypes.Notifications:
                case DocumentTypes.ExportImportHistory:
                    result = true;
                    break;
                default:
                    break;
            }
            return result;
        }

        private bool IsSingleEditModeDocument(DocumentTypes type)
        {
            bool result = false;
            switch (type)
            {
                case DocumentTypes.MillReleaseNote:
                    result = true;
                    break;
                default:
                    break;
            }
            return result;
        }

        private bool IsEditConflictWithSettings(DocumentTypes type)
        {
            bool result = false;
            switch (type)
            {
                case DocumentTypes.MillReleaseNote:
                    result = true;
                    break;
                default:
                    break;
            }
            return result;
        }

        private IReadOnlyList<ChildForm> SettingsConflictedDocumentsOpened()
        {
            List<ChildForm> list = new List<ChildForm>();
            foreach(var type in childForms)
            {
                if (IsEditConflictWithSettings(type))
                {
                    list.AddRange(childForms[type]);
                }
            }
            return list;
        }

        private Main.Forms.Settings.SettingsXtraForm GetSettingsForm()
        {
            ChildForm result = childForms[DocumentTypes.Settings].FirstOrDefault();
            System.Type type = childForms.GetFormType(DocumentTypes.Settings);

            // this code will change when it will be available to do nameof
            if(type.Name == typeof(Main.Forms.Settings.SettingsXtraForm).Name)
            {
                return (Main.Forms.Settings.SettingsXtraForm)result;
            }
            else
            {
                throw new ApplicationException(String.Format("Type inconsistency between {0} and {1}", typeof(Main.Forms.Settings.SettingsXtraForm).Name, type.Name));
            }
        }

        #endregion //--- Conditions ---


        /// <summary>
        /// Creates an instance of child form of given form type
        /// </summary>
        /// <param name="formType">type of form to be created, for example SettingsXtraForm</param>
        /// <returns>reference to newly created child form</returns>
        private ChildForm CreateChildForm(DocumentTypes documentType, List<KeyValuePair<string, object>> parameters)
        {
            ChildForm newlyCreatedForm = null;

            if (FramesCanOpen < 1)
            {
                notify.HideProcessing();
                notify.ShowError(Program.LanguageManager.GetString(StringResources.Message_NoMoreDocumentsCanOpen),
                    Program.LanguageManager.GetString(StringResources.Message_ErrorHeader));
            }
            else
            {
                newlyCreatedForm = childForms.CreateNew(documentType, parameters);
                newlyCreatedForm.MdiParent = Program.MainForm;
                newlyCreatedForm.FormClosed += ChildClosedEventHandler;
                FramesCanOpen--;
            }
            return newlyCreatedForm;
        }

        /// <summary>
        /// Create and show Settings child form. Starting tab page is set or first page if page doesn't exist.
        /// </summary>
        /// <param name="page">number of starting page</param>
        public void OpenSettingsChildForm(int page)
        {
            try
            {
                Prizm.Main.Forms.Settings.SettingsXtraForm form = (Prizm.Main.Forms.Settings.SettingsXtraForm)OpenReturnChildForm(DocumentTypes.Settings, null);

                if (form != null && form.tabbedControlGroup.TabPages.Count > page)
                {
                    form.tabbedControlGroup.SelectedTabPage = form.tabbedControlGroup.TabPages[page];
                }
            }
            finally
            {
                notify.HideProcessing();
            }
        }

        /// <summary>
        /// Cleans child form if it was closed
        /// </summary>
        /// <param name="sender">child form expected</param>
        /// <param name="arguments"></param>
        private void ChildClosedEventHandler(object sender, EventArgs arguments)
        {
            if (typeof(ChildForm).IsAssignableFrom(sender.GetType()))
            {
                if (childForms.Remove((ChildForm)sender))
                {
                    FramesCanOpen++;
                }
            }
        }

        public void OpenChildForm(DocumentTypes documentType, Guid id = default(Guid))
        {
            List<KeyValuePair<string, object>> parameters = new List<KeyValuePair<string, object>>();
            parameters.Add(new KeyValuePair<string, object>("id", id));
            OpenReturnChildForm(documentType, parameters, id);
        }

        public void OpenChildForm(DocumentTypes documentType, string number)
        {
            List<KeyValuePair<string, object>> parameters = new List<KeyValuePair<string, object>>();
            parameters.Add(new KeyValuePair<string, object>("number", number));
            OpenReturnChildForm(documentType, parameters);
        }


        [Flags]
        private enum FormFlags
        {
            Nothing = 0,
            CanEditAtThisWorkstation = 1,
            CanReadAtThisWorkstation = 2,
            EditAccessDenied = 4,
            ReadAccessDenied = 8,
            SingleEditAlreadyOpened = 16,
            EditConflict = 32
        }

        private FormFlags GetSecurityRestrictionReasons(DocumentTypes documentType)
        {
            FormFlags reasons = FormFlags.Nothing;

            reasons |= SecurityUtil.ExistOnCurrentWorkstation(childForms.GetAccessOption(documentType, editMode: true))
                            ? FormFlags.CanEditAtThisWorkstation : FormFlags.Nothing;

            reasons |= SecurityUtil.ExistOnCurrentWorkstation(childForms.GetAccessOption(documentType, editMode: false))
                            ? FormFlags.CanReadAtThisWorkstation : FormFlags.Nothing;

            if (!ctx.HasAccess(childForms.GetAccessOption(documentType, editMode: true)))
            {
                reasons |= FormFlags.EditAccessDenied;
            }
            if (!ctx.HasAccess(childForms.GetAccessOption(documentType, editMode: false)))
            {
                reasons |= FormFlags.ReadAccessDenied;
            }
            return reasons;
        }

        private bool CanOpen(DocumentTypes type, bool isNew, FormFlags flags, out bool editMode)
        {
            editMode = !flags.HasFlag(FormFlags.EditAccessDenied) && flags.HasFlag(FormFlags.CanEditAtThisWorkstation);
            bool canOpen = true;

            if (flags.HasFlag(FormFlags.EditConflict))
            {
                if (type == DocumentTypes.Settings)
                {
                    canOpen &= notify.ShowYesNo(Program.LanguageManager.GetString(StringResources.Message_OpenSettingsForViewing),
                        Program.LanguageManager.GetString(StringResources.Message_OpenSettingsForViewingHeader));
                }
                else
                {
                    canOpen &= notify.ShowYesNo(Program.LanguageManager.GetString(StringResources.Message_OpenFormForViewing),
                        Program.LanguageManager.GetString(StringResources.Message_OpenFormForViewingHeader));
                }
                editMode = false;
            }
            if (flags.HasFlag(FormFlags.SingleEditAlreadyOpened))
            {
                if (isNew)
                {
                    string text = Program.LanguageManager.GetString(StringResources.MainWindow_CloseEditingReleaseNote);
                    notify.ShowWarning(text, "");
                    canOpen = false;
                }
                else
                {
                    string text = Program.LanguageManager.GetString(StringResources.MainWindow_OpenReleaseNoteReadOnly);
                    canOpen &= notify.ShowYesNo(text, "");
                    editMode = false;
                }
            }
            return canOpen;
        }

        /// <summary>
        /// Creation of child form. Can be used from outside to pass some Guid of entity and number to newly created forms.
        /// </summary>
        /// <param name="formType">exact type of form</param>
        /// <param name="id">Guid of entity</param>
        /// <param name="parameters">input parameters passed to the newly created form</param>
        private ChildForm OpenReturnChildForm(DocumentTypes documentType, List<KeyValuePair<string, object>> parameters, Guid id = default(Guid))
        {
            ChildForm formToActivate = null;
            try
            {
                notify.ShowProcessing();

                FormFlags flags = FormFlags.Nothing;
                flags |= GetSecurityRestrictionReasons(documentType);

                // is possible for this option to open for this user, at all
                if (flags.HasFlag(FormFlags.CanReadAtThisWorkstation) && !flags.HasFlag(FormFlags.ReadAccessDenied)
                    || flags.HasFlag(FormFlags.CanEditAtThisWorkstation) && !flags.HasFlag(FormFlags.EditAccessDenied))
                {
                    if (id != Guid.Empty)
                    {
                        formToActivate = childForms.GetById(id);
                    }
                    if (formToActivate == null)
                    {
                        IReadOnlyList<ChildForm> existingDocuments = childForms[documentType];

                        if (IsSingleDocumentPerProgram(documentType) && existingDocuments.Count > 0)
                        {
                            formToActivate = existingDocuments.First();
                        }
                        if(formToActivate == null)
                        {
                            flags |= (IsSingleEditModeDocument(documentType) && existingDocuments.Any((form) => { return form.IsEditMode; }))
                                ? FormFlags.SingleEditAlreadyOpened : FormFlags.Nothing;

                            Main.Forms.Settings.SettingsXtraForm settingsForm = GetSettingsForm();

                            if (( settingsForm != null && settingsForm.IsEditMode && IsEditConflictWithSettings(documentType)
                                    || documentType == DocumentTypes.Settings && SettingsConflictedDocumentsOpened().Any((form) => { return form.IsEditMode; }) 
                                  )
                                )
                            {
                                flags |= FormFlags.EditConflict;
                            }

                            bool editMode;
                            if (CanOpen(documentType, id == Guid.Empty, flags, out editMode))
                            {
                                formToActivate = CreateChildForm(documentType, parameters);
                                formToActivate.IsEditMode = editMode;
                                ShowChildForm(formToActivate);
                            }
                        }
                    }
                    if (formToActivate != null)
                    {
                        formToActivate.Activate();
                    }
                }
                else
                {
                    notify.ShowError(
                         Program.LanguageManager.GetString(StringResources.FormManager_AccessForbidden),
                        Program.LanguageManager.GetString(StringResources.FormManager_AccessHeader));
                    log.Warn("Attempt to open form with restricted access to it");
                }
            }
            finally
            {
                notify.HideProcessing();
            }
            return formToActivate;
        }
        /*
        private void blabla()
        {
            else //create new
            {
                int index = FindOpenForm(documentType, true);

                if (documentType == DocumentTypes.MillReleaseNote && index >= 0)// this type form is open in edit mode
                {
                    if (id == default(Guid))
                    {
                        string text = Program.LanguageManager.GetString(StringResources.MainWindow_CloseEditingReleaseNote);
                        notify.ShowWarning(text, "");
                        form = forms[index];
                        form.Activate();
                    }
                    else
                    {
                        string text = Program.LanguageManager.GetString(StringResources.MainWindow_OpenReleaseNoteReadOnly);
                        if (notify.ShowYesNo(text, ""))
                        {
                            form = ShowChildForm(documentType, parameters, false);
                        }
                    }
                }
                else
                {
                    form = ShowChildForm(documentType, parameters, true);
                }
            }
            return form;
        }
        */
        /// <summary>
        /// Based on @formType returns 
        /// whether form can be opened for editing
        /// </summary>
//        private bool CanOpenFormForEditing(DocumentTypes documentType)
//        {
//            bool cannotOpenFormForEditing = false;
            /*
            foreach (var form in childForms)
            {
                if (documentType == DocumentTypes.Settings ?
                    form.Key != DocumentTypes.Settings : form.Key == DocumentTypes.Settings)
                {
                    cannotOpenFormForEditing = form.Value.Any(x => x.IsEditMode);

                    if (cannotOpenFormForEditing)
                        break;
                }
            }*/
 //           return !cannotOpenFormForEditing;
 //       }

        /// <summary>
        /// If form can be opened for viewing, asks user if we
        /// should open form for viewing only.
        /// If form cannot be opened for viewing (ex. New pipe creation),
        /// shown warning
        /// </summary>
        /// <param name="formType">Type of form to be opened</param>
        /// <param name="form">Shown child form</param>
        /// <returns>If it is OK to open form for viewing</returns>
        /// 
        /*
        private bool CanViewEditableForm(DocumentTypes documentType, ChildForm form)
        {
            bool canOpenFormForViewing = false;

            if (!form.CannotOpenForViewing)
            {
                if (documentType == DocumentTypes.Settings)
                {
                    canOpenFormForViewing = notify.ShowYesNo(Program.LanguageManager.GetString(StringResources.Message_OpenSettingsForViewing),
                        Program.LanguageManager.GetString(StringResources.Message_OpenSettingsForViewingHeader));
                }
                else
                {
                    canOpenFormForViewing = notify.ShowYesNo(Program.LanguageManager.GetString(StringResources.Message_OpenFormForViewing),
                        Program.LanguageManager.GetString(StringResources.Message_OpenFormForViewingHeader));
                }
            }
            else
            {
                notify.ShowWarning(Program.LanguageManager.GetString(StringResources.Message_CannotOpenForViewing),
                    Program.LanguageManager.GetString(StringResources.Message_CannotOpenForViewingHeader));
            }

            return canOpenFormForViewing;
        }

        private ChildForm ShowChildForm(DocumentTypes documentType, List<KeyValuePair<string, object>> parameters, bool IsEditMode = true)
        {
            ChildForm form = CreateChildForm(documentType, parameters);

            if (form != null)
            {
                ShowChildForm(form);

                bool canOpenFormForEditing = CanOpenFormForEditing(documentType); 

                // If form.IsEditMode == false -- form is always opened for viewing
                if (IsEditMode && form.IsEditMode &&
                    !canOpenFormForEditing && !CanViewEditableForm(documentType, form))
                {
                    form.Close();
                }
                else if (!(IsEditMode && canOpenFormForEditing))
                {
                    ((ChildForm)form).IsEditMode = IsEditMode && canOpenFormForEditing;
                }
            }
            return form;
        }
        */

        /// <summary>
        /// Show existing child form.
        /// </summary>
        /// <param name="form"></param>
        private void ShowChildForm(ChildForm form)
        {
            if (form != null)
            {
                form.Show();
                form.WindowState = FormWindowState.Normal;
                form.WindowState = FormWindowState.Maximized;
            }
        }


        public IEnumerable<ChildForm> ChildForms
        {
            get
            {
                return childForms.GetEnumerable();
            }
        }

    }
}