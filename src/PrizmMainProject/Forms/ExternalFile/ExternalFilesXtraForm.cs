using System;
using System.ComponentModel;
using DevExpress.XtraEditors;
using Prizm.Domain.Entity;
using PrizmMain.Forms.ExternalFile;
using Ninject.Parameters;
using Ninject;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Prizm.Main.Forms.ExternalFile
{
    public partial class ExternalFilesXtraForm : XtraForm
    {
        ExternalFilesViewModel viewModel;
        public ExternalFilesXtraForm(Item item)
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
          
            OpenFileDialog openFileDlg = new OpenFileDialog();
             openFileDlg.InitialDirectory = Directory.GetCurrentDirectory();
                if (openFileDlg.ShowDialog() == DialogResult.OK) 
                {
                    FileInfo fileInfo = new FileInfo(openFileDlg.FileName);
                    viewModel.FileInfo = fileInfo;
                    viewModel.AddExternalFileCommand.Execute();
                    files.DataSource = viewModel.Files; //the only variant that works
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
    }
}