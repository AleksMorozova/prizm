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
                new LocalizedItem(loadingReportLabel, StringResources.LoadingXtraReport_LoadingReportLabel.Id),
                new LocalizedItem(releaseNoteNumberLabel, StringResources.LoadingXtraReport_ReleaseNoteNumberLabel.Id),
                new LocalizedItem(railcarNumberLabel, StringResources.LoadingXtraReport_RailcarNumberLabel.Id),
                new LocalizedItem(destinationLabel, StringResources.LoadingXtraReport_DestinationLabel.Id),
                new LocalizedItem(certificateLabel, StringResources.LoadingXtraReport_CertificateLabel.Id),
                new LocalizedItem(metersCountLabel, StringResources.LoadingXtraReport_MetersCountLabel.Id),
                new LocalizedItem(weightCountLabel, StringResources.LoadingXtraReport_WeightCountLabel.Id),
                new LocalizedItem(pipesCountLabel, StringResources.LoadingXtraReport_PipesCountLabel.Id),
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
