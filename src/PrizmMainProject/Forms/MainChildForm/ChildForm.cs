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

        private void InitializeComponent()
        {
        }

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

        public virtual bool IsModified 
        { 
           get
           {
              return isModified;
           }
           set
           {
              isModified = value;
              CorrectCaption();
              Modified(isModified);
           }
        }

        private void CorrectCaption()
        {
           if (IsModified)
           {
              if (!Text.EndsWith("*"))
              {
                 Text = string.Format("{0}*", Text);
              }
           }
           else
           {
              if (Text.EndsWith("*"))
              {
                 Text = Text.Substring(0, Text.Length - 1);
              }
           }
        }

        protected ICommand SaveCommand
        {
           get;
           set;
        }

        public event System.Action<bool> Modified = delegate { };

        public PrizmApplicationXtraForm MdiParent 
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