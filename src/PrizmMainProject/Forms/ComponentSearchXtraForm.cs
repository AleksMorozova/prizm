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
    public partial class ComponentSearchXtraForm : DevExpress.XtraEditors.XtraForm
    {
        public ComponentSearchXtraForm()
        {
            InitializeComponent();

            //please remove data at this region in real project
            #region demoData
            //==============================================================
            //==============================================================

            componentNumber.Text = PrizmMain.DummyData.ComponentryDummy.componentNumber;
            certificate.Text = PrizmMain.DummyData.ComponentryDummy.certificate;

            DevExpress.XtraEditors.Controls.ComboBoxItemCollection coll = componentType.Properties.Items;

            PrizmMain.DummyData.ComponentryDummy.FillComboComponentType(coll);

            componentType.SelectedIndex = 2;

            searchResultsGrid.DataSource = PrizmMain.DummyData.ComponentryDummy.GetCmpDummy();

            //==============================================================
            //==============================================================
            #endregion

        }
     }
}