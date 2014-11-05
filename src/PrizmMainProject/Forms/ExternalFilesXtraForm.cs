using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PrizmMain.Forms
{
    public partial class ExternalFilesXtraForm : DevExpress.XtraEditors.XtraForm
    {
        public ExternalFilesXtraForm()
        {
            InitializeComponent();
            BindingList<Domain.Entity.File> list = new BindingList<Domain.Entity.File>();
            list.Add( new Domain.Entity.File() { Description = "Aaa", FileName = "ERER", UploadDate = DateTime.Now });
            files.DataSource = list;
        }
    }
}