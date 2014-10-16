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
    public partial class RailcarSearchXtraForm : DevExpress.XtraEditors.XtraForm
    {
        public RailcarSearchXtraForm()
        {
            InitializeComponent();
            certificateNumber.Text = "7635356";
            designer.Text = "Mill 1";
            client.Text = "Mill 2";
            purchaseOrder.Text = "456373";
            deliveryDate.Text = "10.09.2014";
            shippedDate.Text = "16.10.2014";
        }
    }
}