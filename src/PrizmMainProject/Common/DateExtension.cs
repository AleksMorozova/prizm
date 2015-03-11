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

        public static bool CheckDiapason(DateTime startDate, DateTime endDate)
        {
            bool checkDiapason = false;
            if (startDate != DateTime.MinValue && endDate != DateTime.MinValue)
            {
                checkDiapason = (startDate <= endDate);
            }
            else
            {
                if (startDate == null)
                {
                    startDate=DateTime.MinValue;
                }
                if (endDate == null)
                {
                    endDate = DateTime.MaxValue;
                }

                checkDiapason= true;
            }
            return checkDiapason;
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
