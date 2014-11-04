namespace PrizmMain.Forms
{
    partial class ExternalFilesXtraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExternalFilesXtraForm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.files = new DevExpress.XtraGrid.GridControl();
            this.fileBindingSource = new System.Windows.Forms.BindingSource();
            this.filesView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUploadDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colView = new DevExpress.XtraGrid.Columns.GridColumn();
            this.viewButton = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colDownload = new DevExpress.XtraGrid.Columns.GridColumn();
            this.downloadButton = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.addFile = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.files)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downloadButton)).BeginInit();
            this.SuspendLayout();
            // 
            // files
            // 
            this.files.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.files.Cursor = System.Windows.Forms.Cursors.Default;
            this.files.DataSource = this.fileBindingSource;
            this.files.Location = new System.Drawing.Point(20, 20);
            this.files.MainView = this.filesView;
            this.files.Margin = new System.Windows.Forms.Padding(11);
            this.files.Name = "files";
            this.files.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.viewButton,
            this.downloadButton});
            this.files.Size = new System.Drawing.Size(475, 251);
            this.files.TabIndex = 0;
            this.files.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.filesView});
            // 
            // filesView
            // 
            this.filesView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFileName,
            this.colDescription,
            this.colUploadDate,
            this.colView,
            this.colDownload});
            this.filesView.GridControl = this.files;
            this.filesView.Name = "filesView";
            this.filesView.OptionsBehavior.Editable = false;
            this.filesView.OptionsView.ShowGroupPanel = false;
            this.filesView.OptionsView.ShowIndicator = false;
            // 
            // colFileName
            // 
            this.colFileName.Caption = "Имя файла";
            this.colFileName.FieldName = "FileName";
            this.colFileName.Name = "colFileName";
            this.colFileName.Visible = true;
            this.colFileName.VisibleIndex = 0;
            this.colFileName.Width = 104;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Описание";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            this.colDescription.Width = 104;
            // 
            // colUploadDate
            // 
            this.colUploadDate.Caption = "Дата добавления";
            this.colUploadDate.FieldName = "UploadDate";
            this.colUploadDate.Name = "colUploadDate";
            this.colUploadDate.Visible = true;
            this.colUploadDate.VisibleIndex = 2;
            this.colUploadDate.Width = 104;
            // 
            // colView
            // 
            this.colView.ColumnEdit = this.viewButton;
            this.colView.Name = "colView";
            this.colView.ToolTip = "Просмотреть файл";
            this.colView.Visible = true;
            this.colView.VisibleIndex = 3;
            this.colView.Width = 30;
            // 
            // viewButton
            // 
            this.viewButton.AutoHeight = false;
            this.viewButton.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("viewButton.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.viewButton.Name = "viewButton";
            this.viewButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // colDownload
            // 
            this.colDownload.ColumnEdit = this.downloadButton;
            this.colDownload.Name = "colDownload";
            this.colDownload.ToolTip = "Извлечь файл";
            this.colDownload.Visible = true;
            this.colDownload.VisibleIndex = 4;
            this.colDownload.Width = 30;
            // 
            // downloadButton
            // 
            this.downloadButton.AutoHeight = false;
            this.downloadButton.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("downloadButton.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", null, null, true)});
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // addFile
            // 
            this.addFile.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.addFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addFile.Image = ((System.Drawing.Image)(resources.GetObject("addFile.Image")));
            this.addFile.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.addFile.Location = new System.Drawing.Point(20, 293);
            this.addFile.Margin = new System.Windows.Forms.Padding(11);
            this.addFile.Name = "addFile";
            this.addFile.Size = new System.Drawing.Size(113, 23);
            this.addFile.TabIndex = 1;
            this.addFile.Text = "Добавить файл";
            // 
            // ExternalFilesXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 336);
            this.Controls.Add(this.addFile);
            this.Controls.Add(this.files);
            this.Name = "ExternalFilesXtraForm";
            this.Text = "Внешние файлы";
            ((System.ComponentModel.ISupportInitialize)(this.files)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downloadButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl files;
        private DevExpress.XtraGrid.Views.Grid.GridView filesView;
        private System.Windows.Forms.BindingSource fileBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colFileName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colUploadDate;
        private DevExpress.XtraEditors.SimpleButton addFile;
        private DevExpress.XtraGrid.Columns.GridColumn colView;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit viewButton;
        private DevExpress.XtraGrid.Columns.GridColumn colDownload;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit downloadButton;
    }
}