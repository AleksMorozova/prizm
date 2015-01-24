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

using Prizm.Main.Languages;

namespace Prizm.Main.Forms.MainChildForm
{
    [System.ComponentModel.DesignerCategory("")]
    public abstract class PrizmForm : DevExpress.XtraEditors.XtraForm, ILocalizable
    {
        #region --- Localization ---

        private List<LocalizedItem> localizedItems = null;

        protected abstract List<LocalizedItem> CreateLocalizedItems();

        public IEnumerator<ILocalizedItem> GetEnumerator()
        {
            if (localizedItems == null)
            {
                localizedItems = CreateLocalizedItems();
            }
            return localizedItems.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Program.MainForm.ChangeLanguage(this);
        }

        #endregion // --- Localization ---

    }
}