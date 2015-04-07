namespace Prizm.Main.Forms.Reports.Mill
{
    partial class LoadingXtraReport
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
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingXtraReport));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource();
            this.releaseNoteNumberLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.pipesCountLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.pageFooterBand = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.reportHeaderBand1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.pageHeaderLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.reportDateTimeInfo = new DevExpress.XtraReports.UI.XRPageInfo();
            this.loadingReportLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.FieldCaption = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DataField = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.certificateLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.destinationLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.railcarNumberLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.weightCountLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.metersCountLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel15,
            this.xrLabel14,
            this.xrLabel12,
            this.xrLabel11,
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel13});
            this.Detail.HeightF = 23F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("releaseNote", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.Detail.StyleName = "DataField";
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel15
            // 
            this.xrLabel15.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomSqlQuery.pipes")});
            this.xrLabel15.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(650.25F, 0F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(86.75F, 23F);
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.Text = "xrLabel15";
            // 
            // xrLabel14
            // 
            this.xrLabel14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomSqlQuery.weight")});
            this.xrLabel14.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(547.1335F, 0F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(103.1165F, 23F);
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.Text = "xrLabel14";
            // 
            // xrLabel12
            // 
            this.xrLabel12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomSqlQuery.railcarCertificate")});
            this.xrLabel12.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(352.641F, 0F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.Text = "xrLabel12";
            // 
            // xrLabel11
            // 
            this.xrLabel11.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomSqlQuery.railcarDestination")});
            this.xrLabel11.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(251.0661F, 0F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(101.5749F, 23F);
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.Text = "xrLabel11";
            // 
            // xrLabel4
            // 
            this.xrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomSqlQuery.railcarNumber")});
            this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(139.0747F, 0F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(111.9914F, 23F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.Text = "xrLabel4";
            // 
            // xrLabel3
            // 
            this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomSqlQuery.releaseNote")});
            this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(139.0747F, 23F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.Text = "xrLabel3";
            // 
            // xrLabel13
            // 
            this.xrLabel13.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomSqlQuery.length")});
            this.xrLabel13.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(452.641F, 0F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(94.49243F, 23F);
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.Text = "xrLabel13";
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 50F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 37.625F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "PrismDatabase";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "CustomSqlQuery";
            customSqlQuery1.Sql = "Select Distinct(note.number) Notes, (Select Count(r.number) from Railcar r where " +
    "r.releaseNoteId=note.id) as railcars from ReleaseNote note";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0ic3FsRGF0YVNvdXJjZTEiPjxWaWV3IE5hbWU9IkN1c3RvbVNxbFF1ZXJ5Ij48R" +
    "mllbGQgTmFtZT0iTm90ZXMiIFR5cGU9IlN0cmluZyIgLz48RmllbGQgTmFtZT0icmFpbGNhcnMiIFR5c" +
    "GU9IkludDMyIiAvPjwvVmlldz48L0RhdGFTZXQ+";
            // 
            // releaseNoteNumberLabel
            // 
            this.releaseNoteNumberLabel.ForeColor = System.Drawing.Color.Black;
            this.releaseNoteNumberLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.releaseNoteNumberLabel.Multiline = true;
            this.releaseNoteNumberLabel.Name = "releaseNoteNumberLabel";
            this.releaseNoteNumberLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.releaseNoteNumberLabel.SizeF = new System.Drawing.SizeF(139.0747F, 36F);
            this.releaseNoteNumberLabel.StyleName = "FieldCaption";
            this.releaseNoteNumberLabel.StylePriority.UseForeColor = false;
            this.releaseNoteNumberLabel.Text = "Номер разрешения\r\nна отгрузку";
            // 
            // pipesCountLabel
            // 
            this.pipesCountLabel.BorderColor = System.Drawing.Color.Black;
            this.pipesCountLabel.ForeColor = System.Drawing.Color.Black;
            this.pipesCountLabel.LocationFloat = new DevExpress.Utils.PointFloat(650.25F, 0F);
            this.pipesCountLabel.Name = "pipesCountLabel";
            this.pipesCountLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pipesCountLabel.SizeF = new System.Drawing.SizeF(86.75F, 36F);
            this.pipesCountLabel.StyleName = "FieldCaption";
            this.pipesCountLabel.StylePriority.UseBorderColor = false;
            this.pipesCountLabel.StylePriority.UseForeColor = false;
            this.pipesCountLabel.Text = "Кол-во труб";
            // 
            // pageFooterBand
            // 
            this.pageFooterBand.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1,
            this.xrPageInfo2});
            this.pageFooterBand.HeightF = 23.79168F;
            this.pageFooterBand.Name = "pageFooterBand";
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Format = "{0:dddd, d MMMM, yyyy HH:mm:ss}";
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(251.0661F, 23F);
            this.xrPageInfo1.StyleName = "PageInfo";
            // 
            // xrPageInfo2
            // 
            this.xrPageInfo2.Format = "{0} / {1}";
            this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(547.1332F, 0.7916768F);
            this.xrPageInfo2.Name = "xrPageInfo2";
            this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo2.SizeF = new System.Drawing.SizeF(189.8666F, 23F);
            this.xrPageInfo2.StyleName = "PageInfo";
            this.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // reportHeaderBand1
            // 
            this.reportHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel21,
            this.xrLabel20,
            this.xrLabel19,
            this.xrLabel18,
            this.xrLabel17,
            this.xrLabel16,
            this.pageHeaderLabel,
            this.reportDateTimeInfo,
            this.loadingReportLabel});
            this.reportHeaderBand1.HeightF = 73.95832F;
            this.reportHeaderBand1.Name = "reportHeaderBand1";
            // 
            // xrLabel21
            // 
            this.xrLabel21.ForeColor = System.Drawing.Color.Black;
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(650.25F, 52.45832F);
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(86.74976F, 21.5F);
            this.xrLabel21.StyleName = "Title";
            this.xrLabel21.StylePriority.UseForeColor = false;
            // 
            // xrLabel20
            // 
            this.xrLabel20.ForeColor = System.Drawing.Color.Black;
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(547.1335F, 52.45832F);
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(103.1166F, 21.5F);
            this.xrLabel20.StyleName = "Title";
            this.xrLabel20.StylePriority.UseForeColor = false;
            // 
            // xrLabel19
            // 
            this.xrLabel19.ForeColor = System.Drawing.Color.Black;
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(452.641F, 52.45832F);
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(94.49249F, 21.5F);
            this.xrLabel19.StyleName = "Title";
            this.xrLabel19.StylePriority.UseForeColor = false;
            // 
            // xrLabel18
            // 
            this.xrLabel18.ForeColor = System.Drawing.Color.Black;
            this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(352.641F, 52.45832F);
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel18.SizeF = new System.Drawing.SizeF(100F, 21.5F);
            this.xrLabel18.StyleName = "Title";
            this.xrLabel18.StylePriority.UseForeColor = false;
            // 
            // xrLabel17
            // 
            this.xrLabel17.ForeColor = System.Drawing.Color.Black;
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(251.0661F, 52.45832F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(101.5749F, 21.5F);
            this.xrLabel17.StyleName = "Title";
            this.xrLabel17.StylePriority.UseForeColor = false;
            // 
            // xrLabel16
            // 
            this.xrLabel16.ForeColor = System.Drawing.Color.Black;
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(139.0747F, 52.45832F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(111.9914F, 21.5F);
            this.xrLabel16.StyleName = "Title";
            this.xrLabel16.StylePriority.UseForeColor = false;
            // 
            // pageHeaderLabel
            // 
            this.pageHeaderLabel.ForeColor = System.Drawing.Color.Black;
            this.pageHeaderLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 52.45832F);
            this.pageHeaderLabel.Name = "pageHeaderLabel";
            this.pageHeaderLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pageHeaderLabel.SizeF = new System.Drawing.SizeF(139.0747F, 21.5F);
            this.pageHeaderLabel.StyleName = "Title";
            this.pageHeaderLabel.StylePriority.UseForeColor = false;
            // 
            // reportDateTimeInfo
            // 
            this.reportDateTimeInfo.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.reportDateTimeInfo.Format = "{0:dd-MM-yyyy H:mm:ss}";
            this.reportDateTimeInfo.LocationFloat = new DevExpress.Utils.PointFloat(452.6411F, 0F);
            this.reportDateTimeInfo.Name = "reportDateTimeInfo";
            this.reportDateTimeInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.reportDateTimeInfo.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.reportDateTimeInfo.SizeF = new System.Drawing.SizeF(284.3588F, 19.45833F);
            this.reportDateTimeInfo.StylePriority.UseFont = false;
            this.reportDateTimeInfo.StylePriority.UseTextAlignment = false;
            this.reportDateTimeInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // loadingReportLabel
            // 
            this.loadingReportLabel.ForeColor = System.Drawing.Color.Black;
            this.loadingReportLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 19.45833F);
            this.loadingReportLabel.Name = "loadingReportLabel";
            this.loadingReportLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.loadingReportLabel.SizeF = new System.Drawing.SizeF(736.9999F, 33F);
            this.loadingReportLabel.StyleName = "Title";
            this.loadingReportLabel.StylePriority.UseForeColor = false;
            this.loadingReportLabel.Text = "Рапорт по отгрузке ";
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.BorderColor = System.Drawing.Color.Black;
            this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Title.BorderWidth = 1F;
            this.Title.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.Title.ForeColor = System.Drawing.Color.Maroon;
            this.Title.Name = "Title";
            // 
            // FieldCaption
            // 
            this.FieldCaption.BackColor = System.Drawing.Color.Transparent;
            this.FieldCaption.BorderColor = System.Drawing.Color.Black;
            this.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.FieldCaption.BorderWidth = 1F;
            this.FieldCaption.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.FieldCaption.ForeColor = System.Drawing.Color.Maroon;
            this.FieldCaption.Name = "FieldCaption";
            // 
            // PageInfo
            // 
            this.PageInfo.BackColor = System.Drawing.Color.Transparent;
            this.PageInfo.BorderColor = System.Drawing.Color.Black;
            this.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PageInfo.BorderWidth = 1F;
            this.PageInfo.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.PageInfo.ForeColor = System.Drawing.Color.Black;
            this.PageInfo.Name = "PageInfo";
            // 
            // DataField
            // 
            this.DataField.BackColor = System.Drawing.Color.Transparent;
            this.DataField.BorderColor = System.Drawing.Color.Black;
            this.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DataField.BorderWidth = 1F;
            this.DataField.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.DataField.ForeColor = System.Drawing.Color.Black;
            this.DataField.Name = "DataField";
            this.DataField.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.certificateLabel,
            this.destinationLabel,
            this.railcarNumberLabel,
            this.releaseNoteNumberLabel,
            this.pipesCountLabel,
            this.weightCountLabel,
            this.metersCountLabel});
            this.GroupHeader1.HeightF = 36F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // certificateLabel
            // 
            this.certificateLabel.ForeColor = System.Drawing.Color.Black;
            this.certificateLabel.LocationFloat = new DevExpress.Utils.PointFloat(352.641F, 0F);
            this.certificateLabel.Multiline = true;
            this.certificateLabel.Name = "certificateLabel";
            this.certificateLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.certificateLabel.SizeF = new System.Drawing.SizeF(100F, 36F);
            this.certificateLabel.StyleName = "FieldCaption";
            this.certificateLabel.StylePriority.UseForeColor = false;
            this.certificateLabel.Text = "Сертификат";
            // 
            // destinationLabel
            // 
            this.destinationLabel.ForeColor = System.Drawing.Color.Black;
            this.destinationLabel.LocationFloat = new DevExpress.Utils.PointFloat(251.0661F, 0F);
            this.destinationLabel.Multiline = true;
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.destinationLabel.SizeF = new System.Drawing.SizeF(101.5748F, 36F);
            this.destinationLabel.StyleName = "FieldCaption";
            this.destinationLabel.StylePriority.UseForeColor = false;
            this.destinationLabel.Text = "Станция назначения";
            // 
            // railcarNumberLabel
            // 
            this.railcarNumberLabel.ForeColor = System.Drawing.Color.Black;
            this.railcarNumberLabel.LocationFloat = new DevExpress.Utils.PointFloat(139.0747F, 0F);
            this.railcarNumberLabel.Multiline = true;
            this.railcarNumberLabel.Name = "railcarNumberLabel";
            this.railcarNumberLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.railcarNumberLabel.SizeF = new System.Drawing.SizeF(111.9914F, 36F);
            this.railcarNumberLabel.StyleName = "FieldCaption";
            this.railcarNumberLabel.StylePriority.UseForeColor = false;
            this.railcarNumberLabel.Text = "Номер вагона";
            // 
            // weightCountLabel
            // 
            this.weightCountLabel.BorderColor = System.Drawing.Color.Black;
            this.weightCountLabel.ForeColor = System.Drawing.Color.Black;
            this.weightCountLabel.LocationFloat = new DevExpress.Utils.PointFloat(547.1335F, 0F);
            this.weightCountLabel.Name = "weightCountLabel";
            this.weightCountLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.weightCountLabel.SizeF = new System.Drawing.SizeF(103.1165F, 36F);
            this.weightCountLabel.StyleName = "FieldCaption";
            this.weightCountLabel.StylePriority.UseBorderColor = false;
            this.weightCountLabel.StylePriority.UseForeColor = false;
            this.weightCountLabel.Text = "Вес";
            // 
            // metersCountLabel
            // 
            this.metersCountLabel.BorderColor = System.Drawing.Color.Black;
            this.metersCountLabel.ForeColor = System.Drawing.Color.Black;
            this.metersCountLabel.LocationFloat = new DevExpress.Utils.PointFloat(452.641F, 0F);
            this.metersCountLabel.Name = "metersCountLabel";
            this.metersCountLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.metersCountLabel.SizeF = new System.Drawing.SizeF(94.49249F, 36F);
            this.metersCountLabel.StyleName = "FieldCaption";
            this.metersCountLabel.StylePriority.UseBorderColor = false;
            this.metersCountLabel.StylePriority.UseForeColor = false;
            this.metersCountLabel.Text = "Кол-во метров";
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "PrismDatabase";
            this.sqlDataSource2.Name = "sqlDataSource2";
            customSqlQuery2.Name = "CustomSqlQuery";
            queryParameter1.Name = "param1";
            queryParameter1.Type = typeof(int);
            queryParameter1.ValueInfo = "0";
            customSqlQuery2.Parameters.Add(queryParameter1);
            customSqlQuery2.Sql = resources.GetString("customSqlQuery2.Sql");
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery2});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
            // 
            // LoadingXtraReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.pageFooterBand,
            this.reportHeaderBand1,
            this.GroupHeader1});
            this.ComponentStorage.Add(this.sqlDataSource1);
            this.ComponentStorage.Add(this.sqlDataSource2);
            this.DataMember = "ReleaseNote";
            this.DataSource = this.sqlDataSource2;
            this.Margins = new System.Drawing.Printing.Margins(50, 40, 50, 38);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.FieldCaption,
            this.PageInfo,
            this.DataField});
            this.Version = "14.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.XRLabel pipesCountLabel;
        private DevExpress.XtraReports.UI.XRLabel releaseNoteNumberLabel;
        private DevExpress.XtraReports.UI.PageFooterBand pageFooterBand;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo2;
        private DevExpress.XtraReports.UI.ReportHeaderBand reportHeaderBand1;
        private DevExpress.XtraReports.UI.XRLabel loadingReportLabel;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle FieldCaption;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.UI.XRControlStyle DataField;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRLabel certificateLabel;
        private DevExpress.XtraReports.UI.XRLabel destinationLabel;
        private DevExpress.XtraReports.UI.XRLabel railcarNumberLabel;
        private DevExpress.XtraReports.UI.XRLabel weightCountLabel;
        private DevExpress.XtraReports.UI.XRLabel metersCountLabel;
        private DevExpress.XtraReports.UI.XRLabel xrLabel15;
        private DevExpress.XtraReports.UI.XRLabel xrLabel14;
        private DevExpress.XtraReports.UI.XRLabel xrLabel13;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private DevExpress.XtraReports.UI.XRPageInfo reportDateTimeInfo;
        private DevExpress.XtraReports.UI.XRLabel pageHeaderLabel;
        private DevExpress.XtraReports.UI.XRLabel xrLabel21;
        private DevExpress.XtraReports.UI.XRLabel xrLabel20;
        private DevExpress.XtraReports.UI.XRLabel xrLabel19;
        private DevExpress.XtraReports.UI.XRLabel xrLabel18;
        private DevExpress.XtraReports.UI.XRLabel xrLabel17;
        private DevExpress.XtraReports.UI.XRLabel xrLabel16;
    }
}
