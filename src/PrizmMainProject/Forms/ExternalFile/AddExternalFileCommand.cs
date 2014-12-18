using Prizm.Data.DAL;
using Prizm.Main.Commands;
using PrizmMain.Forms.ExternalFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataAnnotations;
using System.IO;

namespace Prizm.Main.Forms.ExternalFile
{
    public class AddExternalFileCommand : ICommand
    {
        private readonly IFileRepository repo;
        private readonly ExternalFilesViewModel viewModel;
       // private readonly IUserNotify notify;

        public AddExternalFileCommand(IFileRepository repo, ExternalFilesViewModel viewModel)
        {
            this.repo = repo;
            this.viewModel = viewModel;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            string targetPath = Path.Combine(Directory.GetCurrentDirectory(), "Attachments\\");
            Prizm.Domain.Entity.File fileEntity = new Domain.Entity.File()
            {
                FileName = viewModel.FileInfo.Name, 
                UploadDate =  DateTime.Now,
                Item = viewModel.Item,
                IsActive = true
            };
            repo.BeginTransaction();
            repo.Save(fileEntity);
            repo.Commit();
            repo.Evict(fileEntity);

            if (!Directory.Exists(targetPath))
            {
                Directory.CreateDirectory(targetPath);
                DirectoryInfo directoryInfo = new DirectoryInfo(targetPath);
                directoryInfo.Attributes |= FileAttributes.Hidden;
            }
            viewModel.FileInfo.CopyTo(string.Format("{0}{1}{2}", targetPath, fileEntity.Id, viewModel.FileInfo.Extension));
            viewModel.RefreshFiles();

        }

        public virtual bool IsExecutable { get; set; }

        public bool CanExecute()
        {
            return viewModel.FileInfo != null;
        }
    }
}
