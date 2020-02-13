using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace trainees_Management_System
{
    class Cyper
    {
        //..must be 32 character...
        public static string key = "QW3RTyuIo1A6DFghjklpoiu7TR3wq9By";
        //..must be 16 character...
        public static string IV = "394231kijhts/mnq";

        public string Encrypt(string str)
        {
            byte[] planeTextByte = System.Text.UTF8Encoding.UTF8.GetBytes(str);
            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.BlockSize = 128;
            aes.KeySize = 256;
            aes.Key = System.Text.UTF8Encoding.UTF8.GetBytes(key);
            aes.IV = System.Text.UTF8Encoding.UTF8.GetBytes(IV);
            aes.Padding = PaddingMode.PKCS7;
            aes.Mode = CipherMode.CBC;
            ICryptoTransform crypto = aes.CreateEncryptor(aes.Key, aes.IV);
            byte[] encrypt = crypto.TransformFinalBlock(planeTextByte, 0, planeTextByte.Length);
            crypto.Dispose();
            return Convert.ToBase64String(encrypt);

        }

        public string Decrypt(string encrypted)
        {
            byte[] encryptbyte = Convert.FromBase64String(encrypted);
            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.BlockSize = 128;
            aes.KeySize = 256;
            aes.Key = System.Text.UTF8Encoding.UTF8.GetBytes(key);
            aes.IV = System.Text.UTF8Encoding.UTF8.GetBytes(IV);
            aes.Padding = PaddingMode.PKCS7;
            aes.Mode = CipherMode.CBC;
            ICryptoTransform crypto = aes.CreateDecryptor(aes.Key, aes.IV);
            byte[] secret = crypto.TransformFinalBlock(encryptbyte, 0, encryptbyte.Length);
            crypto.Dispose();
            return System.Text.UTF8Encoding.UTF8.GetString(secret);
        }
    }
}
