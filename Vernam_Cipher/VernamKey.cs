using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vernam_Cipher
{
    class VernamKey
    {
        public string key { get; set; }
        private System.Text.ASCIIEncoding _encoding = new System.Text.ASCIIEncoding();

        public VernamKey(string Key)
        {
            this.key = Key;
        }

        public string encrypt(string text)
        {

            return null;
        }

        public string decode(string text)
        {
            return null;
        }

        private Byte[] ToBytes(string text)
        {
            return _encoding.GetBytes(text);
        }
    }
}
