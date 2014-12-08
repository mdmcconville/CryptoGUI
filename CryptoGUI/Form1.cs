using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoGUI
{
    public partial class GUIForm : Form
    {
        private static bool isSHA256 = true; // Default true
        private static bool isSHA512 = false;
        private static bool isHMAC_SHA256 = true; // Default true since only one radio button
        private static bool isAES256Decrypt = true; // Default true

        public GUIForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioSHA512_CheckedChanged(object sender, EventArgs e)
        {
            // Change the static bool to true
            isSHA512 = true;
        }

        private void radioMAC256_CheckedChanged(object sender, EventArgs e)
        {
            // Change the static bool to true
            isHMAC_SHA256 = true;
        }

        private void shaENTERButton_Click(object sender, EventArgs e)
        {
            string shaText = textBoxSHAMessage.Text;
            string resultText = "";
            // Call the method that calculates the SHA depending on the static bool that is true
            if (isSHA512 == true)
            {
                resultText = CryptoGUI.SHAController.calculateSHA512(shaText);
            }
            else if (isSHA256 == true)
            {
                resultText = CryptoGUI.SHAController.calculateSHA256(shaText);
            }
            // Update the result textbox
            textBoxSHAResults.Text = resultText;
        }

        private void radioSHA256_CheckedChanged(object sender, EventArgs e)
        {
            // Change the static bool to true
            isSHA256 = true;
        }

        private void macENTERButton_Click(object sender, EventArgs e)
        {
            // Get input entered by the user
            string macMsg = textBoxMACMsg.Text;
            string macKey = textBoxMACKey.Text;
            string resultText = "";
            if (isHMAC_SHA256 == true)
            {
                resultText = CryptoGUI.MACController.calculateHMAC_SHA256(macMsg, macKey);
            }
            // Update the result textbox
            textBoxMACResults.Text = resultText;
        }

        private void radioAES256Encrypt_CheckedChanged(object sender, EventArgs e)
        {
            isAES256Decrypt = false; // Now encrypt instead of decrypt
        }

        private void textBoxCiphertext_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void aesEnterButton_Click(object sender, EventArgs e)
        {
            // Is decryption or encryption?
            if (isAES256Decrypt)
            {
                try
                {
                    // Get the ciphertext
                    string ciphertext = textBoxCiphertext.Text;
                    // Get the key
                    string aesKey = textBoxAESKey.Text;
                    // Get the IV
                    string IV = textBoxIV.Text;

                    string results = AESController.decryptAES256(ciphertext, aesKey, IV);
                    // Update the textbox
                    textBoxPlaintext.Text = results;

                }
                catch (Exception ex)
                {
                    textBoxPlaintext.Text = ex.ToString();
                }
            }
            else
            {
                try
                {
                    // Get the plaintext
                    string plaintext = textBoxPlaintext.Text;
                    // Get the key
                    string aesKey = textBoxAESKey.Text;
                    // Get the IV
                    string IV = textBoxIV.Text;

                    string results = AESController.encryptAES256(plaintext, aesKey, IV);
                    // Update the textbox
                    textBoxCiphertext.Text = results;
                }
                catch (Exception ex)
                {
                    textBoxCiphertext.Text = ex.ToString();
                }
            }
        }

        private void radioAES256Decrypt_CheckedChanged(object sender, EventArgs e)
        {
            isAES256Decrypt = true;
        }

    }
}
