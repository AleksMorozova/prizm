namespace Prizm.Main.Forms.Common
{
    partial class YesNoDialog
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
            this.questionPictureBox = new System.Windows.Forms.PictureBox();
            this.yesButton = new DevExpress.XtraEditors.SimpleButton();
            this.noButton = new DevExpress.XtraEditors.SimpleButton();
            this.questionLabel = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.questionPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // questionPictureBox
            // 
            this.questionPictureBox.Image = global::Prizm.Main.Properties.Resources.Question;
            this.questionPictureBox.Location = new System.Drawing.Point(12, 12);
            this.questionPictureBox.Name = "questionPictureBox";
            this.questionPictureBox.Size = new System.Drawing.Size(66, 59);
            this.questionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.questionPictureBox.TabIndex = 0;
            this.questionPictureBox.TabStop = false;
            // 
            // yesButton
            // 
            this.yesButton.Location = new System.Drawing.Point(115, 109);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(112, 23);
            this.yesButton.TabIndex = 1;
            this.yesButton.Text = "Yes";
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // noButton
            // 
            this.noButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.noButton.Location = new System.Drawing.Point(298, 109);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(112, 23);
            this.noButton.TabIndex = 2;
            this.noButton.Text = "No";
            // 
            // questionLabel
            // 
            this.questionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.questionLabel.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.questionLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.questionLabel.Location = new System.Drawing.Point(105, 21);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(346, 0);
            this.questionLabel.TabIndex = 3;
            // 
            // YesNoDialog
            // 
            this.AcceptButton = this.yesButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.noButton;
            this.ClientSize = new System.Drawing.Size(485, 144);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.questionPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "YesNoDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YesNoDialog";
            ((System.ComponentModel.ISupportInitialize)(this.questionPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox questionPictureBox;
        private DevExpress.XtraEditors.SimpleButton yesButton;
        private DevExpress.XtraEditors.SimpleButton noButton;
        private DevExpress.XtraEditors.LabelControl questionLabel;


    }
}