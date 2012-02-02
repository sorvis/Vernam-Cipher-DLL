using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Vernam_Cipher
{
    static class ByteTools
    {
        public static byte[] XOR_byteArray(byte[] original, byte[] key)
        {
            BitArray first = new BitArray(original);
            BitArray second = new BitArray(key);
            BitArray target = new BitArray(first.Count);

            for (int i = 0; i < first.Count; i++)
            {
                target[i] = first[i] ^ second[i];
            }
            return BitArrayToByteArray(target);
        }

        private static byte[] BitArrayToByteArray(BitArray bits)
        {
            byte[] ret = new byte[bits.Length / 8];
            bits.CopyTo(ret, 0);
            return ret;
        }

        public static byte[] StringToBytes(string text)
        {
            return new System.Text.ASCIIEncoding().GetBytes(text);
        }

        public static string BytesToString(byte[] bytes)
        {
            return System.Text.Encoding.UTF8.GetString(bytes);
        }
    }
}
