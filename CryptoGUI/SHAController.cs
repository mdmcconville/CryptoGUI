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
    // This is where all of the business logic for SHA is performed
    public static class SHAController
    {
        public static string calculateSHA512(string s)
        {
            string results = "";
            // Calculate stuff here

            List<string> strList = new List<string>();

            try
            {
                for (int i = 0; i <= s.Length - 2; i = i + 2)
                {
                    // add the substrings of size 2 each to the string list
                    strList.Add(s.Substring(i, 2));
                }
            }
            catch (Exception e)
            {

            }
            string[] strArray = strList.ToArray<string>();

            byte[] tempBytes = strArray.Select(str => Convert.ToByte(str, 16)).ToArray();

            // Create a SHA512 instance
            SHA512 shaObj = SHA512.Create();
            // Compute the SHA512 hash
            byte[] hashResults = shaObj.ComputeHash(tempBytes);

            // Create a SoapHexBinary object to get the results in hex
            SoapHexBinary soapThing = new SoapHexBinary(hashResults);
            results = soapThing.ToString();

            return results;

        }

        public static string calculateSHA256(string s)
        {
            string results = "";
            // Calculate stuff here

            List<string> strList = new List<string>();

            try
            {
                for (int i = 0; i <= s.Length - 2; i = i + 2)
                {
                    // add the substrings of size 2 each to the string list
                    strList.Add(s.Substring(i, 2));
                }
            }
            catch (Exception e)
            {

            }
            string[] strArray = strList.ToArray<string>();

            byte[] tempBytes = strArray.Select(str => Convert.ToByte(str, 16)).ToArray();

            // Create a SHA256 instance
            SHA256 shaObj = SHA256.Create();
            // Compute the SHA512 hash
            byte[] hashResults = shaObj.ComputeHash(tempBytes);

            // Create a SoapHexBinary object to get the results in hex
            SoapHexBinary soapThing = new SoapHexBinary(hashResults);
            results = soapThing.ToString();

            return results;
        }

    }   
}
