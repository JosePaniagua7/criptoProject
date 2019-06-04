using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace TDESEncrypter
{
    public class TDES
    {
        private byte[] keys;        
        private byte[] initializationVector;
        private TripleDESCryptoServiceProvider ecrypterServiceProvider;
        private Random rnd;
        
        public TDES()
        {
            this.rnd = new Random();
        }
        public byte[] generateKeys()
        {
            for (int i = 0; i < this.keys.Length; i++)
            {
                this.keys[i] = (byte)rnd.Next(128);
            }
            return this.keys;
        }

        public byte[] generateInitializationVector()
        {
            for (int i = 0; i < this.initializationVector.Length; i++)
            {
                this.initializationVector[i] = (byte)rnd.Next(128);
            }
            return this.initializationVector;
        }

        public byte[][] getKeys()
        {
            byte[][] keys = new byte[3][];
            keys[0] = this.keys.Take(8).ToArray();
            keys[1] = this.keys.Skip(8).Take(8).ToArray();
            keys[2] = this.keys.Skip(16).Take(8).ToArray();
            for (int i = 0; i < keys.Length; i++)
            {
                for(int j = 0; j < keys[i].Length; j++)
                {
                    Console.Write(keys[i][j]+ ",");
                }
                Console.WriteLine();
            }
            return keys;
        }
        
        public void setKeys(byte[] key)
        {

        }

        public byte[] getInitializationVector()
        {
            return this.initializationVector;
        }

        public byte[] Encrypt(string Data)
        {
            try
            {
                // Create a MemoryStream.
                MemoryStream memoryStream = new MemoryStream();
                // Create a CryptoStream using the MemoryStream 
                // and the passed key and initialization vector (IV).
                CryptoStream criptoStream = new CryptoStream(memoryStream, this.ecrypterServiceProvider.CreateEncryptor(this.keys, this.initializationVector),
                    CryptoStreamMode.Write);

                // Convert the passed string to a byte array.
                byte[] stringAsByteArray = new ASCIIEncoding().GetBytes(Data);

                // Write the byte array to the crypto stream and flush it.
                criptoStream.Write(stringAsByteArray, 0, stringAsByteArray.Length);
                criptoStream.FlushFinalBlock();

                // Get an array of bytes from the 
                // MemoryStream that holds the 
                // encrypted data.
                byte[] dataEncrypted = memoryStream.ToArray();

                // Close the streams.
                criptoStream.Close();
                criptoStream.Close();

                // Return the encrypted buffer.
                return dataEncrypted;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine("A Cryptographic error occurred: {0}", e.Message);
                return null;
            }
        }

        public string Decrypt(byte[] Data)
        {
            try
            {
                // Create a new MemoryStream using the passed 
                // array of encrypted data.
                MemoryStream memoryStream = new MemoryStream(Data);
                // Create a CryptoStream using the MemoryStream 
                // and the passed key and initialization vector (IV).
                CryptoStream cryptoStream = new CryptoStream(memoryStream,
                    this.ecrypterServiceProvider.CreateDecryptor(this.keys, this.initializationVector), CryptoStreamMode.Read);

                // Create buffer to hold the decrypted data.
                byte[] decryptedData = new byte[Data.Length];

                // Read the decrypted data out of the crypto stream
                // and place it into the temporary buffer.
                cryptoStream.Read(decryptedData, 0, decryptedData.Length);

                //Convert the buffer into a string and return it.
                return new ASCIIEncoding().GetString(decryptedData);
            }
            catch (CryptographicException e)
            {
                Console.WriteLine("A Cryptographic error occurred: {0}", e.Message);
                return null;
            }
        }
    }
}
