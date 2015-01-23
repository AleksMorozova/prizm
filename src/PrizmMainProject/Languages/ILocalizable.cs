using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Languages
{
    public interface ILocalizedItem
    {
        string Text { get; set; }
        string ResourceId { get; }
        void BackToDefault();
    }

    public interface ILocalizable : IEnumerable<ILocalizedItem>
    {
    }
}
