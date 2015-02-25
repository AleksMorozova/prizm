namespace Prizm.Main.Forms.Parts.Inspection
{
    partial class CreateSpoolComponentDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateSpoolComponentDialog));
            this.generalLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.numberLabel = new DevExpress.XtraEditors.LabelControl();
            this.questionLabel = new DevExpress.XtraEditors.LabelControl();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.acceptButton = new DevExpress.XtraEditors.SimpleButton();
            this.partRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.generalLayoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.partRadioGroupLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.acceptButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.cancelButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.questionLabelLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.numberLabelLayout = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.generalLayoutControl)).BeginInit();
            this.generalLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partRadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalLayoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partRadioGroupLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionLabelLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberLabelLayout)).BeginInit();
            this.SuspendLayout();
            // 
            // generalLayoutControl
            // 
            this.generalLayoutControl.Controls.Add(this.numberLabel);
            this.generalLayoutControl.Controls.Add(this.questionLabel);
            this.generalLayoutControl.Controls.Add(this.cancelButton);
            this.generalLayoutControl.Controls.Add(this.acceptButton);
            this.generalLayoutControl.Controls.Add(this.partRadioGroup);
            this.generalLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.generalLayoutControl.Name = "generalLayoutControl";
            this.generalLayoutControl.OptionsView.UseDefaultDragAndDropRendering = false;
            this.generalLayoutControl.Root = this.generalLayoutControlGroup;
            this.generalLayoutControl.Size = new System.Drawing.Size(321, 151);
            this.generalLayoutControl.TabIndex = 0;
            // 
            // numberLabel
            // 
            this.numberLabel.Location = new System.Drawing.Point(308, 12);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(1, 13);
            this.numberLabel.StyleController = this.generalLayoutControl;
            this.numberLabel.TabIndex = 8;
            // 
            // questionLabel
            // 
            this.questionLabel.Location = new System.Drawing.Point(155, 12);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(6, 13);
            this.questionLabel.StyleController = this.generalLayoutControl;
            this.questionLabel.TabIndex = 7;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.cancelButton.Location = new System.Drawing.Point(12, 117);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(137, 22);
            this.cancelButton.StyleController = this.generalLayoutControl;
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "О&тмена";
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(173, 117);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(136, 22);
            this.acceptButton.StyleController = this.generalLayoutControl;
            this.acceptButton.TabIndex = 5;
            this.acceptButton.Text = "&Создать";
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // partRadioGroup
            // 
            this.partRadioGroup.EditValue = "spool";
            this.partRadioGroup.Location = new System.Drawing.Point(12, 29);
            this.partRadioGroup.Name = "partRadioGroup";
            this.partRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("spool", "Катушка"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("component", "Компонент")});
            this.partRadioGroup.Size = new System.Drawing.Size(297, 54);
            this.partRadioGroup.StyleController = this.generalLayoutControl;
            this.partRadioGroup.TabIndex = 4;
            // 
            // generalLayoutControlGroup
            // 
            this.generalLayoutControlGroup.CustomizationFormText = "generalLayoutControlGroup";
            this.generalLayoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.generalLayoutControlGroup.GroupBordersVisible = false;
            this.generalLayoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.partRadioGroupLayout,
            this.acceptButtonLayout,
            this.cancelButtonLayout,
            this.questionLabelLayout,
            this.numberLabelLayout});
            this.generalLayoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.generalLayoutControlGroup.Name = "generalLayoutControlGroup";
            this.generalLayoutControlGroup.Size = new System.Drawing.Size(321, 151);
            this.generalLayoutControlGroup.Text = "generalLayoutControlGroup";
            this.generalLayoutControlGroup.TextVisible = false;
            // 
            // partRadioGroupLayout
            // 
            this.partRadioGroupLayout.Control = this.partRadioGroup;
            this.partRadioGroupLayout.CustomizationFormText = "Создать элемент с номером ";
            this.partRadioGroupLayout.Location = new System.Drawing.Point(0, 17);
            this.partRadioGroupLayout.Name = "partRadioGroupLayout";
            this.partRadioGroupLayout.Size = new System.Drawing.Size(301, 73);
            this.partRadioGroupLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 15);
            this.partRadioGroupLayout.Text = "partRadioGroupLayout";
            this.partRadioGroupLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.partRadioGroupLayout.TextSize = new System.Drawing.Size(0, 0);
            this.partRadioGroupLayout.TextVisible = false;
            // 
            // acceptButtonLayout
            // 
            this.acceptButtonLayout.Control = this.acceptButton;
            this.acceptButtonLayout.CustomizationFormText = "acceptButtonLayout";
            this.acceptButtonLayout.Location = new System.Drawing.Point(151, 90);
            this.acceptButtonLayout.Name = "acceptButtonLayout";
            this.acceptButtonLayout.Size = new System.Drawing.Size(150, 41);
            this.acceptButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 0, 15, 0);
            this.acceptButtonLayout.Text = "acceptButtonLayout";
            this.acceptButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.acceptButtonLayout.TextVisible = false;
            // 
            // cancelButtonLayout
            // 
            this.cancelButtonLayout.Control = this.cancelButton;
            this.cancelButtonLayout.CustomizationFormText = "cancelButtonLayout";
            this.cancelButtonLayout.Location = new System.Drawing.Point(0, 90);
            this.cancelButtonLayout.Name = "cancelButtonLayout";
            this.cancelButtonLayout.Size = new System.Drawing.Size(151, 41);
            this.cancelButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 10, 15, 0);
            this.cancelButtonLayout.Text = "cancelButtonLayout";
            this.cancelButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.cancelButtonLayout.TextVisible = false;
            // 
            // questionLabelLayout
            // 
            this.questionLabelLayout.Control = this.questionLabel;
            this.questionLabelLayout.CustomizationFormText = "questionLabelLayout";
            this.questionLabelLayout.Location = new System.Drawing.Point(0, 0);
            this.questionLabelLayout.Name = "questionLabelLayout";
            this.questionLabelLayout.Size = new System.Drawing.Size(153, 17);
            this.questionLabelLayout.Text = "Создать элемент с номером";
            this.questionLabelLayout.TextSize = new System.Drawing.Size(140, 13);
            // 
            // numberLabelLayout
            // 
            this.numberLabelLayout.Control = this.numberLabel;
            this.numberLabelLayout.CustomizationFormText = " ";
            this.numberLabelLayout.Location = new System.Drawing.Point(153, 0);
            this.numberLabelLayout.Name = "numberLabelLayout";
            this.numberLabelLayout.Size = new System.Drawing.Size(148, 17);
            this.numberLabelLayout.Text = " ";
            this.numberLabelLayout.TextSize = new System.Drawing.Size(140, 13);
            // 
            // CreateSpoolComponentDialog
            // 
            this.AcceptButton = this.acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(321, 151);
            this.Controls.Add(this.generalLayoutControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateSpoolComponentDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Создание компонента";
            ((System.ComponentModel.ISupportInitialize)(this.generalLayoutControl)).EndInit();
            this.generalLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.partRadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalLayoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partRadioGroupLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionLabelLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberLabelLayout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl generalLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup generalLayoutControlGroup;
        private DevExpress.XtraEditors.SimpleButton acceptButton;
        private DevExpress.XtraEditors.RadioGroup partRadioGroup;
        private DevExpress.XtraLayout.LayoutControlItem partRadioGroupLayout;
        private DevExpress.XtraLayout.LayoutControlItem acceptButtonLayout;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraLayout.LayoutControlItem cancelButtonLayout;
        private DevExpress.XtraEditors.LabelControl questionLabel;
        private DevExpress.XtraLayout.LayoutControlItem questionLabelLayout;
        private DevExpress.XtraEditors.LabelControl numberLabel;
        private DevExpress.XtraLayout.LayoutControlItem numberLabelLayout;
    }
}