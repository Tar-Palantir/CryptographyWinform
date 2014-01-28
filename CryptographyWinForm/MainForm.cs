using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using Zeus.Common.CryptographyHelper;

namespace CryptographyWinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            InitializeData();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbHash.Checked)
                {
                    tbOutput.Text = GetHashCryptResult();
                }
                else if (rbSymmetric.Checked)
                {
                    tbOutput.Text = GetSymmetricCryptResult(true);
                }
                else
                {
                    tbOutput.Text = GetAsymmetricCryptResult(true);
                }
            }
            catch (Exception ex)
            {
                tbOutput.Text = ex.Message;
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbHash.Checked)
                {
                    tbOutput.Text = @"散列加密不能解密";
                }
                else if (rbSymmetric.Checked)
                {
                    tbOutput.Text = GetSymmetricCryptResult(false);
                }
                else
                {
                    tbOutput.Text = GetAsymmetricCryptResult(false);
                }
            }
            catch (Exception ex)
            {
                tbOutput.Text = ex.Message;
            }
        }

        private void rbHash_CheckedChanged(object sender, EventArgs e)
        {
            PanelEnabledChange("pHash");
            btnDecrypt.Enabled = false;
        }

        private void rbSymmetric_CheckedChanged(object sender, EventArgs e)
        {
            PanelEnabledChange("pSymmetric");
            btnDecrypt.Enabled = true;
        }

        private void rbAsymmetric_CheckedChanged(object sender, EventArgs e)
        {
            PanelEnabledChange("pAsymmetric");
            btnDecrypt.Enabled = true;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            ofdCertificate.ShowDialog();
        }

        private void ofdCertificate_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            tbCertificatePath.Text = ofdCertificate.FileName;
        }



        private void InitializeData()
        {
            cbAsymmetricCrypt.SelectedIndex = 0;
            cbCharset.SelectedIndex = 0; ;
            cbCryptoType.SelectedIndex = 0;
            cbHashCrypt.SelectedIndex = 0;
            cbKeyType.SelectedIndex = 0;
            cbSymmetricCrypt.SelectedIndex = 0;

            tbAlias.Text = string.Empty;
            tbCertificatePath.Text = string.Empty;
            tbInput.Text = string.Empty;
            tbIV.Text = string.Empty;
            tbKey.Text = string.Empty;
            tbOutput.Text = string.Empty;
            tbPassword.Text = string.Empty;
        }

        private string GetHashCryptResult()
        {
            string result;

            switch (cbHashCrypt.SelectedIndex)
            {
                case 0:
                    result = HashCryptography.MD5Encrypt(tbInput.Text.Trim(), (EncryptResultType)(cbCryptoType.SelectedIndex), cbCharset.SelectedItem.ToString());
                    break;
                case 1:
                    result = HashCryptography.SHA256Encrypt(tbInput.Text.Trim(), (EncryptResultType)(cbCryptoType.SelectedIndex), cbCharset.SelectedItem.ToString());
                    break;
                default:
                    result = @"非法选项";
                    break;
            }
            return result;
        }

        private string GetSymmetricCryptResult(bool isEncrypt)
        {
            string result;
            string input = tbInput.Text.Trim();
            string charset = cbCharset.SelectedItem.ToString();
            string key = tbKey.Text.Trim();
            string iv = tbIV.Text.Trim();

            switch (cbSymmetricCrypt.SelectedIndex)
            {
                case 0:
                    if (isEncrypt)
                    {
                        result = DesCryptography.DESEncrypt(input, charset, key, iv);
                    }
                    else
                    {
                        result = DesCryptography.DESDecrypt(input, charset, key, iv);
                    }
                    break;
                case 1: 
                    if (isEncrypt)
                    {
                        result = AesCryptography.AESEncrypt(input, charset, key, iv);
                    }
                    else
                    {
                        result = AesCryptography.AESDecrypt(input, charset, key, iv);
                    }
                    break;
                default:
                    result = @"非法选项";
                    break;
            }
            return result;
        }

        private string GetAsymmetricCryptResult(bool isEncrypt)
        {
            string result;
            string input = tbInput.Text.Trim();
            string charset = cbCharset.SelectedItem.ToString();
            string cerPath = tbCertificatePath.Text.Trim();
            string alias = tbAlias.Text.Trim();
            string password = tbPassword.Text.Trim();
            RSAKeyType keyType=(RSAKeyType)cbKeyType.SelectedIndex;

            switch (cbAsymmetricCrypt.SelectedIndex)
            {
                case 0:
                    if (isEncrypt)
                    {
                        result = RSACryptography.RSAEncryptFromCer(input, cerPath, alias, password, charset, keyType);
                    }
                    else
                    {
                        result = RSACryptography.RSADecryptFromCer(input, cerPath, alias, password, charset, keyType);
                    }
                    break;
                default:
                    result = @"非法选项";
                    break;
            }
            return result;
        }

        private void PanelEnabledChange(string currentPanelName)
        {
            var pList = gbCryptoChoose.Controls.OfType<Panel>();
            foreach (Panel panel in pList)
            {
                if (panel.Name == currentPanelName)
                {
                    panel.Enabled = true;
                }
                else
                {
                    panel.Enabled = false;
                }
            }
        }

    }
}
