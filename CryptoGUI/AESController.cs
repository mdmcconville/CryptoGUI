using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoGUI
{
    // This is where all of the business logic for AES is performed
    class AESController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ciph">in hex</param>
        /// <param name="key">in hex</param>
        /// <param name="iv">in hex</param>
        /// <returns></returns>
        public static string decryptAES256(string ciph, string key, string iv)
        {
            string plaintext = "";

            // Create an AES object
            AesCryptoServiceProvider aesThing = new AesCryptoServiceProvider();

            // Create string lists
            List<string> ciphList = new List<string>();
            List<string> keyList = new List<string>();
            List<string> ivList = new List<string>();

            try
            {
                // Put string contents into lists
                for (int i = 0; i <= ciph.Length - 2; i = i + 2)
                {
                    // add the substrings of size 2 each to the string list
                    ciphList.Add(ciph.Substring(i, 2));
                }
                for (int i = 0; i <= key.Length - 2; i = i + 2)
                {
                    // add the substrings of size 2 each to the string list
                    keyList.Add(key.Substring(i, 2));
                }
                for (int i = 0; i <= iv.Length - 2; i = i + 2)
                {
                    // add the substrings of size 2 each to the string list
                    ivList.Add(iv.Substring(i, 2));
                }

            }
            catch (Exception e)
            {

            }

            // Need to create byte[]'s for ciphertext, key, iv, plaintext
            byte[] ciphArray = Convert.FromBase64String(ciph);
            byte[] keyArray = Convert.FromBase64String(key);
            byte[] ivArray = Convert.FromBase64String(iv);
            byte[] plainArray = null;

            // Convert string lists to byte[]'s
            try
            {
                ciphArray = (ciphList.ToArray<string>()).Select(str => Convert.ToByte(str, 16)).ToArray();
                keyArray = (keyList.ToArray<string>()).Select(str => Convert.ToByte(str, 16)).ToArray();
                ivArray = (ivList.ToArray<string>()).Select(str => Convert.ToByte(str, 16)).ToArray();
            }
            catch (Exception ex)
            {

            }
            aesThing.KeySize = 256;
            aesThing.BlockSize = 128;
            aesThing.Key = keyArray;
            aesThing.Padding = PaddingMode.Zeros;

            ICryptoTransform decryptor = aesThing.CreateDecryptor(keyArray, ivArray);
            
            // Create the streams used for decryption. 
            // Don't initialize the memory stream so that it can be expanded
            using (MemoryStream msDecrypt = new MemoryStream())
            {
                CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Write);
                using (csDecrypt)
                {
                    csDecrypt.Write(ciphArray, 0, ciphArray.Length);
                }
                plainArray = msDecrypt.ToArray();
            }
            plaintext = System.Text.Encoding.Unicode.GetString(plainArray);
            
            return plaintext;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="plain">in hex</param>
        /// <param name="key">in hex</param>
        /// <param name="iv">in hex</param>
        /// <returns></returns>
        public static string encryptAES256(string plain, string key, string iv)
        {
            string ciphertext = "";
            // Create an AES object
            AesCryptoServiceProvider aesThing = new AesCryptoServiceProvider();

            // Create string lists
            List<string> plainList = new List<string>();
            List<string> keyList = new List<string>();
            List<string> ivList = new List<string>();

            try
            {
                // Put string contents into lists
                for (int i = 0; i <= plain.Length - 2; i = i + 2)
                {
                    // add the substrings of size 2 each to the string list
                    plainList.Add(plain.Substring(i, 2));
                }
                for (int i = 0; i <= key.Length - 2; i = i + 2)
                {
                    // add the substrings of size 2 each to the string list
                    keyList.Add(key.Substring(i, 2));
                }
                for (int i = 0; i <= iv.Length - 2; i = i + 2)
                {
                    // add the substrings of size 2 each to the string list
                    ivList.Add(iv.Substring(i, 2));
                }

            }
            catch (Exception e)
            {

            }

            // Need to create byte[]'s for plaintext, key, iv, plaintext
            byte[] ciphArray = null;
            byte[] keyArray = Convert.FromBase64String(key);
            byte[] ivArray = Convert.FromBase64String(iv);
            byte[] plainArray = Convert.FromBase64String(plain);

            // Convert string lists to byte[]'s
            try
            {
                ciphArray = (plainList.ToArray<string>()).Select(str => Convert.ToByte(str, 16)).ToArray();
                keyArray = (keyList.ToArray<string>()).Select(str => Convert.ToByte(str, 16)).ToArray();
                ivArray = (ivList.ToArray<string>()).Select(str => Convert.ToByte(str, 16)).ToArray();
            }
            catch (Exception ex)
            {

            }
            aesThing.KeySize = 256;
            aesThing.BlockSize = 128;
            aesThing.Key = keyArray;
            aesThing.Padding = PaddingMode.Zeros;

            ICryptoTransform encryptor = aesThing.CreateEncryptor(keyArray, ivArray);

            // Create the streams used for encryption. 
            // Don't initialize memory stream so that it is expandable
            using (MemoryStream msEncrypt = new MemoryStream())
            {
                CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write);
                using (csEncrypt)
                {
                    csEncrypt.Write(plainArray, 0, plainArray.Length);
                }
                ciphArray = msEncrypt.ToArray();
            }
            ciphertext = System.Text.Encoding.Unicode.GetString(ciphArray);

            return ciphertext;
        }
    }
}
