using System;
using System.ComponentModel;
using DevExpress.XtraEditors;
using Prizm.Domain.Entity;
using PrizmMain.Forms.ExternalFile;
using Ninject.Parameters;
using Ninject;

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

    }
}