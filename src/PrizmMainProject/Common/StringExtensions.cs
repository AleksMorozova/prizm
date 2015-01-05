using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Common
{
    static class StringExtensions
    {
        public static string EscapeCharacters (this String str)
        {
            return str.Replace(@"\", @"\\")
                            .Replace(@"%", @"\%")
                                .Replace(@"[", @"\[")
                                    .Replace(@"]", @"\]")
                                        .Replace(@"_", @"\_")
                                            .Replace("'", @"''");
        }
    }
}
