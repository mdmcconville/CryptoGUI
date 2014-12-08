namespace CryptoGUI
{
    partial class GUIForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.radioSHA256 = new System.Windows.Forms.RadioButton();
            this.labelSHAResults = new System.Windows.Forms.Label();
            this.textBoxSHAResults = new System.Windows.Forms.TextBox();
            this.shaENTERButton = new System.Windows.Forms.Button();
            this.hexMsgLabel1 = new System.Windows.Forms.Label();
            this.textBoxSHAMessage = new System.Windows.Forms.TextBox();
            this.radioSHA512 = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.macENTERButton = new System.Windows.Forms.Button();
            this.labelMACResults = new System.Windows.Forms.Label();
            this.textBoxMACResults = new System.Windows.Forms.TextBox();
            this.hexKeyLabel1 = new System.Windows.Forms.Label();
            this.textBoxMACKey = new System.Windows.Forms.TextBox();
            this.hexMsgLabel2 = new System.Windows.Forms.Label();
            this.textBoxMACMsg = new System.Windows.Forms.TextBox();
            this.radioMAC256 = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.aesEnterButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPlaintext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAESKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCiphertext = new System.Windows.Forms.TextBox();
            this.radioAES256Encrypt = new System.Windows.Forms.RadioButton();
            this.radioAES256Decrypt = new System.Windows.Forms.RadioButton();
            this.textBoxIV = new System.Windows.Forms.TextBox();
            this.labelIV = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.AccessibleName = global::CryptoGUI.Properties.Settings.Default.SHA512;
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.DataBindings.Add(new System.Windows.Forms.Binding("Name", global::CryptoGUI.Properties.Settings.Default, "SHA512", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tabControl.DataBindings.Add(new System.Windows.Forms.Binding("AccessibleName", global::CryptoGUI.Properties.Settings.Default, "SHA512", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tabControl.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(15, 12);
            this.tabControl.Name = global::CryptoGUI.Properties.Settings.Default.SHA512;
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(502, 397);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SeaShell;
            this.tabPage1.Controls.Add(this.radioSHA256);
            this.tabPage1.Controls.Add(this.labelSHAResults);
            this.tabPage1.Controls.Add(this.textBoxSHAResults);
            this.tabPage1.Controls.Add(this.shaENTERButton);
            this.tabPage1.Controls.Add(this.hexMsgLabel1);
            this.tabPage1.Controls.Add(this.textBoxSHAMessage);
            this.tabPage1.Controls.Add(this.radioSHA512);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(494, 370);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SHA";
            // 
            // radioSHA256
            // 
            this.radioSHA256.AutoSize = true;
            this.radioSHA256.Checked = true;
            this.radioSHA256.Location = new System.Drawing.Point(53, 20);
            this.radioSHA256.Name = "radioSHA256";
            this.radioSHA256.Size = new System.Drawing.Size(75, 19);
            this.radioSHA256.TabIndex = 6;
            this.radioSHA256.TabStop = true;
            this.radioSHA256.Text = "SHA-256";
            this.radioSHA256.UseVisualStyleBackColor = true;
            this.radioSHA256.CheckedChanged += new System.EventHandler(this.radioSHA256_CheckedChanged);
            // 
            // labelSHAResults
            // 
            this.labelSHAResults.AutoSize = true;
            this.labelSHAResults.Location = new System.Drawing.Point(53, 195);
            this.labelSHAResults.Name = "labelSHAResults";
            this.labelSHAResults.Size = new System.Drawing.Size(48, 15);
            this.labelSHAResults.TabIndex = 5;
            this.labelSHAResults.Text = "Results";
            // 
            // textBoxSHAResults
            // 
            this.textBoxSHAResults.Location = new System.Drawing.Point(53, 214);
            this.textBoxSHAResults.Multiline = true;
            this.textBoxSHAResults.Name = "textBoxSHAResults";
            this.textBoxSHAResults.ReadOnly = true;
            this.textBoxSHAResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSHAResults.Size = new System.Drawing.Size(316, 49);
            this.textBoxSHAResults.TabIndex = 4;
            // 
            // shaENTERButton
            // 
            this.shaENTERButton.Location = new System.Drawing.Point(293, 149);
            this.shaENTERButton.Name = "shaENTERButton";
            this.shaENTERButton.Size = new System.Drawing.Size(75, 23);
            this.shaENTERButton.TabIndex = 3;
            this.shaENTERButton.Text = "ENTER";
            this.shaENTERButton.UseVisualStyleBackColor = true;
            this.shaENTERButton.Click += new System.EventHandler(this.shaENTERButton_Click);
            // 
            // hexMsgLabel1
            // 
            this.hexMsgLabel1.AutoSize = true;
            this.hexMsgLabel1.Location = new System.Drawing.Point(50, 76);
            this.hexMsgLabel1.Name = "hexMsgLabel1";
            this.hexMsgLabel1.Size = new System.Drawing.Size(276, 15);
            this.hexMsgLabel1.TabIndex = 2;
            this.hexMsgLabel1.Text = "Please enter a message in hex with no spaces.";
            // 
            // textBoxSHAMessage
            // 
            this.textBoxSHAMessage.Location = new System.Drawing.Point(53, 93);
            this.textBoxSHAMessage.Multiline = true;
            this.textBoxSHAMessage.Name = "textBoxSHAMessage";
            this.textBoxSHAMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSHAMessage.Size = new System.Drawing.Size(316, 49);
            this.textBoxSHAMessage.TabIndex = 1;
            // 
            // radioSHA512
            // 
            this.radioSHA512.AccessibleName = "SHA512";
            this.radioSHA512.AutoSize = true;
            this.radioSHA512.Location = new System.Drawing.Point(53, 44);
            this.radioSHA512.Name = "radioSHA512";
            this.radioSHA512.Size = new System.Drawing.Size(75, 19);
            this.radioSHA512.TabIndex = 0;
            this.radioSHA512.Text = "SHA-512";
            this.radioSHA512.UseVisualStyleBackColor = true;
            this.radioSHA512.CheckedChanged += new System.EventHandler(this.radioSHA512_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SeaShell;
            this.tabPage2.Controls.Add(this.macENTERButton);
            this.tabPage2.Controls.Add(this.labelMACResults);
            this.tabPage2.Controls.Add(this.textBoxMACResults);
            this.tabPage2.Controls.Add(this.hexKeyLabel1);
            this.tabPage2.Controls.Add(this.textBoxMACKey);
            this.tabPage2.Controls.Add(this.hexMsgLabel2);
            this.tabPage2.Controls.Add(this.textBoxMACMsg);
            this.tabPage2.Controls.Add(this.radioMAC256);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(494, 370);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MAC";
            // 
            // macENTERButton
            // 
            this.macENTERButton.Location = new System.Drawing.Point(294, 245);
            this.macENTERButton.Name = "macENTERButton";
            this.macENTERButton.Size = new System.Drawing.Size(75, 23);
            this.macENTERButton.TabIndex = 8;
            this.macENTERButton.Text = "ENTER";
            this.macENTERButton.UseVisualStyleBackColor = true;
            this.macENTERButton.Click += new System.EventHandler(this.macENTERButton_Click);
            // 
            // labelMACResults
            // 
            this.labelMACResults.AutoSize = true;
            this.labelMACResults.Location = new System.Drawing.Point(56, 265);
            this.labelMACResults.Name = "labelMACResults";
            this.labelMACResults.Size = new System.Drawing.Size(48, 15);
            this.labelMACResults.TabIndex = 7;
            this.labelMACResults.Text = "Results";
            // 
            // textBoxMACResults
            // 
            this.textBoxMACResults.Location = new System.Drawing.Point(53, 284);
            this.textBoxMACResults.Multiline = true;
            this.textBoxMACResults.Name = "textBoxMACResults";
            this.textBoxMACResults.ReadOnly = true;
            this.textBoxMACResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMACResults.Size = new System.Drawing.Size(316, 49);
            this.textBoxMACResults.TabIndex = 6;
            // 
            // hexKeyLabel1
            // 
            this.hexKeyLabel1.AutoSize = true;
            this.hexKeyLabel1.Location = new System.Drawing.Point(53, 171);
            this.hexKeyLabel1.Name = "hexKeyLabel1";
            this.hexKeyLabel1.Size = new System.Drawing.Size(230, 15);
            this.hexKeyLabel1.TabIndex = 5;
            this.hexKeyLabel1.Text = "Please enter a hex key with no spaces.";
            // 
            // textBoxMACKey
            // 
            this.textBoxMACKey.Location = new System.Drawing.Point(53, 190);
            this.textBoxMACKey.Multiline = true;
            this.textBoxMACKey.Name = "textBoxMACKey";
            this.textBoxMACKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMACKey.Size = new System.Drawing.Size(316, 49);
            this.textBoxMACKey.TabIndex = 4;
            // 
            // hexMsgLabel2
            // 
            this.hexMsgLabel2.AutoSize = true;
            this.hexMsgLabel2.Location = new System.Drawing.Point(50, 76);
            this.hexMsgLabel2.Name = "hexMsgLabel2";
            this.hexMsgLabel2.Size = new System.Drawing.Size(276, 15);
            this.hexMsgLabel2.TabIndex = 3;
            this.hexMsgLabel2.Text = "Please enter a message in hex with no spaces.";
            // 
            // textBoxMACMsg
            // 
            this.textBoxMACMsg.Location = new System.Drawing.Point(53, 93);
            this.textBoxMACMsg.Multiline = true;
            this.textBoxMACMsg.Name = "textBoxMACMsg";
            this.textBoxMACMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMACMsg.Size = new System.Drawing.Size(316, 49);
            this.textBoxMACMsg.TabIndex = 1;
            // 
            // radioMAC256
            // 
            this.radioMAC256.AutoSize = true;
            this.radioMAC256.Checked = true;
            this.radioMAC256.Location = new System.Drawing.Point(53, 20);
            this.radioMAC256.Name = "radioMAC256";
            this.radioMAC256.Size = new System.Drawing.Size(143, 19);
            this.radioMAC256.TabIndex = 0;
            this.radioMAC256.TabStop = true;
            this.radioMAC256.Text = "HMAC with SHA-256";
            this.radioMAC256.UseVisualStyleBackColor = true;
            this.radioMAC256.CheckedChanged += new System.EventHandler(this.radioMAC256_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.SeaShell;
            this.tabPage3.Controls.Add(this.labelIV);
            this.tabPage3.Controls.Add(this.textBoxIV);
            this.tabPage3.Controls.Add(this.aesEnterButton);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.textBoxPlaintext);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.textBoxAESKey);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.textBoxCiphertext);
            this.tabPage3.Controls.Add(this.radioAES256Encrypt);
            this.tabPage3.Controls.Add(this.radioAES256Decrypt);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage3.Size = new System.Drawing.Size(494, 370);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "AES";
            // 
            // aesEnterButton
            // 
            this.aesEnterButton.Location = new System.Drawing.Point(294, 341);
            this.aesEnterButton.Name = "aesEnterButton";
            this.aesEnterButton.Size = new System.Drawing.Size(75, 23);
            this.aesEnterButton.TabIndex = 15;
            this.aesEnterButton.Text = "ENTER";
            this.aesEnterButton.UseVisualStyleBackColor = true;
            this.aesEnterButton.Click += new System.EventHandler(this.aesEnterButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Plaintext";
            // 
            // textBoxPlaintext
            // 
            this.textBoxPlaintext.Location = new System.Drawing.Point(53, 284);
            this.textBoxPlaintext.Multiline = true;
            this.textBoxPlaintext.Name = "textBoxPlaintext";
            this.textBoxPlaintext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPlaintext.Size = new System.Drawing.Size(316, 49);
            this.textBoxPlaintext.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Please enter the 256-bit hex key without spaces.";
            // 
            // textBoxAESKey
            // 
            this.textBoxAESKey.Location = new System.Drawing.Point(53, 146);
            this.textBoxAESKey.Multiline = true;
            this.textBoxAESKey.Name = "textBoxAESKey";
            this.textBoxAESKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAESKey.Size = new System.Drawing.Size(316, 49);
            this.textBoxAESKey.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ciphertext";
            // 
            // textBoxCiphertext
            // 
            this.textBoxCiphertext.Location = new System.Drawing.Point(53, 77);
            this.textBoxCiphertext.Multiline = true;
            this.textBoxCiphertext.Name = "textBoxCiphertext";
            this.textBoxCiphertext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCiphertext.Size = new System.Drawing.Size(316, 49);
            this.textBoxCiphertext.TabIndex = 9;
            // 
            // radioAES256Encrypt
            // 
            this.radioAES256Encrypt.AutoSize = true;
            this.radioAES256Encrypt.Location = new System.Drawing.Point(53, 30);
            this.radioAES256Encrypt.Name = "radioAES256Encrypt";
            this.radioAES256Encrypt.Size = new System.Drawing.Size(120, 19);
            this.radioAES256Encrypt.TabIndex = 1;
            this.radioAES256Encrypt.Text = "AES-256 Encrypt";
            this.radioAES256Encrypt.UseVisualStyleBackColor = true;
            this.radioAES256Encrypt.CheckedChanged += new System.EventHandler(this.radioAES256Encrypt_CheckedChanged);
            // 
            // radioAES256Decrypt
            // 
            this.radioAES256Decrypt.AutoSize = true;
            this.radioAES256Decrypt.Checked = true;
            this.radioAES256Decrypt.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAES256Decrypt.Location = new System.Drawing.Point(53, 6);
            this.radioAES256Decrypt.Name = "radioAES256Decrypt";
            this.radioAES256Decrypt.Size = new System.Drawing.Size(122, 19);
            this.radioAES256Decrypt.TabIndex = 0;
            this.radioAES256Decrypt.TabStop = true;
            this.radioAES256Decrypt.Text = "AES-256 Decrypt";
            this.radioAES256Decrypt.UseVisualStyleBackColor = true;
            this.radioAES256Decrypt.CheckedChanged += new System.EventHandler(this.radioAES256Decrypt_CheckedChanged);
            // 
            // textBoxIV
            // 
            this.textBoxIV.Location = new System.Drawing.Point(53, 215);
            this.textBoxIV.Multiline = true;
            this.textBoxIV.Name = "textBoxIV";
            this.textBoxIV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIV.Size = new System.Drawing.Size(316, 49);
            this.textBoxIV.TabIndex = 16;
            // 
            // labelIV
            // 
            this.labelIV.AutoSize = true;
            this.labelIV.Location = new System.Drawing.Point(50, 198);
            this.labelIV.Name = "labelIV";
            this.labelIV.Size = new System.Drawing.Size(209, 15);
            this.labelIV.TabIndex = 17;
            this.labelIV.Text = "Please enter the IV without spaces.";
            // 
            // GUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(526, 421);
            this.Controls.Add(this.tabControl);
            this.Name = "GUIForm";
            this.Text = "CryptoGUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label hexMsgLabel1;
        private System.Windows.Forms.TextBox textBoxMACMsg;
        private System.Windows.Forms.RadioButton radioMAC256;
        private System.Windows.Forms.Label hexMsgLabel2;
        public System.Windows.Forms.TabControl tabControl;
        public System.Windows.Forms.TextBox textBoxSHAMessage;
        public System.Windows.Forms.RadioButton radioSHA512;
        public System.Windows.Forms.Button shaENTERButton;
        private System.Windows.Forms.Label labelSHAResults;
        public System.Windows.Forms.TextBox textBoxSHAResults;
        private System.Windows.Forms.RadioButton radioSHA256;
        private System.Windows.Forms.TextBox textBoxMACKey;
        private System.Windows.Forms.Label hexKeyLabel1;
        private System.Windows.Forms.Label labelMACResults;
        public System.Windows.Forms.TextBox textBoxMACResults;
        public System.Windows.Forms.Button macENTERButton;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RadioButton radioAES256Encrypt;
        private System.Windows.Forms.RadioButton radioAES256Decrypt;
        public System.Windows.Forms.Button aesEnterButton;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxPlaintext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAESKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCiphertext;
        private System.Windows.Forms.Label labelIV;
        private System.Windows.Forms.TextBox textBoxIV;
    }
}

