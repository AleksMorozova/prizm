using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Common
{
    public static class Directories
    {
        public static string FilesToAttachFolder = Path.Combine(Directory.GetCurrentDirectory(), "Attachments\\FilesToAttach\\");
        public static string TargetPath = Path.Combine(Directory.GetCurrentDirectory(), "Attachments\\");
        public static string TargetPathForView = Path.Combine(Directory.GetCurrentDirectory(), "Attachments\\tmp\\");
    }
}
