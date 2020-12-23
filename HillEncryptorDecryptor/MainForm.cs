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

        private bool ValidEncryptionInput()
        {
            // التحقق من أن حقول الإدخال ليست فارغة
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
            if (!ValidEncryptionInput())
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


        private bool ValidateDecryptionInput()
        {
            return false;
        }

        private void decryptionButton_Click(object sender, EventArgs e)
        {
            if (!ValidateDecryptionInput())
            {

                return;
            }
        }
    }
}
    
