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

namespace PrizmMain.Forms.ExternalFile
{
    public class ExternalFilesViewModel: ViewModelBase, IDisposable
    {
        private readonly IFileRepository repo;
        private BindingList<File> files;
        [Inject]
        public ExternalFilesViewModel(IFileRepository repo, Item item)
        {
            this.repo = repo;
            var fileList = repo.GetByItem(item);
            if (fileList != null)
            {
                files = new BindingList<File>(fileList);
            }
        }

        public BindingList<File> Files
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

        public void Dispose()
        {
            repo.Dispose();
        }
    }
}
