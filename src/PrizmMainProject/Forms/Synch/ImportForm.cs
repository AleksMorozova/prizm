using DevExpress.XtraEditors;
using Ninject;
using Prizm.Main.Forms.MainChildForm;
using Prizm.Main.Languages;
using Prizm.Main.Properties;
using Prizm.Main.Synch.Import;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prizm.Main.Forms.Synch
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class ImportForm : PrizmForm
   {
      private ConflictDialog singleConflictDialog = null;

      readonly DataImporter importer;
      [Inject]
      public ImportForm(DataImporter importer)
      {
         InitializeComponent();

         this.importer = importer;
         importer.OnDone += importer_OnDone;
         importer.OnError += importer_OnError;
         importer.OnConflict += importer_OnConflict;
         importer.OnMessage += importer_OnMessage;
         importer.OnProgress += importer_OnProgress;
         importer.OnMissing += importer_OnMissing;
      }


      #region --- Localization ---

      protected override List<LocalizedItem> CreateLocalizedItems()
      {
          return new List<LocalizedItem>()
          {
              new LocalizedItem(archive, StringResources.Import_ArchiveLabel.Id),
              new LocalizedItem(btnBrowse, StringResources.Import_BrowseButton.Id),
              new LocalizedItem(btnImport, StringResources.Import_ImportButton.Id),
              new LocalizedItem(btnClose, StringResources.Import_ExitButton.Id),

              new LocalizedItem(this, localizedHeader, new string[] {StringResources.ImportForm_Title.Id} )
          };
      }

      #endregion // --- Localization ---
       
       void SetProgressBar(int progress)
      {
         if (progressBarControl.InvokeRequired)
         {
            progressBarControl.Invoke(new MethodInvoker(() => progressBarControl.Position = progress));
         }
         else
         {
            progressBarControl.Position = progress;
         }

      }

      void SetStatusLabel(string msg)
      {
         if (lblStatus.InvokeRequired)
         {
            lblStatus.Invoke(new MethodInvoker(() => lblStatus.Text = msg));
         }
         else
         {
            lblStatus.Text = msg;
         }
      }

      void EnableButtons(bool enabled)
      {
         if (btnImport.InvokeRequired)
         {
            btnImport.Invoke(new MethodInvoker(() => btnImport.Enabled = enabled));
         }
         else
         {
            btnImport.Enabled = enabled;
         }
         if (btnBrowse.InvokeRequired)
         {
             btnBrowse.Invoke(new MethodInvoker(() => btnBrowse.Enabled = enabled));
         }
         else
         {
             btnBrowse.Enabled = enabled;
         }
         if (btnClose.InvokeRequired)
         {
             btnClose.Invoke(new MethodInvoker(() => btnClose.Enabled = enabled));
         }
         else
         {
             btnClose.Enabled = enabled;
         }
      }

      void importer_OnProgress(int progress)
      {
         SetProgressBar(progress);
      }

      void importer_OnMessage(string msg)
      {
         SetStatusLabel(msg);
      }

      void importer_OnConflict(ConflictEventArgs args)
      {
          if (this.InvokeRequired)
          {
              this.Invoke(new Action(() => { ConflictDialogCreation(args); }));
          }
          else
          {
              ConflictDialogCreation(args);
          }
      }

      private void ConflictDialogCreation(ConflictEventArgs args)
      {
          if (singleConflictDialog == null)
          {
              singleConflictDialog = new ConflictDialog(args.Message);
          }
          else
          {
              singleConflictDialog.SetConflictDialog(args.Message);
          }

          singleConflictDialog.ShowDialog();
          args.Decision = singleConflictDialog.Decision;
          args.ForAll = singleConflictDialog.ForAll;
      }

      void importer_OnMissing(MissingEventArgs args)
      {
          if (this.InvokeRequired)
          {
              this.Invoke(new Action(() => { MissingPortionsDialogCreation(args); }));
          }
          else
          {
              MissingPortionsDialogCreation(args);
          }
      }

      private void MissingPortionsDialogCreation(MissingEventArgs args)
      {
          MissingPortionsDialog dialog = new MissingPortionsDialog(args.ExistingPortions, args.MissingPortions, args.MillName);
          dialog.ShowDialog();
          if (dialog.DialogResult != System.Windows.Forms.DialogResult.No)
          {
              importer.TaskIsCancelled = true;
          }
      }

      void importer_OnError(ImportException e)
      {
          if (this.InvokeRequired && !importer.IsDisposed)
          {
              this.Invoke(new Action(() => { OnErrorMessaging(e); }));
          }
          else
          {
              OnErrorMessaging(e);
          }
      }

      private void OnErrorMessaging(ImportException e)
      {
         string msg = e.Message;
         if (e.StackTrace != null)
            msg += "\n " + e.StackTrace;
         MessageBox.Show(msg, 
             Program.LanguageManager.GetString(StringResources.Message_ErrorHeader), MessageBoxButtons.OK, MessageBoxIcon.Error);
         ResetControls();
      }

      void ResetControls()
      {
         SetProgressBar(0);
         SetStatusLabel(string.Empty);
         EnableButtons(true);
      }

      void importer_OnDone()
      {
          if (this.InvokeRequired)
          {
              this.Invoke(new Action(() => { OnDoneMessageCreation(); }));
          }
          else
          {
              OnDoneMessageCreation();
          }
      }

      private void OnDoneMessageCreation()
      {
          string message = Program.LanguageManager.GetString(StringResources.ImportMessage_IsFinished);
          XtraMessageBox.Show(message, message);
          ResetControls();
      }


      public ImportForm()
      {
         InitializeComponent();
      }

      private void btnBrowse_Click(object sender, EventArgs e)
      {
         OpenFileDialog dlg = new OpenFileDialog();
         dlg.Filter = Program.LanguageManager.GetString(StringResources.Export_Filter)+Resources.prizm;

         if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
         {
            txtArchive.Text = dlg.FileName;        
         }
      }

      private void btnImport_Click(object sender, EventArgs e)
      {
          if (txtArchive.Text != string.Empty)
          {
              EnableButtons(false);
              new Task(() => importer.Import(txtArchive.Text)).Start();
          }
      }

      private void ImportForm_FormClosing(object sender, FormClosingEventArgs e)
      {
          importer.Dispose();
      }
   }
}
