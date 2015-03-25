using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Prizm.Main.Languages;
using System.Collections.Generic;

namespace Prizm.Main.Forms.Reports.Incoming
{
    public partial class IncomingReportsXtraReport : LocalizableXtraReport
    {
        public IncomingReportsXtraReport()
        {
            InitializeComponent();

            Program.LanguageManager.ChangeLanguage(this as ILocalizable);
        }

        public bool FootersVisibility
        {
            get { return pageFooter.Visible; }
            set { pageFooter.Visible = value; }
        }

        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
                new LocalizedItem(pipeNumberLabel, StringResources.IncomingReportsXtraReport_PipeNumberLabel.Id),
                new LocalizedItem(reportHeaderLabel, StringResources.IncomingReportsXtraReport_ReportHeaderLabel.Id),

                new LocalizedItem(pipeTypeLabel, StringResources.IncomingReportsXtraReport_PipeTypeLabel.Id),
                new LocalizedItem(pipeLengthLabel, StringResources.IncomingReportsXtraReport_PipeLengthLabel.Id),
                new LocalizedItem(pipeWallThicknessLabel, StringResources.IncomingReportsXtraReport_PipeWallThicknessLabel.Id),
                new LocalizedItem(heatNumberLabel, StringResources.IncomingReportsXtraReport_HeatNumberLabel.Id),
                new LocalizedItem(inspectionStatusLabel, StringResources.IncomingReportsXtraReport_InspectionStatusLabel.Id),
                //new LocalizedItem(reportDateTimeInfo, StringResources.IncomingReportsXtraReport_ReportDateTimeInfo.Id) 
            };
        }

        #endregion // --- Localization ---
    }
}
