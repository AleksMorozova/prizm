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
    public class PrizmForm : DevExpress.XtraEditors.XtraForm, ILocalizable
    {
        #region --- Localization ---

        // do NOT re-create it because reference passed to localization item. Clean it instead.
        protected List<string> localizedHeader = new List<string>();

        /// <summary>
        /// override this method for special title updates
        /// </summary>
        public virtual void UpdateTitle()
        {
            if (localizedHeader != null && localizedHeader.Count > 0)
            {
                this.Text = localizedHeader[0];
            }
        }
        
        private List<LocalizedItem> localizedItems = null;

        protected virtual List<LocalizedItem> CreateLocalizedItems() { return null; } // not abstract because of designer

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
            if (!DesignMode)
            {
                Program.LanguageManager.ChangeLanguage(this);
            }
        }

        #endregion // --- Localization ---

    }
}