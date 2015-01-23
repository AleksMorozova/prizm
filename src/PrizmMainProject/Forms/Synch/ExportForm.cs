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
              // layout items
              //new LocalizedItem(pipeNumberLayout, "NewEditPipe_PipeNumberLabel"),

              // controls
              //new LocalizedItem(attachmentsButton, "NewEditPipe_AttachmentsButton"),

              // grid column headers
              //new LocalizedItem(weldersGridColumn, "NewEditPipe_WeldersColumnHeader"),

              // layout control groups
              //new LocalizedItem(plateLayoutControlGroup, "NewEditPipe_PlateGroup"),

              // other
          };
      }

      #endregion // --- Localization ---

      void DoExport(Portion portion = null)
      {
         exportTabs.SelectedTabPage = logTabPage;
         log.Clear();

         if (portion == null && !exporter.AnyNewDataToExport())
         {
            exporter_OnMessage(Resources.Export_NoData);
            return;
         }

         SaveFileDialog dlg = new SaveFileDialog();
         dlg.Filter = Resources.Export_Filter;

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
            log.AppendText(string.Format(Resources.Export_Error, DateTime.Now.ToString(), e.Message) + "\n");
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
            log.AppendText(string.Format(Resources.Export_ArchiveExported, DateTime.Now.ToString(), exporter.ArchiveName) + "\n");
            log.AppendText("--------------------------------------------------------------------------------------------\n");
            log.AppendText(Resources.Export_Ready + "\n");
         });
      }

      void exporter_OnMessage(string msg)
      {
         InvokeIfRequired(() =>
         {
            log.AppendText(string.Format(Resources.Export_Msg, DateTime.Now.ToString(), msg) + "\n");
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
