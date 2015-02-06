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
using Prizm.Main.Forms.MainChildForm;
using Prizm.Main.Forms.Common;
using Prizm.Main.Properties;
using DevExpress.XtraGrid.Views.Grid;
using Prizm.Main.Common;
using Prizm.Main.Forms.Component.NewEdit;
using Ninject.Parameters;
using Prizm.Domain.Entity.Construction;
using Prizm.Main.Commands;
using Prizm.Main.Forms.PipeMill.NewEdit;
using Prizm.Main.Forms.Spool;
using Prizm.Main.Languages;

namespace Prizm.Main.Forms.Parts.Search
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class PartSearchXtraForm : ChildForm
    {
        private PartSearchViewModel viewModel;
        ICommandManager commandManager = new CommandManager();
        private List<string> localizedPartTypes = new List<string>();

        public PartSearchXtraForm()
        {
            InitializeComponent();
            number.SetAsIdentifier();
            Bitmap bmp = Resources.search_icon;
            this.Icon = Icon.FromHandle(bmp.GetHicon());
        }

        private void PartsSearchXtraForm_Load(object sender, EventArgs e)
        {
            viewModel = (PartSearchViewModel)Program.Kernel.GetService(typeof(PartSearchViewModel));
            BindCommands();
            BindToViewModel();
            foreach (var item in EnumWrapper<ActivityCriteria>.EnumerateItems())
            {
                activity.Properties.Items.Add(item.Item2);
            }
            foreach (var item in EnumWrapper<PartType>.EnumerateItems(skip0: true))
            {
                type.Properties.Items.Add(item.Item1, item.Item2, CheckState.Checked, enabled:true);
                localizedPartTypes.Add(item.Item2);
            }
            RefreshTypes();
            activity.SelectedIndex = 0;
        }

        private void BindToViewModel()
        {
            bindingSource.DataSource = viewModel;
            parts.DataBindings.Add("DataSource", bindingSource, "Parts");
            number.DataBindings.Add("Editvalue", bindingSource, "Number");
            activity.DataBindings.Add("SelectedIndex", bindingSource, "ActivityIndex");
        }

        private void BindCommands()
        {
            commandManager["Search"].Executor(viewModel.SearchCommand).AttachTo(searchButton);
        }

        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
                // layout items
                new LocalizedItem(numberLayoutControl, StringResources.PartSearch_SearchNumberLabel.Id),
                new LocalizedItem(typeLayoutControl, StringResources.PartSearch_SearchTypeLabel.Id),
                new LocalizedItem(activityLayout, StringResources.PartSearch_ActivityLabel.Id),

                // controls
               new LocalizedItem(searchButton, StringResources.PartSearch_SearchButton.Id),
               new LocalizedItem(type, new  string [] {StringResources.PartTypePipe.Id, StringResources.PartTypeSpool.Id, StringResources.PartTypeComponent.Id} ),
               new LocalizedItem(activity, new  string [] {StringResources.StatusActive.Id, StringResources.StatusInactive.Id, StringResources.StatusAll.Id }),

                // grid column headers
                new LocalizedItem(numberCol, StringResources.PartSearch_NumberColumnHeader.Id),
                new LocalizedItem(typeCol, StringResources.PartSearch_TypeColumnHeader.Id),

                // layout control groups
                new LocalizedItem(searchLayoutControlGroup, StringResources.PartSearch_SearchGroup.Id),
                new LocalizedItem(searchResultLayoutGroup, StringResources.PartSearch_SearchResultGroup.Id),

                //grid column with enum
                new LocalizedItem(partsView, localizedPartTypes, new  string [] {StringResources.PartTypePipe.Id, StringResources.PartTypeSpool.Id, StringResources.PartTypeComponent.Id})
                // form
                //??
            };
        }

        #endregion // --- Localization ---

    
        private void type_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            RefreshTypes();
        }

        private void RefreshTypes()
        {
            BindingList<PartType> selectedTypes = new BindingList<PartType>();
            for (int i = 0; i < type.Properties.Items.Count; i++)
            {
                if (type.Properties.Items[i].CheckState == CheckState.Checked)
                {
                    selectedTypes.Add((PartType)type.Properties.Items[i].Value);
                }
            }
            viewModel.Types.Clear();
            viewModel.Types = selectedTypes;
        }

        private void partsView_DoubleClick(object sender, EventArgs e)
        {
            int selectedPart = partsView.GetFocusedDataSourceRowIndex();
            if (selectedPart >= 0)
            {
                var parent = this.MdiParent as PrizmApplicationXtraForm;
                switch (viewModel.Parts[selectedPart].Type.Value)
                {
                    case PartType.Component:
                        {
                            parent.OpenChildForm(
                                typeof(ComponentNewEditXtraForm),
                                viewModel.Parts[selectedPart].Id,
                                viewModel.Parts[selectedPart].Number);
                        } break;
                    case PartType.Pipe:
                        {
                            parent.OpenChildForm
                                (typeof(MillPipeNewEditXtraForm), 
                                viewModel.Parts[selectedPart].Id);
                        } break;
                    case PartType.Spool:
                        {
                            parent.OpenChildForm(
                                typeof(SpoolsXtraForm), viewModel.Parts[selectedPart].Id);
                        } break;
                    default: break;
                }
            }
        }

        private void partsView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                partsView_DoubleClick(sender, e);
            }
        }

        private void PartSearchXtraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            commandManager.Dispose();
            viewModel.Dispose();
            viewModel = null;
        }

        private void partsView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView v = sender as GridView;
            var data = v.GetRow(e.RowHandle) as Part;
            if (data != null)
            {
                if (!data.IsActive)
                {
                    e.Appearance.ForeColor = Color.Gray;
                }
            }
        }

        private void partsView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.Name == typeCol.Name && e.Value != null)
            {
                PartType result;
                if (Enum.TryParse<PartType>(e.Value.ToString(), out result))
                {
                    e.DisplayText = localizedPartTypes[(int)result - 1]; //-1 because we skip 0
                }
            }
        }
    }
}