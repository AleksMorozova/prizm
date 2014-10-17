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

            List<PipesDummy> pipeList = new List<PipesDummy>();
            PipesDummy pipe1 = new PipesDummy();
            pipe1.PipeNumber = 1342352;
            pipe1.Status = "production";
            pipe1.Size = "1100x20";
            pipe1.Manufacturer = "Mill 1";
            pipeList.Add(pipe1);

            PipesDummy pipe2 = new PipesDummy();
            pipe2.PipeNumber = 1342352;
            pipe2.Status = "production";
            pipe2.Size = "1100x20";
            pipe2.Manufacturer = "Mill 1";
            pipeList.Add(pipe2);

            PipesDummy pipe3 = new PipesDummy();
            pipe3.PipeNumber = 1342352;
            pipe3.Status = "production";
            pipe3.Size = "1100x20";
            pipe3.Manufacturer = "Mill 1";
            pipeList.Add(pipe3);

            PipesDummy pipe4 = new PipesDummy();
            pipe4.PipeNumber = 1342352;
            pipe4.Status = "production";
            pipe4.Size = "1100x20";
            pipe4.Manufacturer = "Mill 1";
            pipeList.Add(pipe4);

            pipesList.DataSource = pipesList;
        }
    }
}