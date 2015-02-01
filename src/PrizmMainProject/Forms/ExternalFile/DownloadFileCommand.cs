using DevExpress.Mvvm.DataAnnotations;
using Prizm.Data.DAL;
using Prizm.Main.Commands;
using Prizm.Main.Common;
using Prizm.Main.Languages;
using Prizm.Main.Properties;
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

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        public DownloadFileCommand(IFileRepository repo, ExternalFilesViewModel viewModel, IUserNotify notify)
        {
            this.repo = repo;
            this.viewModel = viewModel;
            this.notify = notify;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            if (CanExecute())
            {
                string sourceFile = Path.Combine(Directories.TargetPath, viewModel.SelectedFile.NewName);
                if (File.Exists(sourceFile))
                {
                    File.Copy(sourceFile, viewModel.SelectedPath);
                    notify.ShowNotify(Program.LanguageManager.GetString(StringResources.ExternalFiles_FileDownloadSuccess), Program.LanguageManager.GetString(StringResources.ExternalFiles_FileDownloadHeader));
                }
            }
            else
            {
                notify.ShowInfo(Program.LanguageManager.GetString(StringResources.ExternalFiles_FileViewDownloadFail), Program.LanguageManager.GetString(StringResources.ExternalFiles_FileViewDownloadFailHeader));
            }
        }

        public bool CanExecute()
        {
            return viewModel.SelectedFile.NewName != null;
        }
    }
}
