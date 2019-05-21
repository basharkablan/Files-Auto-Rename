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
    public partial class msForm : Form
    {
        private int selectedIndex = 0;

        public msForm()
        {
            InitializeComponent();
        }

        private void msForm_Load(object sender, EventArgs e)
        {
            sortingListBox.SelectedIndex = selectedIndex;
        }

        private void toFirstButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (sortingListBox.SelectedIndex > 0)
                {
                    object temp = sortingListBox.Items[sortingListBox.SelectedIndex];
                    sortingListBox.Items.RemoveAt(sortingListBox.SelectedIndex);
                    sortingListBox.Items.Insert(0, temp);
                    sortingListBox.SelectedIndex = 0;
                    selectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (sortingListBox.SelectedIndex > 0)
                {
                    selectedIndex = sortingListBox.SelectedIndex;
                    object temp = sortingListBox.Items[sortingListBox.SelectedIndex];
                    sortingListBox.Items.RemoveAt(sortingListBox.SelectedIndex);
                    sortingListBox.SelectedIndex = selectedIndex - 1;
                    sortingListBox.Items.Insert(sortingListBox.SelectedIndex, temp);
                    sortingListBox.SelectedIndex = selectedIndex - 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (sortingListBox.SelectedIndex < sortingListBox.Items.Count - 1)
                {
                    selectedIndex = sortingListBox.SelectedIndex;
                    object temp = sortingListBox.Items[sortingListBox.SelectedIndex];
                    sortingListBox.Items.RemoveAt(sortingListBox.SelectedIndex);
                    sortingListBox.SelectedIndex = selectedIndex;
                    sortingListBox.Items.Insert(sortingListBox.SelectedIndex + 1, temp);
                    sortingListBox.SelectedIndex = selectedIndex + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void toLastButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (sortingListBox.SelectedIndex < sortingListBox.Items.Count - 1)
                {
                    object temp = sortingListBox.Items[sortingListBox.SelectedIndex];
                    sortingListBox.Items.RemoveAt(sortingListBox.SelectedIndex);
                    sortingListBox.Items.Add(temp);
                    sortingListBox.SelectedIndex = sortingListBox.Items.Count - 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Not Checked Yet !!!!!!

                DialogResult result = openFileDialog1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string[] paths = openFileDialog1.FileNames;

                    sortingListBox.Items.AddRange(paths);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                selectedIndex = sortingListBox.SelectedIndex;
                sortingListBox.Items.RemoveAt(sortingListBox.SelectedIndex);

                if (selectedIndex < sortingListBox.Items.Count)
                    sortingListBox.SelectedIndex = selectedIndex;
                else
                    if (selectedIndex < sortingListBox.Items.Count && selectedIndex > 0)
                        sortingListBox.SelectedIndex = selectedIndex - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
    }
}