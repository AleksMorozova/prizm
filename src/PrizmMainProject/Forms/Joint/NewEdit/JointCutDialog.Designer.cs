namespace Prizm.Main.Forms.Joint
{
    partial class JointCutDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JointCutDialog));
            this.jointCutDialogLayout = new DevExpress.XtraLayout.LayoutControl();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.secondJoinedPartLength = new DevExpress.XtraEditors.TextEdit();
            this.firstJoinedPartLength = new DevExpress.XtraEditors.TextEdit();
            this.secondJoinedPartNumber = new DevExpress.XtraEditors.TextEdit();
            this.firstJoinedPartNumber = new DevExpress.XtraEditors.TextEdit();
            this.cutJointButton = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.underSecondPartEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.underFirstPartEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.firstJoinedPartGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.firstJoinedPartLengthLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.firstJoinedPartNumberLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.betweenFirstEmptySpaceI = new DevExpress.XtraLayout.EmptySpaceItem();
            this.secondJoinedPartGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.secondJoinedPartNumberLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.betweenSecondEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.secondJoinedPartLengthLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.jointCutDialogLayout)).BeginInit();
            this.jointCutDialogLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secondJoinedPartLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstJoinedPartLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondJoinedPartNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstJoinedPartNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.underSecondPartEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.underFirstPartEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstJoinedPartGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstJoinedPartLengthLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstJoinedPartNumberLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betweenFirstEmptySpaceI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondJoinedPartGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondJoinedPartNumberLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betweenSecondEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondJoinedPartLengthLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // jointCutDialogLayout
            // 
            this.jointCutDialogLayout.Controls.Add(this.cancelButton);
            this.jointCutDialogLayout.Controls.Add(this.secondJoinedPartLength);
            this.jointCutDialogLayout.Controls.Add(this.firstJoinedPartLength);
            this.jointCutDialogLayout.Controls.Add(this.secondJoinedPartNumber);
            this.jointCutDialogLayout.Controls.Add(this.firstJoinedPartNumber);
            this.jointCutDialogLayout.Controls.Add(this.cutJointButton);
            this.jointCutDialogLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jointCutDialogLayout.Location = new System.Drawing.Point(0, 0);
            this.jointCutDialogLayout.Name = "jointCutDialogLayout";
            this.jointCutDialogLayout.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray;
            this.jointCutDialogLayout.OptionsPrint.AppearanceGroupCaption.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.jointCutDialogLayout.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = true;
            this.jointCutDialogLayout.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
            this.jointCutDialogLayout.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = true;
            this.jointCutDialogLayout.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.jointCutDialogLayout.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.jointCutDialogLayout.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = true;
            this.jointCutDialogLayout.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.jointCutDialogLayout.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.jointCutDialogLayout.Root = this.Root;
            this.jointCutDialogLayout.Size = new System.Drawing.Size(352, 226);
            this.jointCutDialogLayout.TabIndex = 0;
            this.jointCutDialogLayout.Text = "layoutControl1";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelButton.Image")));
            this.cancelButton.Location = new System.Drawing.Point(243, 192);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(97, 22);
            this.cancelButton.StyleController = this.jointCutDialogLayout;
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Отмена";
            // 
            // secondJoinedPartLength
            // 
            this.secondJoinedPartLength.Location = new System.Drawing.Point(232, 156);
            this.secondJoinedPartLength.Name = "secondJoinedPartLength";
            this.secondJoinedPartLength.Size = new System.Drawing.Size(96, 20);
            this.secondJoinedPartLength.StyleController = this.jointCutDialogLayout;
            this.secondJoinedPartLength.TabIndex = 8;
            // 
            // firstJoinedPartLength
            // 
            this.firstJoinedPartLength.Location = new System.Drawing.Point(232, 59);
            this.firstJoinedPartLength.Name = "firstJoinedPartLength";
            this.firstJoinedPartLength.Size = new System.Drawing.Size(96, 20);
            this.firstJoinedPartLength.StyleController = this.jointCutDialogLayout;
            this.firstJoinedPartLength.TabIndex = 7;
            // 
            // secondJoinedPartNumber
            // 
            this.secondJoinedPartNumber.Location = new System.Drawing.Point(24, 156);
            this.secondJoinedPartNumber.Name = "secondJoinedPartNumber";
            this.secondJoinedPartNumber.Properties.ReadOnly = true;
            this.secondJoinedPartNumber.Size = new System.Drawing.Size(146, 20);
            this.secondJoinedPartNumber.StyleController = this.jointCutDialogLayout;
            this.secondJoinedPartNumber.TabIndex = 6;
            // 
            // firstJoinedPartNumber
            // 
            this.firstJoinedPartNumber.Location = new System.Drawing.Point(24, 59);
            this.firstJoinedPartNumber.Name = "firstJoinedPartNumber";
            this.firstJoinedPartNumber.Properties.ReadOnly = true;
            this.firstJoinedPartNumber.Size = new System.Drawing.Size(146, 20);
            this.firstJoinedPartNumber.StyleController = this.jointCutDialogLayout;
            this.firstJoinedPartNumber.TabIndex = 5;
            // 
            // cutJointButton
            // 
            this.cutJointButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cutJointButton.Image = ((System.Drawing.Image)(resources.GetObject("cutJointButton.Image")));
            this.cutJointButton.Location = new System.Drawing.Point(143, 192);
            this.cutJointButton.Name = "cutJointButton";
            this.cutJointButton.Size = new System.Drawing.Size(96, 22);
            this.cutJointButton.StyleController = this.jointCutDialogLayout;
            this.cutJointButton.TabIndex = 4;
            this.cutJointButton.Text = "Вырезать";
            // 
            // Root
            // 
            this.Root.CustomizationFormText = "Root";
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.underSecondPartEmptySpace,
            this.underFirstPartEmptySpace,
            this.firstJoinedPartGroup,
            this.secondJoinedPartGroup,
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(352, 226);
            this.Root.Text = "Root";
            this.Root.TextVisible = false;
            // 
            // underSecondPartEmptySpace
            // 
            this.underSecondPartEmptySpace.AllowHotTrack = false;
            this.underSecondPartEmptySpace.CustomizationFormText = "underSecondPartEmptySpace";
            this.underSecondPartEmptySpace.Location = new System.Drawing.Point(0, 180);
            this.underSecondPartEmptySpace.MinSize = new System.Drawing.Size(104, 24);
            this.underSecondPartEmptySpace.Name = "underSecondPartEmptySpace";
            this.underSecondPartEmptySpace.Size = new System.Drawing.Size(131, 26);
            this.underSecondPartEmptySpace.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.underSecondPartEmptySpace.Text = "underSecondPartEmptySpace";
            this.underSecondPartEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // underFirstPartEmptySpace
            // 
            this.underFirstPartEmptySpace.AllowHotTrack = false;
            this.underFirstPartEmptySpace.CustomizationFormText = "underFirstPartEmptySpace";
            this.underFirstPartEmptySpace.Location = new System.Drawing.Point(0, 83);
            this.underFirstPartEmptySpace.Name = "underFirstPartEmptySpace";
            this.underFirstPartEmptySpace.Size = new System.Drawing.Size(332, 14);
            this.underFirstPartEmptySpace.Text = "underFirstPartEmptySpace";
            this.underFirstPartEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // firstJoinedPartGroup
            // 
            this.firstJoinedPartGroup.CustomizationFormText = "Первый элемент";
            this.firstJoinedPartGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.firstJoinedPartLengthLayout,
            this.firstJoinedPartNumberLayout,
            this.betweenFirstEmptySpaceI});
            this.firstJoinedPartGroup.Location = new System.Drawing.Point(0, 0);
            this.firstJoinedPartGroup.Name = "firstJoinedPartGroup";
            this.firstJoinedPartGroup.Size = new System.Drawing.Size(332, 83);
            this.firstJoinedPartGroup.Text = "Первый элемент";
            // 
            // firstJoinedPartLengthLayout
            // 
            this.firstJoinedPartLengthLayout.Control = this.firstJoinedPartLength;
            this.firstJoinedPartLengthLayout.CustomizationFormText = "Длина, мм";
            this.firstJoinedPartLengthLayout.Location = new System.Drawing.Point(208, 0);
            this.firstJoinedPartLengthLayout.MaxSize = new System.Drawing.Size(100, 0);
            this.firstJoinedPartLengthLayout.MinSize = new System.Drawing.Size(100, 40);
            this.firstJoinedPartLengthLayout.Name = "firstJoinedPartLengthLayout";
            this.firstJoinedPartLengthLayout.Size = new System.Drawing.Size(100, 40);
            this.firstJoinedPartLengthLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.firstJoinedPartLengthLayout.Text = "Длина, мм";
            this.firstJoinedPartLengthLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.firstJoinedPartLengthLayout.TextSize = new System.Drawing.Size(51, 13);
            // 
            // firstJoinedPartNumberLayout
            // 
            this.firstJoinedPartNumberLayout.Control = this.firstJoinedPartNumber;
            this.firstJoinedPartNumberLayout.CustomizationFormText = "Первый элемент";
            this.firstJoinedPartNumberLayout.Location = new System.Drawing.Point(0, 0);
            this.firstJoinedPartNumberLayout.MaxSize = new System.Drawing.Size(150, 40);
            this.firstJoinedPartNumberLayout.MinSize = new System.Drawing.Size(150, 40);
            this.firstJoinedPartNumberLayout.Name = "firstJoinedPartNumberLayout";
            this.firstJoinedPartNumberLayout.Size = new System.Drawing.Size(150, 40);
            this.firstJoinedPartNumberLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.firstJoinedPartNumberLayout.Text = "Номер";
            this.firstJoinedPartNumberLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.firstJoinedPartNumberLayout.TextSize = new System.Drawing.Size(51, 13);
            // 
            // betweenFirstEmptySpaceI
            // 
            this.betweenFirstEmptySpaceI.AllowHotTrack = false;
            this.betweenFirstEmptySpaceI.CustomizationFormText = "betweenFirstEmptySpaceI";
            this.betweenFirstEmptySpaceI.Location = new System.Drawing.Point(150, 0);
            this.betweenFirstEmptySpaceI.Name = "betweenFirstEmptySpaceI";
            this.betweenFirstEmptySpaceI.Size = new System.Drawing.Size(58, 40);
            this.betweenFirstEmptySpaceI.Text = "betweenFirstEmptySpaceI";
            this.betweenFirstEmptySpaceI.TextSize = new System.Drawing.Size(0, 0);
            // 
            // secondJoinedPartGroup
            // 
            this.secondJoinedPartGroup.CustomizationFormText = "Второй элемент";
            this.secondJoinedPartGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.secondJoinedPartNumberLayout,
            this.betweenSecondEmptySpace,
            this.secondJoinedPartLengthLayout});
            this.secondJoinedPartGroup.Location = new System.Drawing.Point(0, 97);
            this.secondJoinedPartGroup.Name = "secondJoinedPartGroup";
            this.secondJoinedPartGroup.Size = new System.Drawing.Size(332, 83);
            this.secondJoinedPartGroup.Text = "Второй элемент";
            // 
            // secondJoinedPartNumberLayout
            // 
            this.secondJoinedPartNumberLayout.Control = this.secondJoinedPartNumber;
            this.secondJoinedPartNumberLayout.CustomizationFormText = "Второй элемент";
            this.secondJoinedPartNumberLayout.Location = new System.Drawing.Point(0, 0);
            this.secondJoinedPartNumberLayout.MaxSize = new System.Drawing.Size(150, 40);
            this.secondJoinedPartNumberLayout.MinSize = new System.Drawing.Size(150, 40);
            this.secondJoinedPartNumberLayout.Name = "secondJoinedPartNumberLayout";
            this.secondJoinedPartNumberLayout.Size = new System.Drawing.Size(150, 40);
            this.secondJoinedPartNumberLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.secondJoinedPartNumberLayout.Text = "Номер";
            this.secondJoinedPartNumberLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.secondJoinedPartNumberLayout.TextSize = new System.Drawing.Size(51, 13);
            // 
            // betweenSecondEmptySpace
            // 
            this.betweenSecondEmptySpace.AllowHotTrack = false;
            this.betweenSecondEmptySpace.CustomizationFormText = "betweenSecondEmptySpace";
            this.betweenSecondEmptySpace.Location = new System.Drawing.Point(150, 0);
            this.betweenSecondEmptySpace.Name = "betweenSecondEmptySpace";
            this.betweenSecondEmptySpace.Size = new System.Drawing.Size(58, 40);
            this.betweenSecondEmptySpace.Text = "betweenSecondEmptySpace";
            this.betweenSecondEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // secondJoinedPartLengthLayout
            // 
            this.secondJoinedPartLengthLayout.Control = this.secondJoinedPartLength;
            this.secondJoinedPartLengthLayout.CustomizationFormText = "Длина, мм";
            this.secondJoinedPartLengthLayout.Location = new System.Drawing.Point(208, 0);
            this.secondJoinedPartLengthLayout.MaxSize = new System.Drawing.Size(100, 40);
            this.secondJoinedPartLengthLayout.MinSize = new System.Drawing.Size(100, 40);
            this.secondJoinedPartLengthLayout.Name = "secondJoinedPartLengthLayout";
            this.secondJoinedPartLengthLayout.Size = new System.Drawing.Size(100, 40);
            this.secondJoinedPartLengthLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.secondJoinedPartLengthLayout.Text = "Длина, мм";
            this.secondJoinedPartLengthLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.secondJoinedPartLengthLayout.TextSize = new System.Drawing.Size(51, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cutJointButton;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(131, 180);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(100, 26);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(100, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(100, 26);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cancelButton;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(231, 180);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(101, 26);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(101, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(101, 26);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // JointCutDialog
            // 
            this.AcceptButton = this.cutJointButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(352, 226);
            this.Controls.Add(this.jointCutDialogLayout);
            this.Name = "JointCutDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Вырезка стыка";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.JointCutDialog_FormClosed);
            this.Load += new System.EventHandler(this.JointCutDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jointCutDialogLayout)).EndInit();
            this.jointCutDialogLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.secondJoinedPartLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstJoinedPartLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondJoinedPartNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstJoinedPartNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.underSecondPartEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.underFirstPartEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstJoinedPartGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstJoinedPartLengthLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstJoinedPartNumberLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betweenFirstEmptySpaceI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondJoinedPartGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondJoinedPartNumberLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betweenSecondEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondJoinedPartLengthLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl jointCutDialogLayout;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit secondJoinedPartLength;
        private DevExpress.XtraEditors.TextEdit firstJoinedPartLength;
        private DevExpress.XtraEditors.TextEdit secondJoinedPartNumber;
        private DevExpress.XtraEditors.TextEdit firstJoinedPartNumber;
        private DevExpress.XtraEditors.SimpleButton cutJointButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem underSecondPartEmptySpace;
        private DevExpress.XtraLayout.EmptySpaceItem underFirstPartEmptySpace;
        private DevExpress.XtraLayout.EmptySpaceItem betweenFirstEmptySpaceI;
        private DevExpress.XtraLayout.LayoutControlItem firstJoinedPartLengthLayout;
        private DevExpress.XtraLayout.LayoutControlItem firstJoinedPartNumberLayout;
        private DevExpress.XtraLayout.LayoutControlItem secondJoinedPartLengthLayout;
        private DevExpress.XtraLayout.EmptySpaceItem betweenSecondEmptySpace;
        private DevExpress.XtraLayout.LayoutControlItem secondJoinedPartNumberLayout;
        private DevExpress.XtraLayout.LayoutControlGroup firstJoinedPartGroup;
        private DevExpress.XtraLayout.LayoutControlGroup secondJoinedPartGroup;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}