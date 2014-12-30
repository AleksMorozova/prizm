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
using Prizm.Main.Forms.Parts.Search;

namespace Prizm.Main.Forms.Parts.Inspection
{
    public partial class NumbersDialog : DevExpress.XtraEditors.XtraForm
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