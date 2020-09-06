using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

using EncryptionAndHashingLibrary;

namespace FileEncryption
{
    public class AesFileEncryption
    {
        public static string[] Encrypt(string filePath, byte[] key)
        {
            byte[] data = File.ReadAllBytes(filePath);
            byte[] completeCipherText = AesEncryptionWrapper.EncryptWithGCM(data, key);

            return new string[] {
                Convert.ToBase64String(completeCipherText),
                data.Length.ToString()
            };
        }

        public static byte[] Decrypt(string cipherFilePath, byte[] key)
        {
            string[] encryptedResult = File.ReadAllLines(cipherFilePath);

            byte[] completeCipherText = Convert.FromBase64String(encryptedResult[0]);
            int length = int.Parse(encryptedResult[1]);
            byte[] data = AesEncryptionWrapper.DecryptForGCM(completeCipherText, key);

            return data;
        }
    }
}
