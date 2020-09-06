using System;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;

using EncryptionAndHashingLibrary;

namespace FileEncryption.GUI
{
    public partial class Client : System.Windows.Forms.Form
    {
        private static readonly string USER_MANUAL_URL = "https://google.com";

        private readonly Color DEFAULT_CONTROL_BACKGROUND_COLOR;

        public Client()
        {
            InitializeComponent();

            DEFAULT_CONTROL_BACKGROUND_COLOR = passwordBox1.BackColor;
        }

        // ---

        public bool PasswordIsSet()
        {
            return passwordBox1.Text.Length > 0 &&
                passwordBox1.Text == passwordBox2.Text;
        }

        public byte[] PasswordAsKey()
        {
            return Tools.GetPasswordAsEncryptionKey(AesEncryptionWrapper.GCM_KEY_SIZE, passwordBox1.Text);
        }

        // ---

        private void Encrypt(List<string> inputFilePaths)
        {
            int counter = 0;
            bool skippedBecauseFileExists = false;

            foreach (string inputFilePath in inputFilePaths)
            {
                // Proceed if file exists
                if (File.Exists(inputFilePath))
                {
                    try
                    {
                        // Encrypt
                        byte[] key = PasswordAsKey();
                        string[] encryptedFileContents = AesFileEncryption.Encrypt(inputFilePath, key);

                        // Write to file
                        string outputFilePath = inputFilePath;
                        outputFilePath += ".ENCRYPTED";
                        if (File.Exists(outputFilePath))
                        {
                            skippedBecauseFileExists = true;
                        }
                        else
                        {
                            File.WriteAllLines(outputFilePath, encryptedFileContents);
                            counter++;

                            // Status
                            statusLabel.Text = "Copied and encrypted \"" + Path.GetFileName(inputFilePath) + "\"";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            // Status
            statusLabel.Text = "Copied and encrypted " + counter + "/" + inputFilePaths.Count + " " +
                ((counter == 1) ? "file" : "files");
            if (skippedBecauseFileExists) statusLabel.Text += " (skipped to stop overwriting)";
        }

        private void Decrypt(List<string> inputFilePaths)
        {
            int counter = 0;
            bool skippedBecauseFileExists = false;

            foreach (string inputFilePath in inputFilePaths)
            {
                // Proceed if file exist
                if (File.Exists(inputFilePath))
                {
                    try
                    {
                        // Decrypt
                        byte[] key = PasswordAsKey();
                        byte[] decryptedData = AesFileEncryption.Decrypt(inputFilePath, key);

                        // Write to file
                        string outputFilePath = inputFilePath;
                        if (outputFilePath.EndsWith(".ENCRYPTED")) // user may have removed it
                            outputFilePath = outputFilePath.Substring(0, outputFilePath.LastIndexOf(".ENCRYPTED"));
                        outputFilePath = Path.GetDirectoryName(outputFilePath) + @"\" +
                            Path.GetFileNameWithoutExtension(outputFilePath) + ".DECRYPTED" +
                            Path.GetExtension(outputFilePath);
                        if (File.Exists(outputFilePath))
                        {
                            skippedBecauseFileExists = true;
                        }
                        else
                        {
                            File.WriteAllBytes(outputFilePath, decryptedData);
                            counter++;

                            // Status
                            statusLabel.Text = "Decrypted \"" + Path.GetFileName(inputFilePath) + "\"";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + " Did you use the wrong password?", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            // Show result
            statusLabel.Text = "Decrypted " + counter + "/" + inputFilePaths.Count + " " +
                ((counter == 1) ? "file" : "files");
            if (skippedBecauseFileExists) statusLabel.Text += " (skipped to stop overwriting)";
        }

        // ---

        private void passwordBox1_TextChanged(object sender, EventArgs e)
        {
            processBox.Enabled = PasswordIsSet();
            encryptButton.Enabled = PasswordIsSet();
            decryptButton.Enabled = PasswordIsSet();

            // ---

            if (passwordBox1.TextLength >= 16 ||
                    (passwordBox1.TextLength >= 8 &&
                     passwordBox1.Text.Any(char.IsUpper) && passwordBox1.Text.Any(char.IsLower) &&
                     passwordBox1.Text.Any(char.IsNumber)))
            {
                passwordBox1.BackColor = Color.LightGreen;
            }
            else if (passwordBox1.TextLength >= 8 ||
                       (passwordBox1.TextLength >= 6 &&
                        (passwordBox1.Text.Any(char.IsUpper) || passwordBox1.Text.Any(char.IsLower)) &&
                        passwordBox1.Text.Any(char.IsNumber)))
            {
                passwordBox1.BackColor = Color.Yellow;
            }
            else if (passwordBox1.TextLength > 0 && passwordBox1.TextLength < 8)
            {
                passwordBox1.BackColor = Color.LightPink;
            }
            else
            {
                passwordBox1.BackColor = DEFAULT_CONTROL_BACKGROUND_COLOR;
            }
        }

        private void passwordBox2_TextChanged(object sender, EventArgs e)
        {
            processBox.Enabled = PasswordIsSet();
            encryptButton.Enabled = PasswordIsSet();
            decryptButton.Enabled = PasswordIsSet();

            // ---

            if (passwordBox2.TextLength > 0 && passwordBox1.Text == passwordBox2.Text)
                passwordBox2.BackColor = Color.LightGreen;
            else
                passwordBox2.BackColor = DEFAULT_CONTROL_BACKGROUND_COLOR;
        }

        private void controlEncrypt_Click(object sender, EventArgs e)
        {
            if (PasswordIsSet())
            {
                // Select file
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Select files for encryption";
                openFileDialog.Multiselect = true;
                openFileDialog.ShowDialog();

                // Get paths
                List<string> filePaths = new List<string>();
                filePaths.AddRange(openFileDialog.FileNames);

                Encrypt(filePaths);
            }
        }

        private void controlDecrypt_Click(object sender, EventArgs e)
        {
            if (PasswordIsSet())
            {
                // Select file
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Select files for decryption";
                openFileDialog.Multiselect = true;
                openFileDialog.ShowDialog();

                // Get paths
                List<string> filePaths = new List<string>();
                filePaths.AddRange(openFileDialog.FileNames);

                Decrypt(filePaths);
            }
        }

        private void userManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = USER_MANUAL_URL,
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string info = "";
            info += "Name:\t\tFile Encryption";
            info += "\r\n";
            info += "Encryption:\tAES-128 GCM";
            info += "\r\n";
            info += "Version:\t\t" + System.Windows.Forms.Application.ProductVersion;
            info += "\r\n";
            info += "Developer:\tOve Bakken";
            info += "\r\n";
            info += "License:\t\tMIT";

            MessageBox.Show(info, "About");
        }

        private void label_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void labelEncrypt_DragDrop(object sender, DragEventArgs e)
        {
            if (PasswordIsSet())
            {
                // Get paths
                List<string> filePaths = new List<string>();
                filePaths.AddRange((string[])e.Data.GetData(DataFormats.FileDrop, false));

                Encrypt(filePaths);
            }
        }

        private void labelDecrypt_DragDrop(object sender, DragEventArgs e)
        {
            if (PasswordIsSet())
            {
                // Get paths
                List<string> filePaths = new List<string>();
                filePaths.AddRange((string[])e.Data.GetData(DataFormats.FileDrop, false));

                Decrypt(filePaths);
            }
        }
    }
}
