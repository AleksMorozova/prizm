using Prizm.Data.DAL;
using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Prizm.Domain.Entity;

using Prizm.Domain.Entity.Setup;
using Prizm.Main.Common;
using Prizm.Main.Forms.MainChildForm.FirstSetupForm;
using Prizm.Main.Languages;
using System.Globalization;
using Prizm.Main.Properties;

using DevExpress.XtraBars;

namespace Prizm.Main.Forms.MainChildForm
{
    public class PrizmApplicationViewModel : ViewModelBase, IDisposable
    {
        private EnumWrapper<WorkstationType> workstationName;
        private readonly IUserNotify notify;
        private readonly IProjectRepository repo;
        private readonly ILanguageManager langManager;

        public Project ProjectSettings;

        [Inject]
        public PrizmApplicationViewModel(IProjectRepository repo, ILanguageManager langManager, IUserNotify notify)
        {
            this.repo = repo;
            this.ProjectSettings = repo.GetSingle();
            this.langManager = langManager;
            this.notify = notify;
        }

        /// <summary>
        /// The only non-UI tool returning UI strings (taken from translation files) 
        /// because list of available languages is dynamic and depends on available language files.
        /// </summary>
        /// <returns>collection of menu items to show as languages</returns>
        public IReadOnlyList<CultureInfo> GetLanguagesCultures(out int indexDefault)
        {
            return langManager.GetCultures(out indexDefault);
        }

        public void ChooseTranslation(CultureInfo culture)
        {
            bool status = langManager.LoadTranslation(culture);
            if (!status)
            {
                notify.ShowError(langManager.Current.GetString(Resources.Action), langManager.Current.GetString(Resources.PipeTestResultType_Diapason));
                notify.ShowError(Resources.ResourceManager.GetString(Resources.Action), Resources.ResourceManager.GetString(Resources.PipeTestResultType_Diapason));
                notify.ShowError(Resources.Action, Resources.PipeTestResultType_Diapason);
                notify.ShowError("MenuFile", "MenuFile");
                notify.ShowError(langManager.Current.GetString("MenuFile"), langManager.Current.GetString("MenuFile"));
            }
        }

        public EnumWrapper<WorkstationType> WorkstationType
        {
            get
            {
                return
                   workstationName ??
                    new EnumWrapper<WorkstationType>() { Value = ProjectSettings.WorkstationType };
            }
            set
            {
                workstationName = value;
            }
        }


        public void Dispose()
        {
            repo.Dispose();
        }
    }
}
