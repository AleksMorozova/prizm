using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Prizm.Main.Languages;
using System.Collections.Generic;

namespace Prizm.Main.Forms.Reports.Mill
{
    public partial class MillReportsXtraReport : DevExpress.XtraReports.UI.XtraReport, ILocalizable
    {
        public MillReportsXtraReport()
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

        protected List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
                new LocalizedItem(reportHeaderLabel, StringResources.MillReportsXtraReport_ReportHeaderLabel.Id),
                
                new LocalizedItem(numberLabel, StringResources.MillReportsXtraReport_NumberLabel.Id),
                new LocalizedItem(typeLabel, StringResources.MillReportsXtraReport_TypeLabel.Id),
                new LocalizedItem(statusLabel, StringResources.MillReportsXtraReport_StatusLabel.Id),
                new LocalizedItem(purchaseOrderDateLabel, StringResources.MillReportsXtraReport_PurchaseOrderDateLabel.Id),
                new LocalizedItem(purchaseOrderNumberLabel, StringResources.MillReportsXtraReport_PurchaseOrderNumberLabel.Id),
                new LocalizedItem(wallThicknessLabel, StringResources.MillReportsXtraReport_WallThicknessLabel.Id),
                new LocalizedItem(weightLabel, StringResources.MillReportsXtraReport_WeightLabel.Id),
                new LocalizedItem(lengthLabel, StringResources.MillReportsXtraReport_LengthLabel.Id),
                new LocalizedItem(diameterLabel, StringResources.MillReportsXtraReport_DiameterLabel.Id),
                new LocalizedItem(plateNumberLabel, StringResources.MillReportsXtraReport_PlateNumberLabel.Id),
                new LocalizedItem(heatNumberLabel, StringResources.MillReportsXtraReport_HeatNumberLabel.Id),
                new LocalizedItem(activeLabel, StringResources.MillReportsXtraReport_ActiveLabel.Id),

            };
        }


        private List<LocalizedItem> localizedItems = null;
        public IEnumerator<ILocalizedItem> GetEnumerator()
        {
            if (localizedItems == null)
            {
                localizedItems = CreateLocalizedItems();
            }
            return localizedItems.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        #endregion // --- Localization ---

    }
}
