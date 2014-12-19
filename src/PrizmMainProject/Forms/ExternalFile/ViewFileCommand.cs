using DevExpress.Mvvm.DataAnnotations;
using Prizm.Data.DAL;
using Prizm.Main.Commands;
using PrizmMain.Forms.ExternalFile;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.ExternalFile
{
    public class ViewFileCommand : ICommand
    {
        private readonly IFileRepository repo;
        private readonly ExternalFilesViewModel viewModel;
        private readonly IUserNotify notify;

        public ViewFileCommand(IFileRepository repo, ExternalFilesViewModel viewModel, IUserNotify notify)
        {
            this.repo = repo;
            this.viewModel = viewModel;
            this.notify = notify;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            string sourceFile = Path.Combine(Directory.GetCurrentDirectory(), "Attachments\\", viewModel.SelectedFile.Id.ToString() + viewModel.SelectedFile.FileName.Substring(viewModel.SelectedFile.FileName.LastIndexOf('.')));
            string tempFile = Path.Combine(Directory.GetCurrentDirectory(), "Attachments\\tmp", "random" + viewModel.SelectedFile.FileName.Substring(viewModel.SelectedFile.FileName.LastIndexOf('.')));

            if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), "Attachments\\tmp")))
            {
                Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "Attachments\\tmp"));
                DirectoryInfo directoryInfo = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), "Attachments\\tmp"));
                directoryInfo.Attributes |= FileAttributes.Hidden;
            }
            
            
            if (File.Exists(sourceFile))
            {
                File.Copy(sourceFile, tempFile);
                System.Diagnostics.Process.Start(tempFile);
            }
        }

        public virtual bool IsExecutable { get; set; }

        public bool CanExecute()
        {
            return viewModel.FileInfo != null;
        }
    }
}
