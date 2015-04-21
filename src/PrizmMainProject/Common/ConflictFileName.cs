using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Common
{
    class ConflictFileName
    {
        private string fileName;
        private string folderName;

        public string FileName
        {
            get
            {
                return fileName;
            }
        }
        public string FolderName
        {
            get
            {
                return folderName;
            }
        }
        public string PipeNumber
        {
            get
            {
                int i = fileName.IndexOf(".");
                return fileName.Substring(i + 1); 
            }
        }

        public ConflictFileName(string id, string number) 
        {
            this.fileName = id + "." + number;
            this.folderName =  id + "." + number;
        }

        public ConflictFileName(string fileName)
        {
            this.fileName = fileName;
        }
    }
}
