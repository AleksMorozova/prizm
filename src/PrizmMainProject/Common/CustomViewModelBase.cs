using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Common
{
    public class CustomViewModelBase: ViewModelBase
    {
        protected new void RaisePropertyChanged(string propertyName)
        {
            if (!Program.IsCommandRunning)
            {
                base.RaisePropertyChanged(propertyName);
            }
        }
    }
}
