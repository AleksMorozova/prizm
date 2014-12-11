using System.Collections.Generic;
using System.Windows.Forms;

using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

using PrizmMain.DummyData;
using PrizmMain.Forms.MainChildForm;

namespace PrizmMain.Forms.Component.Search
{
    [System.ComponentModel.DesignerCategory("Form")] 
    public partial class ComponentSearchXtraForm : ChildForm
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