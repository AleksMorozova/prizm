using System;
using System.ComponentModel;
using DevExpress.XtraEditors;
using Domain.Entity;

namespace PrizmMain.Forms.ExternalFile
{
    public partial class ExternalFilesXtraForm : XtraForm
    {
        public ExternalFilesXtraForm()
        {
            InitializeComponent();
            var list = new BindingList<File>
            {
                new File {Description = "Aaa", FileName = "ERER", UploadDate = DateTime.Now}
            };
            files.DataSource = list;
        }
    }
}