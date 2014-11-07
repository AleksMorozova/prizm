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
            this.mainLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.spoolLength = new DevExpress.XtraEditors.TextEdit();
            this.cutButton = new DevExpress.XtraEditors.SimpleButton();
            this.pipeLength = new DevExpress.XtraEditors.TextEdit();
            this.spoolNumber = new DevExpress.XtraEditors.TextEdit();
            this.pipeNumber = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutRootGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.pipeNumberLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.spoolNumberLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutlengthGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.pipelengthLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.spoonlengthLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.searchLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.pipeEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lengthEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.cutLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.cutRightEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.cutLeftEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.upperSearchEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.mainLayoutControl)).BeginInit();
            this.mainLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spoolLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoolNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutRootGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeNumberLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoolNumberLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutlengthGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipelengthLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoonlengthLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cutLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cutRightEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cutLeftEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperSearchEmptySpace)).BeginInit();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(822, 48);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 7);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(71, 22);
            this.searchButton.StyleController = this.mainLayoutControl;
            this.searchButton.TabIndex = 39;
            this.searchButton.Text = "Поиск";
            // 
            // mainLayoutControl
            // 
            this.mainLayoutControl.Controls.Add(this.spoolLength);
            this.mainLayoutControl.Controls.Add(this.cutButton);
            this.mainLayoutControl.Controls.Add(this.pipeLength);
            this.mainLayoutControl.Controls.Add(this.spoolNumber);
            this.mainLayoutControl.Controls.Add(this.searchButton);
            this.mainLayoutControl.Controls.Add(this.pipeNumber);
            this.mainLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutControl.Name = "mainLayoutControl";
            this.mainLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(340, 38, 250, 350);
            this.mainLayoutControl.Root = this.layoutRootGroup;
            this.mainLayoutControl.Size = new System.Drawing.Size(940, 450);
            this.mainLayoutControl.TabIndex = 44;
            this.mainLayoutControl.Text = "layoutControl1";
            // 
            // spoolLength
            // 
            this.spoolLength.Location = new System.Drawing.Point(499, 259);
            this.spoolLength.Name = "spoolLength";
            this.spoolLength.Size = new System.Drawing.Size(371, 20);
            this.spoolLength.StyleController = this.mainLayoutControl;
            this.spoolLength.TabIndex = 16;
            // 
            // cutButton
            // 
            this.cutButton.Location = new System.Drawing.Point(130, 401);
            this.cutButton.Name = "cutButton";
            this.cutButton.Size = new System.Drawing.Size(638, 22);
            this.cutButton.StyleController = this.mainLayoutControl;
            this.cutButton.TabIndex = 43;
            this.cutButton.Text = "Отрезать";
            // 
            // pipeLength
            // 
            this.pipeLength.Location = new System.Drawing.Point(70, 259);
            this.pipeLength.Name = "pipeLength";
            this.pipeLength.Properties.ReadOnly = true;
            this.pipeLength.Size = new System.Drawing.Size(395, 20);
            this.pipeLength.StyleController = this.mainLayoutControl;
            this.pipeLength.TabIndex = 13;
            // 
            // spoolNumber
            // 
            this.spoolNumber.Location = new System.Drawing.Point(47, 163);
            this.spoolNumber.Name = "spoolNumber";
            this.spoolNumber.Size = new System.Drawing.Size(846, 20);
            this.spoolNumber.StyleController = this.mainLayoutControl;
            this.spoolNumber.TabIndex = 41;
            // 
            // pipeNumber
            // 
            this.pipeNumber.Location = new System.Drawing.Point(47, 50);
            this.pipeNumber.Name = "pipeNumber";
            this.pipeNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.pipeNumber.Size = new System.Drawing.Size(741, 20);
            this.pipeNumber.StyleController = this.mainLayoutControl;
            this.pipeNumber.TabIndex = 38;
            // 
            // layoutRootGroup
            // 
            this.layoutRootGroup.CustomizationFormText = "Root";
            this.layoutRootGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutRootGroup.GroupBordersVisible = false;
            this.layoutRootGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.pipeNumberLabel,
            this.spoolNumberLabel,
            this.layoutlengthGroup,
            this.searchLayoutControlItem,
            this.pipeEmptySpace,
            this.lengthEmptySpace,
            this.cutLayoutControlItem,
            this.cutRightEmptySpace,
            this.cutLeftEmptySpace,
            this.upperSearchEmptySpace});
            this.layoutRootGroup.Location = new System.Drawing.Point(0, 0);
            this.layoutRootGroup.Name = "layoutRootGroup";
            this.layoutRootGroup.Size = new System.Drawing.Size(940, 450);
            this.layoutRootGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(20, 20, 15, 15);
            this.layoutRootGroup.Text = "layoutRootGroup";
            this.layoutRootGroup.TextVisible = false;
            // 
            // pipeNumberLabel
            // 
            this.pipeNumberLabel.Control = this.pipeNumber;
            this.pipeNumberLabel.CustomizationFormText = "Номер трубы";
            this.pipeNumberLabel.Location = new System.Drawing.Point(0, 0);
            this.pipeNumberLabel.Name = "pipeNumberLabel";
            this.pipeNumberLabel.Size = new System.Drawing.Size(775, 54);
            this.pipeNumberLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.pipeNumberLabel.Text = "Номер трубы";
            this.pipeNumberLabel.TextLocation = DevExpress.Utils.Locations.Top;
            this.pipeNumberLabel.TextSize = new System.Drawing.Size(78, 13);
            // 
            // spoolNumberLabel
            // 
            this.spoolNumberLabel.Control = this.spoolNumber;
            this.spoolNumberLabel.CustomizationFormText = "Номер катушки";
            this.spoolNumberLabel.Location = new System.Drawing.Point(0, 113);
            this.spoolNumberLabel.Name = "spoolNumberLabel";
            this.spoolNumberLabel.Size = new System.Drawing.Size(880, 54);
            this.spoolNumberLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.spoolNumberLabel.Text = "Номер катушки";
            this.spoolNumberLabel.TextLocation = DevExpress.Utils.Locations.Top;
            this.spoolNumberLabel.TextSize = new System.Drawing.Size(78, 13);
            // 
            // layoutlengthGroup
            // 
            this.layoutlengthGroup.CustomizationFormText = "Длинна";
            this.layoutlengthGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.pipelengthLabel,
            this.spoonlengthLabel});
            this.layoutlengthGroup.Location = new System.Drawing.Point(0, 167);
            this.layoutlengthGroup.Name = "layoutlengthGroup";
            this.layoutlengthGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutlengthGroup.Size = new System.Drawing.Size(880, 119);
            this.layoutlengthGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(20, 20, 20, 20);
            this.layoutlengthGroup.Text = "Длинна";
            // 
            // pipelengthLabel
            // 
            this.pipelengthLabel.Control = this.pipeLength;
            this.pipelengthLabel.CustomizationFormText = "Труба";
            this.pipelengthLabel.Location = new System.Drawing.Point(0, 0);
            this.pipelengthLabel.Name = "pipelengthLabel";
            this.pipelengthLabel.Size = new System.Drawing.Size(429, 54);
            this.pipelengthLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.pipelengthLabel.Text = "Труба";
            this.pipelengthLabel.TextLocation = DevExpress.Utils.Locations.Top;
            this.pipelengthLabel.TextSize = new System.Drawing.Size(78, 13);
            // 
            // spoonlengthLabel
            // 
            this.spoonlengthLabel.Control = this.spoolLength;
            this.spoonlengthLabel.CustomizationFormText = "Катушка";
            this.spoonlengthLabel.Location = new System.Drawing.Point(429, 0);
            this.spoonlengthLabel.MinSize = new System.Drawing.Size(82, 41);
            this.spoonlengthLabel.Name = "spoonlengthLabel";
            this.spoonlengthLabel.Size = new System.Drawing.Size(405, 54);
            this.spoonlengthLabel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.spoonlengthLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.spoonlengthLabel.Text = "Катушка";
            this.spoonlengthLabel.TextLocation = DevExpress.Utils.Locations.Top;
            this.spoonlengthLabel.TextSize = new System.Drawing.Size(78, 13);
            // 
            // searchLayoutControlItem
            // 
            this.searchLayoutControlItem.Control = this.searchButton;
            this.searchLayoutControlItem.CustomizationFormText = "searchLayoutControlItem";
            this.searchLayoutControlItem.Location = new System.Drawing.Point(775, 14);
            this.searchLayoutControlItem.Name = "searchLayoutControlItem";
            this.searchLayoutControlItem.Size = new System.Drawing.Size(105, 40);
            this.searchLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.searchLayoutControlItem.Text = "searchLayoutControlItem";
            this.searchLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.searchLayoutControlItem.TextToControlDistance = 0;
            this.searchLayoutControlItem.TextVisible = false;
            // 
            // pipeEmptySpace
            // 
            this.pipeEmptySpace.AllowHotTrack = false;
            this.pipeEmptySpace.CustomizationFormText = "pipeEmptySpace";
            this.pipeEmptySpace.Location = new System.Drawing.Point(0, 54);
            this.pipeEmptySpace.Name = "pipeEmptySpace";
            this.pipeEmptySpace.Size = new System.Drawing.Size(880, 59);
            this.pipeEmptySpace.Text = "pipeEmptySpace";
            this.pipeEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lengthEmptySpace
            // 
            this.lengthEmptySpace.AllowHotTrack = false;
            this.lengthEmptySpace.CustomizationFormText = "lengthEmptySpace";
            this.lengthEmptySpace.Location = new System.Drawing.Point(0, 286);
            this.lengthEmptySpace.Name = "lengthEmptySpace";
            this.lengthEmptySpace.Size = new System.Drawing.Size(880, 88);
            this.lengthEmptySpace.Text = "lengthEmptySpace";
            this.lengthEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // cutLayoutControlItem
            // 
            this.cutLayoutControlItem.Control = this.cutButton;
            this.cutLayoutControlItem.CustomizationFormText = "cutLayoutControlItem";
            this.cutLayoutControlItem.Location = new System.Drawing.Point(98, 374);
            this.cutLayoutControlItem.Name = "cutLayoutControlItem";
            this.cutLayoutControlItem.Size = new System.Drawing.Size(642, 26);
            this.cutLayoutControlItem.Text = "cutLayoutControlItem";
            this.cutLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.cutLayoutControlItem.TextToControlDistance = 0;
            this.cutLayoutControlItem.TextVisible = false;
            // 
            // cutRightEmptySpace
            // 
            this.cutRightEmptySpace.AllowHotTrack = false;
            this.cutRightEmptySpace.CustomizationFormText = "cutRightEmptySpace";
            this.cutRightEmptySpace.Location = new System.Drawing.Point(740, 374);
            this.cutRightEmptySpace.Name = "cutRightEmptySpace";
            this.cutRightEmptySpace.Size = new System.Drawing.Size(140, 26);
            this.cutRightEmptySpace.Text = "cutRightEmptySpace";
            this.cutRightEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // cutLeftEmptySpace
            // 
            this.cutLeftEmptySpace.AllowHotTrack = false;
            this.cutLeftEmptySpace.CustomizationFormText = "cutLeftEmptySpace";
            this.cutLeftEmptySpace.Location = new System.Drawing.Point(0, 374);
            this.cutLeftEmptySpace.Name = "cutLeftEmptySpace";
            this.cutLeftEmptySpace.Size = new System.Drawing.Size(98, 26);
            this.cutLeftEmptySpace.Text = "cutLeftEmptySpace";
            this.cutLeftEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // upperSearchEmptySpace
            // 
            this.upperSearchEmptySpace.AllowHotTrack = false;
            this.upperSearchEmptySpace.CustomizationFormText = "upperSearchEmptySpace";
            this.upperSearchEmptySpace.Location = new System.Drawing.Point(775, 0);
            this.upperSearchEmptySpace.Name = "upperSearchEmptySpace";
            this.upperSearchEmptySpace.Size = new System.Drawing.Size(105, 14);
            this.upperSearchEmptySpace.Text = "upperSearchEmptySpace";
            this.upperSearchEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // SpoolsXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 450);
            this.Controls.Add(this.mainLayoutControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SpoolsXtraForm";
            this.Text = "Spools";
            ((System.ComponentModel.ISupportInitialize)(this.mainLayoutControl)).EndInit();
            this.mainLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spoolLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoolNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutRootGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeNumberLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoolNumberLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutlengthGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipelengthLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoonlengthLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cutLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cutRightEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cutLeftEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperSearchEmptySpace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton searchButton;
        private DevExpress.XtraEditors.ComboBoxEdit pipeNumber;
        private DevExpress.XtraEditors.TextEdit spoolLength;
        private DevExpress.XtraEditors.TextEdit pipeLength;
        private DevExpress.XtraEditors.TextEdit spoolNumber;
        private DevExpress.XtraEditors.SimpleButton cutButton;
        private DevExpress.XtraLayout.LayoutControl mainLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutRootGroup;
        private DevExpress.XtraLayout.LayoutControlItem pipeNumberLabel;
        private DevExpress.XtraLayout.LayoutControlItem spoolNumberLabel;
        private DevExpress.XtraLayout.LayoutControlGroup layoutlengthGroup;
        private DevExpress.XtraLayout.LayoutControlItem pipelengthLabel;
        private DevExpress.XtraLayout.LayoutControlItem spoonlengthLabel;
        private DevExpress.XtraLayout.LayoutControlItem searchLayoutControlItem;
        private DevExpress.XtraLayout.EmptySpaceItem pipeEmptySpace;
        private DevExpress.XtraLayout.EmptySpaceItem lengthEmptySpace;
        private DevExpress.XtraLayout.LayoutControlItem cutLayoutControlItem;
        private DevExpress.XtraLayout.EmptySpaceItem cutRightEmptySpace;
        private DevExpress.XtraLayout.EmptySpaceItem cutLeftEmptySpace;
        private DevExpress.XtraLayout.EmptySpaceItem upperSearchEmptySpace;
    }
}