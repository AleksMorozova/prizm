using Prizm.Main.Forms.MainChildForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Languages
{
    public class LocalizedItem : ILocalizedItem
    {
        private string[] resourceIds;
        private object obj;
        private ItemType type;
        private string[] defaultValues;

        private enum ItemType 
        { 
            Control, 
            LayoutControlItem, 
            GridColumn, 
            LayoutControlGroup,
            LayoutControlGroupMultipartText,
            BarItem,
            BarItemCustomCaption,
            ProgressPanel, 
            CheckedComboBoxEdit,
            ComboBoxEdit,
            RadioGroup,
            TextEditOneWayStatus, 
            GridView,
            FormHeader,
            RepositoryLookupEdit,
            CheckedListBox
        };

        public LocalizedItem(System.Windows.Forms.Control control, string resourceId)
        {
            const int TextsCount = 1;
            this.resourceIds = new string[TextsCount] { resourceId };
            this.obj = (object)control;
            this.type = ItemType.Control;
            this.defaultValues = new string[TextsCount] { control.Text };
        }

        public LocalizedItem(DevExpress.XtraLayout.LayoutControlItem item, string resourceId)
        {
            const int TextsCount = 1;
            this.resourceIds = new string[TextsCount] { resourceId };
            this.obj = (object)item;
            this.type = ItemType.LayoutControlItem;
            this.defaultValues = new string[TextsCount] { item.Text };
        }

        public LocalizedItem(DevExpress.XtraGrid.Columns.GridColumn column, string resourceId)
        {
            const int TextsCount = 1;
            this.resourceIds = new string[TextsCount] { resourceId };
            this.obj = (object)column;
            this.type = ItemType.GridColumn;
            this.defaultValues = new string[TextsCount] { column.Caption };
        }

        public LocalizedItem(DevExpress.XtraLayout.LayoutControlGroup group, string resourceId)
        {
            const int TextsCount = 1;
            this.resourceIds = new string[TextsCount] { resourceId };
            this.obj = (object)group;
            this.type = ItemType.LayoutControlGroup;
            this.defaultValues = new string[TextsCount] { group.Text };
        }

        public LocalizedItem(DevExpress.XtraLayout.LayoutControlGroup group, List<string> list, string[] resourceIds, Action action = null)
        {
            this.resourceIds = new string[resourceIds.Length];
            for (int index = 0; index < resourceIds.Length; index++)
            {
                this.resourceIds[index] = resourceIds[index];
            }
            this.obj = (object)new Tuple<DevExpress.XtraLayout.LayoutControlGroup, List<string>, Action>(group, list, action);
            this.type = ItemType.LayoutControlGroupMultipartText;
            this.defaultValues = new string[resourceIds.Length];

            for (int index = 0; index < resourceIds.Length; index++)
            {
                this.defaultValues[index] = (index == 0) ? group.Text : "";
            }
        }


        public LocalizedItem(DevExpress.XtraBars.BarItem item, string resourceId)
        {
            const int TextsCount = 1;
            this.resourceIds = new string[TextsCount] { resourceId };
            this.obj = (object)item;
            this.type = ItemType.BarItem;
            this.defaultValues = new string[TextsCount] { item.Caption };
        }

        public LocalizedItem(DevExpress.XtraBars.BarItem item, List<string> list, string [] resourceIds)
        {
            this.resourceIds = new string[resourceIds.Length];
            for (int index = 0; index < resourceIds.Length; index++)
            {
                this.resourceIds[index] = resourceIds[index];
            }
            this.obj = (object)new Tuple<DevExpress.XtraBars.BarItem, List<string>>(item, list);
            this.type = ItemType.BarItemCustomCaption;
            this.defaultValues = new string[resourceIds.Length];

            for (int index = 0; index < resourceIds.Length; index++)
            {
                this.defaultValues[index] = (index == 0) ? item.Caption : "";
            }
        }

        public LocalizedItem(DevExpress.XtraWaitForm.ProgressPanel panel, string captionResourceId, string descriptionResourceId)
        {
            const int TextsCount = 2;
            this.resourceIds = new string[TextsCount] { captionResourceId, descriptionResourceId };
            this.obj = (object)panel;
            this.type = ItemType.ProgressPanel;
            this.defaultValues = new string[TextsCount] { panel.Caption, panel.Description };
        }

        public LocalizedItem(DevExpress.XtraEditors.CheckedComboBoxEdit checkedCombo, string[] resourceIds)
        {
            this.resourceIds = new string[resourceIds.Length];
            for (int index = 0; index < resourceIds.Length; index++)
            {
                this.resourceIds[index] = resourceIds[index];
            }
            this.obj = (object)checkedCombo;
            this.type = ItemType.CheckedComboBoxEdit;
            this.defaultValues = new string[resourceIds.Length];

            for (int index = 0; index < resourceIds.Length; index++)
            {
                this.defaultValues[index] = (string)checkedCombo.Properties.Items[index].Description;
            }
        }

        public LocalizedItem(DevExpress.XtraEditors.ComboBoxEdit combo, string[] resourceIds)
        {
            this.resourceIds = new string[resourceIds.Length];
            for (int index = 0; index < resourceIds.Length; index++)
            {
                this.resourceIds[index] = resourceIds[index];
            }
            this.obj = (object)combo;
            this.type = ItemType.ComboBoxEdit;
            this.defaultValues = new string[resourceIds.Length];

            for (int index = 0; index < resourceIds.Length; index++)
            {
                this.defaultValues[index] = combo.Properties.Items[index].ToString();
            }
        }

        public LocalizedItem(DevExpress.XtraEditors.RadioGroup radio, string[] resourceIds)
        {
            this.resourceIds = new string[resourceIds.Length];
            for (int index = 0; index < resourceIds.Length; index++)
            {
                this.resourceIds[index] = resourceIds[index];
            }
            this.obj = (object)radio;
            this.type = ItemType.RadioGroup;
            this.defaultValues = new string[resourceIds.Length];

            for (int index = 0; index < resourceIds.Length; index++)
            {
                this.defaultValues[index] = radio.Properties.Items[index].ToString();
            }
        }

        /// <summary>
        /// Use this item to localize the output in text edit, where value is the one of enumberation members.
        /// list is required to be at least the same size as resourceIds
        /// </summary>
        /// <param name="update">method which will update text edit from binding source</param>
        /// <param name="list">list of translations</param>
        /// <param name="resourceIds">list of resource ids</param>
        public LocalizedItem(Action update, List<string> list, string[] resourceIds)
        {
            this.resourceIds = new string[resourceIds.Length];
            for (int index = 0; index < resourceIds.Length; index++)
            {
                this.resourceIds[index] = resourceIds[index];
            }
            this.obj = (object)new Tuple<Action, List<string>>(update, list);
            this.type = ItemType.TextEditOneWayStatus;
            this.defaultValues = new string[resourceIds.Length];

            for (int index = 0; index < resourceIds.Length; index++)
            {
                this.defaultValues[index] = list[index];
            }
        }

        /// <summary>
        /// Use this item to localize the output in certain grid column, when enumeration members are displaying as cell values.
        /// list is required to be at least the same size as resourceIds.
        /// </summary>
        /// <param name="grid">grid reference</param>
        /// <param name="list">list of translations</param>
        /// <param name="resourceIds">list of resource ids</param>
        public LocalizedItem(DevExpress.XtraGrid.Views.Grid.GridView grid, List<string> list, string[] resourceIds)
        {
            this.resourceIds = new string[resourceIds.Length];
            for (int index = 0; index < resourceIds.Length; index++)
            {
                this.resourceIds[index] = resourceIds[index];
            }
            this.obj = (object)new Tuple<DevExpress.XtraGrid.Views.Grid.GridView, List<string>>(grid, list);
            this.type = ItemType.GridView;
            this.defaultValues = new string[resourceIds.Length];

            for (int index = 0; index < resourceIds.Length; index++)
            {
                this.defaultValues[index] = list[index];
            }
        }

        public LocalizedItem(PrizmForm form, List<string> list, string[] resourceIds)
        {
            this.resourceIds = new string[resourceIds.Length];
            for (int index = 0; index < resourceIds.Length; index++)
            {
                this.resourceIds[index] = resourceIds[index];
            }
            this.obj = (object)new Tuple<PrizmForm, List<string>>(form, list);
            this.type = ItemType.FormHeader;
            this.defaultValues = new string[resourceIds.Length];

            for (int index = 0; index < resourceIds.Length; index++)
            {
                this.defaultValues[index] = list[index];
            }
        }

        public LocalizedItem(DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoLookup,  List<string> list, string[] resourceIds)
        {
        this.resourceIds = new string[resourceIds.Length];
            for (int index = 0; index < resourceIds.Length; index++)
            {
                this.resourceIds[index] = resourceIds[index];
            }
            this.obj = (object)new Tuple<DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit, List<string>>(repoLookup, list);
            this.type = ItemType.RepositoryLookupEdit;
            this.defaultValues = new string[resourceIds.Length];

            for (int index = 0; index < resourceIds.Length; index++)
            {
                this.defaultValues[index] = list[index];
            }
        }

        public LocalizedItem(DevExpress.XtraEditors.CheckedListBoxControl checkedListBox, string[] resourceIds)
        {
            this.resourceIds = new string[resourceIds.Length];
            for (int index = 0; index < resourceIds.Length; index++)
            {
                this.resourceIds[index] = resourceIds[index];
            }
            this.obj = (object)checkedListBox;
            this.type = ItemType.CheckedListBox;
            this.defaultValues = new string[resourceIds.Length];
            for (int index = 0; index < resourceIds.Length; index++)
            {
                this.defaultValues[index] = (string)checkedListBox.Items[index].Description;
            }
        }

        public string Text
        {
            set
            {
                switch (type) // only types with one string
                {
                    case ItemType.Control:
                        ((System.Windows.Forms.Control)obj).Text = value;
                        break;
                    case ItemType.LayoutControlItem:
                        ((DevExpress.XtraLayout.LayoutControlItem)obj).Text = value;
                        break;
                    case ItemType.GridColumn:
                        ((DevExpress.XtraGrid.Columns.GridColumn)obj).Caption = value;
                        break;
                    case ItemType.LayoutControlGroup:
                        ((DevExpress.XtraLayout.LayoutControlGroup)obj).Text = value;
                        break;
                    case ItemType.LayoutControlGroupMultipartText:
                        Action action = ((Tuple<DevExpress.XtraLayout.LayoutControlGroup, List<string>, Action>)obj).Item3;
                        if (action != null)
                        {
                            action();
                        }
                        break;
                    case ItemType.BarItem:
                        ((DevExpress.XtraBars.BarItem)obj).Caption = value;
                        break;
                    case ItemType.FormHeader:
                        ((Tuple<PrizmForm, List<string>>)obj).Item2[this.Count - 1] = value;
                        break;
                    default:
                        break;
                }
            }
        }

        public string this[int index]
        {
            set
            {
                if (type == ItemType.LayoutControlGroupMultipartText)
                {
                    var list = ((Tuple<DevExpress.XtraLayout.LayoutControlGroup, List<string>, Action>)obj).Item2;
                    if (index < list.Count)
                    {
                        list[index] = value;
                    }
                }
                else if (Count < 2)
                {
                    Text = value;
                }
                else
                {
                    switch (type) // only types with more than one string
                    {
                        case ItemType.ProgressPanel:

                            if(index == 0)
                                ((DevExpress.XtraWaitForm.ProgressPanel)obj).Caption = value;

                            if(index == 1)
                                ((DevExpress.XtraWaitForm.ProgressPanel)obj).Description = value;

                            break;

                        case ItemType.CheckedComboBoxEdit:

                            if (index < Count)
                            {
                                ((DevExpress.XtraEditors.CheckedComboBoxEdit)obj).Properties.Items[index].Description = value;
                            }

                            break;

                        case ItemType.ComboBoxEdit:
                            var combo = (DevExpress.XtraEditors.ComboBoxEdit)obj;
                            int selectedIndex = combo.SelectedIndex; // because editing Properties.Items drops selected index value to -1
                            if (index < Count)
                            {
                                ((DevExpress.XtraEditors.ComboBoxEdit)obj).Properties.Items[index] = value;
                            }
                            combo.SelectedIndex = selectedIndex; // restore selected index for combo
                            break;

                        case ItemType.RadioGroup:
                            var radio = (DevExpress.XtraEditors.RadioGroup)obj;
                            int selectedItem = radio.SelectedIndex;
                            if (index < Count)
                            {
                                ((DevExpress.XtraEditors.RadioGroup)obj).Properties.Items[index].Description = value;
                            }
                            radio.SelectedIndex = selectedItem;
                            break;

                        case ItemType.TextEditOneWayStatus:
                            {
                                var list = ((Tuple<Action, List<string>>)obj).Item2;
                                if (index < list.Count)
                                {
                                    list[index] = value;
                                }
                            }
                            break;

                        case ItemType.GridView:
                            {
                                var list = ((Tuple<DevExpress.XtraGrid.Views.Grid.GridView, List<string>>)obj).Item2;
                                if (index < list.Count)
                                {
                                    list[index] = value;
                                }
                            }
                            break;

                        case ItemType.FormHeader:
                            {
                                var list = ((Tuple<PrizmForm, List<string>>)obj).Item2;
                                if (index < list.Count)
                                {
                                    list[index] = value;
                                }
                            }
                            break;

                        case ItemType.RepositoryLookupEdit:
                            {
                                var list = ((Tuple<DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit, List<string>>)obj).Item2;
                                if (index < list.Count)
                                {
                                    list[index] = value;
                                }
                                ((Tuple<DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit, List<string>>)obj).Item1.DataSource = list;
                            }
                            break;

                        case ItemType.CheckedListBox:
                            {
                                ((DevExpress.XtraEditors.CheckedListBoxControl)obj).Items[index].Description = value;
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        public string GetResourceId(int index=0)
        {
            return this.resourceIds.Length > index ? this.resourceIds[index] : "";
        }

        public void BackToDefault(int index=-1)
        {
            if (index < 0)
            {
                for (int i = 0; i < Count; i++)
                {
                    this[i] = this.defaultValues[i];
                }
            }
            else
            {
                if (index < Count)
                {
                    this[index] = this.defaultValues[index];
                }
            }

        }

        public int Count
        {
            get { return this.resourceIds.Length; }
        }

        public void Refresh()
        {
            switch (type) 
            {
                case ItemType.Control:
                    ((System.Windows.Forms.Control)obj).Refresh();
                    break;
                case ItemType.LayoutControlItem:
                    // ??
                    break;
                case ItemType.GridColumn:
                    // ??
                    break;
                case ItemType.LayoutControlGroup:
                    // ??
                    break;
                case ItemType.LayoutControlGroupMultipartText:
                    ((Tuple<DevExpress.XtraLayout.LayoutControlGroup, List<string>, Action>)obj).Item3.Invoke();
                    break;
                case ItemType.BarItem:
                    ((DevExpress.XtraBars.BarItem)obj).Refresh();
                    break;
                case ItemType.BarItemCustomCaption:
                    ((Tuple<DevExpress.XtraBars.BarItem, List<string>>)obj).Item1.Refresh();
                    break;
                case ItemType.ProgressPanel:
                        ((DevExpress.XtraWaitForm.ProgressPanel)obj).Refresh();
                    break;
                case ItemType.CheckedComboBoxEdit:
                    var checkedCombo = ((DevExpress.XtraEditors.CheckedComboBoxEdit)obj);
                        checkedCombo.Properties.SelectAllItemCaption = Program.LanguageManager.GetString(StringResources.ChechedCombobox_SelectAll);
                        checkedCombo.Refresh();
                    break;
                case ItemType.ComboBoxEdit:
                        var combo = (DevExpress.XtraEditors.ComboBoxEdit)obj;
                        if (combo.SelectedIndex >= 0)
                        {
                            combo.EditValue = combo.Properties.Items[combo.SelectedIndex];
                        }
                        combo.Refresh();
                    break;
                case ItemType.RadioGroup:
                    var radio = (DevExpress.XtraEditors.RadioGroup)obj;
                    if (radio.SelectedIndex >= 0)
                    { 
                        radio.EditValue = radio.Properties.Items[radio.SelectedIndex]; 
                    }
                    radio.Refresh();
                    break;
                case ItemType.TextEditOneWayStatus:
                    ((Tuple<Action, List<string>>)obj).Item1.Invoke();
                    break;
                case ItemType.GridView:
                    ((Tuple<DevExpress.XtraGrid.Views.Grid.GridView, List<string>>)obj).Item1.RefreshData();
                    break;
                case ItemType.FormHeader:
                    ((Tuple<PrizmForm, List<string>>)obj).Item1.UpdateTitle();
                    break;
                case ItemType.CheckedListBox:
                    ((DevExpress.XtraEditors.CheckedListBoxControl)obj).Refresh();
                    break;
                default:
                    break;
            }
        }

    }
}
