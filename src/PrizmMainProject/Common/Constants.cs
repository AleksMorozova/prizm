using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Common
{
    public class Constants
    {
        public const int StatusNotifyHistorySize = 400;
        public const float WallThicknessPrecision = 0.01f;
        public const int MinYear = 1950;
        public const int MaxYear = 2150;

        public const string PositiveDigitMask = "\\d+";

        /// <summary>
        /// Minimal length which can be cut from pipe, in millimeters
        /// </summary>
        public const int MinSpoolCut = 20;

        /// <summary>
        /// period in percents for remaining about execution of control operation
        /// </summary>
        public const string PercentForInspectionOperation = "*0.90";

        /// <summary>
        /// Warning should be shown this amount of days before expiration
        /// </summary>
        public const int DaysToExpirationWarning = 30;
    }
}
