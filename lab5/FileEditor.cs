﻿using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class FileEditor
    {
        public bool Compression = false;
        public bool Encryption = false;
        private byte[] HashedKey;
        public string Key
        {
            get
            {
                return Encoding.UTF8.GetString(HashedKey);
            }
            set
            {
                byte[] keyBytes = Encoding.UTF8.GetBytes(value);
                using (SHA256 sha = SHA256.Create())
                {
                    HashedKey = sha.ComputeHash(keyBytes);
                }
                aes = Aes.Create();

                aes.Key = HashedKey;
                aes.IV = new byte[aes.BlockSize / 8];
            }
        }
        private Aes aes;

        public FileEditor(bool compression, bool encryption, string key)
        {
            Compression = compression;
            Encryption = encryption;

            Key = key;
        
        }

        public void saveToFile(string text, string path)
        {
            using (FileStream file = new FileStream(path, FileMode.Create))
            {
                Stream intermediateStream = file;
                if (Encryption)
                {
                    ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                    intermediateStream = new CryptoStream(intermediateStream, encryptor, CryptoStreamMode.Write);
                }

                if (Compression)
                {
                    intermediateStream = new GZipStream(intermediateStream, CompressionMode.Compress);
                }

                byte[] bytes = Encoding.UTF8.GetBytes(text); ;
                intermediateStream.Write(bytes, 0, bytes.Length);
                intermediateStream.Dispose();
            }
        }

        public string readFile(string path)
        {
            byte[] buffer;

            using (FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                Stream intermediateStream = file;
                if (Encryption)
                {
                    ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                    intermediateStream = new CryptoStream(intermediateStream, decryptor, CryptoStreamMode.Read);
                }

                if (Compression)
                {
                    intermediateStream = new GZipStream(intermediateStream, CompressionMode.Decompress);
                }

                using (MemoryStream output = new MemoryStream())
                {
                    intermediateStream.CopyTo(output);
                    buffer = output.ToArray();
                }
                intermediateStream.Dispose();
            }


            return Encoding.UTF8.GetString(buffer);
        }
    }
}
