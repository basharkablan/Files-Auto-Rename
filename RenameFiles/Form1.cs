using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace RenameFiles
{
    public partial class MainForm : Form
    {
        public string[] paths = new string[0];
        private int[] rNums;
        private int cnt = 0;
        private string rule = "<FILE_NAME>-<NUMBER>";
        private bool keepName = false;
        private bool useContFolderName = false;

        public MainForm()
        {
            InitializeComponent();

            ruleLabel.Text = rule;
        }

        private void addFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                string[] oldPaths = paths;
                DialogResult result = openFileDialog1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    pathsTextBox.Text = "";
                    cnt = 0;

                    paths = new string[oldPaths.Length + openFileDialog1.FileNames.Length];

                    for (int i = 0; i < oldPaths.Length; i++)
                        paths[i] = oldPaths[i];

                    for (int i = oldPaths.Length; i < openFileDialog1.FileNames.Length + oldPaths.Length; i++)
                        paths[i] = openFileDialog1.FileNames[i - oldPaths.Length];

                    rNums = new int[paths.Length];
                    for (int i = 0; i < paths.Length; i++)
                        rNums[i] = i;

                    PrintFiles();

                    MessageBox.Show("The wanted files has been added.");

                    progressBar1.Value = 0;
                    progressLabel.Text = "Progress (0%)";
                }

                /*DialogResult result = openFileDialog1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    paths = openFileDialog1.FileNames;

                    rNums = new int[paths.Length];
                    for (int i = 0; i < paths.Length; i++)
                        rNums[i] = i;

                    progressBar1.Value = 0;
                    progressLabel.Text = "Progress (0%)";

                    PrintFiles();
                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                return;
            }
        }

        private void renameButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" && !useContFolderName && !keepName)
            {
                MessageBox.Show("Enter New Name !!");
                return;
            }

            if (paths.Length == 0)
            {
                MessageBox.Show("Add new files !!");
                return;
            }

            int startNum = 1;

            if (startNumberCheckBox.Checked)
            {
                if (startNumberTextBox.Text == "")
                {
                    MessageBox.Show("Add start number or UNCHECK the start number checkbox !!");
                    return;
                }
                else
                    if (!int.TryParse(startNumberTextBox.Text, out startNum))
                    {
                        MessageBox.Show("Wrong start number format !!");
                        return;
                    }
            }

            if (DialogResult.No == MessageBox.Show("You can't undo this step, Do you want to continue ?", "Caution !!", MessageBoxButtons.YesNo))
            {
                goto notsure;
            }

            string editedPath = "";
            int slashIndex = 0;
            int contFolderSlashIndex = 0;
            int dotIndex = 0;
            string name = "";
            string contFolderName = "";
            string dig0 = "";
            int number0 = 0;

            for (int i = 0; i < cnt; i++)
            {
                try
                {
                    dig0 = "";
                    number0 = (paths.Length + startNum).ToString().Length - (rNums[i] + startNum/* + 1*/).ToString().Length;

                    for (int j = 0; j < number0; j++)
                        dig0 += "0";

                    slashIndex = paths[rNums[i]].LastIndexOf(@"\");
                    dotIndex = paths[rNums[i]].LastIndexOf(".");
                    name = paths[rNums[i]].Substring(slashIndex, dotIndex - slashIndex);

                    if (folderNameRadioButton.Checked)
                    {
                        if (paths[rNums[i]].LastIndexOf(@"\") == paths[rNums[i]].IndexOf(@"\"))
                            contFolderName = paths[rNums[i]].Substring(0, slashIndex).Replace(":", "");
                        else
                        {
                            contFolderSlashIndex = paths[rNums[i]].Remove(slashIndex).LastIndexOf(@"\");
                            contFolderName = paths[rNums[i]].Substring(contFolderSlashIndex, slashIndex - contFolderSlashIndex);
                        }
                    }

                    editedPath = paths[rNums[i]].Remove(slashIndex + 1, name.Length - 1);

                    // Without start number or rule
                    //editedPath = editedPath.Insert(slashIndex + 1, nameTextBox.Text + "-" + dig0 + (rNums[i] + 1));

                    // With start number, but without rule
                    //editedPath = editedPath.Insert(slashIndex + 1, nameTextBox.Text + "-" + dig0 + (rNums[i] + startNum/* + 1*/));

                    if (keepName)
                        editedPath = editedPath.Insert(slashIndex + 1,
                            ReplaceStrings(name.Remove(0, 1), dig0 + (rNums[i] + startNum)));
                    else
                    {
                        if (useContFolderName)
                            editedPath = editedPath.Insert(slashIndex + 1,
                            ReplaceStrings(contFolderName, dig0 + (rNums[i] + startNum)));
                        else
                            editedPath = editedPath.Insert(slashIndex + 1,
                            ReplaceStrings(nameTextBox.Text, dig0 + (rNums[i] + startNum)));
                    }
                    

                    File.Move(paths[rNums[i]], editedPath);

                    progressBar1.Value = (int)((((double)i + 1) / cnt) * 100);

                    progressLabel.Text = "Progress (" + progressBar1.Value + "%)";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message);
                }
            }

            paths = new string[0];
            cnt = 0;

            MessageBox.Show("Done !!");

            notsure: ;
        }

        private string ReplaceStrings(string fileName, string number)
        {
            return rule.Replace("<FILE_NAME>", fileName).Replace("<NUMBER>", number);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void shuffleButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (paths.Length == 0)
                {
                    MessageBox.Show("Add new files !!");
                    return;
                }

                if (cnt > 0)
                {
                    rNums = returnRandomAr(paths.Length);
                    pathsTextBox.Text = "";
                    cnt = 0;

                    PrintFiles();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private int[] returnRandomAr(int len)
        {
            int i, temp, n;
            Random rnd = new Random();
            int[] ar = new int[len];

            for (i = 0; i < len; i++)
                ar[i] = i;

            for (i = 0; i < len; i++)
            {
                n = rnd.Next(len);
                temp = ar[n];
                ar[n] = ar[i];
                ar[i] = temp;
            }
            return ar;
        }

        private void PrintFiles()
        {
            try
            {
                pathsTextBox.Text = "";

                if (paths.Length <= 100)
                    for (cnt = 0; cnt < paths.Length; cnt++)
                        pathsTextBox.Text += (cnt + 1).ToString()
                            + " - " + paths[rNums[cnt]] + Environment.NewLine;
                else
                {
                    cnt = paths.Length;
                    pathsTextBox.Text = "The number of the wanted files is more than 100 (It is : " + cnt + ").";
                    pathsTextBox.Text += Environment.NewLine;
                    pathsTextBox.Text += "So the paths won't be written in this textbox.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            try
            {
                AboutBox1 ab = new AboutBox1();

                ab.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void msButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (cnt != 0)
                {
                    msForm msf = new msForm();

                    for (int i = 0; i < paths.Length; i++)
                        msf.sortingListBox.Items.Add(paths[rNums[i]]);

                    if (msf.ShowDialog() == DialogResult.OK)
                    {
                        paths = new string[msf.sortingListBox.Items.Count];
                        cnt = msf.sortingListBox.Items.Count;
                        rNums = new int[msf.sortingListBox.Items.Count];

                        for (int i = 0; i < msf.sortingListBox.Items.Count; i++)
                        {
                            paths[i] = msf.sortingListBox.Items[i].ToString();
                            rNums[i] = i;
                        }
                        PrintFiles();
                    }
                }
                else
                    MessageBox.Show("Add Files First !!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to clear the current paths ?",
                "Clear current paths", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                paths = new string[0];
                progressBar1.Value = 0;
                PrintFiles();
            }
        }

        private void startNumberCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (startNumberCheckBox.Checked)
                startNumberTextBox.Enabled = true;
            else
                startNumberTextBox.Enabled = false;
        }

        private void ruleButton_Click(object sender, EventArgs e)
        {
            RuleForm ruleForm = new RuleForm();

            if (ruleForm.ShowDialog() == DialogResult.OK)
            {
                rule = ruleForm.ruleTextBox.Text;
                ruleLabel.Text = rule;
            }
        }

        private void resetRuleButton_Click(object sender, EventArgs e)
        {
            rule = "<FILE_NAME>-<NUMBER>";
            ruleLabel.Text = rule;
        }

        private void renameRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (renameRadioButton.Checked)
            {
                nameTextBox.Enabled = true;
                keepName = false;
                useContFolderName = false;
            }
            else
            {
                if (keepNameRadioButton.Checked)
                {
                    nameTextBox.Enabled = false;
                    keepName = true;
                    useContFolderName = false;
                }
                else
                {
                    nameTextBox.Enabled = false;
                    keepName = false;
                    useContFolderName = true;
                }
            }
        }
    }
}