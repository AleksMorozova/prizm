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

namespace PrizmMain.Forms
{
    public partial class RailcarNewEditXtraForm : DevExpress.XtraEditors.XtraForm
    {
        public RailcarNewEditXtraForm()
        {
            InitializeComponent();
            railcarNumber.Text = "15";
            certificateNumber.Text = "7635356";
            pipeSize.Text = "1200x20";
            designer.Text = "Mill 1";
            client.Text = "Mill 2";
            purchaseOrder.Text = "456373";
            deliveryDate.Text = "10.09.2014";
            shippedDate.Text = "16.10.2014";

            BindingList<PipesDummy> pipeList = new BindingList<PipesDummy>();
            pipeList.Add(new PipesDummy { PipeNumber = 1342352, Size = "1100x20", Status = "production" });
            pipeList.Add(new PipesDummy { PipeNumber = 9634626, Size = "1100x20", Status = "production" });
            pipeList.Add(new PipesDummy { PipeNumber = 2141532, Size = "1100x20", Status = "production" });
            pipeList.Add(new PipesDummy { PipeNumber = 9634624, Size = "1100x20", Status = "production" });

            pipesList.DataSource = pipeList;

        }
    }
}