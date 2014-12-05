using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PrizmMain.Documents;
using PrizmMain.Properties;
using PrizmMain.Forms.Common;
using PrizmMain.Commands;

namespace PrizmMain.Forms.MainChildForm
{
    public class ChildForm : XtraForm, IModifiable
    {
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
    }
}