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
    public partial class SettingsXtraForm : ChildForm
    {
        public SettingsXtraForm()
        {
            InitializeComponent();

            //TODO:Remove dummy data connection
            gridControlInspection.DataSource = Dev.DummyData.CreateControlOperationTable();}
    }
}