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
using System.Resources;

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
        /// returns information about translations available (including internal default)
        /// </summary>
        /// <param name="indexDefault">out parameter. index of default translation in returned list</param>
        /// <returns>read only list of culture info</returns>
        public IReadOnlyList<CultureInfo> GetLanguagesCultures(out int indexDefault)
        {
            return langManager.GetCultures(out indexDefault);
        }

        /// <summary>
        /// Changes current language (culture info)
        /// </summary>
        /// <param name="culture">new culture</param>
        /// <returns>status if new localization can be loaded</returns>
        public bool ChooseTranslation(CultureInfo culture)
        {
            return langManager.LoadTranslation(culture);
        }

        /// <summary>
        /// retrieves localized string when available. Otherwise retrieves default string.
        /// </summary>
        /// <param name="resourceId">id of requested string resource</param>
        /// <returns>localized string</returns>
        public string GetLocalizedString(string resourceId)
        {
            string ret = "<no resource>";
            try
            {
                ret = langManager.Current.GetString(resourceId, langManager.CurrentCulture);
            }
            catch (SystemException )
            {
                try
                {
                    ret = langManager.Default.GetString(resourceId, langManager.DefaultCulture);
                }
                catch (SystemException )
                {
                    #if DEBUG
                    throw new ApplicationException(String.Format("No default string resource defined for ID {0}", resourceId));
                    #endif
                }
            }
            return ret;
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
