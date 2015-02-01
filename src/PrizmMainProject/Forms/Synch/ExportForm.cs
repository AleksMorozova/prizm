using DevExpress.XtraEditors;
using Ninject;
using Prizm.Data.DAL.Synch;
using Prizm.Domain.Entity;
using Prizm.Main.Forms.MainChildForm;
using Prizm.Main.Languages;
using Prizm.Main.Properties;
using Prizm.Main.Synch.Export;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prizm.Main.Forms.Synch
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class ExportForm : ChildForm
   {
      readonly DataExporter exporter;

      [Inject]
      public ExportForm(DataExporter exporter)
      {
         InitializeComponent();

         this.exporter = exporter;
      }

      public ExportForm()
      {
         InitializeComponent();
      }

      #region --- Localization ---

      protected override List<LocalizedItem> CreateLocalizedItems()
      {
          return new List<LocalizedItem>()
          {
              // controls
              new LocalizedItem(btnExport, StringResources.Export_ExportButton.Id),
              new LocalizedItem(progressPanel, StringResources.Export_PleaseWaitPanel.Id, StringResources.Export_ExportingData.Id),
              new LocalizedItem(lblLog, StringResources.Export_LogLabel.Id),
              new LocalizedItem(btnReexport, StringResources.Export_ReexportButton.Id),
              
              // grid column headers
              new LocalizedItem(portionId, StringResources.Export_PortionIdColumnHeader.Id),
              new LocalizedItem(gridColumnExportDate, StringResources.Export_ExportDateColumnHeader.Id),
              // other
              new LocalizedItem(logTabPage, StringResources.Export_LogTab.Id),
              new LocalizedItem(historyTabPage,StringResources.Export_HistoryTab.Id),
          };
      }

      #endregion // --- Localization ---

      void DoExport(Portion portion = null)
      {
         exportTabs.SelectedTabPage = logTabPage;
         log.Clear();

         if (portion == null && !exporter.AnyNewDataToExport())
         {
            exporter_OnMessage(Program.LanguageManager.GetString(StringResources.Export_NoData));
            return;
         }

         SaveFileDialog dlg = new SaveFileDialog();
         dlg.Filter = Program.LanguageManager.GetString(StringResources.Export_Filter);

         if (dlg.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            return;

         exporter.ArchiveName = dlg.FileName;

         exporter.OnMessage -= exporter_OnMessage;
         exporter.OnDone -= exporter_OnDone;
         exporter.OnError -= exporter_OnError;

         exporter.OnMessage += exporter_OnMessage;
         exporter.OnDone += exporter_OnDone;
         exporter.OnError += exporter_OnError;

         progressPanel.Visible = true;

         Task task = portion == null ? new Task(() => exporter.Export()) : new Task(() => exporter.Export(portion));
         task.ContinueWith((_) => {
            if (progressPanel.InvokeRequired)
            {
               progressPanel.Invoke(new MethodInvoker(() => { progressPanel.Visible = false; }));
            }
            else
            {
               progressPanel.Visible = false;
            }
            
            LoadPortions();
         });
         task.Start();
      }

      private void btnExport_Click(object sender, EventArgs e)
      {
         DoExport();
      }

      void exporter_OnError(ExportException e)
      {
         InvokeIfRequired(() =>
         {
            log.AppendText(string.Format(Program.LanguageManager.GetString(StringResources.Export_Error), DateTime.Now.ToString(), e.Message) + "\n");
            if (e.InnerException != null && e.InnerException.StackTrace != null)
            {
               log.AppendText(e.InnerException.StackTrace.ToString() + "\n");
            }
         });
      }

      void InvokeIfRequired(Action act)
      {
         if (log.InvokeRequired)
         {
            log.Invoke(act);
         }
         else
         {
            act();
         }
      }

      void exporter_OnDone()
      {
         InvokeIfRequired(() =>
         {
            log.AppendText(string.Format(Program.LanguageManager.GetString(StringResources.Export_ArchiveExported), DateTime.Now.ToString(), exporter.ArchiveName) + "\n");
            log.AppendText("--------------------------------------------------------------------------------------------\n");
            log.AppendText(Program.LanguageManager.GetString(StringResources.Export_Ready) + "\n");
         });
      }

      void exporter_OnMessage(string msg)
      {
         InvokeIfRequired(() =>
         {
             log.AppendText(string.Format("[{0}] {1}", DateTime.Now.ToString(), msg) + "\n");
         });
      }

      void LoadPortions()
      {
         IList<Portion> portions = exporter.GetAllPortions();
         if (gridControlHistory.InvokeRequired)
         {
            gridControlHistory.Invoke(new MethodInvoker(() => { gridControlHistory.DataSource = portions; }));
         }
         else
         {
            gridControlHistory.DataSource = portions;
         }
      }

      void ExportForm_Load(object sender, EventArgs e)
      {
         LoadPortions();
      }

      private void btnReexport_Click(object sender, EventArgs e)
      {
         Portion portion = gridViewHistory.GetFocusedRow() as Portion;
         if (portion != null)
         {
            DoExport(portion);
         }
      }

      private void ExportForm_FormClosing(object sender, FormClosingEventArgs e)
      {
         exporter.Dispose();
      }
   }
}
