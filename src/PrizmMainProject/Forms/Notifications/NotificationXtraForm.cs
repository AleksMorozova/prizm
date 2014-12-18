using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prizm.Main.Forms.MainChildForm;
using PrizmMain.DummyData;


namespace PrizmMain.Forms.Notifications
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class NotificationXtraForm : ChildForm
    {

        // Methods
 
        public NotificationXtraForm()
        {
            this.components = null;
            this.InitializeComponent();
        }

        private void HeatXtraForm_Load(object sender, EventArgs e)
        {
            NotificationOwners[] ownersArray = new NotificationDummy().GetAllOwners().ToArray<NotificationOwners>();
            this.notificationBindingSource.DataSource = ownersArray;
            this.BindToViewModel();
        }

        private void BindToViewModel()
        {
            this.RefreshControls();
        }

        private void HeatXtraForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }


        private void RefreshControls()
        {
        }


    }
}
