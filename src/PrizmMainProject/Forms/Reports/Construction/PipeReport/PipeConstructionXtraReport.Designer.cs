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
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.pageHeaderLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.secondJointHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.firstJointHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.gradeHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.seamTypeHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.thicknessHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.lengthHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.diameterHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.pipeNumberHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.pageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.numberPageInfo = new DevExpress.XtraReports.UI.XRPageInfo();
            this.dateTimePageInfo = new DevExpress.XtraReports.UI.XRPageInfo();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.Detail.HeightF = 37F;
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
            this.secondJoint.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.secondJoint.LocationFloat = new DevExpress.Utils.PointFloat(760F, 0F);
            this.secondJoint.Name = "secondJoint";
            this.secondJoint.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.secondJoint.SizeF = new System.Drawing.SizeF(140F, 37F);
            this.secondJoint.StylePriority.UseFont = false;
            // 
            // firstJoint
            // 
            this.firstJoint.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "FirstJointNumber")});
            this.firstJoint.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.firstJoint.LocationFloat = new DevExpress.Utils.PointFloat(620F, 0F);
            this.firstJoint.Name = "firstJoint";
            this.firstJoint.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.firstJoint.SizeF = new System.Drawing.SizeF(140F, 37F);
            this.firstJoint.StylePriority.UseFont = false;
            // 
            // grade
            // 
            this.grade.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "GradeType")});
            this.grade.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.grade.LocationFloat = new DevExpress.Utils.PointFloat(522.5F, 0F);
            this.grade.Name = "grade";
            this.grade.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.grade.SizeF = new System.Drawing.SizeF(97.49994F, 37F);
            this.grade.StylePriority.UseFont = false;
            // 
            // thickness
            // 
            this.thickness.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Thickness")});
            this.thickness.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.thickness.LocationFloat = new DevExpress.Utils.PointFloat(320F, 0F);
            this.thickness.Name = "thickness";
            this.thickness.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.thickness.SizeF = new System.Drawing.SizeF(90F, 37F);
            this.thickness.StylePriority.UseFont = false;
            // 
            // length
            // 
            this.length.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Length")});
            this.length.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.length.LocationFloat = new DevExpress.Utils.PointFloat(230F, 0F);
            this.length.Name = "length";
            this.length.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.length.SizeF = new System.Drawing.SizeF(90F, 37F);
            this.length.StylePriority.UseFont = false;
            // 
            // diameter
            // 
            this.diameter.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Diameter")});
            this.diameter.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.diameter.LocationFloat = new DevExpress.Utils.PointFloat(140F, 0F);
            this.diameter.Name = "diameter";
            this.diameter.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.diameter.SizeF = new System.Drawing.SizeF(90F, 37F);
            this.diameter.StylePriority.UseFont = false;
            // 
            // pipeNumber
            // 
            this.pipeNumber.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "PipeNumber")});
            this.pipeNumber.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.pipeNumber.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.pipeNumber.Name = "pipeNumber";
            this.pipeNumber.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pipeNumber.SizeF = new System.Drawing.SizeF(140F, 37F);
            this.pipeNumber.StylePriority.UseFont = false;
            // 
            // seamType
            // 
            this.seamType.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SeamType")});
            this.seamType.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.seamType.LocationFloat = new DevExpress.Utils.PointFloat(410F, 0F);
            this.seamType.Name = "seamType";
            this.seamType.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.seamType.SizeF = new System.Drawing.SizeF(112.5F, 37F);
            this.seamType.StylePriority.UseFont = false;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 48.33336F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // reportDateTimeInfo
            // 
            this.reportDateTimeInfo.Format = "Сформирован: {0:dd-MM-yyyy H:mm:ss}";
            this.reportDateTimeInfo.LocationFloat = new DevExpress.Utils.PointFloat(620F, 0F);
            this.reportDateTimeInfo.Name = "reportDateTimeInfo";
            this.reportDateTimeInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.reportDateTimeInfo.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.reportDateTimeInfo.SizeF = new System.Drawing.SizeF(280F, 18.83335F);
            this.reportDateTimeInfo.StylePriority.UseTextAlignment = false;
            this.reportDateTimeInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // pipeConstructionReportHeader
            // 
            this.pipeConstructionReportHeader.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.pipeConstructionReportHeader.LocationFloat = new DevExpress.Utils.PointFloat(0F, 18.83335F);
            this.pipeConstructionReportHeader.Name = "pipeConstructionReportHeader";
            this.pipeConstructionReportHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pipeConstructionReportHeader.SizeF = new System.Drawing.SizeF(900F, 41.75F);
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
            this.xrLabel7,
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel1,
            this.pageHeaderLabel,
            this.reportDateTimeInfo,
            this.pipeConstructionReportHeader});
            this.ReportHeader.HeightF = 82.08337F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrLabel7
            // 
            this.xrLabel7.ForeColor = System.Drawing.Color.Black;
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(760F, 60.58337F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(140F, 21.5F);
            this.xrLabel7.StylePriority.UseForeColor = false;
            // 
            // xrLabel6
            // 
            this.xrLabel6.ForeColor = System.Drawing.Color.Black;
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(620F, 60.58337F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(140F, 21.5F);
            this.xrLabel6.StylePriority.UseForeColor = false;
            // 
            // xrLabel5
            // 
            this.xrLabel5.ForeColor = System.Drawing.Color.Black;
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(522.5F, 60.58337F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(97.5F, 21.5F);
            this.xrLabel5.StylePriority.UseForeColor = false;
            // 
            // xrLabel4
            // 
            this.xrLabel4.ForeColor = System.Drawing.Color.Black;
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(410F, 60.58337F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(112.5F, 21.5F);
            this.xrLabel4.StylePriority.UseForeColor = false;
            // 
            // xrLabel3
            // 
            this.xrLabel3.ForeColor = System.Drawing.Color.Black;
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(320F, 60.58334F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(90.00003F, 21.5F);
            this.xrLabel3.StylePriority.UseForeColor = false;
            // 
            // xrLabel2
            // 
            this.xrLabel2.ForeColor = System.Drawing.Color.Black;
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(230F, 60.58337F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(90.00002F, 21.5F);
            this.xrLabel2.StylePriority.UseForeColor = false;
            // 
            // xrLabel1
            // 
            this.xrLabel1.ForeColor = System.Drawing.Color.Black;
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(140F, 60.58337F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(89.99997F, 21.5F);
            this.xrLabel1.StylePriority.UseForeColor = false;
            // 
            // pageHeaderLabel
            // 
            this.pageHeaderLabel.ForeColor = System.Drawing.Color.Black;
            this.pageHeaderLabel.LocationFloat = new DevExpress.Utils.PointFloat(6.357829E-05F, 60.58337F);
            this.pageHeaderLabel.Name = "pageHeaderLabel";
            this.pageHeaderLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pageHeaderLabel.SizeF = new System.Drawing.SizeF(140F, 21.5F);
            this.pageHeaderLabel.StylePriority.UseForeColor = false;
            // 
            // secondJointHeader
            // 
            this.secondJointHeader.LocationFloat = new DevExpress.Utils.PointFloat(760F, 0F);
            this.secondJointHeader.Name = "secondJointHeader";
            this.secondJointHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.secondJointHeader.SizeF = new System.Drawing.SizeF(140F, 38.37497F);
            this.secondJointHeader.Text = "Второй стык";
            // 
            // firstJointHeader
            // 
            this.firstJointHeader.LocationFloat = new DevExpress.Utils.PointFloat(620F, 0F);
            this.firstJointHeader.Name = "firstJointHeader";
            this.firstJointHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.firstJointHeader.SizeF = new System.Drawing.SizeF(140F, 38.37497F);
            this.firstJointHeader.Text = "Первый стык";
            // 
            // gradeHeader
            // 
            this.gradeHeader.LocationFloat = new DevExpress.Utils.PointFloat(522.5001F, 0F);
            this.gradeHeader.Name = "gradeHeader";
            this.gradeHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.gradeHeader.SizeF = new System.Drawing.SizeF(97.49982F, 38.37497F);
            this.gradeHeader.Text = "Марка стали";
            // 
            // seamTypeHeader
            // 
            this.seamTypeHeader.LocationFloat = new DevExpress.Utils.PointFloat(410F, 0F);
            this.seamTypeHeader.Name = "seamTypeHeader";
            this.seamTypeHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.seamTypeHeader.SizeF = new System.Drawing.SizeF(112.5F, 38.37497F);
            this.seamTypeHeader.Text = "Тип шва";
            // 
            // thicknessHeader
            // 
            this.thicknessHeader.LocationFloat = new DevExpress.Utils.PointFloat(320F, 0F);
            this.thicknessHeader.Name = "thicknessHeader";
            this.thicknessHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.thicknessHeader.SizeF = new System.Drawing.SizeF(90F, 38.37497F);
            this.thicknessHeader.Text = "Толщина, мм";
            // 
            // lengthHeader
            // 
            this.lengthHeader.LocationFloat = new DevExpress.Utils.PointFloat(230F, 0F);
            this.lengthHeader.Name = "lengthHeader";
            this.lengthHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lengthHeader.SizeF = new System.Drawing.SizeF(89.99995F, 38.37497F);
            this.lengthHeader.Text = "Длина, мм";
            // 
            // diameterHeader
            // 
            this.diameterHeader.LocationFloat = new DevExpress.Utils.PointFloat(140F, 0F);
            this.diameterHeader.Name = "diameterHeader";
            this.diameterHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.diameterHeader.SizeF = new System.Drawing.SizeF(89.99997F, 38.37497F);
            this.diameterHeader.Text = "Диаметр, мм";
            // 
            // pipeNumberHeader
            // 
            this.pipeNumberHeader.LocationFloat = new DevExpress.Utils.PointFloat(6.357829E-05F, 0F);
            this.pipeNumberHeader.Name = "pipeNumberHeader";
            this.pipeNumberHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pipeNumberHeader.SizeF = new System.Drawing.SizeF(140F, 38.37497F);
            this.pipeNumberHeader.Text = "Номер трубы";
            // 
            // pageFooter
            // 
            this.pageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.numberPageInfo,
            this.dateTimePageInfo});
            this.pageFooter.HeightF = 23F;
            this.pageFooter.Name = "pageFooter";
            // 
            // numberPageInfo
            // 
            this.numberPageInfo.Format = "{0} / {1}";
            this.numberPageInfo.LocationFloat = new DevExpress.Utils.PointFloat(409.9999F, 0F);
            this.numberPageInfo.Name = "numberPageInfo";
            this.numberPageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.numberPageInfo.SizeF = new System.Drawing.SizeF(490.0001F, 23F);
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
            this.dateTimePageInfo.SizeF = new System.Drawing.SizeF(410F, 23F);
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.gradeHeader,
            this.pipeNumberHeader,
            this.diameterHeader,
            this.lengthHeader,
            this.thicknessHeader,
            this.seamTypeHeader,
            this.firstJointHeader,
            this.secondJointHeader});
            this.PageHeader.HeightF = 38.37497F;
            this.PageHeader.Name = "PageHeader";
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(Prizm.Main.Forms.Reports.Construction.PipeReport.PipeReportData);
            // 
            // PipeConstructionXtraReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.pageFooter,
            this.PageHeader});
            this.DataSource = this.bindingSource;
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 48, 39);
            this.PageHeight = 850;
            this.PageWidth = 1100;
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
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel pageHeaderLabel;
    }
}
