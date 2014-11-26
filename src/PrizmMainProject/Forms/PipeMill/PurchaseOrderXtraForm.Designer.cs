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
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.purchaseOrderDate = new DevExpress.XtraEditors.DateEdit();
            this.purchaseOrderNumber = new DevExpress.XtraEditors.TextEdit();
            this.purchaseOrderLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.purchaseOrderNumberLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.saveButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.purchaseOrderDateLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.saveButtonEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.generalEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderLayout)).BeginInit();
            this.purchaseOrderLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderNumberLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDateLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButtonEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalEmptySpace)).BeginInit();
            this.SuspendLayout();
            // 
            // purchaseOrderLayout
            // 
            this.purchaseOrderLayout.Controls.Add(this.saveButton);
            this.purchaseOrderLayout.Controls.Add(this.purchaseOrderDate);
            this.purchaseOrderLayout.Controls.Add(this.purchaseOrderNumber);
            this.purchaseOrderLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purchaseOrderLayout.Location = new System.Drawing.Point(0, 0);
            this.purchaseOrderLayout.Name = "purchaseOrderLayout";
            this.purchaseOrderLayout.Root = this.purchaseOrderLayoutGroup;
            this.purchaseOrderLayout.Size = new System.Drawing.Size(389, 167);
            this.purchaseOrderLayout.TabIndex = 0;
            this.purchaseOrderLayout.Text = "layoutControl1";
            // 
            // saveButton
            // 
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.Location = new System.Drawing.Point(247, 87);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(115, 22);
            this.saveButton.StyleController = this.purchaseOrderLayout;
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Сохранить";
            // 
            // purchaseOrderDate
            // 
            this.purchaseOrderDate.EditValue = null;
            this.purchaseOrderDate.Location = new System.Drawing.Point(211, 43);
            this.purchaseOrderDate.Name = "purchaseOrderDate";
            this.purchaseOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.purchaseOrderDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.purchaseOrderDate.Size = new System.Drawing.Size(151, 20);
            this.purchaseOrderDate.StyleController = this.purchaseOrderLayout;
            this.purchaseOrderDate.TabIndex = 5;
            // 
            // purchaseOrderNumber
            // 
            this.purchaseOrderNumber.Location = new System.Drawing.Point(27, 43);
            this.purchaseOrderNumber.Name = "purchaseOrderNumber";
            this.purchaseOrderNumber.Size = new System.Drawing.Size(150, 20);
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
            this.saveButtonLayout,
            this.purchaseOrderDateLayout,
            this.saveButtonEmptySpace,
            this.generalEmptySpace});
            this.purchaseOrderLayoutGroup.Location = new System.Drawing.Point(0, 0);
            this.purchaseOrderLayoutGroup.Name = "purchaseOrderLayoutGroup";
            this.purchaseOrderLayoutGroup.Size = new System.Drawing.Size(389, 167);
            this.purchaseOrderLayoutGroup.Text = "purchaseOrderLayoutGroup";
            this.purchaseOrderLayoutGroup.TextVisible = false;
            // 
            // purchaseOrderNumberLayout
            // 
            this.purchaseOrderNumberLayout.Control = this.purchaseOrderNumber;
            this.purchaseOrderNumberLayout.CustomizationFormText = "Номер Наряд заказа";
            this.purchaseOrderNumberLayout.Location = new System.Drawing.Point(0, 0);
            this.purchaseOrderNumberLayout.Name = "purchaseOrderNumberLayout";
            this.purchaseOrderNumberLayout.Size = new System.Drawing.Size(184, 70);
            this.purchaseOrderNumberLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 15, 15);
            this.purchaseOrderNumberLayout.Text = "Номер Наряд заказа";
            this.purchaseOrderNumberLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.purchaseOrderNumberLayout.TextSize = new System.Drawing.Size(103, 13);
            // 
            // saveButtonLayout
            // 
            this.saveButtonLayout.Control = this.saveButton;
            this.saveButtonLayout.CustomizationFormText = "saveButtonLayout";
            this.saveButtonLayout.Location = new System.Drawing.Point(230, 70);
            this.saveButtonLayout.Name = "saveButtonLayout";
            this.saveButtonLayout.Size = new System.Drawing.Size(139, 36);
            this.saveButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 15, 5, 5);
            this.saveButtonLayout.Text = "saveButtonLayout";
            this.saveButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.saveButtonLayout.TextToControlDistance = 0;
            this.saveButtonLayout.TextVisible = false;
            // 
            // purchaseOrderDateLayout
            // 
            this.purchaseOrderDateLayout.Control = this.purchaseOrderDate;
            this.purchaseOrderDateLayout.CustomizationFormText = "Дата наряд-заказа";
            this.purchaseOrderDateLayout.Location = new System.Drawing.Point(184, 0);
            this.purchaseOrderDateLayout.Name = "purchaseOrderDateLayout";
            this.purchaseOrderDateLayout.Size = new System.Drawing.Size(185, 70);
            this.purchaseOrderDateLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 15, 15);
            this.purchaseOrderDateLayout.Text = "Дата наряд-заказа";
            this.purchaseOrderDateLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.purchaseOrderDateLayout.TextSize = new System.Drawing.Size(103, 13);
            // 
            // saveButtonEmptySpace
            // 
            this.saveButtonEmptySpace.AllowHotTrack = false;
            this.saveButtonEmptySpace.CustomizationFormText = "saveButtonEmptySpace";
            this.saveButtonEmptySpace.Location = new System.Drawing.Point(0, 70);
            this.saveButtonEmptySpace.Name = "saveButtonEmptySpace";
            this.saveButtonEmptySpace.Size = new System.Drawing.Size(230, 36);
            this.saveButtonEmptySpace.Text = "saveButtonEmptySpace";
            this.saveButtonEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // generalEmptySpace
            // 
            this.generalEmptySpace.AllowHotTrack = false;
            this.generalEmptySpace.CustomizationFormText = "generalEmptySpace";
            this.generalEmptySpace.Location = new System.Drawing.Point(0, 106);
            this.generalEmptySpace.Name = "generalEmptySpace";
            this.generalEmptySpace.Size = new System.Drawing.Size(369, 41);
            this.generalEmptySpace.Text = "generalEmptySpace";
            this.generalEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // PurchaseOrderXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 167);
            this.Controls.Add(this.purchaseOrderLayout);
            this.Name = "PurchaseOrderXtraForm";
            this.Text = "Наряд-заказ";
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderLayout)).EndInit();
            this.purchaseOrderLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderNumberLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDateLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButtonEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalEmptySpace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl purchaseOrderLayout;
        private DevExpress.XtraLayout.LayoutControlGroup purchaseOrderLayoutGroup;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.DateEdit purchaseOrderDate;
        private DevExpress.XtraEditors.TextEdit purchaseOrderNumber;
        private DevExpress.XtraLayout.LayoutControlItem purchaseOrderNumberLayout;
        private DevExpress.XtraLayout.LayoutControlItem saveButtonLayout;
        private DevExpress.XtraLayout.LayoutControlItem purchaseOrderDateLayout;
        private DevExpress.XtraLayout.EmptySpaceItem saveButtonEmptySpace;
        private DevExpress.XtraLayout.EmptySpaceItem generalEmptySpace;
    }
}