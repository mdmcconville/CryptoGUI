using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoGUI
{
    // This is where all of the business logic for MAC is performed
    class MACController
    {
        public static string calculateHMAC_SHA256(string msg, string key)
        {
            string results = "";

            List<string> msgList = new List<string>();

            try
            {
                for (int i = 0; i <= msg.Length - 2; i = i + 2)
                {
                    // add the substrings of size 2 each to the string list
                    msgList.Add(msg.Substring(i, 2));
                }
            }
            catch (Exception e)
            {

            }

            List<string> keyList = new List<string>();

            try
            {
                for (int i = 0; i <= key.Length - 2; i = i + 2)
                {
                    // add the substrings of size 2 each to the string list
                    keyList.Add(key.Substring(i, 2));
                }
            }
            catch (Exception e)
            {

            }

            string[] msgArray = msgList.ToArray<string>();
            string[] keyArray = keyList.ToArray<string>();

            byte[] msgBytes = msgArray.Select(str => Convert.ToByte(str, 16)).ToArray();
            byte[] keyBytes = keyArray.Select(str => Convert.ToByte(str, 16)).ToArray();


            // Create an HMACSHA256 object with the specified key
            HMACSHA256 shaObj = new HMACSHA256(keyBytes);

            // Compute the hash, or the MAC, of the message and get a byte array
            byte[] MAC = shaObj.ComputeHash(msgBytes);

            int count = 0;
            foreach (byte item in MAC)
            {
                results += string.Format("{0} ", item.ToString());
                count++;
                if (count == 12)
                {
                    results += "\n ";
                    count = 0;
                }
            }

            return results;
        }
    }
}
