namespace Prizm.Main.Forms.Reports.Incoming
{
    partial class IncomingReportsXtraReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncomingReportsXtraReport));
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.inspectionStatus = new DevExpress.XtraReports.UI.XRLabel();
            this.pipeNumber = new DevExpress.XtraReports.UI.XRLabel();
            this.wallThickness = new DevExpress.XtraReports.UI.XRLabel();
            this.pipeType = new DevExpress.XtraReports.UI.XRLabel();
            this.heatNumber = new DevExpress.XtraReports.UI.XRLabel();
            this.length = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.sqlDataSourceForReport = new DevExpress.DataAccess.Sql.SqlDataSource();
            this.pipeWallThicknessLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.pipeTypeLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.pipeNumberLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.pipeLengthLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.heatNumberLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.groupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.inspectionStatusLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.pageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.datePageInfo = new DevExpress.XtraReports.UI.XRPageInfo();
            this.numberOfPageInfo = new DevExpress.XtraReports.UI.XRPageInfo();
            this.reportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.pageHeaderLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.reportHeaderLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.reportDateTimeInfo = new DevExpress.XtraReports.UI.XRPageInfo();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.FieldCaption = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DataField = new DevExpress.XtraReports.UI.XRControlStyle();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.inspectionStatus,
            this.pipeNumber,
            this.wallThickness,
            this.pipeType,
            this.heatNumber,
            this.length});
            this.Detail.HeightF = 26.00001F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.StyleName = "DataField";
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // inspectionStatus
            // 
            this.inspectionStatus.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomSqlQuery.status")});
            this.inspectionStatus.LocationFloat = new DevExpress.Utils.PointFloat(655.2914F, 0F);
            this.inspectionStatus.Multiline = true;
            this.inspectionStatus.Name = "inspectionStatus";
            this.inspectionStatus.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.inspectionStatus.SizeF = new System.Drawing.SizeF(92.70825F, 26.00001F);
            this.inspectionStatus.Text = "inspectionStatus";
            // 
            // pipeNumber
            // 
            this.pipeNumber.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomSqlQuery.number")});
            this.pipeNumber.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.pipeNumber.Multiline = true;
            this.pipeNumber.Name = "pipeNumber";
            this.pipeNumber.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pipeNumber.SizeF = new System.Drawing.SizeF(176.4731F, 26F);
            this.pipeNumber.StyleName = "DataField";
            this.pipeNumber.Text = "pipeNumber";
            // 
            // wallThickness
            // 
            this.wallThickness.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomSqlQuery.wallThickness")});
            this.wallThickness.LocationFloat = new DevExpress.Utils.PointFloat(437.5537F, 0F);
            this.wallThickness.Multiline = true;
            this.wallThickness.Name = "wallThickness";
            this.wallThickness.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.wallThickness.SizeF = new System.Drawing.SizeF(97.39648F, 26F);
            this.wallThickness.StyleName = "DataField";
            this.wallThickness.Text = "wallThickness";
            // 
            // pipeType
            // 
            this.pipeType.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomSqlQuery.type")});
            this.pipeType.LocationFloat = new DevExpress.Utils.PointFloat(176.4732F, 0F);
            this.pipeType.Multiline = true;
            this.pipeType.Name = "pipeType";
            this.pipeType.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pipeType.SizeF = new System.Drawing.SizeF(167.0066F, 26F);
            this.pipeType.StyleName = "DataField";
            this.pipeType.Text = "pipeType";
            // 
            // heatNumber
            // 
            this.heatNumber.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomSqlQuery.Heat_number")});
            this.heatNumber.LocationFloat = new DevExpress.Utils.PointFloat(534.9502F, 0F);
            this.heatNumber.Multiline = true;
            this.heatNumber.Name = "heatNumber";
            this.heatNumber.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.heatNumber.SizeF = new System.Drawing.SizeF(120.3413F, 26.00001F);
            this.heatNumber.StyleName = "DataField";
            this.heatNumber.Text = "heatNumber";
            // 
            // length
            // 
            this.length.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomSqlQuery.length")});
            this.length.LocationFloat = new DevExpress.Utils.PointFloat(343.4798F, 0F);
            this.length.Multiline = true;
            this.length.Name = "length";
            this.length.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.length.SizeF = new System.Drawing.SizeF(94.07391F, 26F);
            this.length.StyleName = "DataField";
            this.length.Text = "length";
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 51F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 62F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // sqlDataSourceForReport
            // 
            this.sqlDataSourceForReport.ConnectionName = "PrismDatabase";
            this.sqlDataSourceForReport.Name = "sqlDataSourceForReport";
            customSqlQuery1.Name = "CustomSqlQuery";
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            this.sqlDataSourceForReport.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSourceForReport.ResultSchemaSerializable = resources.GetString("sqlDataSourceForReport.ResultSchemaSerializable");
            // 
            // pipeWallThicknessLabel
            // 
            this.pipeWallThicknessLabel.ForeColor = System.Drawing.Color.Black;
            this.pipeWallThicknessLabel.LocationFloat = new DevExpress.Utils.PointFloat(437.5537F, 0F);
            this.pipeWallThicknessLabel.Name = "pipeWallThicknessLabel";
            this.pipeWallThicknessLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pipeWallThicknessLabel.SizeF = new System.Drawing.SizeF(97.39648F, 36F);
            this.pipeWallThicknessLabel.StyleName = "FieldCaption";
            this.pipeWallThicknessLabel.StylePriority.UseForeColor = false;
            this.pipeWallThicknessLabel.Text = "Толщина";
            // 
            // pipeTypeLabel
            // 
            this.pipeTypeLabel.ForeColor = System.Drawing.Color.Black;
            this.pipeTypeLabel.LocationFloat = new DevExpress.Utils.PointFloat(176.4732F, 0F);
            this.pipeTypeLabel.Name = "pipeTypeLabel";
            this.pipeTypeLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pipeTypeLabel.SizeF = new System.Drawing.SizeF(167.0066F, 36F);
            this.pipeTypeLabel.StyleName = "FieldCaption";
            this.pipeTypeLabel.StylePriority.UseForeColor = false;
            this.pipeTypeLabel.Text = "Тип трубы";
            // 
            // pipeNumberLabel
            // 
            this.pipeNumberLabel.ForeColor = System.Drawing.Color.Black;
            this.pipeNumberLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.pipeNumberLabel.Name = "pipeNumberLabel";
            this.pipeNumberLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pipeNumberLabel.SizeF = new System.Drawing.SizeF(176.4731F, 36F);
            this.pipeNumberLabel.StyleName = "FieldCaption";
            this.pipeNumberLabel.StylePriority.UseForeColor = false;
            this.pipeNumberLabel.Text = "Заводской номер трубы";
            // 
            // pipeLengthLabel
            // 
            this.pipeLengthLabel.ForeColor = System.Drawing.Color.Black;
            this.pipeLengthLabel.LocationFloat = new DevExpress.Utils.PointFloat(343.4798F, 0F);
            this.pipeLengthLabel.Name = "pipeLengthLabel";
            this.pipeLengthLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pipeLengthLabel.SizeF = new System.Drawing.SizeF(94.07391F, 36F);
            this.pipeLengthLabel.StyleName = "FieldCaption";
            this.pipeLengthLabel.StylePriority.UseForeColor = false;
            this.pipeLengthLabel.Text = "Длина";
            // 
            // heatNumberLabel
            // 
            this.heatNumberLabel.ForeColor = System.Drawing.Color.Black;
            this.heatNumberLabel.LocationFloat = new DevExpress.Utils.PointFloat(534.9502F, 0F);
            this.heatNumberLabel.Name = "heatNumberLabel";
            this.heatNumberLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.heatNumberLabel.SizeF = new System.Drawing.SizeF(120.3414F, 36F);
            this.heatNumberLabel.StyleName = "FieldCaption";
            this.heatNumberLabel.StylePriority.UseForeColor = false;
            this.heatNumberLabel.Text = "Номер плавки";
            // 
            // groupHeader
            // 
            this.groupHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.inspectionStatusLabel,
            this.pipeNumberLabel,
            this.pipeTypeLabel,
            this.heatNumberLabel,
            this.pipeWallThicknessLabel,
            this.pipeLengthLabel});
            this.groupHeader.HeightF = 36F;
            this.groupHeader.Name = "groupHeader";
            this.groupHeader.StyleName = "FieldCaption";
            // 
            // inspectionStatusLabel
            // 
            this.inspectionStatusLabel.ForeColor = System.Drawing.Color.Black;
            this.inspectionStatusLabel.LocationFloat = new DevExpress.Utils.PointFloat(655.2916F, 0F);
            this.inspectionStatusLabel.Name = "inspectionStatusLabel";
            this.inspectionStatusLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.inspectionStatusLabel.SizeF = new System.Drawing.SizeF(92.70813F, 36F);
            this.inspectionStatusLabel.StyleName = "FieldCaption";
            this.inspectionStatusLabel.StylePriority.UseForeColor = false;
            this.inspectionStatusLabel.Text = "Результат";
            // 
            // pageFooter
            // 
            this.pageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.datePageInfo,
            this.numberOfPageInfo});
            this.pageFooter.HeightF = 23F;
            this.pageFooter.Name = "pageFooter";
            // 
            // datePageInfo
            // 
            this.datePageInfo.Format = "{0:dddd, d MMMM, yyyy HH:mm:ss}";
            this.datePageInfo.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.datePageInfo.Name = "datePageInfo";
            this.datePageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.datePageInfo.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.datePageInfo.SizeF = new System.Drawing.SizeF(437.5537F, 23F);
            this.datePageInfo.StyleName = "PageInfo";
            // 
            // numberOfPageInfo
            // 
            this.numberOfPageInfo.Format = "{0} / {1}";
            this.numberOfPageInfo.LocationFloat = new DevExpress.Utils.PointFloat(437.5537F, 0F);
            this.numberOfPageInfo.Name = "numberOfPageInfo";
            this.numberOfPageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.numberOfPageInfo.SizeF = new System.Drawing.SizeF(310.4463F, 23F);
            this.numberOfPageInfo.StyleName = "PageInfo";
            this.numberOfPageInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // reportHeader
            // 
            this.reportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel1,
            this.pageHeaderLabel,
            this.reportHeaderLabel,
            this.reportDateTimeInfo});
            this.reportHeader.HeightF = 71.87502F;
            this.reportHeader.Name = "reportHeader";
            // 
            // xrLabel5
            // 
            this.xrLabel5.ForeColor = System.Drawing.Color.Black;
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(655.2914F, 50.37502F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(92.70819F, 21.5F);
            this.xrLabel5.StyleName = "Title";
            this.xrLabel5.StylePriority.UseForeColor = false;
            // 
            // xrLabel4
            // 
            this.xrLabel4.ForeColor = System.Drawing.Color.Black;
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(534.9503F, 50.37498F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(120.3412F, 21.5F);
            this.xrLabel4.StyleName = "Title";
            this.xrLabel4.StylePriority.UseForeColor = false;
            // 
            // xrLabel3
            // 
            this.xrLabel3.ForeColor = System.Drawing.Color.Black;
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(437.5537F, 50.37498F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(97.39655F, 21.5F);
            this.xrLabel3.StyleName = "Title";
            this.xrLabel3.StylePriority.UseForeColor = false;
            // 
            // xrLabel2
            // 
            this.xrLabel2.ForeColor = System.Drawing.Color.Black;
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(343.4798F, 50.37498F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(94.07388F, 21.5F);
            this.xrLabel2.StyleName = "Title";
            this.xrLabel2.StylePriority.UseForeColor = false;
            // 
            // xrLabel1
            // 
            this.xrLabel1.ForeColor = System.Drawing.Color.Black;
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(176.4732F, 50.37498F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(167.0066F, 21.5F);
            this.xrLabel1.StyleName = "Title";
            this.xrLabel1.StylePriority.UseForeColor = false;
            // 
            // pageHeaderLabel
            // 
            this.pageHeaderLabel.ForeColor = System.Drawing.Color.Black;
            this.pageHeaderLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 50.37502F);
            this.pageHeaderLabel.Name = "pageHeaderLabel";
            this.pageHeaderLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pageHeaderLabel.SizeF = new System.Drawing.SizeF(176.4731F, 21.5F);
            this.pageHeaderLabel.StyleName = "Title";
            this.pageHeaderLabel.StylePriority.UseForeColor = false;
            // 
            // reportHeaderLabel
            // 
            this.reportHeaderLabel.ForeColor = System.Drawing.Color.Black;
            this.reportHeaderLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 17.37499F);
            this.reportHeaderLabel.Name = "reportHeaderLabel";
            this.reportHeaderLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.reportHeaderLabel.SizeF = new System.Drawing.SizeF(747.9996F, 33F);
            this.reportHeaderLabel.StyleName = "Title";
            this.reportHeaderLabel.StylePriority.UseForeColor = false;
            this.reportHeaderLabel.Text = "Отчет по входному контролю";
            // 
            // reportDateTimeInfo
            // 
            this.reportDateTimeInfo.Format = "Сформирован: {0:dd-MM-yyyy H:mm:ss}";
            this.reportDateTimeInfo.LocationFloat = new DevExpress.Utils.PointFloat(437.5537F, 0F);
            this.reportDateTimeInfo.Name = "reportDateTimeInfo";
            this.reportDateTimeInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.reportDateTimeInfo.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.reportDateTimeInfo.SizeF = new System.Drawing.SizeF(310.446F, 17.375F);
            this.reportDateTimeInfo.StylePriority.UseTextAlignment = false;
            this.reportDateTimeInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
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
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "PrismDatabase";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery2.Name = "CustomSqlQuery";
            customSqlQuery2.Sql = resources.GetString("customSqlQuery2.Sql");
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // IncomingReportsXtraReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.groupHeader,
            this.pageFooter,
            this.reportHeader});
            this.ComponentStorage.Add(this.sqlDataSource1);
            this.DataMember = "Pipe";
            this.DataSource = this.sqlDataSource1;
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.Margins = new System.Drawing.Printing.Margins(42, 36, 51, 62);
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
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSourceForReport;
        private DevExpress.XtraReports.UI.XRLabel wallThickness;
        private DevExpress.XtraReports.UI.XRLabel pipeType;
        private DevExpress.XtraReports.UI.XRLabel pipeNumber;
        private DevExpress.XtraReports.UI.XRLabel length;
        private DevExpress.XtraReports.UI.XRLabel heatNumber;
        private DevExpress.XtraReports.UI.XRLabel pipeWallThicknessLabel;
        private DevExpress.XtraReports.UI.XRLabel pipeTypeLabel;
        private DevExpress.XtraReports.UI.XRLabel pipeNumberLabel;
        private DevExpress.XtraReports.UI.XRLabel pipeLengthLabel;
        private DevExpress.XtraReports.UI.XRLabel heatNumberLabel;
        private DevExpress.XtraReports.UI.GroupHeaderBand groupHeader;
        private DevExpress.XtraReports.UI.PageFooterBand pageFooter;
        private DevExpress.XtraReports.UI.XRPageInfo datePageInfo;
        private DevExpress.XtraReports.UI.XRPageInfo numberOfPageInfo;
        private DevExpress.XtraReports.UI.ReportHeaderBand reportHeader;
        private DevExpress.XtraReports.UI.XRLabel reportHeaderLabel;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle FieldCaption;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.UI.XRControlStyle DataField;
        private DevExpress.XtraReports.UI.XRPageInfo reportDateTimeInfo;
        private DevExpress.XtraReports.UI.XRLabel inspectionStatus;
        private DevExpress.XtraReports.UI.XRLabel inspectionStatusLabel;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel pageHeaderLabel;
    }
}
