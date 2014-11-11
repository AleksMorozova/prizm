using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using PrizmMain.DummyData;

namespace PrizmMain.Forms.Component.Search
{
    public partial class ComponentSearchXtraForm : XtraForm
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
            var bs = new BindingSource();
            bs.DataSource = MyComponent;

            //Set GridControl's dataSource
            searchResultsGrid.DataSource = bs;

            ComboBoxItemCollection coll = componentType.Properties.Items;

            ComponentryDummy.FillComboComponentType(coll);

            componentType.SelectedIndex = 2;

            //searchResultsGrid.DataSource = PrizmMain.DummyData.ComponentryDummy.GetCmpDummy();

            //==============================================================
            //==============================================================

            #endregion
        }
    }
}