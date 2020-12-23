namespace HillEncryptorDecryptor
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
            this.components = new System.ComponentModel.Container();
            this.encryptionPlaintextTextBox = new System.Windows.Forms.TextBox();
            this.encryptionPlaintextLabel = new System.Windows.Forms.Label();
            this.encryptionButton = new System.Windows.Forms.Button();
            this.encryptionKeyTextBox = new System.Windows.Forms.TextBox();
            this.encryptionKeyLabel = new System.Windows.Forms.Label();
            this.encryptionCiphertextTextBox = new System.Windows.Forms.TextBox();
            this.encryptionCiphertextLabel = new System.Windows.Forms.Label();
            this.key_toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.decryptionKeyLabel = new System.Windows.Forms.Label();
            this.encryptionAlphabetLabel = new System.Windows.Forms.Label();
            this.decryptionAlphabetLabel = new System.Windows.Forms.Label();
            this.encryptionGroupBox = new System.Windows.Forms.GroupBox();
            this.encryptionAlphabetTextBox = new System.Windows.Forms.TextBox();
            this.decryptionCiphertextLabel = new System.Windows.Forms.Label();
            this.decryptionPlaintextTextBox = new System.Windows.Forms.TextBox();
            this.decryptionKeyTextBox = new System.Windows.Forms.TextBox();
            this.decryptionButton = new System.Windows.Forms.Button();
            this.decryptionPlaintextLabel = new System.Windows.Forms.Label();
            this.decryptionCiphertextTextBox = new System.Windows.Forms.TextBox();
            this.decryptionGroupBox = new System.Windows.Forms.GroupBox();
            this.decryptionAlphabetTextBox = new System.Windows.Forms.TextBox();
            this.encryptionGroupBox.SuspendLayout();
            this.decryptionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // encryptionPlaintextTextBox
            // 
            this.encryptionPlaintextTextBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptionPlaintextTextBox.Location = new System.Drawing.Point(104, 76);
            this.encryptionPlaintextTextBox.Multiline = true;
            this.encryptionPlaintextTextBox.Name = "encryptionPlaintextTextBox";
            this.encryptionPlaintextTextBox.Size = new System.Drawing.Size(331, 94);
            this.encryptionPlaintextTextBox.TabIndex = 2;
            // 
            // encryptionPlaintextLabel
            // 
            this.encryptionPlaintextLabel.AutoSize = true;
            this.encryptionPlaintextLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.encryptionPlaintextLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.encryptionPlaintextLabel.Location = new System.Drawing.Point(33, 76);
            this.encryptionPlaintextLabel.Name = "encryptionPlaintextLabel";
            this.encryptionPlaintextLabel.Size = new System.Drawing.Size(57, 15);
            this.encryptionPlaintextLabel.TabIndex = 1;
            this.encryptionPlaintextLabel.Text = "Plaintext";
            // 
            // encryptionButton
            // 
            this.encryptionButton.BackColor = System.Drawing.Color.SteelBlue;
            this.encryptionButton.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptionButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.encryptionButton.Location = new System.Drawing.Point(216, 221);
            this.encryptionButton.Name = "encryptionButton";
            this.encryptionButton.Size = new System.Drawing.Size(81, 42);
            this.encryptionButton.TabIndex = 4;
            this.encryptionButton.Text = "Enncrypt";
            this.encryptionButton.UseVisualStyleBackColor = false;
            this.encryptionButton.Click += new System.EventHandler(this.encryptionButton_Click);
            // 
            // encryptionKeyTextBox
            // 
            this.encryptionKeyTextBox.Font = new System.Drawing.Font("Arial", 11.25F);
            this.encryptionKeyTextBox.Location = new System.Drawing.Point(104, 185);
            this.encryptionKeyTextBox.Name = "encryptionKeyTextBox";
            this.encryptionKeyTextBox.Size = new System.Drawing.Size(331, 25);
            this.encryptionKeyTextBox.TabIndex = 3;
            // 
            // encryptionKeyLabel
            // 
            this.encryptionKeyLabel.AutoSize = true;
            this.encryptionKeyLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.encryptionKeyLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.encryptionKeyLabel.Location = new System.Drawing.Point(62, 185);
            this.encryptionKeyLabel.Name = "encryptionKeyLabel";
            this.encryptionKeyLabel.Size = new System.Drawing.Size(28, 15);
            this.encryptionKeyLabel.TabIndex = 4;
            this.encryptionKeyLabel.Text = "Key";
            this.key_toolTip.SetToolTip(this.encryptionKeyLabel, "16 byte ");
            // 
            // encryptionCiphertextTextBox
            // 
            this.encryptionCiphertextTextBox.Font = new System.Drawing.Font("Arial", 11.25F);
            this.encryptionCiphertextTextBox.Location = new System.Drawing.Point(104, 278);
            this.encryptionCiphertextTextBox.Multiline = true;
            this.encryptionCiphertextTextBox.Name = "encryptionCiphertextTextBox";
            this.encryptionCiphertextTextBox.ReadOnly = true;
            this.encryptionCiphertextTextBox.Size = new System.Drawing.Size(331, 125);
            this.encryptionCiphertextTextBox.TabIndex = 5;
            // 
            // encryptionCiphertextLabel
            // 
            this.encryptionCiphertextLabel.AutoSize = true;
            this.encryptionCiphertextLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptionCiphertextLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.encryptionCiphertextLabel.Location = new System.Drawing.Point(24, 278);
            this.encryptionCiphertextLabel.Name = "encryptionCiphertextLabel";
            this.encryptionCiphertextLabel.Size = new System.Drawing.Size(66, 15);
            this.encryptionCiphertextLabel.TabIndex = 6;
            this.encryptionCiphertextLabel.Text = "Ciphertext";
            // 
            // decryptionKeyLabel
            // 
            this.decryptionKeyLabel.AutoSize = true;
            this.decryptionKeyLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.decryptionKeyLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.decryptionKeyLabel.Location = new System.Drawing.Point(68, 186);
            this.decryptionKeyLabel.Name = "decryptionKeyLabel";
            this.decryptionKeyLabel.Size = new System.Drawing.Size(28, 15);
            this.decryptionKeyLabel.TabIndex = 11;
            this.decryptionKeyLabel.Text = "Key";
            this.key_toolTip.SetToolTip(this.decryptionKeyLabel, "16 byte ");
            // 
            // encryptionAlphabetLabel
            // 
            this.encryptionAlphabetLabel.AutoSize = true;
            this.encryptionAlphabetLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.encryptionAlphabetLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.encryptionAlphabetLabel.Location = new System.Drawing.Point(33, 36);
            this.encryptionAlphabetLabel.Name = "encryptionAlphabetLabel";
            this.encryptionAlphabetLabel.Size = new System.Drawing.Size(57, 15);
            this.encryptionAlphabetLabel.TabIndex = 8;
            this.encryptionAlphabetLabel.Text = "Alphabet";
            this.key_toolTip.SetToolTip(this.encryptionAlphabetLabel, "16 byte ");
            // 
            // decryptionAlphabetLabel
            // 
            this.decryptionAlphabetLabel.AutoSize = true;
            this.decryptionAlphabetLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.decryptionAlphabetLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.decryptionAlphabetLabel.Location = new System.Drawing.Point(39, 37);
            this.decryptionAlphabetLabel.Name = "decryptionAlphabetLabel";
            this.decryptionAlphabetLabel.Size = new System.Drawing.Size(57, 15);
            this.decryptionAlphabetLabel.TabIndex = 10;
            this.decryptionAlphabetLabel.Text = "Alphabet";
            this.key_toolTip.SetToolTip(this.decryptionAlphabetLabel, "16 byte ");
            // 
            // encryptionGroupBox
            // 
            this.encryptionGroupBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.encryptionGroupBox.Controls.Add(this.encryptionAlphabetLabel);
            this.encryptionGroupBox.Controls.Add(this.encryptionAlphabetTextBox);
            this.encryptionGroupBox.Controls.Add(this.encryptionCiphertextLabel);
            this.encryptionGroupBox.Controls.Add(this.encryptionCiphertextTextBox);
            this.encryptionGroupBox.Controls.Add(this.encryptionKeyLabel);
            this.encryptionGroupBox.Controls.Add(this.encryptionKeyTextBox);
            this.encryptionGroupBox.Controls.Add(this.encryptionButton);
            this.encryptionGroupBox.Controls.Add(this.encryptionPlaintextLabel);
            this.encryptionGroupBox.Controls.Add(this.encryptionPlaintextTextBox);
            this.encryptionGroupBox.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptionGroupBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.encryptionGroupBox.Location = new System.Drawing.Point(15, 18);
            this.encryptionGroupBox.Name = "encryptionGroupBox";
            this.encryptionGroupBox.Size = new System.Drawing.Size(482, 418);
            this.encryptionGroupBox.TabIndex = 0;
            this.encryptionGroupBox.TabStop = false;
            this.encryptionGroupBox.Text = "Encryption";
            // 
            // encryptionAlphabetTextBox
            // 
            this.encryptionAlphabetTextBox.Font = new System.Drawing.Font("Arial", 11.25F);
            this.encryptionAlphabetTextBox.Location = new System.Drawing.Point(104, 36);
            this.encryptionAlphabetTextBox.Name = "encryptionAlphabetTextBox";
            this.encryptionAlphabetTextBox.Size = new System.Drawing.Size(331, 25);
            this.encryptionAlphabetTextBox.TabIndex = 1;
            this.encryptionAlphabetTextBox.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            // 
            // decryptionCiphertextLabel
            // 
            this.decryptionCiphertextLabel.AutoSize = true;
            this.decryptionCiphertextLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptionCiphertextLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.decryptionCiphertextLabel.Location = new System.Drawing.Point(30, 77);
            this.decryptionCiphertextLabel.Name = "decryptionCiphertextLabel";
            this.decryptionCiphertextLabel.Size = new System.Drawing.Size(66, 15);
            this.decryptionCiphertextLabel.TabIndex = 13;
            this.decryptionCiphertextLabel.Text = "Ciphertext";
            // 
            // decryptionPlaintextTextBox
            // 
            this.decryptionPlaintextTextBox.Font = new System.Drawing.Font("Arial", 11.25F);
            this.decryptionPlaintextTextBox.Location = new System.Drawing.Point(109, 279);
            this.decryptionPlaintextTextBox.Multiline = true;
            this.decryptionPlaintextTextBox.Name = "decryptionPlaintextTextBox";
            this.decryptionPlaintextTextBox.ReadOnly = true;
            this.decryptionPlaintextTextBox.Size = new System.Drawing.Size(331, 125);
            this.decryptionPlaintextTextBox.TabIndex = 12;
            // 
            // decryptionKeyTextBox
            // 
            this.decryptionKeyTextBox.Font = new System.Drawing.Font("Arial", 11.25F);
            this.decryptionKeyTextBox.Location = new System.Drawing.Point(109, 181);
            this.decryptionKeyTextBox.Name = "decryptionKeyTextBox";
            this.decryptionKeyTextBox.Size = new System.Drawing.Size(331, 25);
            this.decryptionKeyTextBox.TabIndex = 12;
            // 
            // decryptionButton
            // 
            this.decryptionButton.BackColor = System.Drawing.Color.SteelBlue;
            this.decryptionButton.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptionButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.decryptionButton.Location = new System.Drawing.Point(227, 222);
            this.decryptionButton.Name = "decryptionButton";
            this.decryptionButton.Size = new System.Drawing.Size(81, 42);
            this.decryptionButton.TabIndex = 13;
            this.decryptionButton.Text = "Decrypt";
            this.decryptionButton.UseVisualStyleBackColor = false;
            this.decryptionButton.Click += new System.EventHandler(this.decryptionButton_Click);
            // 
            // decryptionPlaintextLabel
            // 
            this.decryptionPlaintextLabel.AutoSize = true;
            this.decryptionPlaintextLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.decryptionPlaintextLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.decryptionPlaintextLabel.Location = new System.Drawing.Point(39, 284);
            this.decryptionPlaintextLabel.Name = "decryptionPlaintextLabel";
            this.decryptionPlaintextLabel.Size = new System.Drawing.Size(57, 15);
            this.decryptionPlaintextLabel.TabIndex = 8;
            this.decryptionPlaintextLabel.Text = "Plaintext";
            // 
            // decryptionCiphertextTextBox
            // 
            this.decryptionCiphertextTextBox.Font = new System.Drawing.Font("Arial", 11.25F);
            this.decryptionCiphertextTextBox.Location = new System.Drawing.Point(109, 72);
            this.decryptionCiphertextTextBox.Multiline = true;
            this.decryptionCiphertextTextBox.Name = "decryptionCiphertextTextBox";
            this.decryptionCiphertextTextBox.Size = new System.Drawing.Size(331, 95);
            this.decryptionCiphertextTextBox.TabIndex = 11;
            // 
            // decryptionGroupBox
            // 
            this.decryptionGroupBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.decryptionGroupBox.Controls.Add(this.decryptionAlphabetLabel);
            this.decryptionGroupBox.Controls.Add(this.decryptionCiphertextLabel);
            this.decryptionGroupBox.Controls.Add(this.decryptionAlphabetTextBox);
            this.decryptionGroupBox.Controls.Add(this.decryptionPlaintextTextBox);
            this.decryptionGroupBox.Controls.Add(this.decryptionCiphertextTextBox);
            this.decryptionGroupBox.Controls.Add(this.decryptionKeyLabel);
            this.decryptionGroupBox.Controls.Add(this.decryptionPlaintextLabel);
            this.decryptionGroupBox.Controls.Add(this.decryptionKeyTextBox);
            this.decryptionGroupBox.Controls.Add(this.decryptionButton);
            this.decryptionGroupBox.Font = new System.Drawing.Font("Britannic Bold", 14.25F);
            this.decryptionGroupBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.decryptionGroupBox.Location = new System.Drawing.Point(516, 17);
            this.decryptionGroupBox.Name = "decryptionGroupBox";
            this.decryptionGroupBox.Size = new System.Drawing.Size(504, 419);
            this.decryptionGroupBox.TabIndex = 14;
            this.decryptionGroupBox.TabStop = false;
            this.decryptionGroupBox.Text = "Decryption";
            // 
            // decryptionAlphabetTextBox
            // 
            this.decryptionAlphabetTextBox.Font = new System.Drawing.Font("Arial", 11.25F);
            this.decryptionAlphabetTextBox.Location = new System.Drawing.Point(109, 37);
            this.decryptionAlphabetTextBox.Name = "decryptionAlphabetTextBox";
            this.decryptionAlphabetTextBox.Size = new System.Drawing.Size(331, 25);
            this.decryptionAlphabetTextBox.TabIndex = 10;
            this.decryptionAlphabetTextBox.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1034, 447);
            this.Controls.Add(this.decryptionGroupBox);
            this.Controls.Add(this.encryptionGroupBox);
            this.Name = "MainForm";
            this.Text = "Hill Encryptor/Decryptor";
            this.encryptionGroupBox.ResumeLayout(false);
            this.encryptionGroupBox.PerformLayout();
            this.decryptionGroupBox.ResumeLayout(false);
            this.decryptionGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox encryptionPlaintextTextBox;
        private System.Windows.Forms.Label encryptionPlaintextLabel;
        private System.Windows.Forms.Button encryptionButton;
        private System.Windows.Forms.TextBox encryptionKeyTextBox;
        private System.Windows.Forms.Label encryptionKeyLabel;
        private System.Windows.Forms.TextBox encryptionCiphertextTextBox;
        private System.Windows.Forms.Label encryptionCiphertextLabel;
        private System.Windows.Forms.ToolTip key_toolTip;
        private System.Windows.Forms.GroupBox encryptionGroupBox;
        private System.Windows.Forms.Label decryptionCiphertextLabel;
        private System.Windows.Forms.TextBox decryptionPlaintextTextBox;
        private System.Windows.Forms.Label decryptionKeyLabel;
        private System.Windows.Forms.TextBox decryptionKeyTextBox;
        private System.Windows.Forms.Button decryptionButton;
        private System.Windows.Forms.Label decryptionPlaintextLabel;
        private System.Windows.Forms.TextBox decryptionCiphertextTextBox;
        private System.Windows.Forms.GroupBox decryptionGroupBox;
        private System.Windows.Forms.Label encryptionAlphabetLabel;
        private System.Windows.Forms.TextBox encryptionAlphabetTextBox;
        private System.Windows.Forms.Label decryptionAlphabetLabel;
        private System.Windows.Forms.TextBox decryptionAlphabetTextBox;
    }
}

