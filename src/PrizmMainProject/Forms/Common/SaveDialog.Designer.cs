namespace Prizm.Main.Forms.Common
{
   partial class SaveDialog
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
         this.pictureBox = new System.Windows.Forms.PictureBox();
         this.btnSave = new DevExpress.XtraEditors.SimpleButton();
         this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
         this.btnDontSave = new DevExpress.XtraEditors.SimpleButton();
         this.panel = new System.Windows.Forms.Panel();
         this.lblText = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
         this.panel.SuspendLayout();
         this.SuspendLayout();
         // 
         // pictureBox
         // 
         this.pictureBox.Image = global::Prizm.Main.Properties.Resources.Question;
         this.pictureBox.Location = new System.Drawing.Point(12, 12);
         this.pictureBox.Name = "pictureBox";
         this.pictureBox.Size = new System.Drawing.Size(56, 52);
         this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox.TabIndex = 0;
         this.pictureBox.TabStop = false;
         // 
         // btnSave
         // 
         this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Yes;
         this.btnSave.Location = new System.Drawing.Point(54, 106);
         this.btnSave.Name = "btnSave";
         this.btnSave.Size = new System.Drawing.Size(104, 26);
         this.btnSave.TabIndex = 1;
         this.btnSave.Text = "&Сохранить";
         // 
         // btnCancel
         // 
         this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnCancel.Location = new System.Drawing.Point(274, 106);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(104, 26);
         this.btnCancel.TabIndex = 3;
         this.btnCancel.Text = "&Отмена";
         // 
         // btnDontSave
         // 
         this.btnDontSave.DialogResult = System.Windows.Forms.DialogResult.No;
         this.btnDontSave.Location = new System.Drawing.Point(164, 106);
         this.btnDontSave.Name = "btnDontSave";
         this.btnDontSave.Size = new System.Drawing.Size(104, 26);
         this.btnDontSave.TabIndex = 2;
         this.btnDontSave.Text = "&Не сохранять";
         // 
         // panel
         // 
         this.panel.BackColor = System.Drawing.Color.White;
         this.panel.Controls.Add(this.lblText);
         this.panel.Controls.Add(this.pictureBox);
         this.panel.Location = new System.Drawing.Point(0, 0);
         this.panel.Name = "panel";
         this.panel.Size = new System.Drawing.Size(450, 100);
         this.panel.TabIndex = 4;
         // 
         // lblText
         // 
         this.lblText.AutoSize = true;
         this.lblText.Location = new System.Drawing.Point(74, 32);
         this.lblText.Name = "lblText";
         this.lblText.Size = new System.Drawing.Size(123, 13);
         this.lblText.TabIndex = 1;
         this.lblText.Text = "Сохранить изменения?";
         // 
         // SaveDialog
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(388, 141);
         this.Controls.Add(this.panel);
         this.Controls.Add(this.btnDontSave);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.btnSave);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "SaveDialog";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Сохранить изменения?";
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
         this.panel.ResumeLayout(false);
         this.panel.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.PictureBox pictureBox;
      private DevExpress.XtraEditors.SimpleButton btnSave;
      private DevExpress.XtraEditors.SimpleButton btnCancel;
      private DevExpress.XtraEditors.SimpleButton btnDontSave;
      private System.Windows.Forms.Panel panel;
      private System.Windows.Forms.Label lblText;
   }
}