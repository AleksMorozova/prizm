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
using PrizmMain.DummyData;


namespace PrizmMain.Forms.Railcar.Edit
{
   public partial class RailcarNewEditXtraForm : DevExpress.XtraEditors.XtraForm
   {
      RailcarViewModel viewModel;
      
      public RailcarNewEditXtraForm()
      {
          InitializeComponent();
      }

      private void RailcarNewEditXtraForm_Load(object sender, EventArgs e)
      {
         viewModel = (RailcarViewModel) Program.Kernel.GetService(typeof(RailcarViewModel));
         BindCommands();
         BindToViewModel();
      }

      private void BindToViewModel()
      {
         bindingSource.DataSource = viewModel;

         railcarNumber.DataBindings.Add("EditValue", bindingSource, "Number");
         certificateNumber.DataBindings.Add("EditValue", bindingSource, "Certificate");
         destination.DataBindings.Add("EditValue", bindingSource, "Destination");
         shippedDate.DataBindings.Add("EditValue", bindingSource, "ShippingDate");
      }

      private void BindCommands()
      {
         saveButton.BindCommand(() => viewModel.SaveCommand.Execute(), viewModel.SaveCommand);
      }

      private void RailcarNewEditXtraForm_FormClosed(object sender, FormClosedEventArgs e)
      {
         viewModel.Dispose();
         viewModel = null;
      }

      
   }
}