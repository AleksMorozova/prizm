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
        public virtual bool Is(Guid id) { return false; } // to store all existingDocuments in one container. Always false for non-editable existingDocuments and for settings.

        public virtual bool IsEditMode { get { return false; } set { } }
    }


}