using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Prizm.Main.Languages;

namespace Prizm.Main.Forms.Reports.Mill
{
    public partial class LoadingXtraReport : DevExpress.XtraReports.UI.XtraReport, ILocalizable
    {
        public LoadingXtraReport()
        {
            InitializeComponent();

            Program.LanguageManager.ChangeLanguage(this as ILocalizable);
        }
        public bool FootersVisibility
        {
            get { return pageFooterBand.Visible; }
            set { pageFooterBand.Visible = value; }
        }


        #region --- Localization ---

        protected List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
                //new LocalizedItem(xrLabel5, StringResources.LoadingXtraReport_xrReportHeader.Id),
                //new LocalizedItem(pageHeaderLabel, StringResources.LoadingXtraReport__PageHeaderLabel.Id),
                //new LocalizedItem(numberLabel, StringResources.LoadingXtraReport__NumberLabel.Id),
                //new LocalizedItem(typeLabel, StringResources.LoadingXtraReport_TypeLabel.Id),
                //new LocalizedItem(statusLabel, StringResources.LoadingXtraReport__StatusLabel.Id),
                //new LocalizedItem(purchaseOrderDateLabel, StringResources.LoadingXtraReport__PurchaseOrderDateLabel.Id),
                //new LocalizedItem(purchaseOrderNumberLabel, StringResources.LoadingXtraReport__PurchaseOrderNumberLabel.Id),
                //new LocalizedItem(wallThicknessLabel, StringResources.LoadingXtraReport__WallThicknessLabel.Id),
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
