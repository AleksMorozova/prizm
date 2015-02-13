using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Common
{
    public static class DateExtension
    {
        /// <summary>
        /// Check date limits for save to DB 
        /// </summary>
        /// <param name="date">DateTime</param>
        /// <returns></returns>
        public static bool IsValid(this DateTime date)
        {
            return Constants.MinYear <= date.Year && date.Year <= Constants.MaxYear;
        }

        /// <summary>
        /// Check date limits for save to DB & Convert DatetimeMinValue to NULL value;
        /// </summary>
        /// <param name="date">Nullable<DateTime></param>
        /// <returns></returns>
        public static bool IsValid(this DateTime? date)
        {
            bool result = true;
            if(date != null)
            {
                if(date.Value == DateTime.MinValue)
                {
                    date = null;
                }
                else
                {
                    result = Constants.MinYear <= date.Value.Year && date.Value.Year <= Constants.MaxYear;
                }
            }
            return result;

        }
    }
}
