using System;
using System.Windows.Forms;

namespace HillEncryptorDecryptor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private bool ISEncryptionInputValid()
        {
            if (String.IsNullOrEmpty(encryptionAlphabetTextBox.Text))
            {
                MessageBox.Show("Alphabet can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(encryptionPlaintextTextBox.Text))
            {
                MessageBox.Show("Please type some text to encrypt", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(encryptionKeyTextBox.Text))
            {
                MessageBox.Show("Encryption key can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void encryptionButton_Click(object sender, EventArgs e)
        {
            if (!ISEncryptionInputValid())
            {
                return;
            }

            try
            {
                HillCipher hillCipher = new HillCipher(encryptionAlphabetTextBox.Text, encryptionKeyTextBox.Text);
                encryptionCiphertextTextBox.Text = hillCipher.Encrypt(encryptionPlaintextTextBox.Text);
            } 
            catch(Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool IsDecryptionInputValid()
        {
            if (String.IsNullOrEmpty(decryptionAlphabetTextBox.Text))
            {
                MessageBox.Show("Alphabet can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(decryptionCiphertextTextBox.Text))
            {
                MessageBox.Show("Please type some text to decrypt", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(decryptionKeyTextBox.Text))
            {
                MessageBox.Show("Decryption key can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void decryptionButton_Click(object sender, EventArgs e)
        {
            if (!IsDecryptionInputValid())
            {
                return;
            }

            try
            {
                HillCipher hillCipher = new HillCipher(decryptionAlphabetTextBox.Text, decryptionKeyTextBox.Text);
                decryptionPlaintextTextBox.Text = hillCipher.Decrypt(decryptionCiphertextTextBox.Text);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.StackTrace);
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
    
