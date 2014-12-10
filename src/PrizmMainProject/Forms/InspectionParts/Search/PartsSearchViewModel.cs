using DevExpress.Mvvm;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.InspectionParts.Search
{
    public class PartsSearchViewModel : ViewModelBase, IDisposable
    {

        [Inject]
        public PartsSearchViewModel()
        {

        }

        #region IDisposable Members

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
