using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Prizm.Main.Languages;
using Prizm.Domain.Entity.Construction;
using Prizm.Main.Common;

namespace Prizm.Main.Forms.Reports.Construction
{
    public partial class UsedProductsXtraReport : DevExpress.XtraReports.UI.XtraReport, ILocalizable
    {
        private List<string> localizedStrings = new List<string>();

        public UsedProductsXtraReport(): this(new List<string>()) { }

        public UsedProductsXtraReport(List<string> localizedStrings)
        {
            InitializeComponent();
            this.localizedStrings = localizedStrings;
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

        private void xrLabel2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            PartType result = (PartType)Enum.Parse(typeof(PartType),xrLabel2.Text.ToString());

            xrLabel2.Text = localizedStrings[(int)((object)result) - 1];
     
        }

        public static void LoadItems(List<string> list, bool skip0 = false)
        {
            if (list != null)
            {
                if (list.Count == 0)
                {
                    foreach (var item in EnumWrapper<PartType>.EnumerateItems(skip0))
                    {
                        list.Add(item.Item2);
                    }
                }
            }
        }
    }
}
