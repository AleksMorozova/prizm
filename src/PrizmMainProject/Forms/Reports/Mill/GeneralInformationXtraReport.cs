using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Prizm.Main.Languages;
using System.Collections.Generic;

namespace Prizm.Main.Forms.Reports.Mill
{
    public partial class GeneralInformationXtraReport : DevExpress.XtraReports.UI.XtraReport, ILocalizable
    {
        public GeneralInformationXtraReport()
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
                new LocalizedItem(generalReportHeaderLabel, StringResources.GeneralInformationXtraReport_GeneralReportHeaderLabel.Id),              
                new LocalizedItem(BARLabel, StringResources.GeneralInformationXtraReport_BARLabel.Id),
                new LocalizedItem(EXCLabel, StringResources.GeneralInformationXtraReport_EXCLabel.Id),
                new LocalizedItem(COALabel, StringResources.GeneralInformationXtraReport_COALabel.Id),
                new LocalizedItem(productionDateLabel, StringResources.GeneralInformationXtraReport_ProductionDateLabel.Id),
                new LocalizedItem(BARAcceptedLabel, StringResources.GeneralInformationXtraReport_BARAcceptedLabel.Id),
                new LocalizedItem(BARRepairLabel, StringResources.GeneralInformationXtraReport_BARRepairLabel.Id),
                new LocalizedItem(BARAfterRepairLabel, StringResources.GeneralInformationXtraReport_BARAfterRepairLabel.Id),
                new LocalizedItem(BARRejectedLabel, StringResources.GeneralInformationXtraReport_BARRejectedLabel.Id),
                new LocalizedItem(EXCAcceptedLabel, StringResources.GeneralInformationXtraReport_EXCAcceptedLabel.Id),
                new LocalizedItem(EXCRepairLabel, StringResources.GeneralInformationXtraReport_EXCRepairLabel.Id),
                new LocalizedItem(EXCAfterRepairLabel, StringResources.GeneralInformationXtraReport_EXCAfterRepairLabel.Id),
                new LocalizedItem(EXCRejectedLabel, StringResources.GeneralInformationXtraReport_EXCRejectedLabel.Id),
                new LocalizedItem(COAAcceptedLabel, StringResources.GeneralInformationXtraReport_COAAcceptedLabel.Id),
                new LocalizedItem(COARepairLabel, StringResources.GeneralInformationXtraReport_COARepairLabel.Id),
                new LocalizedItem(COAAfterRepairLabel, StringResources.GeneralInformationXtraReport_COAAfterRepairLabel.Id),
                new LocalizedItem(COARejectedLabel, StringResources.GeneralInformationXtraReport_COARejectedLabel.Id),
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
