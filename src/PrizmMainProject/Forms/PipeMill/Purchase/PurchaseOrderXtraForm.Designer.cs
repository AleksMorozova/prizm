namespace PrizmMain.Forms.PipeMill
{
    partial class PurchaseOrderXtraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseOrderXtraForm));
            this.purchaseOrderLayout = new DevExpress.XtraLayout.LayoutControl();
            this.purchaseOrderDate = new DevExpress.XtraEditors.DateEdit();
            this.purchaseOrderNumber = new DevExpress.XtraEditors.TextEdit();
            this.purchaseOrderLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.purchaseOrderNumberLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.purchaseOrderDateLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.generalEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.saveButtonLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.canselLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.divideButtonEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.saveButtonEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderLayout)).BeginInit();
            this.purchaseOrderLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderNumberLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDateLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButtonLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canselLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divideButtonEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButtonEmptySpace)).BeginInit();
            this.SuspendLayout();
            // 
            // purchaseOrderLayout
            // 
            this.purchaseOrderLayout.Controls.Add(this.purchaseOrderDate);
            this.purchaseOrderLayout.Controls.Add(this.purchaseOrderNumber);
            this.purchaseOrderLayout.Controls.Add(this.simpleButton1);
            this.purchaseOrderLayout.Controls.Add(this.simpleButton2);
            this.purchaseOrderLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purchaseOrderLayout.Location = new System.Drawing.Point(0, 0);
            this.purchaseOrderLayout.Name = "purchaseOrderLayout";
            this.purchaseOrderLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(694, 114, 250, 350);
            this.purchaseOrderLayout.Root = this.purchaseOrderLayoutGroup;
            this.purchaseOrderLayout.ShowTemplates = true;
            this.purchaseOrderLayout.Size = new System.Drawing.Size(389, 129);
            this.purchaseOrderLayout.TabIndex = 0;
            this.purchaseOrderLayout.Text = "layoutControl1";
            // 
            // purchaseOrderDate
            // 
            this.purchaseOrderDate.EditValue = null;
            this.purchaseOrderDate.Location = new System.Drawing.Point(278, 35);
            this.purchaseOrderDate.Name = "purchaseOrderDate";
            this.purchaseOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.purchaseOrderDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.purchaseOrderDate.Size = new System.Drawing.Size(92, 20);
            this.purchaseOrderDate.StyleController = this.purchaseOrderLayout;
            this.purchaseOrderDate.TabIndex = 5;
            // 
            // purchaseOrderNumber
            // 
            this.purchaseOrderNumber.Location = new System.Drawing.Point(19, 35);
            this.purchaseOrderNumber.Name = "purchaseOrderNumber";
            this.purchaseOrderNumber.Size = new System.Drawing.Size(241, 20);
            this.purchaseOrderNumber.StyleController = this.purchaseOrderLayout;
            this.purchaseOrderNumber.TabIndex = 4;
            // 
            // purchaseOrderLayoutGroup
            // 
            this.purchaseOrderLayoutGroup.CustomizationFormText = "purchaseOrderLayoutGroup";
            this.purchaseOrderLayoutGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.purchaseOrderLayoutGroup.GroupBordersVisible = false;
            this.purchaseOrderLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.purchaseOrderNumberLayout,
            this.purchaseOrderDateLayout,
            this.saveButtonEmptySpace,
            this.generalEmptySpace,
            this.saveButtonLayoutControl,
            this.canselLayoutControl,
            this.divideButtonEmptySpace});
            this.purchaseOrderLayoutGroup.Location = new System.Drawing.Point(0, 0);
            this.purchaseOrderLayoutGroup.Name = "purchaseOrderLayoutGroup";
            this.purchaseOrderLayoutGroup.Size = new System.Drawing.Size(389, 129);
            this.purchaseOrderLayoutGroup.Text = "purchaseOrderLayoutGroup";
            this.purchaseOrderLayoutGroup.TextVisible = false;
            // 
            // purchaseOrderNumberLayout
            // 
            this.purchaseOrderNumberLayout.Control = this.purchaseOrderNumber;
            this.purchaseOrderNumberLayout.CustomizationFormText = "Номер Наряд заказа";
            this.purchaseOrderNumberLayout.Location = new System.Drawing.Point(0, 0);
            this.purchaseOrderNumberLayout.Name = "purchaseOrderNumberLayout";
            this.purchaseOrderNumberLayout.Size = new System.Drawing.Size(259, 54);
            this.purchaseOrderNumberLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(7, 7, 7, 7);
            this.purchaseOrderNumberLayout.Text = "Номер";
            this.purchaseOrderNumberLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.purchaseOrderNumberLayout.TextSize = new System.Drawing.Size(31, 13);
            // 
            // purchaseOrderDateLayout
            // 
            this.purchaseOrderDateLayout.Control = this.purchaseOrderDate;
            this.purchaseOrderDateLayout.CustomizationFormText = "Дата наряд-заказа";
            this.purchaseOrderDateLayout.Location = new System.Drawing.Point(259, 0);
            this.purchaseOrderDateLayout.Name = "purchaseOrderDateLayout";
            this.purchaseOrderDateLayout.Size = new System.Drawing.Size(110, 54);
            this.purchaseOrderDateLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(7, 7, 7, 7);
            this.purchaseOrderDateLayout.Text = "Дата";
            this.purchaseOrderDateLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.purchaseOrderDateLayout.TextSize = new System.Drawing.Size(31, 13);
            // 
            // generalEmptySpace
            // 
            this.generalEmptySpace.AllowHotTrack = false;
            this.generalEmptySpace.CustomizationFormText = "generalEmptySpace";
            this.generalEmptySpace.Location = new System.Drawing.Point(0, 81);
            this.generalEmptySpace.Name = "generalEmptySpace";
            this.generalEmptySpace.Size = new System.Drawing.Size(369, 28);
            this.generalEmptySpace.Text = "generalEmptySpace";
            this.generalEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // simpleButton1
            // 
            this.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(171, 66);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(96, 23);
            this.simpleButton1.StyleController = this.purchaseOrderLayout;
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Сохранить";
            // 
            // simpleButton2
            // 
            this.simpleButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(281, 66);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(96, 23);
            this.simpleButton2.StyleController = this.purchaseOrderLayout;
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Text = "Отменить";
            // 
            // saveButtonLayoutControl
            // 
            this.saveButtonLayoutControl.Control = this.simpleButton1;
            this.saveButtonLayoutControl.CustomizationFormText = "saveButtonLayoutControl";
            this.saveButtonLayoutControl.Location = new System.Drawing.Point(159, 54);
            this.saveButtonLayoutControl.MaxSize = new System.Drawing.Size(154, 31);
            this.saveButtonLayoutControl.MinSize = new System.Drawing.Size(70, 27);
            this.saveButtonLayoutControl.Name = "saveButtonLayoutControl";
            this.saveButtonLayoutControl.Size = new System.Drawing.Size(100, 27);
            this.saveButtonLayoutControl.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.saveButtonLayoutControl.Text = "saveButtonLayoutControl";
            this.saveButtonLayoutControl.TextSize = new System.Drawing.Size(0, 0);
            this.saveButtonLayoutControl.TextToControlDistance = 0;
            this.saveButtonLayoutControl.TextVisible = false;
            // 
            // canselLayoutControl
            // 
            this.canselLayoutControl.Control = this.simpleButton2;
            this.canselLayoutControl.CustomizationFormText = "canselLayoutControl";
            this.canselLayoutControl.Location = new System.Drawing.Point(269, 54);
            this.canselLayoutControl.MaxSize = new System.Drawing.Size(154, 31);
            this.canselLayoutControl.MinSize = new System.Drawing.Size(70, 27);
            this.canselLayoutControl.Name = "canselLayoutControl";
            this.canselLayoutControl.Size = new System.Drawing.Size(100, 27);
            this.canselLayoutControl.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.canselLayoutControl.Text = "canselLayoutControl";
            this.canselLayoutControl.TextSize = new System.Drawing.Size(0, 0);
            this.canselLayoutControl.TextToControlDistance = 0;
            this.canselLayoutControl.TextVisible = false;
            // 
            // divideButtonEmptySpace
            // 
            this.divideButtonEmptySpace.AllowHotTrack = false;
            this.divideButtonEmptySpace.CustomizationFormText = "divideButtonEmptySpace";
            this.divideButtonEmptySpace.Location = new System.Drawing.Point(259, 54);
            this.divideButtonEmptySpace.MaxSize = new System.Drawing.Size(10, 27);
            this.divideButtonEmptySpace.MinSize = new System.Drawing.Size(10, 27);
            this.divideButtonEmptySpace.Name = "divideButtonEmptySpace";
            this.divideButtonEmptySpace.Size = new System.Drawing.Size(10, 27);
            this.divideButtonEmptySpace.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.divideButtonEmptySpace.Text = "divideButtonEmptySpace";
            this.divideButtonEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // saveButtonEmptySpace
            // 
            this.saveButtonEmptySpace.AllowHotTrack = false;
            this.saveButtonEmptySpace.CustomizationFormText = "saveButtonEmptySpace";
            this.saveButtonEmptySpace.Location = new System.Drawing.Point(0, 54);
            this.saveButtonEmptySpace.Name = "saveButtonEmptySpace";
            this.saveButtonEmptySpace.Size = new System.Drawing.Size(159, 27);
            this.saveButtonEmptySpace.Text = "saveButtonEmptySpace";
            this.saveButtonEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // PurchaseOrderXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 129);
            this.Controls.Add(this.purchaseOrderLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PurchaseOrderXtraForm";
            this.Text = "Наряд-заказ";
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderLayout)).EndInit();
            this.purchaseOrderLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderNumberLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDateLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButtonLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canselLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divideButtonEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButtonEmptySpace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl purchaseOrderLayout;
        private DevExpress.XtraLayout.LayoutControlGroup purchaseOrderLayoutGroup;
        private DevExpress.XtraEditors.DateEdit purchaseOrderDate;
        private DevExpress.XtraEditors.TextEdit purchaseOrderNumber;
        private DevExpress.XtraLayout.LayoutControlItem purchaseOrderNumberLayout;
        private DevExpress.XtraLayout.LayoutControlItem purchaseOrderDateLayout;
        private DevExpress.XtraLayout.EmptySpaceItem generalEmptySpace;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraLayout.EmptySpaceItem saveButtonEmptySpace;
        private DevExpress.XtraLayout.LayoutControlItem saveButtonLayoutControl;
        private DevExpress.XtraLayout.LayoutControlItem canselLayoutControl;
        private DevExpress.XtraLayout.EmptySpaceItem divideButtonEmptySpace;
    }
}