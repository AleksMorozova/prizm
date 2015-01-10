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

namespace Prizm.Main.Forms.MainChildForm
{
    [System.ComponentModel.DesignerCategory("")] 
    public class ChildForm : XtraForm, IModifiable
    {
        #region --- Modified and header ---

        private bool isModified = false;
        private string originalText = string.Empty;
        protected string headerNumberPart = string.Empty;

        /// <summary>
        /// If this is first-time Text change, remember original text
        /// </summary>
        /// <param name="e">to pass to base class</param>
        protected override void OnTextChanged(System.EventArgs e)
        {
            if (string.IsNullOrEmpty(originalText))
            {
                originalText = this.Text;
            }
            base.OnTextChanged(e);
        }

        /// <summary>
        /// Before closing.
        /// </summary>
        /// <param name="e">used for decision whether to close form or not</param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (this.IsModified)
            {
                DialogResult result = new SaveDialog().ShowDialog();

                if (result == DialogResult.Yes)
                {
                   if (SaveCommand != null && SaveCommand.CanExecute())
                      SaveCommand.Execute();
                }
                else if (result == DialogResult.Cancel)
                {
                   e.Cancel = true;
                   return;
                }
            }
            base.OnFormClosing(e);
        }

        /// <summary>
        /// On closing. Free controls references.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            controls.Clear();
            base.OnFormClosed(e);
        }

        /// <summary>
        /// modified state of document
        /// </summary>
        public virtual bool IsModified 
        { 
           get
           {
              return isModified;
           }
           set
           {
              isModified = value;
              SetCaption();
              Modified(isModified);
           }
        }

        /// <summary>
        /// Set new caption according to current state of document
        /// </summary>
        private void SetCaption()
        {
            Text = string.Format("{0}{1}{2}", originalText,
                !string.IsNullOrEmpty(headerNumberPart) ? ": " + headerNumberPart : string.Empty,  
                IsModified ? "*" : string.Empty);
        }

        /// <summary>
        /// Derived classes should set SaveCommand, to let it be automatically performed at child form closing.
        /// </summary>
        protected ICommand SaveCommand
        {
           get;
           set;
        }

        public event System.Action<bool> Modified = delegate { };

        #endregion // Modified and header

        #region --- MdiParent --- 
        /// <summary>
        /// override (hide) MdiParent to have automatic right type of main application form.
        /// </summary>
        public new PrizmApplicationXtraForm MdiParent 
        { 
            get 
            { 
                return base.MdiParent as PrizmApplicationXtraForm; 
            } 
            set 
            { 
                base.MdiParent = value; 
            } 
        }
        #endregion // MdiParent

        #region --- Edit mode ---

        private bool isEditMode = false;

        /// <summary>
        /// Set/clear edit mode for the form. It is about all form controls.
        /// </summary>
        public bool IsEditMode
        {
            get
            {
                return isEditMode;
            }
            set
            {
                bool previous = isEditMode;
                isEditMode = value;

                if (isEditMode != previous)
                {
                    SetEditModeAllChildren(this, isEditMode);
                }
            }
        }

        private class ControlsCollection
        {
            private Dictionary<Control, Tuple<ControlCondition, Func<bool, bool>>> collection = new Dictionary<Control, Tuple<ControlCondition, Func<bool, bool>>>();

            public void Add(Control c, ControlCondition condition, Func<bool, bool> IsEditableMethod = null)
            {
                var t = Tuple.Create<ControlCondition, Func<bool, bool>>(condition, IsEditableMethod);
                if (!collection.ContainsKey(c))
                {
                    collection.Add(c, t);
                }
                else
                {
                    collection[c] = t;
                }
            }
            public ControlCondition GetCondition(Control c)
            {
                return collection.ContainsKey(c) ? collection[c].Item1 : ControlCondition.Undefined;
            }

            public bool CheckConditionEditable(Control c, bool argument)
            {
                return 
                       collection.ContainsKey(c) && collection[c].Item1 == ControlCondition.Conditional
                    && collection[c].Item2 != null && collection[c].Item2(argument);
            }

            public void Clear()
            {
                collection.Clear();
            }
        }

        private enum ControlCondition { Undefined = 0, AlwaysReadOnly, AlwaysEditable, Conditional };

        private ControlsCollection controls = new ControlsCollection();


        /// <summary>
        /// Derived class can set some it's controls as always read only, and they won't be editable in edit mode.
        /// Overrides previous setting for this control
        /// </summary>
        /// <param name="c">reference to control</param>
        protected void SetAlwaysReadOnly(Control c)
        {
            controls.Add(c, ControlCondition.AlwaysReadOnly, null);
        }
        /// <summary>
        /// Derived class can set some it's controls as an exception to be not processed on switching edit mode.
        /// Overrides previous setting for this control
        /// </summary>
        /// <param name="c">reference to control</param>
        protected void SetAlwaysEditable(Control c)
        {
            controls.Add(c, ControlCondition.AlwaysEditable, null);
        }
        /// <summary>
        /// Derived class can set some it's controls as conditional read/edit mode, depending on real mode
        /// Overrides previous setting for this control
        /// </summary>
        /// <param name="c">reference to control</param>
        /// <param name="method">reference to method which evaluates control read/edit mode. Method returns editable condition.
        /// It's argument true if edit mode is on</param>
        protected void SetConditional(Control c, Func<bool, bool> IsEditableMethod)
        {
            if (IsEditableMethod == null)
            {
                throw new ApplicationException(String.Format("No method defined for conditional mode of control {0}", c.ToString()));
            }
            controls.Add(c, ControlCondition.Conditional, IsEditableMethod);
        }

        /// <summary>
        /// Set read/edit mode for given control and all it's children (always read only will remain read only)
        /// </summary>
        /// <param name="control">reference to control</param>
        /// <param name="editMode">is edit mode</param>
        private void SetEditModeAllChildren(Control control, bool editMode)
        {
            foreach (Control c in control.Controls)
            {
                bool isControlReadOnly = true;      // secure control availability by default

                switch(controls.GetCondition(c))
                {
                    case ControlCondition.Undefined: // routine way. Depends on edit mode only.
                        isControlReadOnly = !editMode;
                        break;
                    case ControlCondition.AlwaysEditable:
                        isControlReadOnly = false;
                        break;
                    case ControlCondition.Conditional:
                        isControlReadOnly = !controls.CheckConditionEditable(c, editMode);
                        break;
                    case ControlCondition.AlwaysReadOnly:
                    default:
                        isControlReadOnly = true;
                        break;
                }
                if (c is TextEdit)
                {
                    ((TextEdit)c).Properties.ReadOnly = isControlReadOnly;
                }
                else if (c is DevExpress.XtraGrid.GridControl)
                {
                    foreach (var v in ((DevExpress.XtraGrid.GridControl)c).Views)
                    {
                        ((GridView)v).OptionsBehavior.Editable = !isControlReadOnly;
                    }
                }
                else if (c is DevExpress.XtraEditors.CheckEdit)
                {
                    ((DevExpress.XtraEditors.CheckEdit)c).Enabled = !isControlReadOnly;

                }
                SetEditModeAllChildren(c, editMode);
            } 
        }

        #endregion // Edit mode

    }


}