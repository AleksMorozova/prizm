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
        public PurchaseOrderXtraForm()
            : this("", "")
        {

        }
        public PurchaseOrderXtraForm(string orderNumber, string date)
        {
            InitializeComponent();
            purchaseOrderNumber.Text = orderNumber;

            if (string.IsNullOrWhiteSpace(orderNumber))
            {
                //TODO: create new order
            }
            else
            {
                //TODO: get order from repo by number 
                purchaseOrderDate.Text = date;
                purchaseOrderNumber.Text = orderNumber;
            }
        }


    }
}