using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;

namespace lab5
{
    public partial class Form1 : Form
    {
        private TextEditor TextEditor;

        public Form1()
        {
            InitializeComponent();
            TextEditor = new TextEditor(false, false, "");
        }

        private void koniecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TextEditor.saveToFile(editField.Text, pathTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK);
            }
        }

        private void odczytajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                editField.Text = TextEditor.readFile(pathTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK);
            }
        }

        private void oDekoratorachToolStripMenuItem_Click(object sender, EventArgs e)
        {

            sender.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "C:\\";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                pathTextBox.Text = selectedFilePath;
            }
        }

        private void kompresjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextEditor.Compression = kompresjaToolStripMenuItem.Checked;
        }

        private void szyfrowanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextEditor.Encryption = szyfrowanieToolStripMenuItem.Checked;
        }

        private void setPasswordButton_Click(object sender, EventArgs e)
        {
            TextEditor.Key = passwordTextBox.Text;
            passwordTextBox.Text = "";
        }
    }
}
