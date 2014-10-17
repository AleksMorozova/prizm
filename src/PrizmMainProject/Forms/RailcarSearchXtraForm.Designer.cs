namespace PrizmMain.Forms
{
    partial class RailcarSearchXtraForm
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
            this.railcarList = new DevExpress.XtraGrid.GridControl();
            this.railcarListView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.railcarNumberGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.shippingDateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.deliveryDateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.editGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.shipButton = new DevExpress.XtraEditors.SimpleButton();
            this.searchButton = new DevExpress.XtraEditors.SimpleButton();
            this.pipeSize = new DevExpress.XtraEditors.ComboBoxEdit();
            this.pipeSizeLabel = new DevExpress.XtraEditors.LabelControl();
            this.certificateNumber = new DevExpress.XtraEditors.TextEdit();
            this.certificateNumberLabel = new DevExpress.XtraEditors.LabelControl();
            this.shippedDate = new DevExpress.XtraEditors.DateEdit();
            this.deliveryDate = new DevExpress.XtraEditors.DateEdit();
            this.shippedDateLabel = new DevExpress.XtraEditors.LabelControl();
            this.deliveryDateLabel = new DevExpress.XtraEditors.LabelControl();
            this.railcarNumber = new DevExpress.XtraEditors.ComboBoxEdit();
            this.railcarLabel = new DevExpress.XtraEditors.LabelControl();
            this.purchaseOrder = new DevExpress.XtraEditors.TextEdit();
            this.purchaseOrderLabel = new DevExpress.XtraEditors.LabelControl();
            this.client = new DevExpress.XtraEditors.ComboBoxEdit();
            this.designer = new DevExpress.XtraEditors.ComboBoxEdit();
            this.clientLabel = new DevExpress.XtraEditors.LabelControl();
            this.designerLabel = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.railcarList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.railcarListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippedDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.railcarNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.designer.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // railcarList
            // 
            this.railcarList.Cursor = System.Windows.Forms.Cursors.Default;
            this.railcarList.Location = new System.Drawing.Point(12, 124);
            this.railcarList.MainView = this.railcarListView;
            this.railcarList.Name = "railcarList";
            this.railcarList.Size = new System.Drawing.Size(860, 278);
            this.railcarList.TabIndex = 1;
            this.railcarList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.railcarListView});
            // 
            // railcarListView
            // 
            this.railcarListView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.railcarNumberGridColumn,
            this.statusGridColumn,
            this.shippingDateGridColumn,
            this.deliveryDateGridColumn,
            this.editGridColumn});
            this.railcarListView.GridControl = this.railcarList;
            this.railcarListView.Name = "railcarListView";
            // 
            // railcarNumberGridColumn
            // 
            this.railcarNumberGridColumn.Caption = "Railcar number";
            this.railcarNumberGridColumn.Name = "railcarNumberGridColumn";
            this.railcarNumberGridColumn.Visible = true;
            this.railcarNumberGridColumn.VisibleIndex = 0;
            // 
            // statusGridColumn
            // 
            this.statusGridColumn.Caption = "Status";
            this.statusGridColumn.Name = "statusGridColumn";
            this.statusGridColumn.Visible = true;
            this.statusGridColumn.VisibleIndex = 1;
            // 
            // shippingDateGridColumn
            // 
            this.shippingDateGridColumn.Caption = "Shiping date";
            this.shippingDateGridColumn.Name = "shippingDateGridColumn";
            this.shippingDateGridColumn.Visible = true;
            this.shippingDateGridColumn.VisibleIndex = 2;
            // 
            // deliveryDateGridColumn
            // 
            this.deliveryDateGridColumn.Caption = "Delivery date";
            this.deliveryDateGridColumn.Name = "deliveryDateGridColumn";
            this.deliveryDateGridColumn.Visible = true;
            this.deliveryDateGridColumn.VisibleIndex = 3;
            // 
            // editGridColumn
            // 
            this.editGridColumn.Caption = "Edit";
            this.editGridColumn.Name = "editGridColumn";
            this.editGridColumn.Visible = true;
            this.editGridColumn.VisibleIndex = 4;
            // 
            // shipButton
            // 
            this.shipButton.Location = new System.Drawing.Point(797, 410);
            this.shipButton.Name = "shipButton";
            this.shipButton.Size = new System.Drawing.Size(75, 23);
            this.shipButton.TabIndex = 3;
            this.shipButton.Text = "Ship";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(797, 82);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 29;
            this.searchButton.Text = "Search";
            // 
            // pipeSize
            // 
            this.pipeSize.Location = new System.Drawing.Point(416, 31);
            this.pipeSize.Name = "pipeSize";
            this.pipeSize.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.pipeSize.Size = new System.Drawing.Size(138, 20);
            this.pipeSize.TabIndex = 45;
            // 
            // pipeSizeLabel
            // 
            this.pipeSizeLabel.Location = new System.Drawing.Point(416, 12);
            this.pipeSizeLabel.Name = "pipeSizeLabel";
            this.pipeSizeLabel.Size = new System.Drawing.Size(41, 13);
            this.pipeSizeLabel.TabIndex = 44;
            this.pipeSizeLabel.Text = "Pipe size";
            // 
            // certificateNumber
            // 
            this.certificateNumber.Location = new System.Drawing.Point(116, 31);
            this.certificateNumber.Name = "certificateNumber";
            this.certificateNumber.Size = new System.Drawing.Size(265, 20);
            this.certificateNumber.TabIndex = 43;
            // 
            // certificateNumberLabel
            // 
            this.certificateNumberLabel.Location = new System.Drawing.Point(116, 10);
            this.certificateNumberLabel.Name = "certificateNumberLabel";
            this.certificateNumberLabel.Size = new System.Drawing.Size(89, 13);
            this.certificateNumberLabel.TabIndex = 42;
            this.certificateNumberLabel.Text = "Certificate number";
            // 
            // shippedDate
            // 
            this.shippedDate.EditValue = null;
            this.shippedDate.Location = new System.Drawing.Point(416, 85);
            this.shippedDate.Name = "shippedDate";
            this.shippedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.shippedDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.shippedDate.Size = new System.Drawing.Size(138, 20);
            this.shippedDate.TabIndex = 41;
            // 
            // deliveryDate
            // 
            this.deliveryDate.EditValue = null;
            this.deliveryDate.Location = new System.Drawing.Point(591, 85);
            this.deliveryDate.Name = "deliveryDate";
            this.deliveryDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deliveryDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deliveryDate.Size = new System.Drawing.Size(138, 20);
            this.deliveryDate.TabIndex = 40;
            // 
            // shippedDateLabel
            // 
            this.shippedDateLabel.Location = new System.Drawing.Point(416, 66);
            this.shippedDateLabel.Name = "shippedDateLabel";
            this.shippedDateLabel.Size = new System.Drawing.Size(65, 13);
            this.shippedDateLabel.TabIndex = 39;
            this.shippedDateLabel.Text = "Shipping date";
            // 
            // deliveryDateLabel
            // 
            this.deliveryDateLabel.Location = new System.Drawing.Point(591, 66);
            this.deliveryDateLabel.Name = "deliveryDateLabel";
            this.deliveryDateLabel.Size = new System.Drawing.Size(64, 13);
            this.deliveryDateLabel.TabIndex = 38;
            this.deliveryDateLabel.Text = "Delivery date";
            // 
            // railcarNumber
            // 
            this.railcarNumber.Location = new System.Drawing.Point(12, 31);
            this.railcarNumber.Name = "railcarNumber";
            this.railcarNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.railcarNumber.Size = new System.Drawing.Size(71, 20);
            this.railcarNumber.TabIndex = 37;
            // 
            // railcarLabel
            // 
            this.railcarLabel.Location = new System.Drawing.Point(12, 12);
            this.railcarLabel.Name = "railcarLabel";
            this.railcarLabel.Size = new System.Drawing.Size(71, 13);
            this.railcarLabel.TabIndex = 36;
            this.railcarLabel.Text = "Railcar number";
            // 
            // purchaseOrder
            // 
            this.purchaseOrder.Location = new System.Drawing.Point(591, 31);
            this.purchaseOrder.Name = "purchaseOrder";
            this.purchaseOrder.Size = new System.Drawing.Size(132, 20);
            this.purchaseOrder.TabIndex = 35;
            // 
            // purchaseOrderLabel
            // 
            this.purchaseOrderLabel.Location = new System.Drawing.Point(591, 12);
            this.purchaseOrderLabel.Name = "purchaseOrderLabel";
            this.purchaseOrderLabel.Size = new System.Drawing.Size(73, 13);
            this.purchaseOrderLabel.TabIndex = 34;
            this.purchaseOrderLabel.Text = "Purchase order";
            // 
            // client
            // 
            this.client.Location = new System.Drawing.Point(214, 85);
            this.client.Name = "client";
            this.client.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.client.Size = new System.Drawing.Size(167, 20);
            this.client.TabIndex = 33;
            // 
            // designer
            // 
            this.designer.Location = new System.Drawing.Point(12, 85);
            this.designer.Name = "designer";
            this.designer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.designer.Size = new System.Drawing.Size(167, 20);
            this.designer.TabIndex = 32;
            // 
            // clientLabel
            // 
            this.clientLabel.Location = new System.Drawing.Point(214, 66);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(27, 13);
            this.clientLabel.TabIndex = 31;
            this.clientLabel.Text = "Client";
            // 
            // designerLabel
            // 
            this.designerLabel.Location = new System.Drawing.Point(12, 66);
            this.designerLabel.Name = "designerLabel";
            this.designerLabel.Size = new System.Drawing.Size(42, 13);
            this.designerLabel.TabIndex = 30;
            this.designerLabel.Text = "Designer";
            // 
            // RailcarSearchXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.pipeSize);
            this.Controls.Add(this.pipeSizeLabel);
            this.Controls.Add(this.certificateNumber);
            this.Controls.Add(this.certificateNumberLabel);
            this.Controls.Add(this.shippedDate);
            this.Controls.Add(this.deliveryDate);
            this.Controls.Add(this.shippedDateLabel);
            this.Controls.Add(this.deliveryDateLabel);
            this.Controls.Add(this.railcarNumber);
            this.Controls.Add(this.railcarLabel);
            this.Controls.Add(this.purchaseOrder);
            this.Controls.Add(this.purchaseOrderLabel);
            this.Controls.Add(this.client);
            this.Controls.Add(this.designer);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.designerLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.shipButton);
            this.Controls.Add(this.railcarList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RailcarSearchXtraForm";
            this.Text = "Find railcars";
            ((System.ComponentModel.ISupportInitialize)(this.railcarList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.railcarListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippedDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.railcarNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.designer.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl railcarList;
        private DevExpress.XtraGrid.Views.Grid.GridView railcarListView;
        private DevExpress.XtraGrid.Columns.GridColumn railcarNumberGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn statusGridColumn;
        private DevExpress.XtraEditors.SimpleButton shipButton;
        private DevExpress.XtraGrid.Columns.GridColumn deliveryDateGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn shippingDateGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn editGridColumn;
        private DevExpress.XtraEditors.SimpleButton searchButton;
        private DevExpress.XtraEditors.ComboBoxEdit pipeSize;
        private DevExpress.XtraEditors.LabelControl pipeSizeLabel;
        private DevExpress.XtraEditors.TextEdit certificateNumber;
        private DevExpress.XtraEditors.LabelControl certificateNumberLabel;
        private DevExpress.XtraEditors.DateEdit shippedDate;
        private DevExpress.XtraEditors.DateEdit deliveryDate;
        private DevExpress.XtraEditors.LabelControl shippedDateLabel;
        private DevExpress.XtraEditors.LabelControl deliveryDateLabel;
        private DevExpress.XtraEditors.ComboBoxEdit railcarNumber;
        private DevExpress.XtraEditors.LabelControl railcarLabel;
        private DevExpress.XtraEditors.TextEdit purchaseOrder;
        private DevExpress.XtraEditors.LabelControl purchaseOrderLabel;
        private DevExpress.XtraEditors.ComboBoxEdit client;
        private DevExpress.XtraEditors.ComboBoxEdit designer;
        private DevExpress.XtraEditors.LabelControl clientLabel;
        private DevExpress.XtraEditors.LabelControl designerLabel;
    }
}