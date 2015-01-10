namespace Prizm.Main.Forms.Reports.Construction
{
    partial class ConstructionReportsXtraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConstructionReportsXtraForm));
            this.reportType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.generalLayout = new DevExpress.XtraLayout.LayoutControl();
            this.tracingModeRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.start = new DevExpress.XtraEditors.ComboBoxEdit();
            this.end = new DevExpress.XtraEditors.ComboBoxEdit();
            this.endKPComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.startKPComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.createReportButton = new DevExpress.XtraEditors.SimpleButton();
            this.previewButton = new DevExpress.XtraEditors.SimpleButton();
            this.previewReportDocument = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            this.type = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.generalLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.previewLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.previewLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.createReportaLyoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.typeLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.reportTypeLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.buttonsEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.previewButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.startKPComboBoxLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.startJointEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.reportTypeEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.endKPLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.endJointLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.startJointLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.createButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.underPreviewEmptySpaceI = new DevExpress.XtraLayout.EmptySpaceItem();
            this.underCreateButtonEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.tracingModeLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.reportType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalLayout)).BeginInit();
            this.generalLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracingModeRadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.start.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.end.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endKPComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startKPComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createReportaLyoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportTypeLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonsEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startKPComboBoxLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startJointEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportTypeEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endKPLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endJointLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startJointLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.underPreviewEmptySpaceI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.underCreateButtonEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracingModeLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportType
            // 
            this.reportType.EditValue = "";
            this.reportType.Location = new System.Drawing.Point(24, 59);
            this.reportType.Name = "reportType";
            this.reportType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.reportType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.reportType.Size = new System.Drawing.Size(186, 20);
            this.reportType.StyleController = this.generalLayout;
            this.reportType.TabIndex = 68;
            this.reportType.SelectedIndexChanged += new System.EventHandler(this.reportType_SelectedIndexChanged);
            // 
            // generalLayout
            // 
            this.generalLayout.Controls.Add(this.tracingModeRadioGroup);
            this.generalLayout.Controls.Add(this.start);
            this.generalLayout.Controls.Add(this.end);
            this.generalLayout.Controls.Add(this.endKPComboBox);
            this.generalLayout.Controls.Add(this.startKPComboBox);
            this.generalLayout.Controls.Add(this.reportType);
            this.generalLayout.Controls.Add(this.createReportButton);
            this.generalLayout.Controls.Add(this.previewButton);
            this.generalLayout.Controls.Add(this.previewReportDocument);
            this.generalLayout.Controls.Add(this.type);
            this.generalLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalLayout.Location = new System.Drawing.Point(0, 0);
            this.generalLayout.Name = "generalLayout";
            this.generalLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(251, 263, 250, 350);
            this.generalLayout.Root = this.generalLayoutGroup;
            this.generalLayout.Size = new System.Drawing.Size(940, 450);
            this.generalLayout.TabIndex = 70;
            this.generalLayout.Text = "layoutControl1";
            // 
            // tracingModeRadioGroup
            // 
            this.tracingModeRadioGroup.Location = new System.Drawing.Point(234, 43);
            this.tracingModeRadioGroup.Name = "tracingModeRadioGroup";
            this.tracingModeRadioGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tracingModeRadioGroup.Properties.Appearance.Options.UseBackColor = true;
            this.tracingModeRadioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.tracingModeRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Стыки"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Пикеты")});
            this.tracingModeRadioGroup.Size = new System.Drawing.Size(93, 82);
            this.tracingModeRadioGroup.StyleController = this.generalLayout;
            this.tracingModeRadioGroup.TabIndex = 75;
            this.tracingModeRadioGroup.SelectedIndex = 1;
            this.tracingModeRadioGroup.SelectedIndexChanged += new System.EventHandler(this.tracingModeRadioGroup_SelectedIndexChanged);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(331, 59);
            this.start.Name = "start";
            this.start.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.start.Size = new System.Drawing.Size(116, 20);
            this.start.StyleController = this.generalLayout;
            this.start.TabIndex = 74;
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(471, 59);
            this.end.Name = "end";
            this.end.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.end.Size = new System.Drawing.Size(116, 20);
            this.end.StyleController = this.generalLayout;
            this.end.TabIndex = 73;
            // 
            // endKPComboBox
            // 
            this.endKPComboBox.Location = new System.Drawing.Point(471, 99);
            this.endKPComboBox.Name = "endKPComboBox";
            this.endKPComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endKPComboBox.Size = new System.Drawing.Size(116, 20);
            this.endKPComboBox.StyleController = this.generalLayout;
            this.endKPComboBox.TabIndex = 72;
            // 
            // startKPComboBox
            // 
            this.startKPComboBox.Location = new System.Drawing.Point(331, 99);
            this.startKPComboBox.Name = "startKPComboBox";
            this.startKPComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.startKPComboBox.Size = new System.Drawing.Size(116, 20);
            this.startKPComboBox.StyleController = this.generalLayout;
            this.startKPComboBox.TabIndex = 71;
            // 
            // createReportButton
            // 
            this.createReportButton.Image = ((System.Drawing.Image)(resources.GetObject("createReportButton.Image")));
            this.createReportButton.Location = new System.Drawing.Point(750, 102);
            this.createReportButton.Name = "createReportButton";
            this.createReportButton.Size = new System.Drawing.Size(113, 23);
            this.createReportButton.StyleController = this.generalLayout;
            this.createReportButton.TabIndex = 64;
            this.createReportButton.Text = "Соз&дать отчет";
            // 
            // previewButton
            // 
            this.previewButton.Image = ((System.Drawing.Image)(resources.GetObject("previewButton.Image")));
            this.previewButton.Location = new System.Drawing.Point(606, 102);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(110, 22);
            this.previewButton.StyleController = this.generalLayout;
            this.previewButton.TabIndex = 65;
            this.previewButton.Text = "&Предпросмотр";
            // 
            // previewReportDocument
            // 
            this.previewReportDocument.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.previewReportDocument.IsMetric = false;
            this.previewReportDocument.Location = new System.Drawing.Point(24, 172);
            this.previewReportDocument.Name = "previewReportDocument";
            this.previewReportDocument.Size = new System.Drawing.Size(892, 254);
            this.previewReportDocument.Status = "Документ не содержит каких-либо страниц.";
            this.previewReportDocument.TabIndex = 56;
            // 
            // type
            // 
            this.type.EditValue = "";
            this.type.Location = new System.Drawing.Point(24, 99);
            this.type.Name = "type";
            this.type.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.type.Properties.SelectAllItemCaption = "(Выбрать все)";
            this.type.Size = new System.Drawing.Size(186, 20);
            this.type.StyleController = this.generalLayout;
            this.type.TabIndex = 63;
            this.type.EditValueChanged += new System.EventHandler(this.type_EditValueChanged);
            // 
            // generalLayoutGroup
            // 
            this.generalLayoutGroup.CustomizationFormText = "generalLayoutGroup";
            this.generalLayoutGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.generalLayoutGroup.GroupBordersVisible = false;
            this.generalLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.previewLayoutGroup,
            this.createReportaLyoutGroup});
            this.generalLayoutGroup.Location = new System.Drawing.Point(0, 0);
            this.generalLayoutGroup.Name = "generalLayoutGroup";
            this.generalLayoutGroup.Size = new System.Drawing.Size(940, 450);
            this.generalLayoutGroup.Text = "generalLayoutGroup";
            this.generalLayoutGroup.TextVisible = false;
            // 
            // previewLayoutGroup
            // 
            this.previewLayoutGroup.CustomizationFormText = "Предварительный просмотр отчёта ";
            this.previewLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.previewLayout});
            this.previewLayoutGroup.Location = new System.Drawing.Point(0, 129);
            this.previewLayoutGroup.Name = "previewLayoutGroup";
            this.previewLayoutGroup.Size = new System.Drawing.Size(920, 301);
            this.previewLayoutGroup.Text = "Предварительный просмотр отчёта ";
            // 
            // previewLayout
            // 
            this.previewLayout.Control = this.previewReportDocument;
            this.previewLayout.CustomizationFormText = "previewLayout";
            this.previewLayout.Location = new System.Drawing.Point(0, 0);
            this.previewLayout.Name = "previewLayout";
            this.previewLayout.Size = new System.Drawing.Size(896, 258);
            this.previewLayout.Text = "previewLayout";
            this.previewLayout.TextSize = new System.Drawing.Size(0, 0);
            this.previewLayout.TextToControlDistance = 0;
            this.previewLayout.TextVisible = false;
            // 
            // createReportaLyoutGroup
            // 
            this.createReportaLyoutGroup.CustomizationFormText = "Сформировать отчёт";
            this.createReportaLyoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.typeLayout,
            this.reportTypeLayout,
            this.buttonsEmptySpace,
            this.previewButtonLayout,
            this.startKPComboBoxLayoutControl,
            this.startJointEmptySpace,
            this.reportTypeEmptySpace,
            this.endKPLayout,
            this.endJointLayout,
            this.startJointLayout,
            this.createButtonLayout,
            this.underPreviewEmptySpaceI,
            this.underCreateButtonEmptySpace,
            this.tracingModeLayoutControl});
            this.createReportaLyoutGroup.Location = new System.Drawing.Point(0, 0);
            this.createReportaLyoutGroup.Name = "createReportaLyoutGroup";
            this.createReportaLyoutGroup.Size = new System.Drawing.Size(920, 129);
            this.createReportaLyoutGroup.Text = "Сформировать отчёт";
            // 
            // typeLayout
            // 
            this.typeLayout.Control = this.type;
            this.typeLayout.CustomizationFormText = "Тип изделия";
            this.typeLayout.Location = new System.Drawing.Point(0, 40);
            this.typeLayout.MinSize = new System.Drawing.Size(107, 40);
            this.typeLayout.Name = "typeLayout";
            this.typeLayout.Size = new System.Drawing.Size(200, 46);
            this.typeLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.typeLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 10, 0, 0);
            this.typeLayout.Text = "Тип изделия";
            this.typeLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.typeLayout.TextSize = new System.Drawing.Size(90, 13);
            // 
            // reportTypeLayout
            // 
            this.reportTypeLayout.Control = this.reportType;
            this.reportTypeLayout.CustomizationFormText = "Тип отчета";
            this.reportTypeLayout.Location = new System.Drawing.Point(0, 0);
            this.reportTypeLayout.MaxSize = new System.Drawing.Size(200, 40);
            this.reportTypeLayout.MinSize = new System.Drawing.Size(200, 40);
            this.reportTypeLayout.Name = "reportTypeLayout";
            this.reportTypeLayout.Size = new System.Drawing.Size(200, 40);
            this.reportTypeLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.reportTypeLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 10, 0, 0);
            this.reportTypeLayout.Text = "Тип отчета";
            this.reportTypeLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.reportTypeLayout.TextSize = new System.Drawing.Size(90, 13);
            // 
            // buttonsEmptySpace
            // 
            this.buttonsEmptySpace.AllowHotTrack = false;
            this.buttonsEmptySpace.CustomizationFormText = "buttonsEmptySpace";
            this.buttonsEmptySpace.Location = new System.Drawing.Point(858, 0);
            this.buttonsEmptySpace.Name = "buttonsEmptySpace";
            this.buttonsEmptySpace.Size = new System.Drawing.Size(38, 86);
            this.buttonsEmptySpace.Text = "buttonsEmptySpace";
            this.buttonsEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // previewButtonLayout
            // 
            this.previewButtonLayout.Control = this.previewButton;
            this.previewButtonLayout.CustomizationFormText = "previewButtonLayout";
            this.previewButtonLayout.Location = new System.Drawing.Point(567, 44);
            this.previewButtonLayout.MaxSize = new System.Drawing.Size(144, 42);
            this.previewButtonLayout.MinSize = new System.Drawing.Size(144, 42);
            this.previewButtonLayout.Name = "previewButtonLayout";
            this.previewButtonLayout.Size = new System.Drawing.Size(144, 42);
            this.previewButtonLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.previewButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 15, 1);
            this.previewButtonLayout.Text = "previewButtonLayout";
            this.previewButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.previewButtonLayout.TextToControlDistance = 0;
            this.previewButtonLayout.TextVisible = false;
            // 
            // startKPComboBoxLayoutControl
            // 
            this.startKPComboBoxLayoutControl.Control = this.startKPComboBox;
            this.startKPComboBoxLayoutControl.CustomizationFormText = "С";
            this.startKPComboBoxLayoutControl.Location = new System.Drawing.Point(307, 40);
            this.startKPComboBoxLayoutControl.MinSize = new System.Drawing.Size(97, 40);
            this.startKPComboBoxLayoutControl.Name = "startKPComboBoxLayoutControl";
            this.startKPComboBoxLayoutControl.Size = new System.Drawing.Size(120, 46);
            this.startKPComboBoxLayoutControl.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.startKPComboBoxLayoutControl.Text = "Начальный пикет";
            this.startKPComboBoxLayoutControl.TextLocation = DevExpress.Utils.Locations.Top;
            this.startKPComboBoxLayoutControl.TextSize = new System.Drawing.Size(90, 13);
            // 
            // startJointEmptySpace
            // 
            this.startJointEmptySpace.AllowHotTrack = false;
            this.startJointEmptySpace.CustomizationFormText = "startJointEmptySpace";
            this.startJointEmptySpace.Location = new System.Drawing.Point(427, 0);
            this.startJointEmptySpace.MaxSize = new System.Drawing.Size(20, 86);
            this.startJointEmptySpace.MinSize = new System.Drawing.Size(20, 86);
            this.startJointEmptySpace.Name = "startJointEmptySpace";
            this.startJointEmptySpace.Size = new System.Drawing.Size(20, 86);
            this.startJointEmptySpace.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.startJointEmptySpace.Text = "startJointEmptySpace";
            this.startJointEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // reportTypeEmptySpace
            // 
            this.reportTypeEmptySpace.AllowHotTrack = false;
            this.reportTypeEmptySpace.CustomizationFormText = "reportTypeEmptySpace";
            this.reportTypeEmptySpace.Location = new System.Drawing.Point(200, 0);
            this.reportTypeEmptySpace.MaxSize = new System.Drawing.Size(10, 86);
            this.reportTypeEmptySpace.MinSize = new System.Drawing.Size(10, 86);
            this.reportTypeEmptySpace.Name = "reportTypeEmptySpace";
            this.reportTypeEmptySpace.Size = new System.Drawing.Size(10, 86);
            this.reportTypeEmptySpace.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.reportTypeEmptySpace.Text = "reportTypeEmptySpace";
            this.reportTypeEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // endKPLayout
            // 
            this.endKPLayout.Control = this.endKPComboBox;
            this.endKPLayout.CustomizationFormText = "Конечный пикет";
            this.endKPLayout.Location = new System.Drawing.Point(447, 40);
            this.endKPLayout.MinSize = new System.Drawing.Size(97, 40);
            this.endKPLayout.Name = "endKPLayout";
            this.endKPLayout.Size = new System.Drawing.Size(120, 46);
            this.endKPLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.endKPLayout.Text = "Конечный пикет";
            this.endKPLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.endKPLayout.TextSize = new System.Drawing.Size(90, 13);
            // 
            // endJointLayout
            // 
            this.endJointLayout.Control = this.end;
            this.endJointLayout.CustomizationFormText = "Конечный стык";
            this.endJointLayout.Location = new System.Drawing.Point(447, 0);
            this.endJointLayout.MaxSize = new System.Drawing.Size(120, 40);
            this.endJointLayout.MinSize = new System.Drawing.Size(120, 40);
            this.endJointLayout.Name = "endJointLayout";
            this.endJointLayout.Size = new System.Drawing.Size(120, 40);
            this.endJointLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.endJointLayout.Text = "Конечный стык";
            this.endJointLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.endJointLayout.TextSize = new System.Drawing.Size(90, 13);
            // 
            // startJointLayout
            // 
            this.startJointLayout.Control = this.start;
            this.startJointLayout.CustomizationFormText = "Начальный стык";
            this.startJointLayout.Location = new System.Drawing.Point(307, 0);
            this.startJointLayout.MaxSize = new System.Drawing.Size(120, 40);
            this.startJointLayout.MinSize = new System.Drawing.Size(120, 40);
            this.startJointLayout.Name = "startJointLayout";
            this.startJointLayout.Size = new System.Drawing.Size(120, 40);
            this.startJointLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.startJointLayout.Text = "Начальный стык";
            this.startJointLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.startJointLayout.TextSize = new System.Drawing.Size(90, 13);
            // 
            // createButtonLayout
            // 
            this.createButtonLayout.Control = this.createReportButton;
            this.createButtonLayout.CustomizationFormText = "createButtonLayout";
            this.createButtonLayout.Location = new System.Drawing.Point(711, 44);
            this.createButtonLayout.MaxSize = new System.Drawing.Size(147, 42);
            this.createButtonLayout.MinSize = new System.Drawing.Size(147, 42);
            this.createButtonLayout.Name = "createButtonLayout";
            this.createButtonLayout.Size = new System.Drawing.Size(147, 42);
            this.createButtonLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.createButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 15, 0);
            this.createButtonLayout.Text = "createButtonLayout";
            this.createButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.createButtonLayout.TextToControlDistance = 0;
            this.createButtonLayout.TextVisible = false;
            // 
            // underPreviewEmptySpaceI
            // 
            this.underPreviewEmptySpaceI.AllowHotTrack = false;
            this.underPreviewEmptySpaceI.CustomizationFormText = "underPreviewEmptySpaceI";
            this.underPreviewEmptySpaceI.Location = new System.Drawing.Point(567, 0);
            this.underPreviewEmptySpaceI.MinSize = new System.Drawing.Size(104, 24);
            this.underPreviewEmptySpaceI.Name = "underPreviewEmptySpaceI";
            this.underPreviewEmptySpaceI.Size = new System.Drawing.Size(144, 44);
            this.underPreviewEmptySpaceI.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.underPreviewEmptySpaceI.Text = "underPreviewEmptySpaceI";
            this.underPreviewEmptySpaceI.TextSize = new System.Drawing.Size(0, 0);
            // 
            // underCreateButtonEmptySpace
            // 
            this.underCreateButtonEmptySpace.AllowHotTrack = false;
            this.underCreateButtonEmptySpace.CustomizationFormText = "underCreateButtonEmptySpace";
            this.underCreateButtonEmptySpace.Location = new System.Drawing.Point(711, 0);
            this.underCreateButtonEmptySpace.MinSize = new System.Drawing.Size(104, 24);
            this.underCreateButtonEmptySpace.Name = "underCreateButtonEmptySpace";
            this.underCreateButtonEmptySpace.Size = new System.Drawing.Size(147, 44);
            this.underCreateButtonEmptySpace.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.underCreateButtonEmptySpace.Text = "underCreateButtonEmptySpace";
            this.underCreateButtonEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // tracingModeLayoutControl
            // 
            this.tracingModeLayoutControl.Control = this.tracingModeRadioGroup;
            this.tracingModeLayoutControl.CustomizationFormText = "tracingModeLayoutControl";
            this.tracingModeLayoutControl.Location = new System.Drawing.Point(210, 0);
            this.tracingModeLayoutControl.MaxSize = new System.Drawing.Size(97, 0);
            this.tracingModeLayoutControl.MinSize = new System.Drawing.Size(97, 44);
            this.tracingModeLayoutControl.Name = "tracingModeLayoutControl";
            this.tracingModeLayoutControl.Size = new System.Drawing.Size(97, 86);
            this.tracingModeLayoutControl.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.tracingModeLayoutControl.Text = "tracingModeLayoutControl";
            this.tracingModeLayoutControl.TextLocation = DevExpress.Utils.Locations.Top;
            this.tracingModeLayoutControl.TextSize = new System.Drawing.Size(0, 0);
            this.tracingModeLayoutControl.TextToControlDistance = 0;
            this.tracingModeLayoutControl.TextVisible = false;
            // 
            // bindingSource
            // 
            this.bindingSource.AllowNew = false;
            // 
            // ConstructionReportsXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 450);
            this.Controls.Add(this.generalLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConstructionReportsXtraForm";
            this.Text = "Отчет по строительству";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConstructionReportsXtraForm_FormClosed);
            this.Load += new System.EventHandler(this.ConstructionReportsXtraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalLayout)).EndInit();
            this.generalLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tracingModeRadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.start.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.end.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endKPComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startKPComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createReportaLyoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportTypeLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonsEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startKPComboBoxLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startJointEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportTypeEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endKPLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endJointLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startJointLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.underPreviewEmptySpaceI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.underCreateButtonEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracingModeLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit reportType;

        private DevExpress.XtraEditors.SimpleButton previewButton;
        private DevExpress.XtraEditors.SimpleButton createReportButton;
        private DevExpress.XtraPrinting.Preview.DocumentViewer previewReportDocument;

        private DevExpress.XtraLayout.LayoutControl generalLayout;
        private DevExpress.XtraLayout.LayoutControlGroup generalLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlGroup previewLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem previewLayout;
        private DevExpress.XtraLayout.LayoutControlGroup createReportaLyoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem typeLayout;

        private DevExpress.XtraLayout.LayoutControlItem reportTypeLayout;
        private DevExpress.XtraLayout.LayoutControlItem previewButtonLayout;
        private DevExpress.XtraLayout.LayoutControlItem createButtonLayout;

        private DevExpress.XtraLayout.EmptySpaceItem buttonsEmptySpace;

        private DevExpress.XtraEditors.CheckedComboBoxEdit type;
        private System.Windows.Forms.BindingSource bindingSource;
        private DevExpress.XtraEditors.ComboBoxEdit endKPComboBox;
        private DevExpress.XtraEditors.ComboBoxEdit startKPComboBox;
        private DevExpress.XtraLayout.LayoutControlItem startKPComboBoxLayoutControl;
        private DevExpress.XtraLayout.LayoutControlItem endKPLayout;
        private DevExpress.XtraLayout.EmptySpaceItem startJointEmptySpace;
        private DevExpress.XtraEditors.ComboBoxEdit start;
        private DevExpress.XtraEditors.ComboBoxEdit end;
        private DevExpress.XtraLayout.EmptySpaceItem reportTypeEmptySpace;
        private DevExpress.XtraLayout.LayoutControlItem endJointLayout;
        private DevExpress.XtraLayout.LayoutControlItem startJointLayout;
        private DevExpress.XtraLayout.EmptySpaceItem underPreviewEmptySpaceI;
        private DevExpress.XtraLayout.EmptySpaceItem underCreateButtonEmptySpace;
        private DevExpress.XtraEditors.RadioGroup tracingModeRadioGroup;
        private DevExpress.XtraLayout.LayoutControlItem tracingModeLayoutControl;
    }
}