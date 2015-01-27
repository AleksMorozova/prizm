using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Languages
{
    public interface ILocalizedItem
    {
        string Text { set; }
        int Count { get; }
        string this[int index] { set; }
        string GetResourceId(int index);
        void BackToDefault(int index);
        void Refresh();
    }

    public interface ILocalizable : IEnumerable<ILocalizedItem>
    {
    }
}
