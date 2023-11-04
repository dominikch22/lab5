using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class TextEditor
    {
        public bool Compression = false;
        public bool Encryption = false;
        private byte[] HashedKey;
        private Aes aes;

        public TextEditor(bool compression, bool encryption, string key)
        {
            Compression = compression;
            Encryption = encryption;

            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            using (SHA256 sha = SHA256.Create())
            {
                HashedKey = sha.ComputeHash(keyBytes);
            }
            aes = Aes.Create();

            aes.Key = HashedKey;
            aes.IV = new byte[aes.BlockSize / 8];
        }

        public void saveToFile(string text, string path)
        {
            using (FileStream file = new FileStream(path, FileMode.Create))
            {
                Stream finalStream = file;
                if (Encryption)
                {
                    ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                    finalStream = new CryptoStream(finalStream, encryptor, CryptoStreamMode.Write);
                }

                if (Compression)
                {
                    finalStream = new GZipStream(finalStream, CompressionMode.Compress);
                }

                byte[] bytes = Encoding.UTF8.GetBytes(text); ;
                finalStream.Write(bytes, 0, bytes.Length);
                finalStream.Dispose();
            }
        }

        public string readFile(string path)
        {
            byte[] buffer;

            using (FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                Stream finalStream = file;
                if (Encryption)
                {
                    ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                    finalStream = new CryptoStream(finalStream, decryptor, CryptoStreamMode.Read);
                }

                if (Compression)
                {
                    finalStream = new GZipStream(finalStream, CompressionMode.Decompress);
                }

                using (MemoryStream output = new MemoryStream())
                {
                    finalStream.CopyTo(output);
                    buffer = output.ToArray();
                }
                finalStream.Dispose();
            }


            return Encoding.UTF8.GetString(buffer);
        }
    }
}
