using DevExpress.XtraEditors;
using PrizmMain.DummyData;

namespace PrizmMain.Forms.Settings.Dictionary
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