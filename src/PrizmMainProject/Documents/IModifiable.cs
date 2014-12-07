using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrizmMain.Documents
{
    public interface IModifiable
    {
        bool IsModified { get; set; }
        event Action<bool> Modified;

        bool IsEditMode { get; set; }
    }
}
