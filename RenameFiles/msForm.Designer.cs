namespace RenameFiles
{
    partial class msForm
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
            this.sortingListBox = new System.Windows.Forms.ListBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.doneButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.toFirstButton = new System.Windows.Forms.Button();
            this.toLastButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // sortingListBox
            // 
            this.sortingListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sortingListBox.FormattingEnabled = true;
            this.sortingListBox.Location = new System.Drawing.Point(12, 12);
            this.sortingListBox.Name = "sortingListBox";
            this.sortingListBox.Size = new System.Drawing.Size(378, 355);
            this.sortingListBox.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(12, 379);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(101, 35);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // doneButton
            // 
            this.doneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.doneButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.doneButton.Location = new System.Drawing.Point(396, 379);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(101, 35);
            this.doneButton.TabIndex = 11;
            this.doneButton.Text = "OK";
            this.doneButton.UseVisualStyleBackColor = true;
            // 
            // upButton
            // 
            this.upButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.upButton.Location = new System.Drawing.Point(396, 191);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(101, 35);
            this.upButton.TabIndex = 12;
            this.upButton.Text = "Move Up / ▲";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // downButton
            // 
            this.downButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.downButton.Location = new System.Drawing.Point(396, 232);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(101, 35);
            this.downButton.TabIndex = 13;
            this.downButton.Text = "Move Down / ▼";
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // toFirstButton
            // 
            this.toFirstButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.toFirstButton.Location = new System.Drawing.Point(396, 150);
            this.toFirstButton.Name = "toFirstButton";
            this.toFirstButton.Size = new System.Drawing.Size(101, 35);
            this.toFirstButton.TabIndex = 14;
            this.toFirstButton.Text = "To First / ↑";
            this.toFirstButton.UseVisualStyleBackColor = true;
            this.toFirstButton.Click += new System.EventHandler(this.toFirstButton_Click);
            // 
            // toLastButton
            // 
            this.toLastButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.toLastButton.Location = new System.Drawing.Point(396, 273);
            this.toLastButton.Name = "toLastButton";
            this.toLastButton.Size = new System.Drawing.Size(101, 35);
            this.toLastButton.TabIndex = 15;
            this.toLastButton.Text = "To Last / ↓";
            this.toLastButton.UseVisualStyleBackColor = true;
            this.toLastButton.Click += new System.EventHandler(this.toLastButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addButton.Location = new System.Drawing.Point(396, 68);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(101, 35);
            this.addButton.TabIndex = 16;
            this.addButton.Text = "Add / +";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.removeButton.Location = new System.Drawing.Point(396, 109);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(101, 35);
            this.removeButton.TabIndex = 17;
            this.removeButton.Text = "Remove / -";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "Choose File To Add !!";
            // 
            // msForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 426);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.toLastButton);
            this.Controls.Add(this.toFirstButton);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.upButton);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.sortingListBox);
            this.MinimumSize = new System.Drawing.Size(400, 464);
            this.Name = "msForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "msForm";
            this.Load += new System.EventHandler(this.msForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox sortingListBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button toFirstButton;
        private System.Windows.Forms.Button toLastButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}