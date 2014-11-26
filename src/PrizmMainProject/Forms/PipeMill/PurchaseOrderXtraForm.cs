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
using Domain.Entity.Mill;

namespace PrizmMain.Forms.PipeMill
{
    public partial class PurchaseOrderXtraForm : DevExpress.XtraEditors.XtraForm
    {
        public PurchaseOrderXtraForm(PurchaseOrder order)
        {
            InitializeComponent();
            purchaseOrderNumber.Text = order.Number;
            purchaseOrderDate.Text = order.Date.ToShortDateString();
        }
    }
}