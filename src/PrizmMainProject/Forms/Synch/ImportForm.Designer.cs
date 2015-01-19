namespace Prizm.Main.Forms.Synch
{
   partial class ImportForm
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
         this.label1 = new System.Windows.Forms.Label();
         this.txtArchive = new DevExpress.XtraEditors.TextEdit();
         this.btnBrowse = new DevExpress.XtraEditors.SimpleButton();
         this.progressBarControl = new DevExpress.XtraEditors.ProgressBarControl();
         this.lblStatus = new System.Windows.Forms.Label();
         this.btnImport = new DevExpress.XtraEditors.SimpleButton();
         ((System.ComponentModel.ISupportInitialize)(this.txtArchive.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).BeginInit();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 29);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(42, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Архив:";
         // 
         // txtArchive
         // 
         this.txtArchive.Location = new System.Drawing.Point(60, 26);
         this.txtArchive.Name = "txtArchive";
         this.txtArchive.Size = new System.Drawing.Size(476, 20);
         this.txtArchive.TabIndex = 1;
         // 
         // btnBrowse
         // 
         this.btnBrowse.Location = new System.Drawing.Point(542, 24);
         this.btnBrowse.Name = "btnBrowse";
         this.btnBrowse.Size = new System.Drawing.Size(111, 23);
         this.btnBrowse.TabIndex = 2;
         this.btnBrowse.Text = "Обзор...";
         this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
         // 
         // progressBarControl
         // 
         this.progressBarControl.Location = new System.Drawing.Point(15, 81);
         this.progressBarControl.Name = "progressBarControl";
         this.progressBarControl.Size = new System.Drawing.Size(638, 25);
         this.progressBarControl.TabIndex = 3;
         // 
         // lblStatus
         // 
         this.lblStatus.AutoSize = true;
         this.lblStatus.Location = new System.Drawing.Point(19, 65);
         this.lblStatus.Name = "lblStatus";
         this.lblStatus.Size = new System.Drawing.Size(0, 13);
         this.lblStatus.TabIndex = 4;
         // 
         // btnImport
         // 
         this.btnImport.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnImport.Appearance.Options.UseFont = true;
         this.btnImport.Image = global::Prizm.Main.Properties.Resources.import;
         this.btnImport.Location = new System.Drawing.Point(542, 112);
         this.btnImport.Name = "btnImport";
         this.btnImport.Size = new System.Drawing.Size(111, 35);
         this.btnImport.TabIndex = 5;
         this.btnImport.Text = "&Импорт";
         this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
         // 
         // ImportForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(665, 159);
         this.Controls.Add(this.btnImport);
         this.Controls.Add(this.lblStatus);
         this.Controls.Add(this.progressBarControl);
         this.Controls.Add(this.btnBrowse);
         this.Controls.Add(this.txtArchive);
         this.Controls.Add(this.label1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.Name = "ImportForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Импорт";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImportForm_FormClosing);
         ((System.ComponentModel.ISupportInitialize)(this.txtArchive.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private DevExpress.XtraEditors.TextEdit txtArchive;
      private DevExpress.XtraEditors.SimpleButton btnBrowse;
      private DevExpress.XtraEditors.ProgressBarControl progressBarControl;
      private System.Windows.Forms.Label lblStatus;
      private DevExpress.XtraEditors.SimpleButton btnImport;
   }
}