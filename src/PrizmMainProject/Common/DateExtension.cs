using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Common
{
    public static class DateExtension
    {
        public static bool IsValid(this DateTime date)
        {
            return Constants.MinYear <= date.Year && date.Year <= Constants.MaxYear; 
        }

        public static bool IsValid(this DateTime? date)
        {
            if(date.Value == null)
            {
                return true;
            }
            else
            {
                return Constants.MinYear <= date.Value.Year && date.Value.Year <= Constants.MaxYear;
            }
            
        }
    }
}
