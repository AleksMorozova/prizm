using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ninject.Parameters;
using Prizm.Main.Forms.Railcar.NewEdit;
using Prizm.Main.Forms.Settings;
using Prizm.Main.Languages;
using PrizmMain.Forms.Notifications;
using Ninject;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using log4net;

namespace Prizm.Main.Forms.MainChildForm
{
    public class FormManager
    {

        // Fields
        private readonly Dictionary<string, List<ChildForm>> childForms = new Dictionary<string, List<ChildForm>>();
        private static uint FramesCanOpen = 20;
        private static FormManager InstanceField;
        private ILog log;
        private IUserNotify notify;

        // Methods
        public static void Initialize(IUserNotify notify, ILog log)
        {
            InstanceField = new FormManager();
            Instance.notify = notify;
            Instance.log = log;
        }

        /// <summary>
        /// Creates an instance of child form of given form type
        /// </summary>
        /// <param name="formType">type of form to be created, for example SettingsXtraForm</param>
        /// <returns>reference to newly created child form</returns>
        private ChildForm CreateChildForm(Type formType, List<KeyValuePair<string, object>> parameters)
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
                if (parameters != null)
                {
                    newlyCreatedForm = (ChildForm)Program.Kernel.Get(formType,
                       parameters.Select(kvp => new ConstructorArgument(kvp.Key, kvp.Value)).ToArray());
                }
                else
                {
                    newlyCreatedForm = (ChildForm)Program.Kernel.Get(formType);
                }

                childForms[formType.Name].Add(newlyCreatedForm);
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
        public void CreateSettingsChildForm(int page)
        {
            try
            {
                SettingsXtraForm form = (SettingsXtraForm)OpenChildForm(typeof(SettingsXtraForm), null);

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
        public void ChildClosedEventHandler(object sender, EventArgs arguments)
        {
            if (typeof(ChildForm).IsAssignableFrom(sender.GetType()))
            {
                foreach (var childType in childForms)
                {
                    if (childType.Value.Remove((ChildForm)sender))
                    {
                        FramesCanOpen++;
                        break;
                    }
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
        private int FindOpenForm(string formTypeName, bool ReadMode)
        {
            int index = -1;
            index = childForms[formTypeName]
                .FindIndex(x => x.IsEditMode == ReadMode);
            return index;
        }

        /// <summary>
        /// Gives the ChildForm index in corresponding childForms list that contains the element defined by id.
        /// </summary>
        /// <param name="formTypeName">string representation of form type name, for example</param>
        /// <param name="id"></param>
        /// <returns>The zero-based index of the first occurrence of an element that matches the
        /// conditions defined by match, if found; otherwise, –1.</returns>
        private int GetFormIndex(string formTypeName, Guid id)
        {
            int index = 0;

            if (id != Guid.Empty)
            {
                index = childForms[formTypeName]
                    .FindIndex(x => x is INewEditEntityForm && ((INewEditEntityForm)x).IsMatchedByGuid(id));
            }
            else
            {
                bool isSingleForm =
                    formTypeName == typeof(SettingsXtraForm).Name ||
                    formTypeName == typeof(NotificationXtraForm).Name;

                if (!isSingleForm)
                {
                    index = -1;
                }
            }

            return index;
        }

        /// <summary>
        /// Register new list for type form and 
        /// </summary>
        /// <param name="formType"></param>
        /// <returns></returns>
        private List<ChildForm> GetListChildForm(Type formType)
        {
            if (!childForms.ContainsKey(formType.Name))
            {
                childForms.Add(formType.Name, new List<ChildForm>());
            }
            return childForms[formType.Name];
        }

        /// <summary>
        /// Creation of child form. Can be used from outside to pass some Guid of entity and number to newly created forms.
        /// </summary>
        /// <param name="formType">exact type of form</param>
        /// <param name="id">Guid of entity</param>
        /// <param name="parameters">input parameters passed to the newly created form</param>
        public ChildForm OpenChildForm(Type formType, List<KeyValuePair<string, object>> parameters, Guid id = default(Guid))
        {

            ChildForm form = null;
            if (typeof(ChildForm).IsAssignableFrom(formType))
            {
                var forms = GetListChildForm(formType);
                //search
                int indexById = GetFormIndex(formType.Name, id);

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
                    int index = FindOpenForm(formType.Name, true);

                    if (formType == typeof(RailcarNewEditXtraForm) && index >= 0)// this type form is open in edit mode
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
                                form = ShowChildForm(formType, parameters, false);
                            }
                        }
                    }
                    else
                    {
                        form = ShowChildForm(formType, parameters, true);
                    }
                }
            }
            else
            {
                var e = new ApplicationException(String.Format("Could not create child form {0} because not of child type.", formType.Name));
                log.Error(e.Message);
                throw e;
            }
            return form;
        }

        private ChildForm ShowChildForm(Type formType, List<KeyValuePair<string, object>> parameters, bool IsEditMode = true)
        {
            ChildForm form = CreateChildForm(formType, parameters);

            if (form != null)
            {
                ShowChildForm(form);
                if (!IsEditMode)
                {
                    ((ChildForm)form).IsEditMode = false;
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
            try
            {
                notify.ShowProcessing();
                form.Show();
                form.WindowState = FormWindowState.Normal;
                form.WindowState = FormWindowState.Maximized;
            }
            finally
            {
                notify.HideProcessing();
            }
        }

        // Properties
        public static FormManager Instance
        {
            get
            {
                if (InstanceField == null)
                {
                    throw new ArgumentException("FormManager not init!");
                }
                return InstanceField;
            }
        }

        public Dictionary<string, List<ChildForm>> ChildForms
        {
            get
            {
                return childForms;
            }
        }

    }
}