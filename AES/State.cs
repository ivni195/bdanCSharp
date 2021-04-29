using System;
using System.IO;
using System.Security.Cryptography;

namespace AES
{
    public class State
    {
        public string Message { get; }
        public byte[] Key { get; }
        public byte[] CipherText { get; set; }
        public byte[] IV { get; }
        public byte[] InvalidCipher { get; }
        public byte[] InvalidKey { get; }
        
        public State()
        {
            Message = System.IO.File.ReadAllText(@"C:\Users\kuba1\Desktop\crypt\crypt\AES\Jakub_Pilimon.txt");
            using (AesManaged aes = new AesManaged())
            {
                Key = aes.Key;
                IV = aes.IV;
            }

            CipherText = Encypt(Message, Key, IV);
            
            InvalidCipher = new byte[CipherText.Length];
            CipherText.CopyTo(InvalidCipher, 0);

            InvalidCipher[0] += 1;
            
            InvalidKey = new byte[Key.Length];
            Key.CopyTo(InvalidKey, 0);

            InvalidKey[0] += 1;
        }

        public byte[] Encypt(string plainText, byte[] key, byte[] IV)
        {
            byte[] encrypted;
            using (AesManaged aes = new AesManaged())
            {
                aes.Padding = PaddingMode.Zeros;
                // Create encryptor    
                ICryptoTransform encryptor = aes.CreateEncryptor(Key, IV);
                // Create MemoryStream    
                using (MemoryStream ms = new MemoryStream())
                {
                    // Create crypto stream using the CryptoStream class. This class is the key to encryption    
                    // and encrypts and decrypts data from any given stream. In this case, we will pass a memory stream    
                    // to encrypt    
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        // Create StreamWriter and write data to a stream    
                        using (StreamWriter sw = new StreamWriter(cs))
                        {
                            sw.Write(plainText);
                            
                        }
                        encrypted = ms.ToArray();
                        
                    }
                }
            }

            return encrypted;
        }
        
        public string Decrypt(byte[] cipherText, byte[] Key, byte[] IV) {  
            string plaintext = null;  
            // Create AesManaged    
            using(AesManaged aes = new AesManaged()) {  
                aes.Padding = PaddingMode.Zeros;
                // Create a decryptor    
                ICryptoTransform decryptor = aes.CreateDecryptor(Key, IV);  
                // Create the streams used for decryption.    
                using(MemoryStream ms = new MemoryStream(cipherText)) {  
                    // Create crypto stream    
                    using(CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read)) {  
                        // Read crypto stream    
                        using(StreamReader reader = new StreamReader(cs))  
                            plaintext = reader.ReadToEnd();  
                    }  
                }  
            }  
            return plaintext;  
        } 

    }
}