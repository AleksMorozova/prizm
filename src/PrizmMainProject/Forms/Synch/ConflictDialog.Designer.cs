namespace Prizm.Main.Forms.Synch
{
   partial class ConflictDialog
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
         this.lblTitle = new System.Windows.Forms.Label();
         this.lblDesc = new System.Windows.Forms.Label();
         this.btnReplace = new DevExpress.XtraEditors.SimpleButton();
         this.btnSkip = new DevExpress.XtraEditors.SimpleButton();
         this.btnPostpone = new DevExpress.XtraEditors.SimpleButton();
         this.chkForAll = new System.Windows.Forms.CheckBox();
         this.SuspendLayout();
         // 
         // lblTitle
         // 
         this.lblTitle.AutoSize = true;
         this.lblTitle.Location = new System.Drawing.Point(13, 13);
         this.lblTitle.Name = "lblTitle";
         this.lblTitle.Size = new System.Drawing.Size(192, 13);
         this.lblTitle.TabIndex = 0;
         this.lblTitle.Text = "Во время импорта возник конфликт:";
         // 
         // lblDesc
         // 
         this.lblDesc.AutoSize = true;
         this.lblDesc.Location = new System.Drawing.Point(13, 35);
         this.lblDesc.Name = "lblDesc";
         this.lblDesc.Size = new System.Drawing.Size(0, 13);
         this.lblDesc.TabIndex = 1;
         // 
         // btnReplace
         // 
         this.btnReplace.DialogResult = System.Windows.Forms.DialogResult.OK;
         this.btnReplace.Location = new System.Drawing.Point(16, 97);
         this.btnReplace.Name = "btnReplace";
         this.btnReplace.Size = new System.Drawing.Size(125, 23);
         this.btnReplace.TabIndex = 2;
         this.btnReplace.Text = "Заменить";
         this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
         // 
         // btnSkip
         // 
         this.btnSkip.DialogResult = System.Windows.Forms.DialogResult.OK;
         this.btnSkip.Location = new System.Drawing.Point(172, 97);
         this.btnSkip.Name = "btnSkip";
         this.btnSkip.Size = new System.Drawing.Size(123, 23);
         this.btnSkip.TabIndex = 3;
         this.btnSkip.Text = "Пропустить";
         this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
         // 
         // btnPostpone
         // 
         this.btnPostpone.DialogResult = System.Windows.Forms.DialogResult.OK;
         this.btnPostpone.Location = new System.Drawing.Point(314, 97);
         this.btnPostpone.Name = "btnPostpone";
         this.btnPostpone.Size = new System.Drawing.Size(150, 23);
         this.btnPostpone.TabIndex = 4;
         this.btnPostpone.Text = "Отложить решение";
         this.btnPostpone.Click += new System.EventHandler(this.btnPostpone_Click);
         // 
         // chkForAll
         // 
         this.chkForAll.AutoSize = true;
         this.chkForAll.Location = new System.Drawing.Point(16, 74);
         this.chkForAll.Name = "chkForAll";
         this.chkForAll.Size = new System.Drawing.Size(269, 17);
         this.chkForAll.TabIndex = 5;
         this.chkForAll.Text = "Применить для всех последующих конфликтов";
         this.chkForAll.UseVisualStyleBackColor = true;
         // 
         // ConflictDialog
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(476, 136);
         this.Controls.Add(this.chkForAll);
         this.Controls.Add(this.btnPostpone);
         this.Controls.Add(this.btnSkip);
         this.Controls.Add(this.btnReplace);
         this.Controls.Add(this.lblDesc);
         this.Controls.Add(this.lblTitle);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.Name = "ConflictDialog";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Конфликт";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lblTitle;
      private System.Windows.Forms.Label lblDesc;
      private DevExpress.XtraEditors.SimpleButton btnReplace;
      private DevExpress.XtraEditors.SimpleButton btnSkip;
      private DevExpress.XtraEditors.SimpleButton btnPostpone;
      private System.Windows.Forms.CheckBox chkForAll;
   }
}