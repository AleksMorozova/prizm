using Prizm.Domain.Entity.Setup;
using System.Collections.Generic;
using System.Text;
namespace Prizm.Domain.Entity
{
    // FIX: remove??
    public class Project : Item
    {
        public virtual string Title { get; set; }
        public virtual string Client { get; set; }
        public virtual string MillName { get; set; }
        public virtual int DocumentSizeLimit { get; set; }
        public virtual WorkstationType WorkstationType { get; set; }
        public virtual string MillPipeNumberMask { get; set; }
        public virtual string MillPipeNumberMaskRegexp { get; set; }
        public virtual bool IsNative { get; set; }

        public static string FormRegExp(string millPipeNumberMask)
        {
            StringBuilder mask = new StringBuilder();
            if (millPipeNumberMask != string.Empty && millPipeNumberMask != null)
            {          
             foreach (char ch in millPipeNumberMask)
                    {
                        string convertedToRegex = "";
                        switch (ch)
                        {
                           case '#': convertedToRegex = @"\d"; break;
                           case '@': convertedToRegex = @"\p{Lu}"; break;
                           case '%': convertedToRegex = @"(\d|\p{Lu})"; break;
                           case '?': convertedToRegex = @"\w"; break;
                           default: convertedToRegex = ch.ToString(); break;
                        }
                        mask.Append(convertedToRegex);
                    }
            }
            return mask.ToString();
        }
    }
}