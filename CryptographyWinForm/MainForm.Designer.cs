namespace CryptographyWinForm
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pForm = new System.Windows.Forms.Panel();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.gbCryptoChoose = new System.Windows.Forms.GroupBox();
            this.pHash = new System.Windows.Forms.Panel();
            this.cbHashCrypt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCryptoType = new System.Windows.Forms.ComboBox();
            this.pAsymmetric = new System.Windows.Forms.Panel();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.tbAlias = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbCertificatePath = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbKeyType = new System.Windows.Forms.ComboBox();
            this.cbAsymmetricCrypt = new System.Windows.Forms.ComboBox();
            this.rbAsymmetric = new System.Windows.Forms.RadioButton();
            this.rbSymmetric = new System.Windows.Forms.RadioButton();
            this.rbHash = new System.Windows.Forms.RadioButton();
            this.pSymmetric = new System.Windows.Forms.Panel();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.tbIV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbSymmetricCrypt = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCharset = new System.Windows.Forms.ComboBox();
            this.ofdCertificate = new System.Windows.Forms.OpenFileDialog();
            this.pForm.SuspendLayout();
            this.gbCryptoChoose.SuspendLayout();
            this.pHash.SuspendLayout();
            this.pAsymmetric.SuspendLayout();
            this.pSymmetric.SuspendLayout();
            this.SuspendLayout();
            // 
            // pForm
            // 
            this.pForm.Controls.Add(this.btnDecrypt);
            this.pForm.Controls.Add(this.label6);
            this.pForm.Controls.Add(this.label5);
            this.pForm.Controls.Add(this.btnEncrypt);
            this.pForm.Controls.Add(this.tbOutput);
            this.pForm.Controls.Add(this.tbInput);
            this.pForm.Controls.Add(this.gbCryptoChoose);
            this.pForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pForm.Location = new System.Drawing.Point(0, 0);
            this.pForm.Name = "pForm";
            this.pForm.Size = new System.Drawing.Size(940, 459);
            this.pForm.TabIndex = 0;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(812, 175);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 3;
            this.btnDecrypt.Text = "解 密";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(492, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "输出：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(492, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "输入：";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(565, 175);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 3;
            this.btnEncrypt.Text = "加 密";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(492, 230);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(436, 217);
            this.tbOutput.TabIndex = 1;
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(492, 28);
            this.tbInput.Multiline = true;
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(436, 139);
            this.tbInput.TabIndex = 1;
            // 
            // gbCryptoChoose
            // 
            this.gbCryptoChoose.Controls.Add(this.pHash);
            this.gbCryptoChoose.Controls.Add(this.pAsymmetric);
            this.gbCryptoChoose.Controls.Add(this.rbAsymmetric);
            this.gbCryptoChoose.Controls.Add(this.rbSymmetric);
            this.gbCryptoChoose.Controls.Add(this.rbHash);
            this.gbCryptoChoose.Controls.Add(this.pSymmetric);
            this.gbCryptoChoose.Controls.Add(this.label7);
            this.gbCryptoChoose.Controls.Add(this.cbCharset);
            this.gbCryptoChoose.Location = new System.Drawing.Point(6, 3);
            this.gbCryptoChoose.Name = "gbCryptoChoose";
            this.gbCryptoChoose.Size = new System.Drawing.Size(480, 444);
            this.gbCryptoChoose.TabIndex = 0;
            this.gbCryptoChoose.TabStop = false;
            this.gbCryptoChoose.Text = "加密方式";
            // 
            // pHash
            // 
            this.pHash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pHash.Controls.Add(this.cbHashCrypt);
            this.pHash.Controls.Add(this.label1);
            this.pHash.Controls.Add(this.label2);
            this.pHash.Controls.Add(this.cbCryptoType);
            this.pHash.Location = new System.Drawing.Point(6, 87);
            this.pHash.Name = "pHash";
            this.pHash.Size = new System.Drawing.Size(463, 50);
            this.pHash.TabIndex = 7;
            // 
            // cbHashCrypt
            // 
            this.cbHashCrypt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHashCrypt.FormattingEnabled = true;
            this.cbHashCrypt.Items.AddRange(new object[] {
            "MD5",
            "SHA256"});
            this.cbHashCrypt.Location = new System.Drawing.Point(75, 14);
            this.cbHashCrypt.Name = "cbHashCrypt";
            this.cbHashCrypt.Size = new System.Drawing.Size(68, 20);
            this.cbHashCrypt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "加密算法";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "加密方式";
            // 
            // cbCryptoType
            // 
            this.cbCryptoType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCryptoType.FormattingEnabled = true;
            this.cbCryptoType.Items.AddRange(new object[] {
            "原型",
            "Base64",
            "32位",
            "48位"});
            this.cbCryptoType.Location = new System.Drawing.Point(234, 14);
            this.cbCryptoType.Name = "cbCryptoType";
            this.cbCryptoType.Size = new System.Drawing.Size(68, 20);
            this.cbCryptoType.TabIndex = 1;
            // 
            // pAsymmetric
            // 
            this.pAsymmetric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pAsymmetric.Controls.Add(this.btnBrowse);
            this.pAsymmetric.Controls.Add(this.tbAlias);
            this.pAsymmetric.Controls.Add(this.tbPassword);
            this.pAsymmetric.Controls.Add(this.label12);
            this.pAsymmetric.Controls.Add(this.label11);
            this.pAsymmetric.Controls.Add(this.label10);
            this.pAsymmetric.Controls.Add(this.tbCertificatePath);
            this.pAsymmetric.Controls.Add(this.label13);
            this.pAsymmetric.Controls.Add(this.label8);
            this.pAsymmetric.Controls.Add(this.cbKeyType);
            this.pAsymmetric.Controls.Add(this.cbAsymmetricCrypt);
            this.pAsymmetric.Enabled = false;
            this.pAsymmetric.Location = new System.Drawing.Point(6, 301);
            this.pAsymmetric.Name = "pAsymmetric";
            this.pAsymmetric.Size = new System.Drawing.Size(463, 134);
            this.pAsymmetric.TabIndex = 6;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(319, 39);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "浏览";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // tbAlias
            // 
            this.tbAlias.Location = new System.Drawing.Point(73, 71);
            this.tbAlias.Name = "tbAlias";
            this.tbAlias.Size = new System.Drawing.Size(229, 21);
            this.tbAlias.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(73, 98);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(229, 21);
            this.tbPassword.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 3;
            this.label12.Text = "Password";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 12);
            this.label11.TabIndex = 3;
            this.label11.Text = "Alias";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 3;
            this.label10.Text = "证书路径";
            // 
            // tbCertificatePath
            // 
            this.tbCertificatePath.Location = new System.Drawing.Point(73, 40);
            this.tbCertificatePath.Name = "tbCertificatePath";
            this.tbCertificatePath.Size = new System.Drawing.Size(229, 21);
            this.tbCertificatePath.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(167, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 3;
            this.label13.Text = "密钥类型";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "加密算法";
            // 
            // cbKeyType
            // 
            this.cbKeyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKeyType.FormattingEnabled = true;
            this.cbKeyType.Items.AddRange(new object[] {
            "公钥",
            "私钥"});
            this.cbKeyType.Location = new System.Drawing.Point(234, 10);
            this.cbKeyType.Name = "cbKeyType";
            this.cbKeyType.Size = new System.Drawing.Size(68, 20);
            this.cbKeyType.TabIndex = 0;
            // 
            // cbAsymmetricCrypt
            // 
            this.cbAsymmetricCrypt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAsymmetricCrypt.FormattingEnabled = true;
            this.cbAsymmetricCrypt.Items.AddRange(new object[] {
            "RSA"});
            this.cbAsymmetricCrypt.Location = new System.Drawing.Point(75, 10);
            this.cbAsymmetricCrypt.Name = "cbAsymmetricCrypt";
            this.cbAsymmetricCrypt.Size = new System.Drawing.Size(68, 20);
            this.cbAsymmetricCrypt.TabIndex = 0;
            // 
            // rbAsymmetric
            // 
            this.rbAsymmetric.AutoSize = true;
            this.rbAsymmetric.Location = new System.Drawing.Point(6, 281);
            this.rbAsymmetric.Name = "rbAsymmetric";
            this.rbAsymmetric.Size = new System.Drawing.Size(83, 16);
            this.rbAsymmetric.TabIndex = 5;
            this.rbAsymmetric.Text = "非对称算法";
            this.rbAsymmetric.UseVisualStyleBackColor = true;
            this.rbAsymmetric.CheckedChanged += new System.EventHandler(this.rbAsymmetric_CheckedChanged);
            // 
            // rbSymmetric
            // 
            this.rbSymmetric.AutoSize = true;
            this.rbSymmetric.Location = new System.Drawing.Point(8, 145);
            this.rbSymmetric.Name = "rbSymmetric";
            this.rbSymmetric.Size = new System.Drawing.Size(71, 16);
            this.rbSymmetric.TabIndex = 5;
            this.rbSymmetric.Text = "对称算法";
            this.rbSymmetric.UseVisualStyleBackColor = true;
            this.rbSymmetric.CheckedChanged += new System.EventHandler(this.rbSymmetric_CheckedChanged);
            // 
            // rbHash
            // 
            this.rbHash.AutoSize = true;
            this.rbHash.Checked = true;
            this.rbHash.Location = new System.Drawing.Point(8, 64);
            this.rbHash.Name = "rbHash";
            this.rbHash.Size = new System.Drawing.Size(71, 16);
            this.rbHash.TabIndex = 5;
            this.rbHash.TabStop = true;
            this.rbHash.Text = "散列算法";
            this.rbHash.UseVisualStyleBackColor = true;
            this.rbHash.CheckedChanged += new System.EventHandler(this.rbHash_CheckedChanged);
            // 
            // pSymmetric
            // 
            this.pSymmetric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pSymmetric.Controls.Add(this.tbKey);
            this.pSymmetric.Controls.Add(this.tbIV);
            this.pSymmetric.Controls.Add(this.label4);
            this.pSymmetric.Controls.Add(this.label3);
            this.pSymmetric.Controls.Add(this.label9);
            this.pSymmetric.Controls.Add(this.cbSymmetricCrypt);
            this.pSymmetric.Enabled = false;
            this.pSymmetric.Location = new System.Drawing.Point(6, 167);
            this.pSymmetric.Name = "pSymmetric";
            this.pSymmetric.Size = new System.Drawing.Size(463, 111);
            this.pSymmetric.TabIndex = 4;
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(73, 44);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(375, 21);
            this.tbKey.TabIndex = 2;
            // 
            // tbIV
            // 
            this.tbIV.Location = new System.Drawing.Point(73, 73);
            this.tbIV.Name = "tbIV";
            this.tbIV.Size = new System.Drawing.Size(375, 21);
            this.tbIV.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "IV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Key";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "加密算法";
            // 
            // cbSymmetricCrypt
            // 
            this.cbSymmetricCrypt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSymmetricCrypt.FormattingEnabled = true;
            this.cbSymmetricCrypt.Items.AddRange(new object[] {
            "DES",
            "AES"});
            this.cbSymmetricCrypt.Location = new System.Drawing.Point(75, 10);
            this.cbSymmetricCrypt.Name = "cbSymmetricCrypt";
            this.cbSymmetricCrypt.Size = new System.Drawing.Size(68, 20);
            this.cbSymmetricCrypt.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "字符集";
            // 
            // cbCharset
            // 
            this.cbCharset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCharset.FormattingEnabled = true;
            this.cbCharset.Items.AddRange(new object[] {
            "utf-8",
            "gbk",
            "gb2312",
            "ascii"});
            this.cbCharset.Location = new System.Drawing.Point(176, 34);
            this.cbCharset.Name = "cbCharset";
            this.cbCharset.Size = new System.Drawing.Size(78, 20);
            this.cbCharset.TabIndex = 1;
            // 
            // ofdCertificate
            // 
            this.ofdCertificate.Filter = "P12证书|*.p12|CER证书|*.cer|PFX证书|*.pfx";
            this.ofdCertificate.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdCertificate_FileOk);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 459);
            this.Controls.Add(this.pForm);
            this.Name = "MainForm";
            this.Text = "转换窗口";
            this.pForm.ResumeLayout(false);
            this.pForm.PerformLayout();
            this.gbCryptoChoose.ResumeLayout(false);
            this.gbCryptoChoose.PerformLayout();
            this.pHash.ResumeLayout(false);
            this.pHash.PerformLayout();
            this.pAsymmetric.ResumeLayout(false);
            this.pAsymmetric.PerformLayout();
            this.pSymmetric.ResumeLayout(false);
            this.pSymmetric.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pForm;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.GroupBox gbCryptoChoose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCryptoType;
        private System.Windows.Forms.ComboBox cbHashCrypt;
        private System.Windows.Forms.TextBox tbIV;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCharset;
        private System.Windows.Forms.Panel pAsymmetric;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox tbCertificatePath;
        private System.Windows.Forms.RadioButton rbAsymmetric;
        private System.Windows.Forms.RadioButton rbSymmetric;
        private System.Windows.Forms.Panel pSymmetric;
        private System.Windows.Forms.OpenFileDialog ofdCertificate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbAsymmetricCrypt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbSymmetricCrypt;
        private System.Windows.Forms.Panel pHash;
        private System.Windows.Forms.RadioButton rbHash;
        private System.Windows.Forms.TextBox tbAlias;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbKeyType;
    }
}

