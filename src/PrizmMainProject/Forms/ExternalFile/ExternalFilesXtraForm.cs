using System;
using System.ComponentModel;
using DevExpress.XtraEditors;
using Prizm.Domain.Entity;
using Prizm.Main.Forms.ExternalFile;
using Ninject.Parameters;
using Ninject;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using Prizm.Main.Common;

namespace Prizm.Main.Forms.ExternalFile
{
    public partial class ExternalFilesXtraForm : XtraForm
    {
        private ExternalFilesViewModel viewModel;

        public ExternalFilesXtraForm(Guid item)
        {
            InitializeComponent();
            viewModel = (ExternalFilesViewModel)Program
                .Kernel
                .Get<ExternalFilesViewModel>(
                new ConstructorArgument("item", item));
        }

        private void ExternalFilesXtraForm_Load(object sender, EventArgs e)
        {
            files.DataSource = viewModel.Files;
        }

        private void addFile_Click(object sender, EventArgs e)
        {
            Guid newNameId = Guid.NewGuid();
            OpenFileDialog openFileDlg = new OpenFileDialog();
            // TODO Save new files position to user settings.
            openFileDlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                FileInfo fileInfo = new FileInfo(openFileDlg.FileName);
                if (!Directory.Exists(Directories.FilesToAttachFolder))
                {
                    Directory.CreateDirectory(Directories.FilesToAttachFolder);
                    DirectoryInfo directoryInfo = new DirectoryInfo(Directories.FilesToAttachFolder);
                    DirectoryInfo directoryInfoParent = new DirectoryInfo(Directories.TargetPath);
                    directoryInfo.Attributes |= FileAttributes.Hidden;
                    directoryInfoParent.Attributes |= FileAttributes.Hidden;
                }
                fileInfo.CopyTo(string.Format("{0}{1}{2}", Directories.FilesToAttachFolder, newNameId, fileInfo.Extension));
                viewModel.FilesToAttach.Add(newNameId.ToString() + fileInfo.Extension, fileInfo.Name);
                Prizm.Domain.Entity.File newFile = new Prizm.Domain.Entity.File() {FileName = fileInfo.Name, UploadDate = DateTime.Now };
                viewModel.Files.Add(newFile);
            }
        }

        private void downloadButton_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Prizm.Domain.Entity.File selectedFile = filesView.GetRow(filesView.FocusedRowHandle) as Prizm.Domain.Entity.File;
            if (selectedFile != null)
            {
                viewModel.SelectedFile = selectedFile;
                SaveFileDialog saveFileDlg = new SaveFileDialog();
                saveFileDlg.FileName = selectedFile.FileName;
                // TODO Save new files position to user settings.
                saveFileDlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                if (saveFileDlg.ShowDialog() == DialogResult.OK)
                {
                    viewModel.SelectedPath = saveFileDlg.FileName;
                    viewModel.DownloadFileCommand.Execute();
                }
            }
        }

        private void viewButton_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Prizm.Domain.Entity.File selectedFile = filesView.GetRow(filesView.FocusedRowHandle) as Prizm.Domain.Entity.File;
            if (selectedFile != null)
            {
                viewModel.SelectedFile = selectedFile;
                viewModel.ViewFileCommand.Execute();
            }
        }

        public ExternalFilesViewModel ViewModel
        {
            get { return viewModel; }
            set
            {
                if (value != viewModel)

                    viewModel = value;
            }
        }
    }
}
