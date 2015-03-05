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
        //path constants
        public const string DataDirName = "Data";
        public const string AttachDirName = "Attachments";
        public const string TmpDirName = "tmp";
        public const string FilesToAttachDirName = "FilesToAttach";
        public const string EndPath = "\\";

        public static string FilesToAttachFolder = Path.Combine(Directory.GetCurrentDirectory(), DataDirName, AttachDirName, FilesToAttachDirName) + EndPath;
        public static string TargetPath = Path.Combine(Directory.GetCurrentDirectory(), DataDirName, AttachDirName) + EndPath;
        public static string TargetPathForView = Path.Combine(Directory.GetCurrentDirectory(), DataDirName, AttachDirName, TmpDirName) + EndPath;

        public const string LanguagesFolderName = "Languages";
        public const string BaseLanguageFileName = "Strings";
        public const string LanguagesResourcesFolderName = "Resources";
        public static string Languages = Path.Combine(Directory.GetCurrentDirectory(), LanguagesFolderName);
        public static string LanguagesResources = Path.Combine(Directory.GetCurrentDirectory(), LanguagesFolderName, LanguagesResourcesFolderName);

        public static string Logs = Path.Combine(Directory.GetCurrentDirectory(), "Logs");
        public static string Seeding = Path.Combine(Directory.GetCurrentDirectory(), "Seeding");
        public static string Importing = Path.Combine(Directory.GetCurrentDirectory(), "Importing");
    }
}
