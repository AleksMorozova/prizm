using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using PrizmMain.DummyData;

namespace PrizmMain.Forms.Notifications
{
    partial class NotificationXtraForm
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
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlNotification = new DevExpress.XtraLayout.LayoutControl();
            this.gridControlMessage = new DevExpress.XtraGrid.GridControl();
            this.notificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewNotification = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotification = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemNotification = new DevExpress.XtraLayout.LayoutControlItem();
            this.colInspectorLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInspectorFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInspectorMiddleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInspectorActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInspectorCertExp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInspectorCertificate = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlNotification)).BeginInit();
            this.layoutControlNotification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNotification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemNotification)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1241, 463);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup1";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1241, 463);
            this.layoutControlGroup2.Text = "layoutControlGroup1";
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlNotification
            // 
            this.layoutControlNotification.Controls.Add(this.gridControlMessage);
            this.layoutControlNotification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControlNotification.Location = new System.Drawing.Point(0, 0);
            this.layoutControlNotification.Name = "layoutControlNotification";
            this.layoutControlNotification.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(39, 176, 250, 350);
            this.layoutControlNotification.OptionsView.UseDefaultDragAndDropRendering = false;
            this.layoutControlNotification.Root = this.layoutControlGroup4;
            this.layoutControlNotification.Size = new System.Drawing.Size(859, 548);
            this.layoutControlNotification.TabIndex = 2;
            this.layoutControlNotification.Text = "layoutControl2";
            // 
            // gridControlMessage
            // 
            this.gridControlMessage.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlMessage.DataSource = this.notificationBindingSource;
            this.gridControlMessage.Location = new System.Drawing.Point(12, 28);
            this.gridControlMessage.MainView = this.gridViewNotification;
            this.gridControlMessage.Name = "gridControlMessage";
            this.gridControlMessage.Size = new System.Drawing.Size(832, 508);
            this.gridControlMessage.TabIndex = 0;
            this.gridControlMessage.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewNotification});
            this.gridControlMessage.DoubleClick += new System.EventHandler(this.gridControlMessage_DoubleClick);
            // 
            // gridViewNotification
            // 
            this.gridViewNotification.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colImage,
            this.colName,
            this.colNotification});
            this.gridViewNotification.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewNotification.GridControl = this.gridControlMessage;
            this.gridViewNotification.Name = "gridViewNotification";
            this.gridViewNotification.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewNotification.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewNotification.OptionsBehavior.Editable = false;
            this.gridViewNotification.OptionsBehavior.ReadOnly = true;
            this.gridViewNotification.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewNotification.OptionsView.ShowDetailButtons = false;
            this.gridViewNotification.OptionsView.ShowGroupPanel = false;
            // 
            // colImage
            // 
            this.colImage.Caption = " ";
            this.colImage.FieldName = "Image";
            this.colImage.Name = "colImage";
            this.colImage.Visible = true;
            this.colImage.VisibleIndex = 0;
            this.colImage.Width = 28;
            // 
            // colName
            // 
            this.colName.Caption = "Регистратор";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 212;
            // 
            // colNotification
            // 
            this.colNotification.Caption = "Сообщение";
            this.colNotification.FieldName = "Message";
            this.colNotification.Name = "colNotification";
            this.colNotification.Visible = true;
            this.colNotification.VisibleIndex = 2;
            this.colNotification.Width = 574;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup4.GroupBordersVisible = false;
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemNotification});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup4.Name = "layoutControlGroup1";
            this.layoutControlGroup4.Size = new System.Drawing.Size(859, 548);
            this.layoutControlGroup4.Text = "layoutControlGroup1";
            this.layoutControlGroup4.TextVisible = false;
            // 
            // layoutControlItemNotification
            // 
            this.layoutControlItemNotification.Control = this.gridControlMessage;
            this.layoutControlItemNotification.CustomizationFormText = "Сообщения";
            this.layoutControlItemNotification.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemNotification.Name = "layoutControlItemNotification";
            this.layoutControlItemNotification.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 5, 2, 2);
            this.layoutControlItemNotification.Size = new System.Drawing.Size(839, 528);
            this.layoutControlItemNotification.Text = "Сообщения";
            this.layoutControlItemNotification.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItemNotification.TextSize = new System.Drawing.Size(58, 13);
            // 
            // colInspectorLastName
            // 
            this.colInspectorLastName.Caption = "Фамилия";
            this.colInspectorLastName.FieldName = "LastName";
            this.colInspectorLastName.Name = "colInspectorLastName";
            this.colInspectorLastName.Visible = true;
            this.colInspectorLastName.VisibleIndex = 0;
            this.colInspectorLastName.Width = 250;
            // 
            // colInspectorFirstName
            // 
            this.colInspectorFirstName.Caption = "Имя";
            this.colInspectorFirstName.FieldName = "FirstName";
            this.colInspectorFirstName.Name = "colInspectorFirstName";
            this.colInspectorFirstName.Visible = true;
            this.colInspectorFirstName.VisibleIndex = 1;
            this.colInspectorFirstName.Width = 250;
            // 
            // colInspectorMiddleName
            // 
            this.colInspectorMiddleName.Caption = "Отчество";
            this.colInspectorMiddleName.FieldName = "MiddleName";
            this.colInspectorMiddleName.Name = "colInspectorMiddleName";
            this.colInspectorMiddleName.Visible = true;
            this.colInspectorMiddleName.VisibleIndex = 2;
            this.colInspectorMiddleName.Width = 250;
            // 
            // colInspectorActive
            // 
            this.colInspectorActive.Caption = "Активен";
            this.colInspectorActive.FieldName = "Active";
            this.colInspectorActive.MaxWidth = 115;
            this.colInspectorActive.Name = "colInspectorActive";
            this.colInspectorActive.Visible = true;
            this.colInspectorActive.VisibleIndex = 3;
            this.colInspectorActive.Width = 50;
            // 
            // colInspectorCertExp
            // 
            this.colInspectorCertExp.Caption = "Дата аттестации";
            this.colInspectorCertExp.FieldName = "CertificateExpiration";
            this.colInspectorCertExp.Name = "colInspectorCertExp";
            this.colInspectorCertExp.Width = 100;
            // 
            // colInspectorCertificate
            // 
            this.colInspectorCertificate.Caption = "Сертификат";
            this.colInspectorCertificate.FieldName = "Certificate";
            this.colInspectorCertificate.Name = "colInspectorCertificate";
            this.colInspectorCertificate.Width = 200;
            // 
            // NotificationXtraForm
            // 
            this.ClientSize = new System.Drawing.Size(859, 548);
            this.Controls.Add(this.layoutControlNotification);
            this.Name = "NotificationXtraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Окно уведомлений";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NotificationXtraForm_FormClosed);
            this.Load += new System.EventHandler(this.NotificationXtraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlNotification)).EndInit();
            this.layoutControlNotification.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNotification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemNotification)).EndInit();
            this.ResumeLayout(false);

        }
        // Fields
        private GridColumn colImage;
        private GridColumn colInspectorActive;
        private GridColumn colInspectorCertExp;
        private GridColumn colInspectorCertificate;
        private GridColumn colInspectorFirstName;
        private GridColumn colInspectorLastName;
        private GridColumn colInspectorMiddleName;
        private GridColumn colName;
        private GridColumn colNotification;
        private GridControl gridControlMessage;
        private GridView gridViewNotification;
        private LayoutControlGroup layoutControlGroup1;
        private LayoutControlGroup layoutControlGroup2;
        private LayoutControlGroup layoutControlGroup4;
        private LayoutControl layoutControlNotification;
        private LayoutControlItem layoutControlItemNotification;
        private BindingSource notificationBindingSource;


        #endregion
    }
}