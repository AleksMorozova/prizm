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

        List<string> localizedSearchResultGroup = new List<string>();

        void UpdateNumberOfFoundItems()
        {
            searchResultLayoutGroup.Text = localizedSearchResultGroup[0];
            searchResultLayoutGroup.Text += ": " + viewModel.Amount;
        }
        public PartSearchXtraForm()
        {
            InitializeComponent();
            number.SetAsIdentifier();
        }

        private void PartsSearchXtraForm_Load(object sender, EventArgs e)
        {
            viewModel = (PartSearchViewModel)Program.Kernel.GetService(typeof(PartSearchViewModel));
            BindCommands();
            BindToViewModel();

            EnumWrapper<PartType>.LoadItems(type.Properties.Items, CheckState.Checked, enabled:true, skip0: true);
            EnumWrapper<PartType>.LoadItems(localizedPartTypes, skip0: true);

            RefreshTypes();

            if (localizedSearchResultGroup.Count == 0)
            {
                localizedSearchResultGroup.Add(searchResultLayoutGroup.Text);
            }
        }

        private void BindToViewModel()
        {
            bindingSource.DataSource = viewModel;
            parts.DataBindings.Add("DataSource", bindingSource, "Parts");
            number.DataBindings.Add("Editvalue", bindingSource, "Number");
            foreach (var item in EnumWrapper<ActivityCriteria>.EnumerateItems())
            {
                activity.Properties.Items.Add(item.Item2);
            }

            viewModel.Activity = ActivityCriteria.StatusActive;

            activity.DataBindings.Add("SelectedIndex", bindingSource, "ActivityIndex");
        }

        private void BindCommands()
        {
            commandManager["Search"].Executor(viewModel.SearchCommand).AttachTo(searchButton);
            viewModel.SearchCommand.RefreshVisualStateEvent += UpdateNumberOfFoundItems;
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
               new LocalizedItem(activity, new  string [] {StringResources.StatusActive.Id, StringResources.StatusUnactive.Id, StringResources.StatusAll.Id }),

                // grid column headers
                new LocalizedItem(numberCol, StringResources.PartSearch_NumberColumnHeader.Id),
                new LocalizedItem(typeCol, StringResources.PartSearch_TypeColumnHeader.Id),

                // layout control groups
                new LocalizedItem(searchLayoutControlGroup, StringResources.PartSearch_SearchGroup.Id),
                new LocalizedItem(searchResultLayoutGroup, localizedSearchResultGroup, new string[] 
                                {StringResources.PartSearch_SearchResultGroup.Id}, UpdateNumberOfFoundItems),
                //grid column with enum
                new LocalizedItem(partsView, localizedPartTypes, new  string [] {StringResources.PartTypePipe.Id, StringResources.PartTypeSpool.Id, StringResources.PartTypeComponent.Id}),
                // form
                
                // header
                new LocalizedItem(this, localizedHeader, new string[] {
                    StringResources.PartSearch_Title.Id} )
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
                switch (viewModel.Parts[selectedPart].Type.Value)
                {
                    case PartType.Component:
                        {
                            if (viewModel.Parts[selectedPart].Id != Guid.Empty)
                            {
                                FormManager.Instance.OpenChildForm(DocumentTypes.ConstructionComponent, viewModel.Parts[selectedPart].Id);
                            }
                            else
                            {
                                FormManager.Instance.OpenChildForm(DocumentTypes.ConstructionComponent, viewModel.Parts[selectedPart].Number);
                            }
                        } break;
                    case PartType.Pipe:
                        {
                            FormManager.Instance.OpenChildForm(DocumentTypes.MillPipe, viewModel.Parts[selectedPart].Id);
                        } break;
                    case PartType.Spool:
                        {
                            FormManager.Instance.OpenChildForm(DocumentTypes.ConstructionSpool, viewModel.Parts[selectedPart].Id);
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
                    e.DisplayText = (result == PartType.Undefined) ? "" : localizedPartTypes[(int)result - 1]; //-1 because we skip 0
                }
            }
        }
    }
}