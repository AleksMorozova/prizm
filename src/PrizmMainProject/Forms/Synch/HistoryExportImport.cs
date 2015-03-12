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
using Prizm.Main.Common;
using Prizm.Domain.Entity.Setup;

namespace Prizm.Main.Forms.Synch
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class HistoryExportImport : ChildForm
    {
        private List<string> localizedAllWorkstations = new List<string>();
        private List<string> localizedSynchType = new List<string>();

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
              // grid column headers
              new LocalizedItem(portionIdColumn, StringResources.Export_PortionIdColumnHeader.Id),
              new LocalizedItem(portionDateColumn, StringResources.Export_ExportDateColumnHeader.Id),

              new LocalizedItem(isExportColumn, StringResources.HistoryExportImport_IsExportColumn.Id),
              new LocalizedItem(workstationColumn, StringResources.HistoryExportImport_WorkstationColumn.Id),

              new LocalizedItem(gridViewHistory, localizedAllWorkstations,
                        new string [] {StringResources.WorkstationType_Undefined.Id, 
                            StringResources.WorkstationType_Master.Id, 
                            StringResources.WorkstationType_Mill.Id, 
                            StringResources.WorkstationType_Construction.Id} ),

              new LocalizedItem(gridViewHistory, localizedSynchType,
                        new string [] {StringResources.HistoryExportImport_SynchType_Undefined.Id, 
                            StringResources.HistoryExportImport_SynchType_Export.Id, 
                            StringResources.HistoryExportImport_SynchType_Import.Id} ),

              new LocalizedItem(this, localizedHeader, new string[] {StringResources.HistoryExportImport_Title.Id} )
          };
        }

        #endregion // --- Localization ---

        private void HistoryExportImport_Load(object sender, EventArgs e)
        {
            foreach (var item in EnumWrapper<WorkstationType>.EnumerateItems())
            {
                localizedAllWorkstations.Add(item.Item2);
            }
            foreach (var item in EnumWrapper<SynchType>.EnumerateItems())
            {
                localizedSynchType.Add(item.Item2);
            }

            gridControlHistory.DataSource = exporter.GetAllPortions();
        }

        private void HistoryExportImport_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.exporter.Dispose();
        }

        private void gridViewHistory_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.Name == workstationColumn.Name)
            {
                WorkstationType result;
                if (Enum.TryParse<WorkstationType>(e.Value.ToString(), out result))
                {
                    e.DisplayText = localizedAllWorkstations[(int)result];
                }
            }

            if (e.Column.Name == isExportColumn.Name)
            {
                bool result;
                if (bool.TryParse(e.Value.ToString(), out result))
                {
                    if ((bool)e.Value)
                    {
                        e.DisplayText = localizedSynchType[(int)SynchType.Export];
                    }
                    else
                    {
                        e.DisplayText = localizedSynchType[(int)SynchType.Import];
                    }
                }
            }
        }

    }
}