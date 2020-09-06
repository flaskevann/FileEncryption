using EncryptionAndHashingLibrary;
using System;
using System.IO;
using System.Linq;

using Xunit;

namespace FileEncryption.Tests
{
    public class AesFileEncryptionTests
    {
        [Fact]
        public void FileEncryptionAndDecryptionTest()
        {
            string encryptionPassword = "This is my long winded test password with strange symbols like =)(/&%¤#@£$€[]";

            // Encrypt and write to file
            string testFilePath = @"..\..\..\test file for encryption.jpg";
            string cipherTestFilePath = @"..\..\..\test file for encryption.jpg.ENCRYPTED";
            string[] encryptedFileContent = AesFileEncryption.Encrypt(
                testFilePath,
                Tools.GetPasswordAsEncryptionKey(AesEncryptionWrapper.GCM_KEY_SIZE, encryptionPassword)
            );
            File.WriteAllLines(cipherTestFilePath, encryptedFileContent);

            // Decrypt and shrink data to correct size, then write to file
            byte[] fileData = AesFileEncryption.Decrypt(
                cipherTestFilePath,
                Tools.GetPasswordAsEncryptionKey(AesEncryptionWrapper.GCM_KEY_SIZE, encryptionPassword)
            );

            // Compare
            Assert.True(File.ReadAllBytes(testFilePath).SequenceEqual(fileData));

            // Clean up
            File.Delete(cipherTestFilePath);
        }
    }
}
