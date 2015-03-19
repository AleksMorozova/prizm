using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Common
{
    public static class InspectorsPopUpExtensions
    {
        public static void SetSize(this RepositoryItemPopupContainerEdit container)
        {
            container.PopupFormSize = new System.Drawing.Size(400, 250);
        }
    }
}
