namespace Prizm.Main.Forms.Reports.Construction.PipeReport
{
    partial class PipeConstructionXtraReport
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
            this.components = new System.ComponentModel.Container();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.secondJoint = new DevExpress.XtraReports.UI.XRLabel();
            this.firstJoint = new DevExpress.XtraReports.UI.XRLabel();
            this.grade = new DevExpress.XtraReports.UI.XRLabel();
            this.thickness = new DevExpress.XtraReports.UI.XRLabel();
            this.length = new DevExpress.XtraReports.UI.XRLabel();
            this.diameter = new DevExpress.XtraReports.UI.XRLabel();
            this.pipeNumber = new DevExpress.XtraReports.UI.XRLabel();
            this.seamType = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.reportDateTimeInfo = new DevExpress.XtraReports.UI.XRPageInfo();
            this.pipeConstructionReportHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.secondJointHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.firstJointHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.gradeHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.seamTypeHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.thicknessHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.lengthHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.diameterHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.pipeNumberHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.numberPageInfo = new DevExpress.XtraReports.UI.XRPageInfo();
            this.dateTimePageInfo = new DevExpress.XtraReports.UI.XRPageInfo();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.secondJoint,
            this.firstJoint,
            this.grade,
            this.thickness,
            this.length,
            this.diameter,
            this.pipeNumber,
            this.seamType});
            this.Detail.HeightF = 23F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("PipeNumber", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // secondJoint
            // 
            this.secondJoint.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SecondJointNumber")});
            this.secondJoint.LocationFloat = new DevExpress.Utils.PointFloat(589.5831F, 0F);
            this.secondJoint.Name = "secondJoint";
            this.secondJoint.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.secondJoint.SizeF = new System.Drawing.SizeF(60.41669F, 23F);
            // 
            // firstJoint
            // 
            this.firstJoint.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "FirstJointNumber")});
            this.firstJoint.LocationFloat = new DevExpress.Utils.PointFloat(505.0596F, 0F);
            this.firstJoint.Name = "firstJoint";
            this.firstJoint.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.firstJoint.SizeF = new System.Drawing.SizeF(84.52368F, 23F);
            // 
            // grade
            // 
            this.grade.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "GradeType")});
            this.grade.LocationFloat = new DevExpress.Utils.PointFloat(420.5358F, 0F);
            this.grade.Name = "grade";
            this.grade.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.grade.SizeF = new System.Drawing.SizeF(84.52383F, 23F);
            // 
            // thickness
            // 
            this.thickness.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Thickness")});
            this.thickness.LocationFloat = new DevExpress.Utils.PointFloat(251.4882F, 0F);
            this.thickness.Name = "thickness";
            this.thickness.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.thickness.SizeF = new System.Drawing.SizeF(84.52379F, 23F);
            // 
            // length
            // 
            this.length.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Length")});
            this.length.LocationFloat = new DevExpress.Utils.PointFloat(166.9644F, 0F);
            this.length.Name = "length";
            this.length.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.length.SizeF = new System.Drawing.SizeF(84.5238F, 23F);
            // 
            // diameter
            // 
            this.diameter.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Diameter")});
            this.diameter.LocationFloat = new DevExpress.Utils.PointFloat(82.44057F, 0F);
            this.diameter.Name = "diameter";
            this.diameter.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.diameter.SizeF = new System.Drawing.SizeF(84.5238F, 23F);
            // 
            // pipeNumber
            // 
            this.pipeNumber.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "PipeNumber")});
            this.pipeNumber.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.pipeNumber.Name = "pipeNumber";
            this.pipeNumber.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pipeNumber.SizeF = new System.Drawing.SizeF(82.44055F, 23F);
            // 
            // seamType
            // 
            this.seamType.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SeamType")});
            this.seamType.LocationFloat = new DevExpress.Utils.PointFloat(336.012F, 0F);
            this.seamType.Name = "seamType";
            this.seamType.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.seamType.SizeF = new System.Drawing.SizeF(84.52377F, 23F);
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.reportDateTimeInfo,
            this.pipeConstructionReportHeader});
            this.TopMargin.HeightF = 90.00002F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // reportDateTimeInfo
            // 
            this.reportDateTimeInfo.Format = "{0:dd-MM-yyyy H:mm:ss}";
            this.reportDateTimeInfo.LocationFloat = new DevExpress.Utils.PointFloat(505.0596F, 48.25001F);
            this.reportDateTimeInfo.Name = "reportDateTimeInfo";
            this.reportDateTimeInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.reportDateTimeInfo.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.reportDateTimeInfo.SizeF = new System.Drawing.SizeF(144.9402F, 41.75002F);
            this.reportDateTimeInfo.StylePriority.UseTextAlignment = false;
            this.reportDateTimeInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            // 
            // pipeConstructionReportHeader
            // 
            this.pipeConstructionReportHeader.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.pipeConstructionReportHeader.LocationFloat = new DevExpress.Utils.PointFloat(0F, 48.25001F);
            this.pipeConstructionReportHeader.Name = "pipeConstructionReportHeader";
            this.pipeConstructionReportHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pipeConstructionReportHeader.SizeF = new System.Drawing.SizeF(505.0596F, 41.75F);
            this.pipeConstructionReportHeader.StylePriority.UseFont = false;
            this.pipeConstructionReportHeader.StylePriority.UseTextAlignment = false;
            this.pipeConstructionReportHeader.Text = "Отчет по трубам на строительстве";
            this.pipeConstructionReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 38.54167F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.secondJointHeader,
            this.firstJointHeader,
            this.gradeHeader,
            this.seamTypeHeader,
            this.thicknessHeader,
            this.lengthHeader,
            this.diameterHeader,
            this.pipeNumberHeader});
            this.ReportHeader.HeightF = 38.37497F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // secondJointHeader
            // 
            this.secondJointHeader.LocationFloat = new DevExpress.Utils.PointFloat(589.5833F, 0F);
            this.secondJointHeader.Name = "secondJointHeader";
            this.secondJointHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.secondJointHeader.SizeF = new System.Drawing.SizeF(60.41667F, 38.37497F);
            this.secondJointHeader.Text = "Второй стык";
            // 
            // firstJointHeader
            // 
            this.firstJointHeader.LocationFloat = new DevExpress.Utils.PointFloat(505.0596F, 0F);
            this.firstJointHeader.Name = "firstJointHeader";
            this.firstJointHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.firstJointHeader.SizeF = new System.Drawing.SizeF(84.52368F, 38.37497F);
            this.firstJointHeader.Text = "Первый стык";
            // 
            // gradeHeader
            // 
            this.gradeHeader.LocationFloat = new DevExpress.Utils.PointFloat(420.5358F, 0F);
            this.gradeHeader.Name = "gradeHeader";
            this.gradeHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.gradeHeader.SizeF = new System.Drawing.SizeF(84.5238F, 38.37497F);
            this.gradeHeader.Text = "Марка стали";
            // 
            // seamTypeHeader
            // 
            this.seamTypeHeader.LocationFloat = new DevExpress.Utils.PointFloat(336.012F, 0F);
            this.seamTypeHeader.Name = "seamTypeHeader";
            this.seamTypeHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.seamTypeHeader.SizeF = new System.Drawing.SizeF(84.5238F, 38.37497F);
            this.seamTypeHeader.Text = "Тип шва";
            // 
            // thicknessHeader
            // 
            this.thicknessHeader.LocationFloat = new DevExpress.Utils.PointFloat(251.4882F, 0F);
            this.thicknessHeader.Name = "thicknessHeader";
            this.thicknessHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.thicknessHeader.SizeF = new System.Drawing.SizeF(84.52379F, 38.37497F);
            this.thicknessHeader.Text = "Толщина, мм";
            // 
            // lengthHeader
            // 
            this.lengthHeader.LocationFloat = new DevExpress.Utils.PointFloat(166.9644F, 0F);
            this.lengthHeader.Name = "lengthHeader";
            this.lengthHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lengthHeader.SizeF = new System.Drawing.SizeF(84.5238F, 38.37497F);
            this.lengthHeader.Text = "Длина, мм";
            // 
            // diameterHeader
            // 
            this.diameterHeader.LocationFloat = new DevExpress.Utils.PointFloat(82.44057F, 0F);
            this.diameterHeader.Name = "diameterHeader";
            this.diameterHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.diameterHeader.SizeF = new System.Drawing.SizeF(84.52382F, 38.37497F);
            this.diameterHeader.Text = "Диаметр, мм";
            // 
            // pipeNumberHeader
            // 
            this.pipeNumberHeader.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.pipeNumberHeader.Name = "pipeNumberHeader";
            this.pipeNumberHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pipeNumberHeader.SizeF = new System.Drawing.SizeF(82.44056F, 38.37497F);
            this.pipeNumberHeader.Text = "Номер трубы";
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(Prizm.Main.Forms.Reports.Construction.PipeReport.PipeReportData);
            // 
            // pageFooter
            // 
            this.pageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.numberPageInfo,
            this.dateTimePageInfo});
            this.pageFooter.HeightF = 26.04167F;
            this.pageFooter.Name = "pageFooter";
            // 
            // numberPageInfo
            // 
            this.numberPageInfo.Format = "Page {0} of {1}";
            this.numberPageInfo.LocationFloat = new DevExpress.Utils.PointFloat(336.012F, 0F);
            this.numberPageInfo.Name = "numberPageInfo";
            this.numberPageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.numberPageInfo.SizeF = new System.Drawing.SizeF(313.988F, 23F);
            this.numberPageInfo.StylePriority.UseTextAlignment = false;
            this.numberPageInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // dateTimePageInfo
            // 
            this.dateTimePageInfo.Format = "{0:dddd, d MMMM, yyyy HH:mm:ss}";
            this.dateTimePageInfo.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.dateTimePageInfo.Name = "dateTimePageInfo";
            this.dateTimePageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.dateTimePageInfo.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.dateTimePageInfo.SizeF = new System.Drawing.SizeF(336.012F, 23F);
            // 
            // PipeConstructionXtraReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.pageFooter});
            this.DataSource = this.bindingSource;
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 90, 39);
            this.Version = "14.2";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel pipeNumberHeader;
        private DevExpress.XtraReports.UI.XRLabel thickness;
        private DevExpress.XtraReports.UI.XRLabel length;
        private DevExpress.XtraReports.UI.XRLabel diameter;
        private DevExpress.XtraReports.UI.XRLabel pipeNumber;
        private DevExpress.XtraReports.UI.XRLabel thicknessHeader;
        private DevExpress.XtraReports.UI.XRLabel lengthHeader;
        private DevExpress.XtraReports.UI.XRLabel diameterHeader;
        private System.Windows.Forms.BindingSource bindingSource;
        private DevExpress.XtraReports.UI.XRLabel secondJoint;
        private DevExpress.XtraReports.UI.XRLabel firstJoint;
        private DevExpress.XtraReports.UI.XRLabel grade;
        private DevExpress.XtraReports.UI.XRLabel seamType;
        private DevExpress.XtraReports.UI.XRLabel secondJointHeader;
        private DevExpress.XtraReports.UI.XRLabel firstJointHeader;
        private DevExpress.XtraReports.UI.XRLabel gradeHeader;
        private DevExpress.XtraReports.UI.XRLabel seamTypeHeader;
        private DevExpress.XtraReports.UI.XRLabel pipeConstructionReportHeader;
        private DevExpress.XtraReports.UI.PageFooterBand pageFooter;
        private DevExpress.XtraReports.UI.XRPageInfo numberPageInfo;
        private DevExpress.XtraReports.UI.XRPageInfo dateTimePageInfo;
        private DevExpress.XtraReports.UI.XRPageInfo reportDateTimeInfo;
    }
}
