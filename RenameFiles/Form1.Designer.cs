namespace RenameFiles
{
    partial class MainForm
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
            this.renameButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pathsTextBox = new System.Windows.Forms.TextBox();
            this.addFileButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.filesNewNameLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressLabel = new System.Windows.Forms.Label();
            this.shuffleButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.msButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.startNumberCheckBox = new System.Windows.Forms.CheckBox();
            this.startNumberTextBox = new System.Windows.Forms.TextBox();
            this.resetRuleButton = new System.Windows.Forms.Button();
            this.ruleGroupBox = new System.Windows.Forms.GroupBox();
            this.ruleButton = new System.Windows.Forms.Button();
            this.ruleLabel = new System.Windows.Forms.Label();
            this.currentRuleLabel = new System.Windows.Forms.Label();
            this.renameOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.renameOptionsLabel = new System.Windows.Forms.Label();
            this.renameRadioButton = new System.Windows.Forms.RadioButton();
            this.keepNameRadioButton = new System.Windows.Forms.RadioButton();
            this.folderNameRadioButton = new System.Windows.Forms.RadioButton();
            this.ruleGroupBox.SuspendLayout();
            this.renameOptionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // renameButton
            // 
            this.renameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.renameButton.Location = new System.Drawing.Point(723, 415);
            this.renameButton.Name = "renameButton";
            this.renameButton.Size = new System.Drawing.Size(70, 35);
            this.renameButton.TabIndex = 0;
            this.renameButton.Text = "Rename";
            this.renameButton.UseVisualStyleBackColor = true;
            this.renameButton.Click += new System.EventHandler(this.renameButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "Choose File To Rename !!";
            // 
            // pathsTextBox
            // 
            this.pathsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pathsTextBox.Location = new System.Drawing.Point(12, 53);
            this.pathsTextBox.MaxLength = 0;
            this.pathsTextBox.Multiline = true;
            this.pathsTextBox.Name = "pathsTextBox";
            this.pathsTextBox.ReadOnly = true;
            this.pathsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.pathsTextBox.Size = new System.Drawing.Size(591, 356);
            this.pathsTextBox.TabIndex = 1;
            this.pathsTextBox.WordWrap = false;
            // 
            // addFileButton
            // 
            this.addFileButton.Location = new System.Drawing.Point(12, 12);
            this.addFileButton.Name = "addFileButton";
            this.addFileButton.Size = new System.Drawing.Size(70, 35);
            this.addFileButton.TabIndex = 2;
            this.addFileButton.Text = "Add Files";
            this.addFileButton.UseVisualStyleBackColor = true;
            this.addFileButton.Click += new System.EventHandler(this.addFileButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.Location = new System.Drawing.Point(643, 27);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(150, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // filesNewNameLabel
            // 
            this.filesNewNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filesNewNameLabel.Location = new System.Drawing.Point(573, 30);
            this.filesNewNameLabel.Name = "filesNewNameLabel";
            this.filesNewNameLabel.Size = new System.Drawing.Size(64, 13);
            this.filesNewNameLabel.TabIndex = 4;
            this.filesNewNameLabel.Text = "New name :";
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.closeButton.Location = new System.Drawing.Point(12, 415);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(70, 35);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(184, 425);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(519, 25);
            this.progressBar1.TabIndex = 6;
            // 
            // progressLabel
            // 
            this.progressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressLabel.Location = new System.Drawing.Point(85, 426);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(93, 13);
            this.progressLabel.TabIndex = 7;
            this.progressLabel.Text = "Progress (0%)";
            // 
            // shuffleButton
            // 
            this.shuffleButton.Location = new System.Drawing.Point(170, 12);
            this.shuffleButton.Name = "shuffleButton";
            this.shuffleButton.Size = new System.Drawing.Size(76, 35);
            this.shuffleButton.TabIndex = 8;
            this.shuffleButton.Text = "Shuffle Files";
            this.shuffleButton.UseVisualStyleBackColor = true;
            this.shuffleButton.Click += new System.EventHandler(this.shuffleButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(334, 12);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(76, 35);
            this.aboutButton.TabIndex = 9;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // msButton
            // 
            this.msButton.Location = new System.Drawing.Point(252, 12);
            this.msButton.Name = "msButton";
            this.msButton.Size = new System.Drawing.Size(76, 35);
            this.msButton.TabIndex = 10;
            this.msButton.Text = "Manual Sort";
            this.msButton.UseVisualStyleBackColor = true;
            this.msButton.Click += new System.EventHandler(this.msButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(88, 12);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(76, 35);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear Current Paths";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // startNumberCheckBox
            // 
            this.startNumberCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startNumberCheckBox.AutoSize = true;
            this.startNumberCheckBox.Location = new System.Drawing.Point(416, 29);
            this.startNumberCheckBox.Name = "startNumberCheckBox";
            this.startNumberCheckBox.Size = new System.Drawing.Size(94, 17);
            this.startNumberCheckBox.TabIndex = 13;
            this.startNumberCheckBox.Text = "Start Number :";
            this.startNumberCheckBox.UseVisualStyleBackColor = true;
            this.startNumberCheckBox.CheckedChanged += new System.EventHandler(this.startNumberCheckBox_CheckedChanged);
            // 
            // startNumberTextBox
            // 
            this.startNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startNumberTextBox.Enabled = false;
            this.startNumberTextBox.Location = new System.Drawing.Point(506, 27);
            this.startNumberTextBox.Name = "startNumberTextBox";
            this.startNumberTextBox.Size = new System.Drawing.Size(61, 20);
            this.startNumberTextBox.TabIndex = 14;
            // 
            // resetRuleButton
            // 
            this.resetRuleButton.Location = new System.Drawing.Point(95, 61);
            this.resetRuleButton.Name = "resetRuleButton";
            this.resetRuleButton.Size = new System.Drawing.Size(76, 35);
            this.resetRuleButton.TabIndex = 9;
            this.resetRuleButton.Text = "Reset Default Rule";
            this.resetRuleButton.UseVisualStyleBackColor = true;
            this.resetRuleButton.Click += new System.EventHandler(this.resetRuleButton_Click);
            // 
            // ruleGroupBox
            // 
            this.ruleGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ruleGroupBox.Controls.Add(this.ruleButton);
            this.ruleGroupBox.Controls.Add(this.ruleLabel);
            this.ruleGroupBox.Controls.Add(this.currentRuleLabel);
            this.ruleGroupBox.Controls.Add(this.resetRuleButton);
            this.ruleGroupBox.Location = new System.Drawing.Point(609, 53);
            this.ruleGroupBox.Name = "ruleGroupBox";
            this.ruleGroupBox.Size = new System.Drawing.Size(184, 102);
            this.ruleGroupBox.TabIndex = 15;
            this.ruleGroupBox.TabStop = false;
            this.ruleGroupBox.Text = "Rule settings";
            // 
            // ruleButton
            // 
            this.ruleButton.Location = new System.Drawing.Point(13, 61);
            this.ruleButton.Name = "ruleButton";
            this.ruleButton.Size = new System.Drawing.Size(76, 35);
            this.ruleButton.TabIndex = 12;
            this.ruleButton.Text = "Set Rule";
            this.ruleButton.UseVisualStyleBackColor = true;
            this.ruleButton.Click += new System.EventHandler(this.ruleButton_Click);
            // 
            // ruleLabel
            // 
            this.ruleLabel.AutoSize = true;
            this.ruleLabel.Location = new System.Drawing.Point(22, 39);
            this.ruleLabel.Name = "ruleLabel";
            this.ruleLabel.Size = new System.Drawing.Size(140, 13);
            this.ruleLabel.TabIndex = 11;
            this.ruleLabel.Text = "<FILE_NAME>-<NUMBER>";
            // 
            // currentRuleLabel
            // 
            this.currentRuleLabel.AutoSize = true;
            this.currentRuleLabel.Location = new System.Drawing.Point(6, 16);
            this.currentRuleLabel.Name = "currentRuleLabel";
            this.currentRuleLabel.Size = new System.Drawing.Size(72, 13);
            this.currentRuleLabel.TabIndex = 10;
            this.currentRuleLabel.Text = "Current Rule :";
            // 
            // renameOptionsGroupBox
            // 
            this.renameOptionsGroupBox.Controls.Add(this.folderNameRadioButton);
            this.renameOptionsGroupBox.Controls.Add(this.renameOptionsLabel);
            this.renameOptionsGroupBox.Controls.Add(this.renameRadioButton);
            this.renameOptionsGroupBox.Controls.Add(this.keepNameRadioButton);
            this.renameOptionsGroupBox.Location = new System.Drawing.Point(609, 161);
            this.renameOptionsGroupBox.Name = "renameOptionsGroupBox";
            this.renameOptionsGroupBox.Size = new System.Drawing.Size(184, 114);
            this.renameOptionsGroupBox.TabIndex = 16;
            this.renameOptionsGroupBox.TabStop = false;
            this.renameOptionsGroupBox.Text = "Rename Options";
            // 
            // renameOptionsLabel
            // 
            this.renameOptionsLabel.AutoSize = true;
            this.renameOptionsLabel.Location = new System.Drawing.Point(6, 16);
            this.renameOptionsLabel.Name = "renameOptionsLabel";
            this.renameOptionsLabel.Size = new System.Drawing.Size(90, 13);
            this.renameOptionsLabel.TabIndex = 2;
            this.renameOptionsLabel.Text = "Select an option :";
            // 
            // renameRadioButton
            // 
            this.renameRadioButton.AutoSize = true;
            this.renameRadioButton.Checked = true;
            this.renameRadioButton.Location = new System.Drawing.Point(13, 32);
            this.renameRadioButton.Name = "renameRadioButton";
            this.renameRadioButton.Size = new System.Drawing.Size(142, 17);
            this.renameRadioButton.TabIndex = 1;
            this.renameRadioButton.TabStop = true;
            this.renameRadioButton.Text = "Rename with new name.";
            this.renameRadioButton.UseVisualStyleBackColor = true;
            this.renameRadioButton.CheckedChanged += new System.EventHandler(this.renameRadioButton_CheckedChanged);
            // 
            // keepNameRadioButton
            // 
            this.keepNameRadioButton.AutoSize = true;
            this.keepNameRadioButton.Location = new System.Drawing.Point(13, 55);
            this.keepNameRadioButton.Name = "keepNameRadioButton";
            this.keepNameRadioButton.Size = new System.Drawing.Size(143, 17);
            this.keepNameRadioButton.TabIndex = 0;
            this.keepNameRadioButton.Text = "Keep the current\'s name.";
            this.keepNameRadioButton.UseVisualStyleBackColor = true;
            // 
            // folderNameRadioButton
            // 
            this.folderNameRadioButton.AutoSize = true;
            this.folderNameRadioButton.Location = new System.Drawing.Point(13, 78);
            this.folderNameRadioButton.Name = "folderNameRadioButton";
            this.folderNameRadioButton.Size = new System.Drawing.Size(149, 30);
            this.folderNameRadioButton.TabIndex = 3;
            this.folderNameRadioButton.Text = "Rename as the containing\r\nfolder\'s name.";
            this.folderNameRadioButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 462);
            this.Controls.Add(this.renameOptionsGroupBox);
            this.Controls.Add(this.ruleGroupBox);
            this.Controls.Add(this.startNumberTextBox);
            this.Controls.Add(this.startNumberCheckBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.msButton);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.shuffleButton);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.filesNewNameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.addFileButton);
            this.Controls.Add(this.pathsTextBox);
            this.Controls.Add(this.renameButton);
            this.Icon = global::RenameFiles.Properties.Resources.icon;
            this.MinimumSize = new System.Drawing.Size(821, 500);
            this.Name = "MainForm";
            this.Text = "Rename My Files";
            this.ruleGroupBox.ResumeLayout(false);
            this.ruleGroupBox.PerformLayout();
            this.renameOptionsGroupBox.ResumeLayout(false);
            this.renameOptionsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button renameButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox pathsTextBox;
        private System.Windows.Forms.Button addFileButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label filesNewNameLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.Button shuffleButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button msButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.CheckBox startNumberCheckBox;
        private System.Windows.Forms.TextBox startNumberTextBox;
        private System.Windows.Forms.Button resetRuleButton;
        private System.Windows.Forms.GroupBox ruleGroupBox;
        private System.Windows.Forms.Label ruleLabel;
        private System.Windows.Forms.Label currentRuleLabel;
        private System.Windows.Forms.Button ruleButton;
        private System.Windows.Forms.GroupBox renameOptionsGroupBox;
        private System.Windows.Forms.RadioButton renameRadioButton;
        private System.Windows.Forms.RadioButton keepNameRadioButton;
        private System.Windows.Forms.Label renameOptionsLabel;
        private System.Windows.Forms.RadioButton folderNameRadioButton;
    }
}

