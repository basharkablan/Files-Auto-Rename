using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RenameFiles
{
    public partial class RuleForm : Form
    {
        public RuleForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (ruleTextBox.Text.Contains("<FILE_NAME>") && ruleTextBox.Text.Contains("<NUMBER>"))
                this.DialogResult = DialogResult.OK;
            else
                MessageBox.Show("Something went wrong, Please check the notes.", "Error");
        }

        private void addFileNameButton_Click(object sender, EventArgs e)
        {
            ruleTextBox.Text += "<FILE_NAME>";
        }

        private void addNumberButton_Click(object sender, EventArgs e)
        {
            ruleTextBox.Text += "<NUMBER>";
        }
    }
}
