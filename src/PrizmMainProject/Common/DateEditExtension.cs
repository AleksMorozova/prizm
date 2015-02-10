using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Common
{
    public static class DateEditExtension
    {
        private static int MINYEAR = 1950;
        private static int MAXYEAR = 2150;

        public static int MinYear { get { return MINYEAR; } }
        public static int MaxYear { get { return MAXYEAR; } }

        public static void SetLimits(this DevExpress.XtraEditors.DateEdit edit)
        {
            edit.Properties.MinValue = new DateTime(MINYEAR, 1, 1);
            edit.Properties.MaxValue = new DateTime(MAXYEAR, 1, 1);
        }

        public static void SetLimits(this DevExpress.XtraEditors.Repository.RepositoryItemDateEdit edit)
        {
            edit.MinValue = new DateTime(MINYEAR, 1, 1);
            edit.MaxValue = new DateTime(MAXYEAR, 1, 1);
        }
    }
}
