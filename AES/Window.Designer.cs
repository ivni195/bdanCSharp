namespace AES
{
    partial class Window
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.Message = new System.Windows.Forms.TextBox();
            this.Key = new System.Windows.Forms.TextBox();
            this.Decrypt = new System.Windows.Forms.Button();
            this.Cipher = new System.Windows.Forms.TextBox();
            this.Valid = new System.Windows.Forms.RadioButton();
            this.ErrorFile = new System.Windows.Forms.RadioButton();
            this.ErrorKey = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Message
            // 
            this.Message.BackColor = System.Drawing.SystemColors.Control;
            this.Message.Location = new System.Drawing.Point(12, 28);
            this.Message.Multiline = true;
            this.Message.Name = "Message";
            this.Message.ReadOnly = true;
            this.Message.Size = new System.Drawing.Size(400, 62);
            this.Message.TabIndex = 1;
            // 
            // Key
            // 
            this.Key.BackColor = System.Drawing.SystemColors.Control;
            this.Key.Location = new System.Drawing.Point(12, 115);
            this.Key.Multiline = true;
            this.Key.Name = "Key";
            this.Key.ReadOnly = true;
            this.Key.Size = new System.Drawing.Size(400, 62);
            this.Key.TabIndex = 2;
            // 
            // Decrypt
            // 
            this.Decrypt.Location = new System.Drawing.Point(464, 137);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(154, 40);
            this.Decrypt.TabIndex = 3;
            this.Decrypt.Text = "Decrypt";
            this.Decrypt.UseVisualStyleBackColor = true;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click_1);
            // 
            // Cipher
            // 
            this.Cipher.BackColor = System.Drawing.SystemColors.Control;
            this.Cipher.Location = new System.Drawing.Point(12, 206);
            this.Cipher.Multiline = true;
            this.Cipher.Name = "Cipher";
            this.Cipher.ReadOnly = true;
            this.Cipher.Size = new System.Drawing.Size(400, 62);
            this.Cipher.TabIndex = 4;
            // 
            // Valid
            // 
            this.Valid.Location = new System.Drawing.Point(464, 28);
            this.Valid.Name = "Valid";
            this.Valid.Size = new System.Drawing.Size(107, 24);
            this.Valid.TabIndex = 0;
            this.Valid.TabStop = true;
            this.Valid.Text = "Valid\r\n";
            this.Valid.UseVisualStyleBackColor = true;
            this.Valid.CheckedChanged += new System.EventHandler(this.Valid_CheckedChanged);
            // 
            // ErrorFile
            // 
            this.ErrorFile.Location = new System.Drawing.Point(464, 58);
            this.ErrorFile.Name = "ErrorFile";
            this.ErrorFile.Size = new System.Drawing.Size(161, 24);
            this.ErrorFile.TabIndex = 1;
            this.ErrorFile.TabStop = true;
            this.ErrorFile.Text = "Error in encrypted file\r\n";
            this.ErrorFile.UseVisualStyleBackColor = true;
            this.ErrorFile.CheckedChanged += new System.EventHandler(this.ErrorFile_CheckedChanged);
            // 
            // ErrorKey
            // 
            this.ErrorKey.Location = new System.Drawing.Point(464, 90);
            this.ErrorKey.Name = "ErrorKey";
            this.ErrorKey.Size = new System.Drawing.Size(184, 24);
            this.ErrorKey.TabIndex = 2;
            this.ErrorKey.TabStop = true;
            this.ErrorKey.Text = "Error in key";
            this.ErrorKey.UseVisualStyleBackColor = true;
            this.ErrorKey.CheckedChanged += new System.EventHandler(this.ErrorKey_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Message";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "AES Key";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "CipherText";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 282);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ErrorKey);
            this.Controls.Add(this.Cipher);
            this.Controls.Add(this.ErrorFile);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.Valid);
            this.Controls.Add(this.Key);
            this.Controls.Add(this.Message);
            this.Name = "Window";
            this.Text = "AES example";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.RadioButton ErrorKey;

        private System.Windows.Forms.RadioButton ErrorFile;

        private System.Windows.Forms.RadioButton Valid;

        private System.Windows.Forms.TextBox Cipher;

        private System.Windows.Forms.Button Decrypt;
        private System.Windows.Forms.TextBox Message;
        private System.Windows.Forms.TextBox Key;
        
        #endregion
    }
}