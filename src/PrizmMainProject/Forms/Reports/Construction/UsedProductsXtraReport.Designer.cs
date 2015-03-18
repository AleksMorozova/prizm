namespace Prizm.Main.Forms.Reports.Construction
{
    partial class UsedProductsXtraReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsedProductsXtraReport));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.productTypeLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.productNumberLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.pageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.dateTimePageInfo = new DevExpress.XtraReports.UI.XRPageInfo();
            this.numberOfPageInfo = new DevExpress.XtraReports.UI.XRPageInfo();
            this.TableHeader = new DevExpress.XtraReports.UI.XRControlStyle();
            this.groupHeaderLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.Header = new DevExpress.XtraReports.UI.XRControlStyle();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.OddStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.EvenStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.reportDateTimeInfo = new DevExpress.XtraReports.UI.XRPageInfo();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.pageHeaderLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2,
            this.xrLabel1});
            this.Detail.HeightF = 23.74999F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomSqlQuery.type")});
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(325F, 0F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(324.9999F, 23F);
            this.xrLabel2.Text = "xrLabel2";
            // 
            // xrLabel1
            // 
            this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomSqlQuery.number")});
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(325F, 23F);
            this.xrLabel1.Text = "xrLabel1";
            // 
            // GroupHeader
            // 
            this.GroupHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.productTypeLabel,
            this.productNumberLabel});
            this.GroupHeader.HeightF = 23F;
            this.GroupHeader.KeepTogether = true;
            this.GroupHeader.Name = "GroupHeader";
            this.GroupHeader.RepeatEveryPage = true;
            // 
            // productTypeLabel
            // 
            this.productTypeLabel.LocationFloat = new DevExpress.Utils.PointFloat(325F, 0F);
            this.productTypeLabel.Name = "productTypeLabel";
            this.productTypeLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.productTypeLabel.SizeF = new System.Drawing.SizeF(325F, 23F);
            this.productTypeLabel.Text = "Тип изделия";
            // 
            // productNumberLabel
            // 
            this.productNumberLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.productNumberLabel.Name = "productNumberLabel";
            this.productNumberLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.productNumberLabel.SizeF = new System.Drawing.SizeF(325F, 23F);
            this.productNumberLabel.Text = "Номер изделия";
            // 
            // pageFooter
            // 
            this.pageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.dateTimePageInfo,
            this.numberOfPageInfo});
            this.pageFooter.HeightF = 25F;
            this.pageFooter.Name = "pageFooter";
            // 
            // dateTimePageInfo
            // 
            this.dateTimePageInfo.Format = "{0:dddd, d MMMM, yyyy HH:mm:ss}";
            this.dateTimePageInfo.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.dateTimePageInfo.Name = "dateTimePageInfo";
            this.dateTimePageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.dateTimePageInfo.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.dateTimePageInfo.SizeF = new System.Drawing.SizeF(325F, 23F);
            // 
            // numberOfPageInfo
            // 
            this.numberOfPageInfo.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.numberOfPageInfo.Format = "Page {0} of {1}";
            this.numberOfPageInfo.LocationFloat = new DevExpress.Utils.PointFloat(325F, 0F);
            this.numberOfPageInfo.Name = "numberOfPageInfo";
            this.numberOfPageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.numberOfPageInfo.SizeF = new System.Drawing.SizeF(325.0001F, 23F);
            this.numberOfPageInfo.StyleName = "EvenStyle";
            this.numberOfPageInfo.StylePriority.UseFont = false;
            this.numberOfPageInfo.StylePriority.UseTextAlignment = false;
            this.numberOfPageInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // TableHeader
            // 
            this.TableHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.TableHeader.Name = "TableHeader";
            this.TableHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TableHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // groupHeaderLabel
            // 
            this.groupHeaderLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 20F);
            this.groupHeaderLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.groupHeaderLabel.Name = "groupHeaderLabel";
            this.groupHeaderLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.groupHeaderLabel.SizeF = new System.Drawing.SizeF(502.0832F, 40.70836F);
            this.groupHeaderLabel.StyleName = "Header";
            this.groupHeaderLabel.StylePriority.UseFont = false;
            this.groupHeaderLabel.StylePriority.UseTextAlignment = false;
            this.groupHeaderLabel.Text = "Отчет по использованным изделиям";
            this.groupHeaderLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // Header
            // 
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.Header.Name = "Header";
            this.Header.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Header.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 34.375F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // OddStyle
            // 
            this.OddStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.OddStyle.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.OddStyle.Name = "OddStyle";
            this.OddStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.OddStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // EvenStyle
            // 
            this.EvenStyle.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.EvenStyle.Name = "EvenStyle";
            this.EvenStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.EvenStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 50.70836F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.groupHeaderLabel,
            this.reportDateTimeInfo});
            this.ReportHeader.HeightF = 40.70836F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // reportDateTimeInfo
            // 
            this.reportDateTimeInfo.Format = "{0:dd-MM-yyyy H:mm:ss}";
            this.reportDateTimeInfo.LocationFloat = new DevExpress.Utils.PointFloat(502.0832F, 0F);
            this.reportDateTimeInfo.Name = "reportDateTimeInfo";
            this.reportDateTimeInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.reportDateTimeInfo.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.reportDateTimeInfo.SizeF = new System.Drawing.SizeF(147.9167F, 40.70836F);
            this.reportDateTimeInfo.StylePriority.UseTextAlignment = false;
            this.reportDateTimeInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pageHeaderLabel});
            this.PageHeader.HeightF = 41.66667F;
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.NotWithReportHeader;
            // 
            // pageHeaderLabel
            // 
            this.pageHeaderLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 20F);
            this.pageHeaderLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.pageHeaderLabel.Name = "pageHeaderLabel";
            this.pageHeaderLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pageHeaderLabel.SizeF = new System.Drawing.SizeF(649.9999F, 40.70836F);
            this.pageHeaderLabel.StyleName = "Header";
            this.pageHeaderLabel.StylePriority.UseFont = false;
            this.pageHeaderLabel.StylePriority.UseTextAlignment = false;
            this.pageHeaderLabel.Text = "Отчет по использованным изделиям";
            this.pageHeaderLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "PrismDatabase";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "CustomSqlQuery";
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0ic3FsRGF0YVNvdXJjZTEiPjxWaWV3IE5hbWU9IkN1c3RvbVNxbFF1ZXJ5Ij48R" +
    "mllbGQgTmFtZT0ibnVtYmVyIiBUeXBlPSJTdHJpbmciIC8+PEZpZWxkIE5hbWU9InR5cGUiIFR5cGU9I" +
    "lN0cmluZyIgLz48L1ZpZXc+PC9EYXRhU2V0Pg==";
            // 
            // UsedProductsXtraReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.pageFooter,
            this.GroupHeader,
            this.ReportHeader,
            this.PageHeader});
            this.DataMember = "Joint";
            this.DataSource = this.sqlDataSource1;
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 51, 34);
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Header,
            this.TableHeader,
            this.OddStyle,
            this.EvenStyle});
            this.Version = "14.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader;
        private DevExpress.XtraReports.UI.PageFooterBand pageFooter;
        private DevExpress.XtraReports.UI.XRPageInfo numberOfPageInfo;
        private DevExpress.XtraReports.UI.XRControlStyle TableHeader;
        private DevExpress.XtraReports.UI.XRLabel groupHeaderLabel;
        private DevExpress.XtraReports.UI.XRControlStyle Header;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRControlStyle OddStyle;
        private DevExpress.XtraReports.UI.XRControlStyle EvenStyle;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRLabel pageHeaderLabel;
        private DevExpress.XtraReports.UI.XRLabel productTypeLabel;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel productNumberLabel;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.XRPageInfo dateTimePageInfo;
        private DevExpress.XtraReports.UI.XRPageInfo reportDateTimeInfo;

    }
}
