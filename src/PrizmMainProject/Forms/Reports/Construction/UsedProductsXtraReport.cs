using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Prizm.Main.Languages;

namespace Prizm.Main.Forms.Reports.Construction
{
    public partial class UsedProductsXtraReport : DevExpress.XtraReports.UI.XtraReport, ILocalizable
    {
        public UsedProductsXtraReport()
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
                new LocalizedItem(groupHeaderLabel, StringResources.UsedProductsXtraReport_GroupHeaderLabel.Id),
                new LocalizedItem(pageHeaderLabel, StringResources.UsedProductsXtraReport_PageHeaderLabel.Id),
                new LocalizedItem(productNumberLabel, StringResources.UsedProductsXtraReport_ProductNumberLabel.Id),
                new LocalizedItem(productTypeLabel, StringResources.UsedProductsXtraReport_ProductTypeLabel.Id),
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
