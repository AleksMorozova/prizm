namespace PrizmMain.Forms
{
    partial class SpoolsXtraForm
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
            this.searchButton = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.spoolLength = new DevExpress.XtraEditors.TextEdit();
            this.cutButton = new DevExpress.XtraEditors.SimpleButton();
            this.pipeLength = new DevExpress.XtraEditors.TextEdit();
            this.spoolNumber = new DevExpress.XtraEditors.TextEdit();
            this.pipeNumber = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutRootGrup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.pipeNumberLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.spoolNumberLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutLenghtGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.pipeLenghtLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.spoonLenghtLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spoolLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoolNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutRootGrup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeNumberLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoolNumberLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutLenghtGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeLenghtLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoonLenghtLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(809, 27);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(99, 22);
            this.searchButton.StyleController = this.layoutControl1;
            this.searchButton.TabIndex = 39;
            this.searchButton.Text = "Поиск";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.spoolLength);
            this.layoutControl1.Controls.Add(this.cutButton);
            this.layoutControl1.Controls.Add(this.pipeLength);
            this.layoutControl1.Controls.Add(this.spoolNumber);
            this.layoutControl1.Controls.Add(this.searchButton);
            this.layoutControl1.Controls.Add(this.pipeNumber);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(498, 38, 250, 350);
            this.layoutControl1.Root = this.layoutRootGrup;
            this.layoutControl1.Size = new System.Drawing.Size(940, 450);
            this.layoutControl1.TabIndex = 44;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // spoolLength
            // 
            this.spoolLength.Location = new System.Drawing.Point(485, 192);
            this.spoolLength.Name = "spoolLength";
            this.spoolLength.Size = new System.Drawing.Size(411, 20);
            this.spoolLength.StyleController = this.layoutControl1;
            this.spoolLength.TabIndex = 16;
            // 
            // cutButton
            // 
            this.cutButton.Location = new System.Drawing.Point(130, 401);
            this.cutButton.Name = "cutButton";
            this.cutButton.Size = new System.Drawing.Size(638, 22);
            this.cutButton.StyleController = this.layoutControl1;
            this.cutButton.TabIndex = 43;
            this.cutButton.Text = "Отрезать";
            // 
            // pipeLength
            // 
            this.pipeLength.Location = new System.Drawing.Point(44, 192);
            this.pipeLength.Name = "pipeLength";
            this.pipeLength.Properties.ReadOnly = true;
            this.pipeLength.Size = new System.Drawing.Size(437, 20);
            this.pipeLength.StyleController = this.layoutControl1;
            this.pipeLength.TabIndex = 13;
            // 
            // spoolNumber
            // 
            this.spoolNumber.Location = new System.Drawing.Point(113, 121);
            this.spoolNumber.Name = "spoolNumber";
            this.spoolNumber.Size = new System.Drawing.Size(795, 20);
            this.spoolNumber.StyleController = this.layoutControl1;
            this.spoolNumber.TabIndex = 41;
            // 
            // pipeNumber
            // 
            this.pipeNumber.Location = new System.Drawing.Point(113, 27);
            this.pipeNumber.Name = "pipeNumber";
            this.pipeNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.pipeNumber.Size = new System.Drawing.Size(690, 20);
            this.pipeNumber.StyleController = this.layoutControl1;
            this.pipeNumber.TabIndex = 38;
            // 
            // layoutRootGrup
            // 
            this.layoutRootGrup.CustomizationFormText = "Root";
            this.layoutRootGrup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutRootGrup.GroupBordersVisible = false;
            this.layoutRootGrup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.pipeNumberLabel,
            this.spoolNumberLabel,
            this.layoutLenghtGroup,
            this.layoutControlItem5,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.layoutControlItem6,
            this.emptySpaceItem3,
            this.emptySpaceItem4,
            this.simpleSeparator1});
            this.layoutRootGrup.Location = new System.Drawing.Point(0, 0);
            this.layoutRootGrup.Name = "layoutRootGrup";
            this.layoutRootGrup.Size = new System.Drawing.Size(940, 450);
            this.layoutRootGrup.Spacing = new DevExpress.XtraLayout.Utils.Padding(20, 20, 15, 15);
            this.layoutRootGrup.Text = "layoutRootGrup";
            this.layoutRootGrup.TextVisible = false;
            // 
            // pipeNumberLabel
            // 
            this.pipeNumberLabel.Control = this.pipeNumber;
            this.pipeNumberLabel.CustomizationFormText = "Номер трубы";
            this.pipeNumberLabel.Location = new System.Drawing.Point(0, 0);
            this.pipeNumberLabel.Name = "pipeNumberLabel";
            this.pipeNumberLabel.Size = new System.Drawing.Size(775, 26);
            this.pipeNumberLabel.Text = "Номер трубы";
            this.pipeNumberLabel.TextSize = new System.Drawing.Size(78, 13);
            // 
            // spoolNumberLabel
            // 
            this.spoolNumberLabel.Control = this.spoolNumber;
            this.spoolNumberLabel.CustomizationFormText = "Номер катушки";
            this.spoolNumberLabel.Location = new System.Drawing.Point(0, 94);
            this.spoolNumberLabel.Name = "spoolNumberLabel";
            this.spoolNumberLabel.Size = new System.Drawing.Size(880, 24);
            this.spoolNumberLabel.Text = "Номер катушки";
            this.spoolNumberLabel.TextSize = new System.Drawing.Size(78, 13);
            // 
            // layoutLenghtGroup
            // 
            this.layoutLenghtGroup.CustomizationFormText = "Длинна";
            this.layoutLenghtGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.pipeLenghtLabel,
            this.spoonLenghtLabel});
            this.layoutLenghtGroup.Location = new System.Drawing.Point(0, 118);
            this.layoutLenghtGroup.Name = "layoutLenghtGroup";
            this.layoutLenghtGroup.Size = new System.Drawing.Size(880, 84);
            this.layoutLenghtGroup.Text = "Длинна";
            // 
            // pipeLenghtLabel
            // 
            this.pipeLenghtLabel.Control = this.pipeLength;
            this.pipeLenghtLabel.CustomizationFormText = "Труба";
            this.pipeLenghtLabel.Location = new System.Drawing.Point(0, 0);
            this.pipeLenghtLabel.Name = "pipeLenghtLabel";
            this.pipeLenghtLabel.Size = new System.Drawing.Size(441, 41);
            this.pipeLenghtLabel.Text = "Труба";
            this.pipeLenghtLabel.TextLocation = DevExpress.Utils.Locations.Top;
            this.pipeLenghtLabel.TextSize = new System.Drawing.Size(78, 13);
            // 
            // spoonLenghtLabel
            // 
            this.spoonLenghtLabel.Control = this.spoolLength;
            this.spoonLenghtLabel.CustomizationFormText = "Катушка";
            this.spoonLenghtLabel.Location = new System.Drawing.Point(441, 0);
            this.spoonLenghtLabel.MinSize = new System.Drawing.Size(82, 41);
            this.spoonLenghtLabel.Name = "spoonLenghtLabel";
            this.spoonLenghtLabel.Size = new System.Drawing.Size(415, 41);
            this.spoonLenghtLabel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.spoonLenghtLabel.Text = "Катушка";
            this.spoonLenghtLabel.TextLocation = DevExpress.Utils.Locations.Top;
            this.spoonLenghtLabel.TextSize = new System.Drawing.Size(78, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.searchButton;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(777, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(103, 26);
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 26);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(880, 68);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 202);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(880, 172);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.cutButton;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(98, 374);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(642, 26);
            this.layoutControlItem6.Text = "layoutControlItem6";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextToControlDistance = 0;
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3";
            this.emptySpaceItem3.Location = new System.Drawing.Point(740, 374);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(140, 26);
            this.emptySpaceItem3.Text = "emptySpaceItem3";
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.CustomizationFormText = "emptySpaceItem4";
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 374);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(98, 26);
            this.emptySpaceItem4.Text = "emptySpaceItem4";
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.CustomizationFormText = "simpleSeparator1";
            this.simpleSeparator1.Location = new System.Drawing.Point(775, 0);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(2, 26);
            this.simpleSeparator1.Text = "simpleSeparator1";
            // 
            // SpoolsXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 450);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SpoolsXtraForm";
            this.Text = "Spools";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spoolLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoolNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutRootGrup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeNumberLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoolNumberLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutLenghtGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeLenghtLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoonLenghtLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton searchButton;
        private DevExpress.XtraEditors.ComboBoxEdit pipeNumber;
        private DevExpress.XtraEditors.TextEdit spoolLength;
        private DevExpress.XtraEditors.TextEdit pipeLength;
        private DevExpress.XtraEditors.TextEdit spoolNumber;
        private DevExpress.XtraEditors.SimpleButton cutButton;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutRootGrup;
        private DevExpress.XtraLayout.LayoutControlItem pipeNumberLabel;
        private DevExpress.XtraLayout.LayoutControlItem spoolNumberLabel;
        private DevExpress.XtraLayout.LayoutControlGroup layoutLenghtGroup;
        private DevExpress.XtraLayout.LayoutControlItem pipeLenghtLabel;
        private DevExpress.XtraLayout.LayoutControlItem spoonLenghtLabel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
    }
}