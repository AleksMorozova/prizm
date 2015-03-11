using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Ninject;
using Prizm.Main.Synch.Export;
using Prizm.Domain.Entity;
using Ninject.Parameters;
using Prizm.Main.Languages;
using Prizm.Main.Forms.MainChildForm;

namespace Prizm.Main.Forms.Synch
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class HistoryExportImport : ChildForm
    {
        private readonly DataExporter exporter;

        [Inject]
        public HistoryExportImport(DataExporter exporter)
            : this()
        {
            this.exporter = exporter;
        }

        public HistoryExportImport()
        {
            InitializeComponent();
        }

        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
          {
              //// controls
              //new LocalizedItem(btnExport, StringResources.Export_ExportButton.Id),
              //new LocalizedItem(progressPanel, StringResources.Export_PleaseWaitPanel.Id, StringResources.Export_ExportingData.Id),
              //new LocalizedItem(lblLog, StringResources.Export_LogLabel.Id),
              //new LocalizedItem(btnReexport, StringResources.Export_ReexportButton.Id),

              //// grid column headers
              //new LocalizedItem(portionId, StringResources.Export_PortionIdColumnHeader.Id),
              //new LocalizedItem(gridColumnExportDate, StringResources.Export_ExportDateColumnHeader.Id),
              //// other
              //new LocalizedItem(logTabPage, StringResources.Export_LogTab.Id),
              //new LocalizedItem(historyTabPage,StringResources.Export_HistoryTab.Id),

              //new LocalizedItem(this, localizedHeader, new string[] {StringResources.ExportForm_Title.Id} )
          };
        }

        #endregion // --- Localization ---

        private void HistoryExportImport_Load(object sender, EventArgs e)
        {
            gridControlHistory.DataSource = exporter.GetAllPortions();
        }

        private void btnReexport_Click(object sender, EventArgs e)
        {
            Portion portion = gridViewHistory.GetFocusedRow() as Portion;
            if (portion != null)
            {
                var parent = this.MdiParent as PrizmApplicationXtraForm;
                parent.OpenChildForm(typeof(ExportForm), portion.Id);
            }
        }

        private void HistoryExportImport_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.exporter.Dispose();
        }


    }
}