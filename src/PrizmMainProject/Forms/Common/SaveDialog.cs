﻿using DevExpress.XtraEditors;
using Prizm.Main.Forms.MainChildForm;
using Prizm.Main.Languages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prizm.Main.Forms.Common
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class SaveDialog : PrizmForm
   {
      public SaveDialog()
      {
         InitializeComponent();
      }

      #region --- Localization ---

      protected override List<LocalizedItem> CreateLocalizedItems()
      {
          return new List<LocalizedItem>()
          {
              new LocalizedItem(lblText, StringResources.SaveDialog_SaveLabel.Id),
              new LocalizedItem(btnSave, StringResources.SaveDialog_SaveButton.Id),
              new LocalizedItem(btnDontSave, StringResources.SaveDialog_DontSaveButton.Id),
              new LocalizedItem(btnCancel, StringResources.SaveDialog_CancelButton.Id),
              // header
              new LocalizedItem(this, localizedHeader, new string[] {
                  StringResources.SaveDialog_Title.Id} )
          };
      }

      #endregion // --- Localization ---

   }
}
