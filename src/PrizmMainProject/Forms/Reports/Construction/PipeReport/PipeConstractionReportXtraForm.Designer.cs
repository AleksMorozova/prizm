namespace Prizm.Main.Forms.Reports.Construction.PipeReport
{
    partial class PipeConstractionReportXtraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PipeConstractionReportXtraForm));
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pipeReportLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.pipeTypeCheckedCombo = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.previewButton = new DevExpress.XtraEditors.SimpleButton();
            this.createReportButton = new DevExpress.XtraEditors.SimpleButton();
            this.pipeNumber = new DevExpress.XtraEditors.TextEdit();
            this.pipeReportViewer = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.documentViewerLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.pipeReportViewerLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.pipeReportParametersLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.pipeNumberLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.createButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.previewButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.pipeTypeCheckedComboLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeReportLayoutControl)).BeginInit();
            this.pipeReportLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTypeCheckedCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentViewerLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeReportViewerLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeReportParametersLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeNumberLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTypeCheckedComboLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // pipeReportLayoutControl
            // 
            this.pipeReportLayoutControl.Controls.Add(this.pipeTypeCheckedCombo);
            this.pipeReportLayoutControl.Controls.Add(this.previewButton);
            this.pipeReportLayoutControl.Controls.Add(this.createReportButton);
            this.pipeReportLayoutControl.Controls.Add(this.pipeNumber);
            this.pipeReportLayoutControl.Controls.Add(this.pipeReportViewer);
            this.pipeReportLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pipeReportLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.pipeReportLayoutControl.Name = "pipeReportLayoutControl";
            this.pipeReportLayoutControl.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray;
            this.pipeReportLayoutControl.OptionsPrint.AppearanceGroupCaption.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.pipeReportLayoutControl.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = true;
            this.pipeReportLayoutControl.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
            this.pipeReportLayoutControl.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = true;
            this.pipeReportLayoutControl.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.pipeReportLayoutControl.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.pipeReportLayoutControl.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = true;
            this.pipeReportLayoutControl.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.pipeReportLayoutControl.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.pipeReportLayoutControl.Root = this.Root;
            this.pipeReportLayoutControl.Size = new System.Drawing.Size(924, 411);
            this.pipeReportLayoutControl.TabIndex = 0;
            this.pipeReportLayoutControl.Text = "layoutControl1";
            // 
            // pipeTypeCheckedCombo
            // 
            this.pipeTypeCheckedCombo.EditValue = "";
            this.pipeTypeCheckedCombo.Location = new System.Drawing.Point(216, 59);
            this.pipeTypeCheckedCombo.Name = "pipeTypeCheckedCombo";
            this.pipeTypeCheckedCombo.Properties.AllowMultiSelect = true;
            this.pipeTypeCheckedCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.pipeTypeCheckedCombo.Properties.SelectAllItemCaption = "(Выбрать все)";
            this.pipeTypeCheckedCombo.Size = new System.Drawing.Size(367, 20);
            this.pipeTypeCheckedCombo.StyleController = this.pipeReportLayoutControl;
            this.pipeTypeCheckedCombo.TabIndex = 13;
            this.pipeTypeCheckedCombo.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.pipeTypeCheckedCombo_CloseUp);
            // 
            // previewButton
            // 
            this.previewButton.Image = ((System.Drawing.Image)(resources.GetObject("previewButton.Image")));
            this.previewButton.Location = new System.Drawing.Point(635, 57);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(112, 22);
            this.previewButton.StyleController = this.pipeReportLayoutControl;
            this.previewButton.TabIndex = 9;
            this.previewButton.Text = "&Предпросмотр";
            // 
            // createReportButton
            // 
            this.createReportButton.Image = ((System.Drawing.Image)(resources.GetObject("createReportButton.Image")));
            this.createReportButton.Location = new System.Drawing.Point(775, 57);
            this.createReportButton.Name = "createReportButton";
            this.createReportButton.Size = new System.Drawing.Size(113, 22);
            this.createReportButton.StyleController = this.pipeReportLayoutControl;
            this.createReportButton.TabIndex = 8;
            this.createReportButton.Text = "Соз&дать отчет";
            // 
            // pipeNumber
            // 
            this.pipeNumber.Location = new System.Drawing.Point(29, 59);
            this.pipeNumber.Name = "pipeNumber";
            this.pipeNumber.Size = new System.Drawing.Size(159, 20);
            this.pipeNumber.StyleController = this.pipeReportLayoutControl;
            this.pipeNumber.TabIndex = 5;
            // 
            // pipeReportViewer
            // 
            this.pipeReportViewer.IsMetric = false;
            this.pipeReportViewer.Location = new System.Drawing.Point(24, 131);
            this.pipeReportViewer.Name = "pipeReportViewer";
            this.pipeReportViewer.Size = new System.Drawing.Size(876, 256);
            this.pipeReportViewer.Status = " ";
            this.pipeReportViewer.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.CustomizationFormText = "Root";
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.documentViewerLayoutGroup,
            this.pipeReportParametersLayoutGroup});
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(924, 411);
            this.Root.Text = "Root";
            this.Root.TextVisible = false;
            // 
            // documentViewerLayoutGroup
            // 
            this.documentViewerLayoutGroup.CustomizationFormText = "Предварительный просмотр отчёта";
            this.documentViewerLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.pipeReportViewerLayout});
            this.documentViewerLayoutGroup.Location = new System.Drawing.Point(0, 88);
            this.documentViewerLayoutGroup.Name = "documentViewerLayoutGroup";
            this.documentViewerLayoutGroup.Size = new System.Drawing.Size(904, 303);
            this.documentViewerLayoutGroup.Text = "Предварительный просмотр отчёта";
            // 
            // pipeReportViewerLayout
            // 
            this.pipeReportViewerLayout.Control = this.pipeReportViewer;
            this.pipeReportViewerLayout.CustomizationFormText = "pipeReportViewerLayout";
            this.pipeReportViewerLayout.Location = new System.Drawing.Point(0, 0);
            this.pipeReportViewerLayout.Name = "pipeReportViewerLayout";
            this.pipeReportViewerLayout.Size = new System.Drawing.Size(880, 260);
            this.pipeReportViewerLayout.Text = "pipeReportViewerLayout";
            this.pipeReportViewerLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.pipeReportViewerLayout.TextSize = new System.Drawing.Size(0, 0);
            this.pipeReportViewerLayout.TextVisible = false;
            // 
            // pipeReportParametersLayoutGroup
            // 
            this.pipeReportParametersLayoutGroup.CustomizationFormText = "Параметры отчета по трубам";
            this.pipeReportParametersLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.pipeNumberLayout,
            this.emptySpaceItem1,
            this.createButtonLayout,
            this.previewButtonLayout,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.pipeTypeCheckedComboLayout,
            this.emptySpaceItem4});
            this.pipeReportParametersLayoutGroup.Location = new System.Drawing.Point(0, 0);
            this.pipeReportParametersLayoutGroup.Name = "pipeReportParametersLayoutGroup";
            this.pipeReportParametersLayoutGroup.Size = new System.Drawing.Size(904, 88);
            this.pipeReportParametersLayoutGroup.Text = "Параметры отчета по трубам";
            // 
            // pipeNumberLayout
            // 
            this.pipeNumberLayout.Control = this.pipeNumber;
            this.pipeNumberLayout.CustomizationFormText = "Номер трубы";
            this.pipeNumberLayout.Location = new System.Drawing.Point(0, 0);
            this.pipeNumberLayout.MaxSize = new System.Drawing.Size(180, 45);
            this.pipeNumberLayout.MinSize = new System.Drawing.Size(180, 45);
            this.pipeNumberLayout.Name = "pipeNumberLayout";
            this.pipeNumberLayout.Size = new System.Drawing.Size(180, 45);
            this.pipeNumberLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.pipeNumberLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 12, 0, 5);
            this.pipeNumberLayout.Text = "Номер трубы";
            this.pipeNumberLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.pipeNumberLayout.TextSize = new System.Drawing.Size(66, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(589, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(10, 45);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // createButtonLayout
            // 
            this.createButtonLayout.Control = this.createReportButton;
            this.createButtonLayout.CustomizationFormText = "createButtonLayout";
            this.createButtonLayout.Location = new System.Drawing.Point(739, 14);
            this.createButtonLayout.MaxSize = new System.Drawing.Size(141, 31);
            this.createButtonLayout.MinSize = new System.Drawing.Size(141, 31);
            this.createButtonLayout.Name = "createButtonLayout";
            this.createButtonLayout.Size = new System.Drawing.Size(141, 31);
            this.createButtonLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.createButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(12, 12, 0, 5);
            this.createButtonLayout.Text = "createButtonLayout";
            this.createButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.createButtonLayout.TextVisible = false;
            // 
            // previewButtonLayout
            // 
            this.previewButtonLayout.Control = this.previewButton;
            this.previewButtonLayout.CustomizationFormText = "previewButtonLayout";
            this.previewButtonLayout.Location = new System.Drawing.Point(599, 14);
            this.previewButtonLayout.MaxSize = new System.Drawing.Size(140, 0);
            this.previewButtonLayout.MinSize = new System.Drawing.Size(140, 31);
            this.previewButtonLayout.Name = "previewButtonLayout";
            this.previewButtonLayout.Size = new System.Drawing.Size(140, 31);
            this.previewButtonLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.previewButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(12, 12, 0, 5);
            this.previewButtonLayout.Text = "previewButtonLayout";
            this.previewButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.previewButtonLayout.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(599, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(140, 14);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3";
            this.emptySpaceItem3.Location = new System.Drawing.Point(739, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(141, 14);
            this.emptySpaceItem3.Text = "emptySpaceItem3";
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // pipeTypeCheckedComboLayout
            // 
            this.pipeTypeCheckedComboLayout.Control = this.pipeTypeCheckedCombo;
            this.pipeTypeCheckedComboLayout.CustomizationFormText = "Типоразмер";
            this.pipeTypeCheckedComboLayout.Location = new System.Drawing.Point(180, 0);
            this.pipeTypeCheckedComboLayout.MinSize = new System.Drawing.Size(368, 45);
            this.pipeTypeCheckedComboLayout.Name = "pipeTypeCheckedComboLayout";
            this.pipeTypeCheckedComboLayout.Size = new System.Drawing.Size(395, 45);
            this.pipeTypeCheckedComboLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.pipeTypeCheckedComboLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(12, 12, 0, 5);
            this.pipeTypeCheckedComboLayout.Text = "Типоразмер";
            this.pipeTypeCheckedComboLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.pipeTypeCheckedComboLayout.TextSize = new System.Drawing.Size(66, 13);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.CustomizationFormText = "emptySpaceItem4";
            this.emptySpaceItem4.Location = new System.Drawing.Point(575, 0);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(14, 45);
            this.emptySpaceItem4.Text = "emptySpaceItem4";
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // PipeConstractionReportXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 411);
            this.Controls.Add(this.pipeReportLayoutControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PipeConstractionReportXtraForm";
            this.Text = "Отчеты по трубам на стройке";
            this.Load += new System.EventHandler(this.PipeConstractionReportXtraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeReportLayoutControl)).EndInit();
            this.pipeReportLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pipeTypeCheckedCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentViewerLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeReportViewerLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeReportParametersLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeNumberLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTypeCheckedComboLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl pipeReportLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton previewButton;
        private DevExpress.XtraEditors.SimpleButton createReportButton;
        private DevExpress.XtraEditors.TextEdit pipeNumber;
        private DevExpress.XtraPrinting.Preview.DocumentViewer pipeReportViewer;
        private DevExpress.XtraLayout.LayoutControlGroup documentViewerLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem pipeReportViewerLayout;
        private DevExpress.XtraLayout.LayoutControlGroup pipeReportParametersLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem pipeNumberLayout;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem createButtonLayout;
        private DevExpress.XtraLayout.LayoutControlItem previewButtonLayout;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private System.Windows.Forms.BindingSource bindingSource;
        private DevExpress.XtraEditors.CheckedComboBoxEdit pipeTypeCheckedCombo;
        private DevExpress.XtraLayout.LayoutControlItem pipeTypeCheckedComboLayout;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
    }
}