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

namespace PrizmMain.Forms.ExternalFile
{
    public class ExternalFilesViewModel: ViewModelBase, IDisposable
    {
        private readonly IFileRepository repo;
        private readonly AddExternalFileCommand addExternalFileCommand;
        private readonly Item item;
        private BindingList<Prizm.Domain.Entity.File> files;
        private FileInfo fileInfo;

        [Inject]
        public ExternalFilesViewModel(IFileRepository repo, Item item)
        {
            this.repo = repo;
            this.item = item;
            if (item.Id != Guid.Empty)
            {
                RefreshFiles();
            }
            else 
            { 
                files = new BindingList<Prizm.Domain.Entity.File>(); 
            }
            addExternalFileCommand =
              ViewModelSource.Create(() => new AddExternalFileCommand(repo, this));
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

         public Item Item
         {
             get {return item;}
         }

        public ICommand AddExternalFileCommand
        {
            get { return addExternalFileCommand; }
        }

        public void Dispose()
        {
            repo.Dispose();
        }
        
    }
}
