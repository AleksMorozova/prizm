using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Main.Common;
using System.IO;
using System.Globalization;
using System.Resources;
using Prizm.Main.Properties;

namespace Prizm.Main.Languages
{
    class LanguageManager : ILanguageManager
    {
        #region Language pack class

        private class LanguagePack
        {
            /// <summary>
            /// Groups information about chosen language around culture information
            /// </summary>
            /// <param name="culture">culture information</param>
            /// <param name="isDefault">is this culture default (only one could be default among all language packs)</param>
            public LanguagePack(CultureInfo culture, bool isDefault = false)
            {
                this.culture = culture;
                this.isDefault = isDefault;
                if (isDefault)
                {
                    manager = Resources.ResourceManager;
                }
            }
            private CultureInfo culture;
            private bool isDefault;
            private ResourceManager manager;

            public static implicit operator CultureInfo(LanguagePack pack)
            {
                return pack.culture;
            }

            public CultureInfo Culture { get { return culture; } }
            public bool IsDefault { get { return isDefault; } }
            public ResourceManager Manager { get { return manager; } set { manager = value; } }
        }

        #endregion // Language pack class

        private const string defaultCulture = "ru-RU";
        private CultureInfo defaultCultureInfo = new CultureInfo(defaultCulture);

        /// <summary>
        /// Is supposed to be called once, finding all available external files with translation resources
        /// </summary>
        private void FindAvailableTranslations()
        {
            List<string> translationFiles = new List<string>();
            var installedCultures = CultureInfo.GetCultures(CultureTypes.InstalledWin32Cultures);

            if (Directory.Exists(Directories.Languages))
            {
                IEnumerable<string> directoryFiles = Directory.EnumerateFiles(Directories.Languages, "*.??-??.resources", SearchOption.TopDirectoryOnly);
                foreach (var file in directoryFiles)
                {
                    string[] tmp = file.Split('.');
                    if (tmp.Length > 1) // just in case
                    {
                        translationFiles.Add(tmp[tmp.Length - 2].Trim());
                    }
                }
            }
            cultures.Clear();
            foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.InstalledWin32Cultures))
            {
                bool cultureIsDefault = ci.Name == defaultCulture;
                int index = translationFiles.FindIndex((cultureName) => { return ci.Name == cultureName; });
                if (index >= 0 && cultures.FindIndex((a) => { return ci.Name == a.Culture.Name; }) < 0 || cultureIsDefault)
                {
                    cultures.Add(new LanguagePack(ci, cultureIsDefault));

                    if (cultureIsDefault)
                    {
                        indexDefault = cultures.Count - 1;
                    }
                }
            }
            indexCurrent = indexDefault;
            if (cultures.Count < 0)
            {
                throw new ApplicationException("Language error: no default culture information available.");
            }
        }

        private List<LanguagePack> cultures = new List<LanguagePack>();
        private int indexDefault = -1;
        private int indexCurrent = -1;

        public IReadOnlyList<CultureInfo> GetCultures(out int indexDefault)
        {
                if (cultures.Count <= 0)
                {
                    FindAvailableTranslations();
                }
                indexDefault = this.indexDefault;
                List<CultureInfo> list = cultures.ConvertAll(new Converter<LanguagePack, CultureInfo>((lp) => { return (CultureInfo)lp; }));
                return list;
        }

        public bool LoadTranslation(CultureInfo culture)
        {
            bool status = false;
            int index = cultures.FindIndex((lp) => { return lp.Culture.Name == culture.Name; });
            if (index >= 0)
            {
                indexCurrent = index;
                status = true;
            }
            return status;
        }

        private ResourceManager manager = null;

        public ResourceManager Current 
        { 
            get 
            {
                if (manager == null)
                {
                    manager = ResourceManager.CreateFileBasedResourceManager(Directories.BaseLanguageFileName, Directories.LanguagesFolderName, null);
                }
                return manager ?? Default;
            } 
        }

        public ResourceManager Default
        {
            get
            {
                return Resources.ResourceManager;
            }
        }

        public CultureInfo CurrentCulture
        {
            get 
            {
                return cultures[indexCurrent].Culture;
            }
        }
        public CultureInfo DefaultCulture
        {
            get
            {
                return cultures[indexDefault].Culture;
            }
        }
    }
}
