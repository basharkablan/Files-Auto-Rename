namespace RenameFiles
{
    partial class RuleForm
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
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.ruleTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addNumberButton = new System.Windows.Forms.Button();
            this.addFileNameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(228, 125);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(76, 35);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "Set Rule";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(12, 125);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(76, 35);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // ruleTextBox
            // 
            this.ruleTextBox.Location = new System.Drawing.Point(75, 12);
            this.ruleTextBox.Name = "ruleTextBox";
            this.ruleTextBox.Size = new System.Drawing.Size(229, 20);
            this.ruleTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Note: The rule must contain <FILE_NAME> and <NUMBER>\r\nDefault rule is : <FILE_NAM" +
                "E>-<NUMBER>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "New Rule :";
            // 
            // addNumberButton
            // 
            this.addNumberButton.Location = new System.Drawing.Point(166, 81);
            this.addNumberButton.Name = "addNumberButton";
            this.addNumberButton.Size = new System.Drawing.Size(111, 23);
            this.addNumberButton.TabIndex = 5;
            this.addNumberButton.Text = "Add <NUMBER>";
            this.addNumberButton.UseVisualStyleBackColor = true;
            this.addNumberButton.Click += new System.EventHandler(this.addNumberButton_Click);
            // 
            // addFileNameButton
            // 
            this.addFileNameButton.Location = new System.Drawing.Point(39, 81);
            this.addFileNameButton.Name = "addFileNameButton";
            this.addFileNameButton.Size = new System.Drawing.Size(111, 23);
            this.addFileNameButton.TabIndex = 5;
            this.addFileNameButton.Text = "Add <FILE_NAME>";
            this.addFileNameButton.UseVisualStyleBackColor = true;
            this.addFileNameButton.Click += new System.EventHandler(this.addFileNameButton_Click);
            // 
            // RuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 172);
            this.Controls.Add(this.addFileNameButton);
            this.Controls.Add(this.addNumberButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ruleTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(332, 210);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(332, 210);
            this.Name = "RuleForm";
            this.Text = "RuleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox ruleTextBox;
        private System.Windows.Forms.Button addNumberButton;
        private System.Windows.Forms.Button addFileNameButton;
    }
}