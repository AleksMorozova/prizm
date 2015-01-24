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

        private enum Type { Control, LayoutControlItem, GridColumn, LayoutControlGroup, ProgressPanel, CheckedComboBoxEdit, ComboBoxEdit };

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
                this.defaultValues[index] = checkedCombo.Properties.Items[index].Description;
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
        {/*
            get
            {
                string ret;
                switch (type)
                {
                    case Type.Control:
                        ret = ((System.Windows.Forms.Control)obj).Text;
                        break;
                    case Type.LayoutControlItem:
                        ret = ((DevExpress.XtraLayout.LayoutControlItem)obj).Text;
                        break;
                    case Type.GridColumn:
                        ret = ((DevExpress.XtraGrid.Columns.GridColumn)obj).Caption;
                        break;
                    case Type.LayoutControlGroup:
                        ret = ((DevExpress.XtraLayout.LayoutControlGroup)obj).Text;
                        break;
                    default:
                        ret = "";
                        break;
                }
                return ret;
            }*/
            set
            {
                if (defaultValues.Length < 2)
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

                            if(index < this.defaultValues.Length)
                            {
                                ((DevExpress.XtraEditors.CheckedComboBoxEdit)obj).Properties.Items[index].Description = value;
                            }

                            break;

                        case Type.ComboBoxEdit:

                            if (index < this.defaultValues.Length)
                            {
                                ((DevExpress.XtraEditors.ComboBoxEdit)obj).Properties.Items[index] = value;
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

        public void BackToDefault()
        {
            for (int index = 0; index < this.defaultValues.Length; index++ )
            {
                this[index] = this.defaultValues[index];
            }
        }

        public int Count
        {
            get { return this.defaultValues.Length; }
        }

    }
}
