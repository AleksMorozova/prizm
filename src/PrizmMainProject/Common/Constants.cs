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
        public const int DiameterDiffLimit = 2;
        public const int ThicknessDiffLimit = 2;

        public const string PositiveDigitMask = "\\d+";

        public const int MinSpoolCut = 20; // in millimeters

        // period in percents for remaining about execution of control operation
        public const string PercentForControlOperation = "*0.90";
    }
}
