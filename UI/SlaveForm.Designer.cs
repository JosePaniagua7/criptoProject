namespace UI
{
    partial class SlaveForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TextBoxRsaPublicKey = new System.Windows.Forms.TextBox();
            this.TextBoxRsaPrivateKey = new System.Windows.Forms.TextBox();
            this.LabelEncryptedTdes1 = new System.Windows.Forms.Label();
            this.LabelEncryptedTdes2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LabelEncryptedTdes3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LabelDecryptedText = new System.Windows.Forms.Label();
            this.LabelEncryptedText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aquamarine;
            this.label3.Location = new System.Drawing.Point(290, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Soy Esclavo";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Location = new System.Drawing.Point(26, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 38);
            this.button1.TabIndex = 33;
            this.button1.Text = "Generar clave RSA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(169, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Clave Publica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(169, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Clave privada";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Enabled = false;
            this.button2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button2.Location = new System.Drawing.Point(479, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 32);
            this.button2.TabIndex = 36;
            this.button2.Text = "Exportar XML clave publica";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.Enabled = false;
            this.button3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button3.Location = new System.Drawing.Point(26, 279);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 40);
            this.button3.TabIndex = 37;
            this.button3.Text = "Importar clave TDES de fichero";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(169, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "TDes1";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button4.Enabled = false;
            this.button4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button4.Location = new System.Drawing.Point(26, 363);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 32);
            this.button4.TabIndex = 39;
            this.button4.Text = "Desenctiptar TDES ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(23, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Introducir Texto a encriptar: ";
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(26, 427);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(599, 60);
            this.MessageTextBox.TabIndex = 42;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button5.Enabled = false;
            this.button5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button5.Location = new System.Drawing.Point(537, 493);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 27);
            this.button5.TabIndex = 43;
            this.button5.Text = "Encrypt";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button6.Enabled = false;
            this.button6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button6.Location = new System.Drawing.Point(26, 545);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(191, 23);
            this.button6.TabIndex = 44;
            this.button6.Text = "Generate XML with encrypted text";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(23, 517);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Result:";
            // 
            // TextBoxRsaPublicKey
            // 
            this.TextBoxRsaPublicKey.Location = new System.Drawing.Point(266, 57);
            this.TextBoxRsaPublicKey.Multiline = true;
            this.TextBoxRsaPublicKey.Name = "TextBoxRsaPublicKey";
            this.TextBoxRsaPublicKey.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TextBoxRsaPublicKey.Size = new System.Drawing.Size(359, 58);
            this.TextBoxRsaPublicKey.TabIndex = 46;
            // 
            // TextBoxRsaPrivateKey
            // 
            this.TextBoxRsaPrivateKey.Enabled = false;
            this.TextBoxRsaPrivateKey.Location = new System.Drawing.Point(265, 142);
            this.TextBoxRsaPrivateKey.Multiline = true;
            this.TextBoxRsaPrivateKey.Name = "TextBoxRsaPrivateKey";
            this.TextBoxRsaPrivateKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxRsaPrivateKey.Size = new System.Drawing.Size(360, 63);
            this.TextBoxRsaPrivateKey.TabIndex = 47;
            // 
            // LabelEncryptedTdes1
            // 
            this.LabelEncryptedTdes1.AutoSize = true;
            this.LabelEncryptedTdes1.ForeColor = System.Drawing.Color.White;
            this.LabelEncryptedTdes1.Location = new System.Drawing.Point(224, 254);
            this.LabelEncryptedTdes1.Name = "LabelEncryptedTdes1";
            this.LabelEncryptedTdes1.Size = new System.Drawing.Size(0, 13);
            this.LabelEncryptedTdes1.TabIndex = 48;
            // 
            // LabelEncryptedTdes2
            // 
            this.LabelEncryptedTdes2.AutoSize = true;
            this.LabelEncryptedTdes2.ForeColor = System.Drawing.Color.White;
            this.LabelEncryptedTdes2.Location = new System.Drawing.Point(223, 293);
            this.LabelEncryptedTdes2.Name = "LabelEncryptedTdes2";
            this.LabelEncryptedTdes2.Size = new System.Drawing.Size(0, 13);
            this.LabelEncryptedTdes2.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(169, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "TDes2";
            // 
            // LabelEncryptedTdes3
            // 
            this.LabelEncryptedTdes3.AutoSize = true;
            this.LabelEncryptedTdes3.ForeColor = System.Drawing.Color.White;
            this.LabelEncryptedTdes3.Location = new System.Drawing.Point(224, 329);
            this.LabelEncryptedTdes3.Name = "LabelEncryptedTdes3";
            this.LabelEncryptedTdes3.Size = new System.Drawing.Size(0, 13);
            this.LabelEncryptedTdes3.TabIndex = 52;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(169, 329);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 51;
            this.label11.Text = "TDes3";
            // 
            // LabelDecryptedText
            // 
            this.LabelDecryptedText.AutoSize = true;
            this.LabelDecryptedText.ForeColor = System.Drawing.Color.White;
            this.LabelDecryptedText.Location = new System.Drawing.Point(169, 373);
            this.LabelDecryptedText.Name = "LabelDecryptedText";
            this.LabelDecryptedText.Size = new System.Drawing.Size(0, 13);
            this.LabelDecryptedText.TabIndex = 53;
            // 
            // LabelEncryptedText
            // 
            this.LabelEncryptedText.AutoSize = true;
            this.LabelEncryptedText.ForeColor = System.Drawing.Color.White;
            this.LabelEncryptedText.Location = new System.Drawing.Point(69, 517);
            this.LabelEncryptedText.Name = "LabelEncryptedText";
            this.LabelEncryptedText.Size = new System.Drawing.Size(0, 13);
            this.LabelEncryptedText.TabIndex = 54;
            // 
            // SlaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(650, 596);
            this.Controls.Add(this.LabelEncryptedText);
            this.Controls.Add(this.LabelDecryptedText);
            this.Controls.Add(this.LabelEncryptedTdes3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.LabelEncryptedTdes2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LabelEncryptedTdes1);
            this.Controls.Add(this.TextBoxRsaPrivateKey);
            this.Controls.Add(this.TextBoxRsaPublicKey);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Name = "SlaveForm";
            this.Text = "SlaveForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SlaveForm_FormClosing);
            this.Load += new System.EventHandler(this.SlaveForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextBoxRsaPublicKey;
        private System.Windows.Forms.TextBox TextBoxRsaPrivateKey;
        private System.Windows.Forms.Label LabelEncryptedTdes1;
        private System.Windows.Forms.Label LabelEncryptedTdes2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LabelEncryptedTdes3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LabelDecryptedText;
        private System.Windows.Forms.Label LabelEncryptedText;
    }
}