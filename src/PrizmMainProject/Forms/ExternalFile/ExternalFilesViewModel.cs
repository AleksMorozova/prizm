using Prizm.Data.DAL;
using DevExpress.Mvvm;
using Prizm.Domain.Entity;
using Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Prizm.Main.Forms.ExternalFile;
using Prizm.Main.Commands;
using DevExpress.Mvvm.POCO;
using Prizm.Main.Forms;

namespace PrizmMain.Forms.ExternalFile
{
    public class ExternalFilesViewModel: ViewModelBase, IDisposable
    {
        private readonly IFileRepository repo;
        private readonly AddExternalFileCommand addExternalFileCommand;
        private readonly DownloadFileCommand downloadFileCommand;
        private readonly ViewFileCommand viewFileCommand;
        private readonly IUserNotify notify;
        private readonly Item item;
        private BindingList<Prizm.Domain.Entity.File> files;
        private FileInfo fileInfo;
        private Prizm.Domain.Entity.File selectedFile;

        [Inject]
        public ExternalFilesViewModel(IFileRepository repo, Item item, IUserNotify notify)
        {
            this.repo = repo;
            this.item = item;
            this.notify = notify;
            if (item.Id != Guid.Empty)
            {
                RefreshFiles();
            }
            else 
            { 
                files = new BindingList<Prizm.Domain.Entity.File>(); 
            }

            addExternalFileCommand =
              ViewModelSource.Create(() => new AddExternalFileCommand(repo, this, notify));
            downloadFileCommand =
              ViewModelSource.Create(() => new DownloadFileCommand(repo, this, notify));
            viewFileCommand =
              ViewModelSource.Create(() => new ViewFileCommand(repo, this, notify));
        }

        public void RefreshFiles()
        {
            var fileList = repo.GetByItem(item);
            if (fileList != null)
            {
            files = new BindingList<Prizm.Domain.Entity.File>(fileList);
            }
        }

        public BindingList<Prizm.Domain.Entity.File> Files
        {
            get { return files; }
            set
            {
                if (value != files)
                {
                    files = value;
                    RaisePropertyChanged("Files");
                }
            }
        }

        public FileInfo FileInfo
        {
            get { return fileInfo; }
          set
          {
              if (value != fileInfo)
              {
                  fileInfo = value;
                  RaisePropertyChanged("FileInfo");
              }
          }
        }

        public Prizm.Domain.Entity.File SelectedFile
        {
            get { return selectedFile; }
            set
            {
                if (value != selectedFile)
                {
                    selectedFile = value;
                    RaisePropertyChanged("SelectedFile");
                }
            }
        }

        public string SelectedPath { get; set; } 
         public Item Item
         {
             get {return item;}
         }

         #region Commands
         public ICommand AddExternalFileCommand
        {
            get { return addExternalFileCommand; }
        }

         public ICommand DownloadFileCommand
         {
             get { return downloadFileCommand; }
         }

         public ICommand ViewFileCommand
         {
             get { return viewFileCommand; }
         }
        #endregion

        public void Dispose()
        {
            repo.Dispose();
        }
        
    }
}
