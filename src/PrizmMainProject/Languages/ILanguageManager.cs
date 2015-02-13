using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Resources;
using Prizm.Domain.Entity.Security;

namespace Prizm.Main.Languages
{
    public interface ILanguageManager
    {
        IReadOnlyList<CultureInfo> GetCultures(out int indexDefault);
        bool LoadTranslation(CultureInfo culture);
        void ChangeLanguage(ILocalizable localizable);
        CultureInfo DefaultCultureInfo { get; }
        CultureInfo CurrentCulture { get; }
        string GetString(StringResource resourceDescription);
        IEnumerable<StringResource> EnumerateStringResources(System.Type stringResourcesStaticClassType);
        StringResource? FindById(System.Type stringResourcesStaticClassType, string resourceId);
        bool ApplyUsersLanguage(User user);
    }
}
