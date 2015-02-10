using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Common
{
    public static class DateEditExtension
    {
        public static int MinYear { get { return Constants.MinYear; } }
        public static int MaxYear { get { return Constants.MaxYear; } }

        public static void SetLimits(this DevExpress.XtraEditors.DateEdit edit)
        {
            edit.Properties.MinValue = new DateTime(Constants.MinYear, 1, 1);
            edit.Properties.MaxValue = new DateTime(Constants.MaxYear, 1, 1);
        }

        public static void SetLimits(this DevExpress.XtraEditors.Repository.RepositoryItemDateEdit edit)
        {
            edit.MinValue = new DateTime(Constants.MinYear, 1, 1);
            edit.MaxValue = new DateTime(Constants.MaxYear, 1, 1);
        }
    }
}
