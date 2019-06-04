using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace TDESEncrypter
{
    public class TDES
    {

        private byte[] joinedKeys;
        private byte[] initializationVector;
        private TripleDESCryptoServiceProvider ecrypterServiceProvider;
        //When the client creats a TDESEncrypter objetct, it needs to concat the three different keys, 
        //so that, they cen be used in the TripleDESCryptoServiceProvider, also, we need to 
        //initialize the initializationVector and create a TripleDESCryptoServiceProvider
        /*public TDES(String key1, String key2, String key3, String initializationString)
        {
            this.joinedKeys = new byte[24];
            concatKeys(key1, key2, key3);
            initializationVector = new byte[8];
            stringToInitializationVector(initializationString);
            this.ecrypterServiceProvider = new TripleDESCryptoServiceProvider();
        }*/        
        public string [] generateKeys()
        {

            string[] keys = new string[3];
            return keys;
        }

        private void concatKeys(String key1, String key2, String key3)
        {
            zeroExtend(this.joinedKeys);

            byte[] key1AsByteArray = convertStringToByteArray(key1);
            byte[] key2AsByteArray = convertStringToByteArray(key2);
            byte[] key3AsByteArray = convertStringToByteArray(key3);

            if (key1AsByteArray.Length > 8)
            {
                key1AsByteArray = key1AsByteArray.Take(8).ToArray();
            }

            if (key2AsByteArray.Length > 8)
            {
                key2AsByteArray = key2AsByteArray.Take(8).ToArray();
            }

            if (key3AsByteArray.Length > 8)
            {
                key3AsByteArray = key3AsByteArray.Take(8).ToArray();
            }

            key1AsByteArray.CopyTo(joinedKeys, 0);
            key2AsByteArray.CopyTo(joinedKeys, key1AsByteArray.Length);
            key3AsByteArray.CopyTo(joinedKeys, (key1AsByteArray.Length + key2AsByteArray.Length));
        }

        public void stringToInitializationVector(String initializationString)
        {
            zeroExtend(this.initializationVector);
            byte[] initializationStringAsByteArray = convertStringToByteArray(initializationString);
            if (initializationStringAsByteArray.Length <= 8)
            {
                initializationStringAsByteArray.CopyTo(this.initializationVector, 0);
            }
            else
            {
                this.initializationVector = initializationStringAsByteArray.Take(8).ToArray();
            }
        }

        byte[] convertStringToByteArray(String key)
        {
            return new ASCIIEncoding().GetBytes(key);
        }

        public byte[] Encrypt(string Data)
        {
            try
            {
                // Create a MemoryStream.
                MemoryStream memoryStream = new MemoryStream();
                // Create a CryptoStream using the MemoryStream 
                // and the passed key and initialization vector (IV).
                CryptoStream criptoStream = new CryptoStream(memoryStream, this.ecrypterServiceProvider.CreateEncryptor(this.joinedKeys, this.initializationVector),
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
                    this.ecrypterServiceProvider.CreateDecryptor(this.joinedKeys, this.initializationVector), CryptoStreamMode.Read);

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

        private void zeroExtend(byte[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 0;
            }
        }



    }
}
