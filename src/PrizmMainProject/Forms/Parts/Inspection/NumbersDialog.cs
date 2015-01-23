﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Prizm.Main.Forms.Parts.Search;
using Prizm.Main.Forms.MainChildForm;
using Prizm.Main.Languages;

namespace Prizm.Main.Forms.Parts.Inspection
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class NumbersDialog : PrizmForm
    {
        BindingList<Part> parts;
        PartInspectionViewModel viewModel;
        public NumbersDialog(BindingList<Part> parts, PartInspectionViewModel viewModel)
        {
            this.parts = parts;
            this.viewModel = viewModel;
            InitializeComponent();
        }

        private void NumbersDialog_Load(object sender, EventArgs e)
        {
            searchResults.DataSource = parts;
        }

        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
                //new LocalizedItem(pipeNumberLayout, "NewEditPipe_PipeNumberLabel"),
            };
        }

        #endregion // --- Localization ---
        private void acceptButton_Click(object sender, EventArgs e)
        {
            Part selectedElement = searchResultsView.GetRow(searchResultsView.FocusedRowHandle) as Part;
            if (selectedElement != null)
            {
                viewModel.SelectedElement = selectedElement;
            }
            this.Close();
        }

    }
}