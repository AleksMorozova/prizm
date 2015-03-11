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

namespace Prizm.Main.Forms.MainChildForm
{
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
        ExportImport
    }

    public class FormManager
    {
        #region --- Instance ---
        public static FormManager Instance
        {
            get
            {
                if (InstanceField == null)
                {
                    throw new ApplicationException("FormManager was not initialized!");
                }
                return InstanceField;
            }
        }

        public static void Initialize(IUserNotify notify, ILog log)
        {
            InstanceField = new FormManager();
            Instance.notify = notify;
            Instance.log = log;
        }
        #endregion // --- Instance ---


        private class FormsReference
        {
            private readonly Dictionary<DocumentTypes, PrizmFormProperties> formsDictionary = new Dictionary<DocumentTypes, PrizmFormProperties>();

            private class PrizmFormProperties
            {
                public System.Type type;
                public List<ChildForm> forms;
            }

            public FormsReference()
            {
                formsDictionary.Add(DocumentTypes.MillPipe, new PrizmFormProperties() { type = typeof(Prizm.Main.Forms.PipeMill.NewEdit.MillPipeNewEditXtraForm), forms = null });
                formsDictionary.Add(DocumentTypes.MillPipeSearch, new PrizmFormProperties() { type = typeof(Prizm.Main.Forms.PipeMill.Search.MillPipeSearchXtraForm), forms = null });
                formsDictionary.Add(DocumentTypes.MillReleaseNote, new PrizmFormProperties() { type = typeof(Prizm.Main.Forms.ReleaseNote.NewEdit.ReleaseNoteNewEditXtraForm), forms = null });
                formsDictionary.Add(DocumentTypes.MillReleaseNoteSearch, new PrizmFormProperties() { type = typeof(Prizm.Main.Forms.ReleaseNote.Search.ReleaseNoteSearchXtraForm), forms = null });
                formsDictionary.Add(DocumentTypes.MillReport, new PrizmFormProperties() { type = typeof(Prizm.Main.Forms.Reports.Mill.MillReportsXtraForm), forms = null });
                formsDictionary.Add(DocumentTypes.InspectionPart, new PrizmFormProperties() { type = typeof(Prizm.Main.Forms.Parts.Inspection.PartInspectionXtraForm), forms = null });
                formsDictionary.Add(DocumentTypes.InspectionPartSearch, new PrizmFormProperties() { type = typeof(Prizm.Main.Forms.Parts.Search.PartSearchXtraForm), forms = null });
                formsDictionary.Add(DocumentTypes.InspectionReport, new PrizmFormProperties() { type = typeof(Prizm.Main.Forms.Reports.Incoming.InspectionReportsXtraForm), forms = null });
                formsDictionary.Add(DocumentTypes.ConstructionComponent, new PrizmFormProperties() { type = typeof(Prizm.Main.Forms.Component.NewEdit.ComponentNewEditXtraForm), forms = null });
                formsDictionary.Add(DocumentTypes.ConstructionJoint, new PrizmFormProperties() { type = typeof(Prizm.Main.Forms.Joint.NewEdit.JointNewEditXtraForm), forms = null });
                formsDictionary.Add(DocumentTypes.ConstructionJointSearch, new PrizmFormProperties() { type = typeof(Prizm.Main.Forms.Joint.Search.JointSearchXtraForm), forms = null });
                formsDictionary.Add(DocumentTypes.ConstructionSpool, new PrizmFormProperties() { type = typeof(Prizm.Main.Forms.Spool.SpoolsXtraForm), forms = null });
                formsDictionary.Add(DocumentTypes.ConstructionPipeReport, new PrizmFormProperties() { type = typeof(Prizm.Main.Forms.Reports.Construction.PipeReport.PipeConstractionReportXtraForm), forms = null });
                formsDictionary.Add(DocumentTypes.ConstructionWeldDateReport, new PrizmFormProperties() { type = typeof(Prizm.Main.Forms.Reports.Construction.WeldDateReports.WeldDateReportXtraForm), forms = null });
                formsDictionary.Add(DocumentTypes.ConstructionTracingReport, new PrizmFormProperties() { type = typeof(Prizm.Main.Forms.Reports.Construction.ConstructionReportsXtraForm), forms = null });
                formsDictionary.Add(DocumentTypes.Settings, new PrizmFormProperties() { type = typeof(Prizm.Main.Forms.Settings.SettingsXtraForm), forms = null });
                formsDictionary.Add(DocumentTypes.Audit, new PrizmFormProperties() { type = typeof(Prizm.Main.Forms.Audit.AuditXtraForm), forms = null });
                formsDictionary.Add(DocumentTypes.Notifications, new PrizmFormProperties() { type = typeof(PrizmMain.Forms.Notifications.NotificationXtraForm), forms = null });
            }

            private void CheckDocumentTypePresence(DocumentTypes documentType)
            {
                if (!formsDictionary.ContainsKey(documentType))
                {
                    throw new ApplicationException("No entry available for document type " + documentType.ToString());
                }
            }

            public ChildForm CreateNew(DocumentTypes documentType, List<KeyValuePair<string, object>> parameters)
            {
                ChildForm newlyCreatedForm = null;

                if (parameters != null)
                {
                    newlyCreatedForm = (ChildForm)Program.Kernel.Get(this.GetFormType(documentType),
                       parameters.Select(kvp => new ConstructorArgument(kvp.Key, kvp.Value)).ToArray());
                }
                else
                {
                    newlyCreatedForm = (ChildForm)Program.Kernel.Get(this.GetFormType(documentType));
                }
                return newlyCreatedForm;
            }

            public bool Remove(ChildForm childForm)
            {
                bool removed = false;
                foreach (var type in formsDictionary)
                {
                    foreach (var form in type.Value.forms)
                    {
                        if (form == childForm)
                        {
                            removed = type.Value.forms.Remove(childForm);
                            break;
                        }
                    }
                }
                return removed;
            }

            public System.Type GetFormType(DocumentTypes documentType)
            {
                CheckDocumentTypePresence(documentType);
                return formsDictionary[documentType].type;
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
                foreach(var list in formsDictionary)
                {
                    foreach(var form in list.Value.forms)
                    {
                        if(form.Is(id))
                        {
                            found = form;
                        }
                    }
                }
                return found;
            }
        }

        private readonly FormsReference childForms = new FormsReference();
        private static uint FramesCanOpen = 20;
        private static FormManager InstanceField;
        private ILog log;
        private IUserNotify notify;

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
                Prizm.Main.Forms.Settings.SettingsXtraForm form = (Prizm.Main.Forms.Settings.SettingsXtraForm)OpenChildForm(DocumentTypes.Settings, null);

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

        /// <summary>
        /// Find ChildForm index in corresponding childForms list that contains the element having mode equal ReadMode.
        /// </summary>
        /// <param name="formTypeName">string representation of form type name</param>
        /// <param name="ReadMode"></param>
        /// <returns>The zero-based index of the first occurrence of an element that matches the
        /// conditions defined by match, if found; otherwise, –1.</returns>
        private int FindOpenForm(DocumentTypes documentType, bool ReadMode)
        {
            int index = -1;
            //index = childForms[documentType].FindIndex(x => x.IsEditMode == ReadMode);
            return index;
        }

        /// <summary>
        /// Gives the ChildForm index in corresponding childForms list that contains the element defined by id.
        /// </summary>
        /// <param name="formTypeName">string representation of form type name, for example</param>
        /// <param name="id"></param>
        /// <returns>The zero-based index of the first occurrence of an element that matches the
        /// conditions defined by match, if found; otherwise, –1.</returns>
        private int GetFormIndex(DocumentTypes documentType, Guid id)
        {
            int index = 0;

            if (id != Guid.Empty)
            {
                index = childForms[documentType]
                    .FindIndex(x => x is ChildEditableForm && ((ChildEditableForm)x).Id == id));
            }
            else
            {
                bool isSingleForm =
                    documentType == DocumentTypes.Settings ||
                    documentType == DocumentTypes.Notifications;

                if (!isSingleForm)
                {
                    index = -1;
                }
            }

            return index;
        }

        /// <summary>
        /// Creation of child form. Can be used from outside to pass some Guid of entity and number to newly created forms.
        /// </summary>
        /// <param name="formType">exact type of form</param>
        /// <param name="id">Guid of entity</param>
        /// <param name="parameters">input parameters passed to the newly created form</param>
        public ChildForm OpenChildForm(DocumentTypes documentType, List<KeyValuePair<string, object>> parameters, Guid id = default(Guid))
        {
            try
            {
                notify.ShowProcessing();
                ChildForm opened = null;
                if(id != Guid.Empty)
                {
                    opened = childForms.GetById(id);
                }
                if(opened != null)
                {
                    opened.Activate();
                }
                else
                {
                
                }
            }
            finally
            {
                notify.HideProcessing();
            }

        }

        private blabla()
        {
            ChildForm form = null;
            var forms = childForms[documentType];
            //search
            int indexById = GetFormIndex(documentType, id);

            if (indexById >= 0 && forms.Count > 0) // is open
            {
                form = forms[indexById];
            }
            if (form != null)
            {
                form.Activate();
            }
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

        /// <summary>
        /// Based on @formType returns 
        /// whether form can be opened for editing
        /// </summary>
        private bool CanOpenFormForEditing(DocumentTypes documentType)
        {
            bool cannotOpenFormForEditing = false;
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
            return !cannotOpenFormForEditing;
        }

        /// <summary>
        /// If form can be opened for viewing, asks user if we
        /// should open form for viewing only.
        /// If form cannot be opened for viewing (ex. New pipe creation),
        /// shown warning
        /// </summary>
        /// <param name="formType">Type of form to be opened</param>
        /// <param name="form">Shown child form</param>
        /// <returns>If it is OK to open form for viewing</returns>
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

        /// <summary>
        /// Show existing child form.
        /// </summary>
        /// <param name="form"></param>
        private void ShowChildForm(ChildForm form)
        {
            form.Show();
            form.WindowState = FormWindowState.Normal;
            form.WindowState = FormWindowState.Maximized;
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