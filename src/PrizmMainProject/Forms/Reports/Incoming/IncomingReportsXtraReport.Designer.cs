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
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
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
            this.pageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.datePageInfo = new DevExpress.XtraReports.UI.XRPageInfo();
            this.numberOfPageInfo = new DevExpress.XtraReports.UI.XRPageInfo();
            this.reportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.reportHeaderLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.FieldCaption = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DataField = new DevExpress.XtraReports.UI.XRControlStyle();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
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
            // 
            // pipeNumber
            // 
            this.pipeNumber.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomSqlQuery.number")});
            this.pipeNumber.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.pipeNumber.Name = "pipeNumber";
            this.pipeNumber.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pipeNumber.SizeF = new System.Drawing.SizeF(202.5148F, 26F);
            this.pipeNumber.StyleName = "DataField";
            this.pipeNumber.Text = "pipeNumber";
            // 
            // wallThickness
            // 
            this.wallThickness.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomSqlQuery.wallThickness")});
            this.wallThickness.LocationFloat = new DevExpress.Utils.PointFloat(508.387F, 9.536743E-06F);
            this.wallThickness.Name = "wallThickness";
            this.wallThickness.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.wallThickness.SizeF = new System.Drawing.SizeF(119.2714F, 26F);
            this.wallThickness.StyleName = "DataField";
            this.wallThickness.Text = "wallThickness";
            // 
            // pipeType
            // 
            this.pipeType.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomSqlQuery.type")});
            this.pipeType.LocationFloat = new DevExpress.Utils.PointFloat(202.5148F, 0F);
            this.pipeType.Name = "pipeType";
            this.pipeType.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pipeType.SizeF = new System.Drawing.SizeF(201.3816F, 26F);
            this.pipeType.StyleName = "DataField";
            this.pipeType.Text = "pipeType";
            // 
            // heatNumber
            // 
            this.heatNumber.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomSqlQuery.Heat_number")});
            this.heatNumber.LocationFloat = new DevExpress.Utils.PointFloat(627.6585F, 0F);
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
            this.length.LocationFloat = new DevExpress.Utils.PointFloat(403.8965F, 9.536743E-06F);
            this.length.Name = "length";
            this.length.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.length.SizeF = new System.Drawing.SizeF(104.4906F, 26F);
            this.length.StyleName = "DataField";
            this.length.Text = "length";
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 51.04167F;
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
            this.pipeWallThicknessLabel.LocationFloat = new DevExpress.Utils.PointFloat(508.387F, 0F);
            this.pipeWallThicknessLabel.Name = "pipeWallThicknessLabel";
            this.pipeWallThicknessLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pipeWallThicknessLabel.SizeF = new System.Drawing.SizeF(119.2715F, 36F);
            this.pipeWallThicknessLabel.StyleName = "FieldCaption";
            this.pipeWallThicknessLabel.StylePriority.UseForeColor = false;
            this.pipeWallThicknessLabel.Text = "Толщина";
            // 
            // pipeTypeLabel
            // 
            this.pipeTypeLabel.ForeColor = System.Drawing.Color.Black;
            this.pipeTypeLabel.LocationFloat = new DevExpress.Utils.PointFloat(202.5148F, 0F);
            this.pipeTypeLabel.Name = "pipeTypeLabel";
            this.pipeTypeLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pipeTypeLabel.SizeF = new System.Drawing.SizeF(201.3816F, 36F);
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
            this.pipeNumberLabel.SizeF = new System.Drawing.SizeF(202.5148F, 36F);
            this.pipeNumberLabel.StyleName = "FieldCaption";
            this.pipeNumberLabel.StylePriority.UseForeColor = false;
            this.pipeNumberLabel.Text = "Заводской номер трубы";
            // 
            // pipeLengthLabel
            // 
            this.pipeLengthLabel.ForeColor = System.Drawing.Color.Black;
            this.pipeLengthLabel.LocationFloat = new DevExpress.Utils.PointFloat(403.8964F, 0F);
            this.pipeLengthLabel.Name = "pipeLengthLabel";
            this.pipeLengthLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pipeLengthLabel.SizeF = new System.Drawing.SizeF(104.4906F, 36F);
            this.pipeLengthLabel.StyleName = "FieldCaption";
            this.pipeLengthLabel.StylePriority.UseForeColor = false;
            this.pipeLengthLabel.Text = "Длина";
            // 
            // heatNumberLabel
            // 
            this.heatNumberLabel.ForeColor = System.Drawing.Color.Black;
            this.heatNumberLabel.LocationFloat = new DevExpress.Utils.PointFloat(627.6585F, 0F);
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
            this.pipeNumberLabel,
            this.pipeTypeLabel,
            this.heatNumberLabel,
            this.pipeWallThicknessLabel,
            this.pipeLengthLabel});
            this.groupHeader.HeightF = 36F;
            this.groupHeader.Name = "groupHeader";
            this.groupHeader.StyleName = "FieldCaption";
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
            this.datePageInfo.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.datePageInfo.Name = "datePageInfo";
            this.datePageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.datePageInfo.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.datePageInfo.SizeF = new System.Drawing.SizeF(202.5148F, 23F);
            this.datePageInfo.StyleName = "PageInfo";
            // 
            // numberOfPageInfo
            // 
            this.numberOfPageInfo.Format = "Page {0} of {1}";
            this.numberOfPageInfo.LocationFloat = new DevExpress.Utils.PointFloat(627.6585F, 0F);
            this.numberOfPageInfo.Name = "numberOfPageInfo";
            this.numberOfPageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.numberOfPageInfo.SizeF = new System.Drawing.SizeF(120.3415F, 23F);
            this.numberOfPageInfo.StyleName = "PageInfo";
            this.numberOfPageInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // reportHeader
            // 
            this.reportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.reportHeaderLabel});
            this.reportHeader.HeightF = 33F;
            this.reportHeader.Name = "reportHeader";
            // 
            // reportHeaderLabel
            // 
            this.reportHeaderLabel.ForeColor = System.Drawing.Color.Black;
            this.reportHeaderLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.reportHeaderLabel.Name = "reportHeaderLabel";
            this.reportHeaderLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.reportHeaderLabel.SizeF = new System.Drawing.SizeF(748F, 33F);
            this.reportHeaderLabel.StyleName = "Title";
            this.reportHeaderLabel.StylePriority.UseForeColor = false;
            this.reportHeaderLabel.Text = "IncomingInspection";
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
            // IncomingReportsXtraReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.groupHeader,
            this.pageFooter,
            this.reportHeader});
            this.DataMember = "Pipe";
            this.DataSource = this.sqlDataSourceForReport;
            this.Margins = new System.Drawing.Printing.Margins(66, 36, 51, 62);
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
    }
}
