namespace AES_Encryption
{
    partial class AES
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
            this.plaintext_enc_textbox = new System.Windows.Forms.TextBox();
            this.Plaintext_enc_label = new System.Windows.Forms.Label();
            this.enncrypt_button = new System.Windows.Forms.Button();
            this.key_enc_textbox = new System.Windows.Forms.TextBox();
            this.key_enc_label = new System.Windows.Forms.Label();
            this.ciphertext_enc_texbox = new System.Windows.Forms.TextBox();
            this.Ciphertext_enc_lable = new System.Windows.Forms.Label();
            this.key_toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.key_dec_label = new System.Windows.Forms.Label();
            this.Encryption_groupBox = new System.Windows.Forms.GroupBox();
            this.Ciphertext_dec_lable = new System.Windows.Forms.Label();
            this.plaintext_dec_textbox = new System.Windows.Forms.TextBox();
            this.key_dec_textbox = new System.Windows.Forms.TextBox();
            this.decrypt_button = new System.Windows.Forms.Button();
            this.Plaintext_dec_label = new System.Windows.Forms.Label();
            this.ciphertext_dec_texbox = new System.Windows.Forms.TextBox();
            this.Decryption_groupBox = new System.Windows.Forms.GroupBox();
            this.Encryption_groupBox.SuspendLayout();
            this.Decryption_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // plaintext_enc_textbox
            // 
            this.plaintext_enc_textbox.Location = new System.Drawing.Point(132, 51);
            this.plaintext_enc_textbox.Multiline = true;
            this.plaintext_enc_textbox.Name = "plaintext_enc_textbox";
            this.plaintext_enc_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.plaintext_enc_textbox.Size = new System.Drawing.Size(280, 100);
            this.plaintext_enc_textbox.TabIndex = 0;
            // 
            // Plaintext_enc_label
            // 
            this.Plaintext_enc_label.AutoSize = true;
            this.Plaintext_enc_label.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Plaintext_enc_label.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Plaintext_enc_label.Location = new System.Drawing.Point(63, 51);
            this.Plaintext_enc_label.Name = "Plaintext_enc_label";
            this.Plaintext_enc_label.Size = new System.Drawing.Size(57, 15);
            this.Plaintext_enc_label.TabIndex = 1;
            this.Plaintext_enc_label.Text = "Plaintext";
            // 
            // enncrypt_button
            // 
            this.enncrypt_button.BackColor = System.Drawing.Color.SteelBlue;
            this.enncrypt_button.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enncrypt_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.enncrypt_button.Location = new System.Drawing.Point(232, 207);
            this.enncrypt_button.Name = "enncrypt_button";
            this.enncrypt_button.Size = new System.Drawing.Size(81, 42);
            this.enncrypt_button.TabIndex = 2;
            this.enncrypt_button.Text = "Enncrypt";
            this.enncrypt_button.UseVisualStyleBackColor = false;
            // 
            // key_enc_textbox
            // 
            this.key_enc_textbox.Location = new System.Drawing.Point(132, 156);
            this.key_enc_textbox.Name = "key_enc_textbox";
            this.key_enc_textbox.Size = new System.Drawing.Size(280, 29);
            this.key_enc_textbox.TabIndex = 3;
            // 
            // key_enc_label
            // 
            this.key_enc_label.AutoSize = true;
            this.key_enc_label.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.key_enc_label.ForeColor = System.Drawing.SystemColors.WindowText;
            this.key_enc_label.Location = new System.Drawing.Point(63, 158);
            this.key_enc_label.Name = "key_enc_label";
            this.key_enc_label.Size = new System.Drawing.Size(28, 15);
            this.key_enc_label.TabIndex = 4;
            this.key_enc_label.Text = "Key";
            this.key_toolTip.SetToolTip(this.key_enc_label, "16 byte ");
            // 
            // ciphertext_enc_texbox
            // 
            this.ciphertext_enc_texbox.Location = new System.Drawing.Point(132, 277);
            this.ciphertext_enc_texbox.Multiline = true;
            this.ciphertext_enc_texbox.Name = "ciphertext_enc_texbox";
            this.ciphertext_enc_texbox.ReadOnly = true;
            this.ciphertext_enc_texbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ciphertext_enc_texbox.Size = new System.Drawing.Size(280, 100);
            this.ciphertext_enc_texbox.TabIndex = 5;
            // 
            // Ciphertext_enc_lable
            // 
            this.Ciphertext_enc_lable.AutoSize = true;
            this.Ciphertext_enc_lable.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ciphertext_enc_lable.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Ciphertext_enc_lable.Location = new System.Drawing.Point(63, 279);
            this.Ciphertext_enc_lable.Name = "Ciphertext_enc_lable";
            this.Ciphertext_enc_lable.Size = new System.Drawing.Size(66, 15);
            this.Ciphertext_enc_lable.TabIndex = 6;
            this.Ciphertext_enc_lable.Text = "Ciphertext";
            // 
            // key_dec_label
            // 
            this.key_dec_label.AutoSize = true;
            this.key_dec_label.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.key_dec_label.ForeColor = System.Drawing.SystemColors.WindowText;
            this.key_dec_label.Location = new System.Drawing.Point(74, 158);
            this.key_dec_label.Name = "key_dec_label";
            this.key_dec_label.Size = new System.Drawing.Size(28, 15);
            this.key_dec_label.TabIndex = 11;
            this.key_dec_label.Text = "Key";
            this.key_toolTip.SetToolTip(this.key_dec_label, "16 byte ");
            // 
            // Encryption_groupBox
            // 
            this.Encryption_groupBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Encryption_groupBox.Controls.Add(this.Ciphertext_enc_lable);
            this.Encryption_groupBox.Controls.Add(this.ciphertext_enc_texbox);
            this.Encryption_groupBox.Controls.Add(this.key_enc_label);
            this.Encryption_groupBox.Controls.Add(this.key_enc_textbox);
            this.Encryption_groupBox.Controls.Add(this.enncrypt_button);
            this.Encryption_groupBox.Controls.Add(this.Plaintext_enc_label);
            this.Encryption_groupBox.Controls.Add(this.plaintext_enc_textbox);
            this.Encryption_groupBox.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Encryption_groupBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.Encryption_groupBox.Location = new System.Drawing.Point(40, 41);
            this.Encryption_groupBox.Name = "Encryption_groupBox";
            this.Encryption_groupBox.Size = new System.Drawing.Size(473, 439);
            this.Encryption_groupBox.TabIndex = 7;
            this.Encryption_groupBox.TabStop = false;
            this.Encryption_groupBox.Text = "Encryption";
            // 
            // Ciphertext_dec_lable
            // 
            this.Ciphertext_dec_lable.AutoSize = true;
            this.Ciphertext_dec_lable.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ciphertext_dec_lable.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Ciphertext_dec_lable.Location = new System.Drawing.Point(70, 54);
            this.Ciphertext_dec_lable.Name = "Ciphertext_dec_lable";
            this.Ciphertext_dec_lable.Size = new System.Drawing.Size(66, 15);
            this.Ciphertext_dec_lable.TabIndex = 13;
            this.Ciphertext_dec_lable.Text = "Ciphertext";
            // 
            // plaintext_dec_textbox
            // 
            this.plaintext_dec_textbox.Location = new System.Drawing.Point(148, 277);
            this.plaintext_dec_textbox.Multiline = true;
            this.plaintext_dec_textbox.Name = "plaintext_dec_textbox";
            this.plaintext_dec_textbox.ReadOnly = true;
            this.plaintext_dec_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.plaintext_dec_textbox.Size = new System.Drawing.Size(280, 100);
            this.plaintext_dec_textbox.TabIndex = 12;
            // 
            // key_dec_textbox
            // 
            this.key_dec_textbox.Location = new System.Drawing.Point(148, 157);
            this.key_dec_textbox.Name = "key_dec_textbox";
            this.key_dec_textbox.Size = new System.Drawing.Size(280, 29);
            this.key_dec_textbox.TabIndex = 10;
            // 
            // decrypt_button
            // 
            this.decrypt_button.BackColor = System.Drawing.Color.SteelBlue;
            this.decrypt_button.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decrypt_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.decrypt_button.Location = new System.Drawing.Point(248, 207);
            this.decrypt_button.Name = "decrypt_button";
            this.decrypt_button.Size = new System.Drawing.Size(81, 42);
            this.decrypt_button.TabIndex = 9;
            this.decrypt_button.Text = "Decrypt";
            this.decrypt_button.UseVisualStyleBackColor = false;
            // 
            // Plaintext_dec_label
            // 
            this.Plaintext_dec_label.AutoSize = true;
            this.Plaintext_dec_label.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Plaintext_dec_label.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Plaintext_dec_label.Location = new System.Drawing.Point(79, 282);
            this.Plaintext_dec_label.Name = "Plaintext_dec_label";
            this.Plaintext_dec_label.Size = new System.Drawing.Size(57, 15);
            this.Plaintext_dec_label.TabIndex = 8;
            this.Plaintext_dec_label.Text = "Plaintext";
            // 
            // ciphertext_dec_texbox
            // 
            this.ciphertext_dec_texbox.Location = new System.Drawing.Point(148, 51);
            this.ciphertext_dec_texbox.Multiline = true;
            this.ciphertext_dec_texbox.Name = "ciphertext_dec_texbox";
            this.ciphertext_dec_texbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ciphertext_dec_texbox.Size = new System.Drawing.Size(280, 100);
            this.ciphertext_dec_texbox.TabIndex = 7;
            // 
            // Decryption_groupBox
            // 
            this.Decryption_groupBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Decryption_groupBox.Controls.Add(this.Ciphertext_dec_lable);
            this.Decryption_groupBox.Controls.Add(this.plaintext_dec_textbox);
            this.Decryption_groupBox.Controls.Add(this.ciphertext_dec_texbox);
            this.Decryption_groupBox.Controls.Add(this.key_dec_label);
            this.Decryption_groupBox.Controls.Add(this.Plaintext_dec_label);
            this.Decryption_groupBox.Controls.Add(this.key_dec_textbox);
            this.Decryption_groupBox.Controls.Add(this.decrypt_button);
            this.Decryption_groupBox.Font = new System.Drawing.Font("Britannic Bold", 14.25F);
            this.Decryption_groupBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.Decryption_groupBox.Location = new System.Drawing.Point(544, 41);
            this.Decryption_groupBox.Name = "Decryption_groupBox";
            this.Decryption_groupBox.Size = new System.Drawing.Size(473, 439);
            this.Decryption_groupBox.TabIndex = 14;
            this.Decryption_groupBox.TabStop = false;
            this.Decryption_groupBox.Text = "Decryption";
            // 
            // AES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1057, 501);
            this.Controls.Add(this.Decryption_groupBox);
            this.Controls.Add(this.Encryption_groupBox);
            this.Name = "AES";
            this.Text = "AES";
            this.Encryption_groupBox.ResumeLayout(false);
            this.Encryption_groupBox.PerformLayout();
            this.Decryption_groupBox.ResumeLayout(false);
            this.Decryption_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox plaintext_enc_textbox;
        private System.Windows.Forms.Label Plaintext_enc_label;
        private System.Windows.Forms.Button enncrypt_button;
        private System.Windows.Forms.TextBox key_enc_textbox;
        private System.Windows.Forms.Label key_enc_label;
        private System.Windows.Forms.TextBox ciphertext_enc_texbox;
        private System.Windows.Forms.Label Ciphertext_enc_lable;
        private System.Windows.Forms.ToolTip key_toolTip;
        private System.Windows.Forms.GroupBox Encryption_groupBox;
        private System.Windows.Forms.Label Ciphertext_dec_lable;
        private System.Windows.Forms.TextBox plaintext_dec_textbox;
        private System.Windows.Forms.Label key_dec_label;
        private System.Windows.Forms.TextBox key_dec_textbox;
        private System.Windows.Forms.Button decrypt_button;
        private System.Windows.Forms.Label Plaintext_dec_label;
        private System.Windows.Forms.TextBox ciphertext_dec_texbox;
        private System.Windows.Forms.GroupBox Decryption_groupBox;
    }
}

