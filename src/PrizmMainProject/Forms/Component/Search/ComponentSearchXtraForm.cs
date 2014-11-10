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
    public partial class ComponentSearchXtraForm : DevExpress.XtraEditors.XtraForm
    {
        private List<ComponentDataDemo> MyComponent;

        public ComponentSearchXtraForm()
        {
            InitializeComponent();

            //please remove data at this region in real project
            #region demoData
            //==============================================================
            //==============================================================

            MyComponent = ComponentryDummy.GetCmpDummy();

            //Initialize bindingSource
            BindingSource bs = new BindingSource();
            bs.DataSource = MyComponent;

            //Set GridControl's dataSource
            searchResultsGrid.DataSource = bs;

            DevExpress.XtraEditors.Controls.ComboBoxItemCollection coll = componentType.Properties.Items;

            PrizmMain.DummyData.ComponentryDummy.FillComboComponentType(coll);

            componentType.SelectedIndex = 2;

            //searchResultsGrid.DataSource = PrizmMain.DummyData.ComponentryDummy.GetCmpDummy();

            //==============================================================
            //==============================================================
            #endregion

        }
     }
}