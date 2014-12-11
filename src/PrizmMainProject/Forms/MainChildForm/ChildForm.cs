using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using PrizmMain.Documents;
using PrizmMain.Properties;
using PrizmMain.Forms.Common;
using PrizmMain.Commands;

namespace PrizmMain.Forms.MainChildForm
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
        private HashSet<Control> alwaysReadOnly;
        private HashSet<Control> exceptionsReadOnly;

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

        /// <summary>
        /// Derived class can set some it's controls as always read only, and they won't be editable in edit mode.
        /// </summary>
        /// <param name="c">reference to control</param>
        protected void SetAlwaysReadOnly(Control c)
        {
            if (exceptionsReadOnly != null && exceptionsReadOnly.Contains(c))
            {
                throw new ApplicationException("Control " + c.Name + " is already in list of exceptions of read-only controls");
            }
            if (alwaysReadOnly == null)
            {
                alwaysReadOnly = new HashSet<Control>();
            }
            alwaysReadOnly.Add(c);
        }
        /// <summary>
        /// Derived class can set some it's controls as an exception to be not processed on switching edit mode.
        /// </summary>
        /// <param name="c">reference to control</param>
        protected void SetExceptionReadOnly(Control c)
        {
            if (alwaysReadOnly != null && alwaysReadOnly.Contains(c))
            {
                throw new ApplicationException("Control " + c.Name + " is already in list of read-only controls");
            }
            if (exceptionsReadOnly == null)
            { 
                exceptionsReadOnly = new HashSet<Control>();
            }
            exceptionsReadOnly.Add(c);
        }

        /// <summary>
        /// Is some control read only for the form
        /// </summary>
        /// <param name="c">reference to control</param>
        /// <returns>true if control should be always read only</returns>
        private bool IsAlwaysReadOnly(Control c)
        {
            return alwaysReadOnly != null && alwaysReadOnly.Contains(c);
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
                bool isControlReadOnly = !editMode || IsAlwaysReadOnly(c);

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