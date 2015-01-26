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
        private Type type;
        private string[] defaultValues;

        private enum Type { Control, LayoutControlItem, GridColumn, LayoutControlGroup, ProgressPanel, CheckedComboBoxEdit, ComboBoxEdit, TextEditOneWayStatus };

        public LocalizedItem(DevExpress.XtraLayout.LayoutControlItem item, string resourceId)
        {
            const int TextsCount = 1;
            this.resourceIds = new string[TextsCount] { resourceId };
            this.obj = (object)item;
            this.type = Type.LayoutControlItem;
            this.defaultValues = new string[TextsCount] { item.Text };
        }

        public LocalizedItem(System.Windows.Forms.Control control, string resourceId)
        {
            const int TextsCount = 1;
            this.resourceIds = new string[TextsCount] { resourceId };
            this.obj = (object)control;
            this.type = Type.Control;
            this.defaultValues = new string[TextsCount] { control.Text };
        }

        public LocalizedItem(DevExpress.XtraGrid.Columns.GridColumn column, string resourceId)
        {
            const int TextsCount = 1;
            this.resourceIds = new string[TextsCount] { resourceId };
            this.obj = (object)column;
            this.type = Type.GridColumn;
            this.defaultValues = new string[TextsCount] { column.Caption };
        }

        public LocalizedItem(DevExpress.XtraLayout.LayoutControlGroup group, string resourceId)
        {
            const int TextsCount = 1;
            this.resourceIds = new string[TextsCount] { resourceId };
            this.obj = (object)group;
            this.type = Type.LayoutControlGroup;
            this.defaultValues = new string[TextsCount] { group.Text };
        }

        public LocalizedItem(DevExpress.XtraWaitForm.ProgressPanel panel, string captionResourceId, string descriptionResourceId)
        {
            const int TextsCount = 2;
            this.resourceIds = new string[TextsCount] { captionResourceId, descriptionResourceId };
            this.obj = (object)panel;
            this.type = Type.ProgressPanel;
            this.defaultValues = new string[TextsCount] { panel.Caption, panel.Description };
        }

        public LocalizedItem(DevExpress.XtraEditors.CheckedComboBoxEdit checkedCombo, string[] resourceIds)
        {
            this.resourceIds = new string[resourceIds.Length];
            this.obj = (object)checkedCombo;
            this.type = Type.CheckedComboBoxEdit;
            this.defaultValues = new string[resourceIds.Length];

            for (int index = 0; index < resourceIds.Length; index++)
            {
                this.resourceIds[index] = resourceIds[index];
                this.defaultValues[index] = (string)checkedCombo.Properties.Items[index].Description;
            }
        }

        public LocalizedItem(DevExpress.XtraEditors.ComboBoxEdit combo, string[] resourceIds)
        {
            this.resourceIds = new string[resourceIds.Length];
            this.obj = (object)combo;
            this.type = Type.ComboBoxEdit;
            this.defaultValues = new string[resourceIds.Length];

            for (int index = 0; index < resourceIds.Length; index++)
            {
                this.resourceIds[index] = resourceIds[index];
                this.defaultValues[index] = combo.Properties.Items[index].ToString();
            }
        }

        /// <summary>
        /// list is required to be at least the same size as resourceIds
        /// </summary>
        /// <param name="list"></param>
        /// <param name="resourceIds"></param>
        public LocalizedItem(DevExpress.XtraEditors.TextEdit edit, List<string> list, string[] resourceIds)
        {
            this.resourceIds = new string[resourceIds.Length];
            this.obj = (object)new Tuple<DevExpress.XtraEditors.TextEdit, List<string>>(edit, list);
            this.type = Type.TextEditOneWayStatus;
            this.defaultValues = new string[resourceIds.Length];

            for (int index = 0; index < resourceIds.Length; index++)
            {
                this.resourceIds[index] = resourceIds[index];
                this.defaultValues[index] = list[index];
            }
        }

        public string Text
        {
            set
            {
                switch (type) // only types with one string
                {
                    case Type.Control:
                        ((System.Windows.Forms.Control)obj).Text = value;
                        break;
                    case Type.LayoutControlItem:
                        ((DevExpress.XtraLayout.LayoutControlItem)obj).Text = value;
                        break;
                    case Type.GridColumn:
                        ((DevExpress.XtraGrid.Columns.GridColumn)obj).Caption = value;
                        break;
                    case Type.LayoutControlGroup:
                        ((DevExpress.XtraLayout.LayoutControlGroup)obj).Text = value;
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
                if (Count < 2)
                {
                    Text = value;
                }
                else
                {
                    switch (type) // only types with more than one string
                    {
                        case Type.ProgressPanel:

                            if(index == 0)
                                ((DevExpress.XtraWaitForm.ProgressPanel)obj).Caption = value;

                            if(index == 1)
                                ((DevExpress.XtraWaitForm.ProgressPanel)obj).Description = value;

                            break;

                        case Type.CheckedComboBoxEdit:

                            if (index < Count)
                            {
                                ((DevExpress.XtraEditors.CheckedComboBoxEdit)obj).Properties.Items[index].Description = value;
                            }

                            break;

                        case Type.ComboBoxEdit:
                            var combo = (DevExpress.XtraEditors.ComboBoxEdit)obj;
                            int selectedIndex = combo.SelectedIndex; // because editing Properties.Items drops selected index value to -1
                            if (index < Count)
                            {
                                ((DevExpress.XtraEditors.ComboBoxEdit)obj).Properties.Items[index] = value;
                            }
                            combo.SelectedIndex = selectedIndex; // restore selected index for combo
                            break;

                        case Type.TextEditOneWayStatus:
                            var list = ((Tuple<DevExpress.XtraEditors.TextEdit, List<string>>)obj).Item2;
                            if (index < list.Count)
                            {
                                list[index] = value;
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
            get { return this.defaultValues.Length; }
        }

        public void Refresh()
        {
            switch (type) 
            {
                case Type.Control:
                    ((System.Windows.Forms.Control)obj).Refresh();
                    break;
                case Type.LayoutControlItem:
                    // ??
                    break;
                case Type.GridColumn:
                    // ??
                    break;
                case Type.LayoutControlGroup:
                    // ??
                    break;
                case Type.ProgressPanel:
                        ((DevExpress.XtraWaitForm.ProgressPanel)obj).Refresh();
                    break;
                case Type.CheckedComboBoxEdit:
                        ((DevExpress.XtraEditors.CheckedComboBoxEdit)obj).Refresh();
                    break;
                case Type.ComboBoxEdit:
                        var combo = (DevExpress.XtraEditors.ComboBoxEdit)obj;
                        if (combo.SelectedIndex >= 0)
                        {
                            combo.EditValue = combo.Properties.Items[combo.SelectedIndex];
                        }
                        combo.Refresh();
                    break;
                case Type.TextEditOneWayStatus:
                    ((Tuple<DevExpress.XtraEditors.TextEdit, List<string>>)obj).Item1.Refresh();
                    break;
                default:
                    break;
            }
        }

    }
}
