using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Languages
{
    public class LocalizedItem : ILocalizedItem
    {
        private string resourceId;
        private object obj;
        private Type type;
        private string defaultValue;

        private enum Type { Control, LayoutControlItem, GridColumn, LayoutControlGroup };

        public LocalizedItem(DevExpress.XtraLayout.LayoutControlItem item, string resourceId)
        {
            this.resourceId = resourceId;
            this.obj = (object)item;
            this.type = Type.LayoutControlItem;
            this.defaultValue = item.Text;
        }

        public LocalizedItem(System.Windows.Forms.Control control, string resourceId)
        {
            this.resourceId = resourceId;
            this.obj = (object)control;
            this.type = Type.Control;
            this.defaultValue = control.Text;
        }

        public LocalizedItem(DevExpress.XtraGrid.Columns.GridColumn column, string resourceId)
        {
            this.resourceId = resourceId;
            this.obj = (object)column;
            this.type = Type.GridColumn;
            this.defaultValue = column.Caption;
        }

        public LocalizedItem(DevExpress.XtraLayout.LayoutControlGroup group, string resourceId)
        {
            this.resourceId = resourceId;
            this.obj = (object)group;
            this.type = Type.LayoutControlGroup;
            this.defaultValue = group.Text;
        }

        public string Text
        {
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
            }
            set
            {
                switch (type)
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

        public string ResourceId
        {
            get { return resourceId; }
        }

        public void BackToDefault()
        {
            Text = defaultValue;
        }

    }
}
