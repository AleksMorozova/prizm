﻿namespace Prizm.Main.Forms.Common
{
    partial class AboutXtraForm
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
            this.labelVersion = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.titleLabel = new DevExpress.XtraEditors.LabelControl();
            this.acceptButton = new DevExpress.XtraEditors.SimpleButton();
            this.textEditVersionNumber = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditVersionNumber.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelVersion
            // 
            this.labelVersion.Location = new System.Drawing.Point(290, 119);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(39, 13);
            this.labelVersion.TabIndex = 0;
            this.labelVersion.Text = "Версия:";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::Prizm.Main.Properties.Resources.main_logo_03;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(255, 164);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.titleLabel.Location = new System.Drawing.Point(287, 28);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(231, 13);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "   ";
            // 
            // acceptButton
            // 
            this.acceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.acceptButton.Location = new System.Drawing.Point(452, 215);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 6;
            this.acceptButton.Text = "ОК";
            // 
            // textEditVersionNumber
            // 
            this.textEditVersionNumber.Location = new System.Drawing.Point(345, 112);
            this.textEditVersionNumber.Name = "textEditVersionNumber";
            this.textEditVersionNumber.Size = new System.Drawing.Size(165, 20);
            this.textEditVersionNumber.TabIndex = 7;
            // 
            // AboutXtraForm
            // 
            this.AcceptButton = this.acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.acceptButton;
            this.ClientSize = new System.Drawing.Size(539, 250);
            this.Controls.Add(this.textEditVersionNumber);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.labelVersion);
            this.Name = "AboutXtraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "О программе";
            this.Load += new System.EventHandler(this.AboutXtraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditVersionNumber.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelVersion;
        private System.Windows.Forms.PictureBox pictureBox;
        private DevExpress.XtraEditors.LabelControl titleLabel;
        private DevExpress.XtraEditors.SimpleButton acceptButton;
        private DevExpress.XtraEditors.TextEdit textEditVersionNumber;
    }
}