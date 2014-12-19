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
    public class DownloadFileCommand : ICommand
    {
        private readonly IFileRepository repo;
        private readonly ExternalFilesViewModel viewModel;
        private readonly IUserNotify notify;

        public DownloadFileCommand(IFileRepository repo, ExternalFilesViewModel viewModel, IUserNotify notify)
        {
            this.repo = repo;
            this.viewModel = viewModel;
            this.notify = notify;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            string sourceFile = Path.Combine(Directory.GetCurrentDirectory(), "Attachments\\", viewModel.SelectedFile.Id.ToString() + viewModel.SelectedFile.FileName.Substring(viewModel.SelectedFile.FileName.LastIndexOf('.')));
            if (File.Exists(sourceFile))
            {
                File.Copy(sourceFile, viewModel.SelectedPath);
                notify.ShowInfo("Файл успешно скачан", "Yay!");
            }
        }

        public virtual bool IsExecutable { get; set; }

        public bool CanExecute()
        {
            return viewModel.SelectedFile != null;
        }
    }
}
