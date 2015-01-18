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
using Prizm.Main.Common;

namespace Prizm.Main.Languages
{
    class LanguageManager : ILanguageManager
    {
        private class LanguagePack
        {
            public LanguagePack(CultureInfo culture, string fullPathFile, string baseNameFile, bool isDefault = false)
            {
                this.culture = culture;
                this.fullPathFile = fullPathFile;
                this.baseNameFile = baseNameFile;
                this.isDefault = isDefault;
            }
            private CultureInfo culture;
            private string fullPathFile;
            private string baseNameFile;
            private bool isDefault;

            public static implicit operator CultureInfo(LanguagePack pack)
            {
                return pack.culture;
            }

            public CultureInfo Culture { get { return culture; } }
            public string FullPathFile { get { return fullPathFile; } }
            public string BaseNameFile { get { return baseNameFile; } }
            public bool IsDefault { get { return isDefault; } }
        }

        private const string defaultCulture = "ru-RU";
        private CultureInfo defaultCultureInfo = new CultureInfo(defaultCulture);

        private void FindAvailableTranslations()
        {
            List<Tuple<string, string, string>> translationFiles = new List<Tuple<string, string, string>>();
            var installedCultures = CultureInfo.GetCultures(CultureTypes.InstalledWin32Cultures);

            if (Directory.Exists(Directories.Languages))
            {
                IEnumerable<string> directoryFiles = Directory.EnumerateFiles(Directories.Languages, "*.??-??.resources", SearchOption.TopDirectoryOnly);
                foreach (var file in directoryFiles)
                {
                    string[] tmp = file.Split('.');
                    if (tmp.Length > 1) // just in case
                    {
                        FileInfo fi = new FileInfo(file);
                        translationFiles.Add(new Tuple<string, string, string>(tmp[tmp.Length - 2].Trim(), file, fi.Name));
                    }
                }
            }
            cultures.Clear();
            foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.InstalledWin32Cultures))
            {
                int translationFileIndex = translationFiles.FindIndex((a) => { return ci.Name == a.Item1; });
                bool cultureIsDefault = ci.Name == defaultCulture;
                if (translationFileIndex >= 0 && cultures.FindIndex((a) => { return ci.Name == a.Culture.Name; }) < 0 || cultureIsDefault)
                {
                    cultures.Add(new LanguagePack(ci,
                        translationFileIndex >= 0 ? translationFiles[translationFileIndex].Item2 : String.Empty,
                        translationFileIndex >= 0 ? translationFiles[translationFileIndex].Item3 : String.Empty,
                        cultureIsDefault));

                    if (cultureIsDefault)
                    {
                        indexDefault = cultures.Count - 1;
                    }
                }
            }
            if (cultures.Count < 0)
            {
                throw new ApplicationException("Language error: no default culture information available.");
            }
        }

        private List<LanguagePack> cultures = new List<LanguagePack>();
        private int indexDefault = -1;

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
                LanguagePack lp = cultures[index];
                if(!lp.IsDefault || lp.IsDefault && !String.IsNullOrWhiteSpace(lp.FullPathFile))
                {
                    FileInfo fi = new FileInfo(cultures[index].FullPathFile);
                    string name = fi.Name;
                    manager = ResourceManager.CreateFileBasedResourceManager(fi.Name, Directories.LanguagesFolderName, null);
                }
                else
                {
                    manager = null;
                }
                status = true;
            }
            return status;
        }

        private ResourceManager manager = null;

        public ResourceManager Current 
        { 
            get 
            {
                return (manager == null ? Resources.ResourceManager : manager);
            } 
        }

    }
}
