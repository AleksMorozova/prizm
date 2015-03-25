using Prizm.Main.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Reports
{
    [System.ComponentModel.DesignerCategory("")]
    public class LocalizableXtraReport : DevExpress.XtraReports.UI.XtraReport, ILocalizable
    {
        protected virtual List<LocalizedItem> CreateLocalizedItems() { return null; }

        private List<LocalizedItem> localizedItems = null;
        public IEnumerator<ILocalizedItem> GetEnumerator()
        {
            if (localizedItems == null)
            {
                localizedItems = CreateLocalizedItems();
            }
            return localizedItems.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
