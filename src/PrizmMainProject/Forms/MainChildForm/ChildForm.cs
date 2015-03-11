using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Prizm.Main.Documents;
using Prizm.Main.Properties;
using Prizm.Main.Forms.Common;
using Prizm.Main.Commands;
using Prizm.Main.Languages;

namespace Prizm.Main.Forms.MainChildForm
{
    /// <summary>
    /// Is intended to use as a document
    /// </summary>
    [System.ComponentModel.DesignerCategory("")]
    public class ChildForm : PrizmForm
    {
        public virtual bool Is(Guid id) { return false; } // to store all documents in one container. Always false for non-editable documents and for settings.
    }


}