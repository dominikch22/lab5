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
        private bool compression = false;
        private bool encryption = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void koniecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveToFile(editField.Text, pathTextBox.Text);
        }

        private void saveToFile(string text, string path)
        {
            try
            {
                using (FileStream file = new FileStream(path, FileMode.Create))
                {
                    Stream finalStream = file;
                    if (encryption)
                    {
                        using (SHA256 sha = SHA256.Create())
                        {
                            using (Aes aesAlg = Aes.Create())
                            {
                                byte[] IV = new byte[aesAlg.BlockSize / 8]; ;
                                byte[] Key = Encoding.UTF8.GetBytes("YourEncryptionKey");
                                byte[] hashKey = sha.ComputeHash(Key);
                                aesAlg.Key = hashKey;
                                aesAlg.IV = IV;
                                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                                finalStream = new CryptoStream(finalStream, encryptor, CryptoStreamMode.Write);
                            }
                        }
                    }

                    if (compression)
                    {
                        finalStream = new GZipStream(finalStream, CompressionMode.Compress);
                    }

                    byte[] bytes = Encoding.UTF8.GetBytes(text); ;
                    finalStream.Write(bytes, 0, bytes.Length);
                    finalStream.Dispose();
                }
            }
            catch { 
                
            }
            

        }
        

        private String readFile(string path)
        {
            byte[] buffer;
            try
            {
                using (FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    Stream finalStream = file;
                    if (encryption)
                    {
                        using (SHA256 sha = SHA256.Create())
                        {
                            using (Aes aesAlg = Aes.Create())
                            {
                                byte[] IV = new byte[aesAlg.BlockSize / 8]; ;
                                byte[] Key = Encoding.UTF8.GetBytes("YourEncryptionKey");
                                byte[] hashKey = sha.ComputeHash(Key);
                                aesAlg.Key = hashKey;
                                aesAlg.IV = IV;
                                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                                finalStream = new CryptoStream(finalStream, decryptor, CryptoStreamMode.Read);
                            }
                        }
                    }

                    if (compression)
                    {
                        finalStream = new GZipStream(finalStream, CompressionMode.Decompress);
                    }

                    using (MemoryStream output = new MemoryStream())
                    {
                        try
                        {
                            finalStream.CopyTo(output);
                            buffer = output.ToArray();
                        }
                        catch
                        {
                            return "Nie można odczytać pliku";
                        }

                    }
                    finalStream.Dispose();
                }
            }
            catch {
                return "Nie można odczytać pliku";
            }
           

            return Encoding.UTF8.GetString(buffer);
        }

        private void odczytajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editField.Text = readFile(pathTextBox.Text);
        }

        private void oDekoratorachToolStripMenuItem_Click(object sender, EventArgs e)
        {

            sender.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void pathTextBox_TextChanged(object sender, EventArgs e)
        {         
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "C:\\";
            //openFileDialog.Filter = "All Files (*.*)|*.*"; 

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                pathTextBox.Text = selectedFilePath;
            }
        }

        private void kompresjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //kompresjaToolStripMenuItem.Checked = !kompresjaToolStripMenuItem.Checked;
            compression = kompresjaToolStripMenuItem.Checked;
        }

        private void szyfrowanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //szyfrowanieToolStripMenuItem.Checked = !szyfrowanieToolStripMenuItem.Checked;
            encryption = szyfrowanieToolStripMenuItem.Checked;
        }
    }
}
