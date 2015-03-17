namespace Prizm.Main.Forms.Reports.Construction.WeldDateReports
{
    partial class WeldDateReportXtraForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeldDateReportXtraForm));
            this.weldReportLayout = new DevExpress.XtraLayout.LayoutControl();
            this.footersCheck = new DevExpress.XtraEditors.CheckEdit();
            this.createReportButton = new DevExpress.XtraEditors.SimpleButton();
            this.previewButton = new DevExpress.XtraEditors.SimpleButton();
            this.weldDateTo = new DevExpress.XtraEditors.DateEdit();
            this.weldDateFrom = new DevExpress.XtraEditors.DateEdit();
            this.jointReportViewer = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.weldReportParameterGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.weldDateToLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.weldDateFromLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.previewButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.createReportButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.footersCheckLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.jointReportViewerGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.jointReportViewerLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.weldReportLayout)).BeginInit();
            this.weldReportLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.footersCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldDateTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldDateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldDateFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldDateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldReportParameterGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldDateToLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldDateFromLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createReportButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footersCheckLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointReportViewerGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointReportViewerLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // weldReportLayout
            // 
            this.weldReportLayout.Controls.Add(this.footersCheck);
            this.weldReportLayout.Controls.Add(this.createReportButton);
            this.weldReportLayout.Controls.Add(this.previewButton);
            this.weldReportLayout.Controls.Add(this.weldDateTo);
            this.weldReportLayout.Controls.Add(this.weldDateFrom);
            this.weldReportLayout.Controls.Add(this.jointReportViewer);
            this.weldReportLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weldReportLayout.Location = new System.Drawing.Point(0, 0);
            this.weldReportLayout.Name = "weldReportLayout";
            this.weldReportLayout.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray;
            this.weldReportLayout.OptionsPrint.AppearanceGroupCaption.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.weldReportLayout.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = true;
            this.weldReportLayout.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
            this.weldReportLayout.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = true;
            this.weldReportLayout.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.weldReportLayout.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.weldReportLayout.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = true;
            this.weldReportLayout.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.weldReportLayout.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.weldReportLayout.Root = this.Root;
            this.weldReportLayout.Size = new System.Drawing.Size(924, 411);
            this.weldReportLayout.TabIndex = 0;
            this.weldReportLayout.Text = "layoutControl1";
            // 
            // footersCheck
            // 
            this.footersCheck.Location = new System.Drawing.Point(475, 58);
            this.footersCheck.MaximumSize = new System.Drawing.Size(160, 0);
            this.footersCheck.MinimumSize = new System.Drawing.Size(160, 0);
            this.footersCheck.Name = "footersCheck";
            this.footersCheck.Properties.Caption = "Добавить колонтитулы";
            this.footersCheck.Size = new System.Drawing.Size(160, 19);
            this.footersCheck.StyleController = this.weldReportLayout;
            this.footersCheck.TabIndex = 9;
            // 
            // createReportButton
            // 
            this.createReportButton.Image = ((System.Drawing.Image)(resources.GetObject("createReportButton.Image")));
            this.createReportButton.Location = new System.Drawing.Point(782, 58);
            this.createReportButton.MaximumSize = new System.Drawing.Size(110, 22);
            this.createReportButton.MinimumSize = new System.Drawing.Size(110, 22);
            this.createReportButton.Name = "createReportButton";
            this.createReportButton.Size = new System.Drawing.Size(110, 22);
            this.createReportButton.StyleController = this.weldReportLayout;
            this.createReportButton.TabIndex = 8;
            this.createReportButton.Text = "Соз&дать отчет";
            // 
            // previewButton
            // 
            this.previewButton.Image = ((System.Drawing.Image)(resources.GetObject("previewButton.Image")));
            this.previewButton.Location = new System.Drawing.Point(651, 58);
            this.previewButton.MaximumSize = new System.Drawing.Size(110, 22);
            this.previewButton.MinimumSize = new System.Drawing.Size(110, 22);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(110, 22);
            this.previewButton.StyleController = this.weldReportLayout;
            this.previewButton.TabIndex = 7;
            this.previewButton.Text = "&Предпросмотр";
            // 
            // weldDateTo
            // 
            this.weldDateTo.EditValue = null;
            this.weldDateTo.Location = new System.Drawing.Point(186, 59);
            this.weldDateTo.Name = "weldDateTo";
            this.weldDateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.weldDateTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.weldDateTo.Size = new System.Drawing.Size(122, 20);
            this.weldDateTo.StyleController = this.weldReportLayout;
            this.weldDateTo.TabIndex = 6;
            // 
            // weldDateFrom
            // 
            this.weldDateFrom.EditValue = null;
            this.weldDateFrom.Location = new System.Drawing.Point(29, 59);
            this.weldDateFrom.Name = "weldDateFrom";
            this.weldDateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.weldDateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.weldDateFrom.Size = new System.Drawing.Size(129, 20);
            this.weldDateFrom.StyleController = this.weldReportLayout;
            this.weldDateFrom.TabIndex = 5;
            // 
            // jointReportViewer
            // 
            this.jointReportViewer.IsMetric = false;
            this.jointReportViewer.Location = new System.Drawing.Point(24, 132);
            this.jointReportViewer.Name = "jointReportViewer";
            this.jointReportViewer.Size = new System.Drawing.Size(876, 255);
            this.jointReportViewer.Status = " ";
            this.jointReportViewer.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.CustomizationFormText = "Root";
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.weldReportParameterGroup,
            this.jointReportViewerGroup});
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(924, 411);
            this.Root.Text = "Root";
            this.Root.TextVisible = false;
            // 
            // weldReportParameterGroup
            // 
            this.weldReportParameterGroup.CustomizationFormText = "layoutControlGroup1";
            this.weldReportParameterGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.weldDateToLayout,
            this.weldDateFromLayout,
            this.previewButtonLayout,
            this.createReportButtonLayout,
            this.emptySpaceItem1,
            this.footersCheckLayout});
            this.weldReportParameterGroup.Location = new System.Drawing.Point(0, 0);
            this.weldReportParameterGroup.Name = "weldReportParameterGroup";
            this.weldReportParameterGroup.Size = new System.Drawing.Size(904, 89);
            this.weldReportParameterGroup.Text = "Сформировать отчёт";
            // 
            // weldDateToLayout
            // 
            this.weldDateToLayout.Control = this.weldDateTo;
            this.weldDateToLayout.CustomizationFormText = "layoutControlItem3";
            this.weldDateToLayout.Location = new System.Drawing.Point(150, 0);
            this.weldDateToLayout.MaxSize = new System.Drawing.Size(150, 45);
            this.weldDateToLayout.MinSize = new System.Drawing.Size(150, 45);
            this.weldDateToLayout.Name = "weldDateToLayout";
            this.weldDateToLayout.Size = new System.Drawing.Size(150, 46);
            this.weldDateToLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.weldDateToLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(12, 12, 0, 5);
            this.weldDateToLayout.Text = "Дата сварки: По";
            this.weldDateToLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.weldDateToLayout.TextSize = new System.Drawing.Size(84, 13);
            // 
            // weldDateFromLayout
            // 
            this.weldDateFromLayout.Control = this.weldDateFrom;
            this.weldDateFromLayout.CustomizationFormText = "layoutControlItem2";
            this.weldDateFromLayout.Location = new System.Drawing.Point(0, 0);
            this.weldDateFromLayout.MaxSize = new System.Drawing.Size(150, 45);
            this.weldDateFromLayout.MinSize = new System.Drawing.Size(150, 45);
            this.weldDateFromLayout.Name = "weldDateFromLayout";
            this.weldDateFromLayout.Size = new System.Drawing.Size(150, 46);
            this.weldDateFromLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.weldDateFromLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 12, 0, 5);
            this.weldDateFromLayout.Text = "Дата сварки: С";
            this.weldDateFromLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.weldDateFromLayout.TextSize = new System.Drawing.Size(84, 13);
            // 
            // previewButtonLayout
            // 
            this.previewButtonLayout.Control = this.previewButton;
            this.previewButtonLayout.CustomizationFormText = "layoutControlItem4";
            this.previewButtonLayout.Location = new System.Drawing.Point(620, 0);
            this.previewButtonLayout.MaxSize = new System.Drawing.Size(131, 46);
            this.previewButtonLayout.MinSize = new System.Drawing.Size(131, 46);
            this.previewButtonLayout.Name = "previewButtonLayout";
            this.previewButtonLayout.Size = new System.Drawing.Size(131, 46);
            this.previewButtonLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.previewButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(7, 5, 15, 0);
            this.previewButtonLayout.Text = "previewButtonLayout";
            this.previewButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.previewButtonLayout.TextVisible = false;
            // 
            // createReportButtonLayout
            // 
            this.createReportButtonLayout.Control = this.createReportButton;
            this.createReportButtonLayout.CustomizationFormText = "layoutControlItem5";
            this.createReportButtonLayout.Location = new System.Drawing.Point(751, 0);
            this.createReportButtonLayout.MaxSize = new System.Drawing.Size(129, 46);
            this.createReportButtonLayout.MinSize = new System.Drawing.Size(129, 46);
            this.createReportButtonLayout.Name = "createReportButtonLayout";
            this.createReportButtonLayout.Size = new System.Drawing.Size(129, 46);
            this.createReportButtonLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.createReportButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(7, 5, 15, 0);
            this.createReportButtonLayout.Text = "createReportButtonLayout";
            this.createReportButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.createReportButtonLayout.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(300, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(146, 46);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // footersCheckLayout
            // 
            this.footersCheckLayout.Control = this.footersCheck;
            this.footersCheckLayout.CustomizationFormText = "footersCheckLayout";
            this.footersCheckLayout.Location = new System.Drawing.Point(446, 0);
            this.footersCheckLayout.MaxSize = new System.Drawing.Size(174, 46);
            this.footersCheckLayout.MinSize = new System.Drawing.Size(174, 46);
            this.footersCheckLayout.Name = "footersCheckLayout";
            this.footersCheckLayout.Size = new System.Drawing.Size(174, 46);
            this.footersCheckLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.footersCheckLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 15, 0);
            this.footersCheckLayout.Text = "footersCheckLayout";
            this.footersCheckLayout.TextSize = new System.Drawing.Size(0, 0);
            this.footersCheckLayout.TextVisible = false;
            // 
            // jointReportViewerGroup
            // 
            this.jointReportViewerGroup.CustomizationFormText = "layoutControlGroup2";
            this.jointReportViewerGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.jointReportViewerLayout});
            this.jointReportViewerGroup.Location = new System.Drawing.Point(0, 89);
            this.jointReportViewerGroup.Name = "jointReportViewerGroup";
            this.jointReportViewerGroup.Size = new System.Drawing.Size(904, 302);
            this.jointReportViewerGroup.Text = "Предварительный просмотр отчёта";
            // 
            // jointReportViewerLayout
            // 
            this.jointReportViewerLayout.Control = this.jointReportViewer;
            this.jointReportViewerLayout.CustomizationFormText = "layoutControlItem1";
            this.jointReportViewerLayout.Location = new System.Drawing.Point(0, 0);
            this.jointReportViewerLayout.Name = "jointReportViewerLayout";
            this.jointReportViewerLayout.Size = new System.Drawing.Size(880, 259);
            this.jointReportViewerLayout.Text = "jointReportViewerLayout";
            this.jointReportViewerLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.jointReportViewerLayout.TextSize = new System.Drawing.Size(0, 0);
            this.jointReportViewerLayout.TextVisible = false;
            // 
            // WeldDateReportXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 411);
            this.Controls.Add(this.weldReportLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WeldDateReportXtraForm";
            this.Text = "Отчет по сварке (по дате)";
            this.Load += new System.EventHandler(this.WeldDateReportXtraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.weldReportLayout)).EndInit();
            this.weldReportLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.footersCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldDateTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldDateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldDateFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldDateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldReportParameterGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldDateToLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldDateFromLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createReportButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footersCheckLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointReportViewerGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointReportViewerLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl weldReportLayout;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton createReportButton;
        private DevExpress.XtraEditors.SimpleButton previewButton;
        private DevExpress.XtraEditors.DateEdit weldDateTo;
        private DevExpress.XtraEditors.DateEdit weldDateFrom;
        private DevExpress.XtraPrinting.Preview.DocumentViewer jointReportViewer;
        private DevExpress.XtraLayout.LayoutControlGroup weldReportParameterGroup;
        private DevExpress.XtraLayout.LayoutControlItem weldDateToLayout;
        private DevExpress.XtraLayout.LayoutControlItem weldDateFromLayout;
        private DevExpress.XtraLayout.LayoutControlItem previewButtonLayout;
        private DevExpress.XtraLayout.LayoutControlItem createReportButtonLayout;
        private DevExpress.XtraLayout.LayoutControlGroup jointReportViewerGroup;
        private DevExpress.XtraLayout.LayoutControlItem jointReportViewerLayout;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private System.Windows.Forms.BindingSource bindingSource;
        private DevExpress.XtraEditors.CheckEdit footersCheck;
        private DevExpress.XtraLayout.LayoutControlItem footersCheckLayout;
    }
}