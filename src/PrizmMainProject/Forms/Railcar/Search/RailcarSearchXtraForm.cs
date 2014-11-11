using System;
using System.ComponentModel;
using DevExpress.XtraEditors;
using PrizmMain.DummyData;

namespace PrizmMain.Forms.Railcar.Search
{
    public partial class RailcarSearchXtraForm : XtraForm
    {
        public RailcarSearchXtraForm()
        {
            InitializeComponent();
            certificateNumber.Text = "7635356";
            railcarNumber.Text = "15";
            destination.Text = "Trans Gas LLC";
            shippedDate.Text = "16.10.2014";
            DateTime date = DateTime.Now;

            var railcarsList = new BindingList<RailcarsDummy>
            {
                new RailcarsDummy
                {
                    RailcarNumber = 151415,
                    Status = "ready",
                    DeliveryDate = date,
                    ShippedDate = date
                },
                new RailcarsDummy
                {
                    RailcarNumber = 161241,
                    Status = "ready",
                    DeliveryDate = date,
                    ShippedDate = date
                },
                new RailcarsDummy
                {
                    RailcarNumber = 925747,
                    Status = "cancel",
                    DeliveryDate = date,
                    ShippedDate = date
                },
                new RailcarsDummy
                {
                    RailcarNumber = 247481,
                    Status = "ready",
                    DeliveryDate = date,
                    ShippedDate = date
                }
            };
            railcarList.DataSource = railcarsList;
        }
    }
}