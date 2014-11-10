using DevExpress.XtraEditors;
using PrizmMain.DummyData;

namespace PrizmMain.Forms
{
    public partial class SettingsEditDictionaryXtraForm : XtraForm
    {
        public SettingsEditDictionaryXtraForm()
        {
            InitializeComponent();
            items.DataSource = DictionaryDummy.GetItems();
        }
    }
}