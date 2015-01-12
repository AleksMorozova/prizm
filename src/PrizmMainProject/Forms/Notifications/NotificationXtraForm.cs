using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ninject.Parameters;
using Prizm.Main;
using Prizm.Main.Forms.MainChildForm;
using Prizm.Main.Forms.Notifications;
using PrizmMain.DummyData;


namespace PrizmMain.Forms.Notifications
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class NotificationXtraForm : ChildForm
    {

        // Fields
        private NotificationViewModel viewModel;

        // Methods
        public NotificationXtraForm()
        {
            this.components = null;
            this.InitializeComponent();
        }

        private void NotificationXtraForm_Load(object sender, EventArgs e)
        {
            viewModel = (NotificationViewModel)Program.Kernel.GetService(typeof(NotificationViewModel));
            BindToViewModel();

        }

        private void BindToViewModel()
        {
            notificationBindingSource.DataSource = viewModel;
            gridControlMessage.DataBindings.Add("DataSource", notificationBindingSource, "Notification");
        }

        private void gridControlMessage_DoubleClick(object sender, EventArgs e)
        {
            int selectedItem = gridViewNotification.GetFocusedDataSourceRowIndex();

            Type typeEditor = viewModel.Notification[selectedItem].Editor;

            var parent = this.MdiParent as PrizmApplicationXtraForm;
            var id = viewModel.Notification[selectedItem].Id;

            parent.CreateChildForm( typeEditor, id, new ConstructorArgument("id", id));
        }

        private void NotificationXtraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            viewModel.Dispose();
            viewModel = null;
        }




    }
}
