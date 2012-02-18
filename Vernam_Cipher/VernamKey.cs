using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Vernam_Cipher
{
    class VernamKey
    {
        public string key { get; set; }

        public VernamKey(string Key)
        {
            this.key = Key;
        }

        public string encrypt(string text)
        {

            return ByteTools.BytesToString(ByteTools.XOR_byteArray(ByteTools.StringToBytes(text), ByteTools.StringToBytes(buildKey(text.Length))));
        }

        public string decode(string text)
        {
            return encrypt(text);   //XOR produces the same result
        }

        /// <summary>
        /// Makes key to the length that is needed. Does this by appending.
        /// </summary>
        /// <param name="keyLength">size of key needed</param>
        /// <returns>the string for the sized key</returns>
        private string buildKey(int keyLength)
        {
            if (keyLength <= this.key.Length)
            {
                return this.key.Substring(0, keyLength);
            }
            else
            {
                string tempString = this.key;
                while (tempString.Length < keyLength)
                {
                    tempString += this.key;
                }
                return tempString.Substring(0, keyLength);
            }
        }
    }
}
