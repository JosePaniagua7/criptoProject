using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSAEncrypter;
using TDESEncrypter;
using DataHandlers;
namespace BusinessProcess
{
    public class MasterWorkFlow
    {
        private RSA RSAEnrcypter;
        private TDES TDESEncrypter;
        private XMLHandler fileHandler;

        private string[] TdesKeys;
        private byte[] TdesIV;
        private string message;
        public MasterWorkFlow()
        {
            this.RSAEnrcypter = new RSA();
            this.TDESEncrypter = new TDES();
            this.fileHandler = new XMLHandler();
            this.TdesKeys = new string[3];
            this.TdesIV = new byte[8];
        }
        public string[] generateRSAKeys()
        {
            string[] keys = new string[2];
            keys[0] = this.RSAEnrcypter.getPrivateKey();
            keys[1] = this.RSAEnrcypter.getPublicKey();
            return keys;
        }
        

        public string importRsaPublicKey(string route)
        {            
            string publicKey=fileHandler.readRsaPublicKey(route);
            //After reading, lets set the key to the rsa
            this.RSAEnrcypter.setPublicKey(publicKey);
            return publicKey;
        }
        
        public string generateTdesKeys()
        {
             byte [] TdesKey= this.TDESEncrypter.generateKey();
             this.TDESEncrypter.generateInitializationVector();
             return ByteArrayToHexa(TdesKey);            
        }

        public string getTdesKey()
        {
            byte[] TdesKey = this.TDESEncrypter.getKey();
            return ByteArrayToHexa(TdesKey);
        }
        
        public string [] encryptTdesKeys()
        {                        
            byte [][] keysAsByteArray = this.TDESEncrypter.getKeys();
            byte[] encryptedKey;

            for (int i = 0; i < keysAsByteArray.Length; i++)
            {
                encryptedKey = this.RSAEnrcypter.Encrypt(keysAsByteArray[i]);
                this.TdesKeys[i] = ByteArrayToHexa(encryptedKey);
            }
            return this.TdesKeys;
        }

        public void exportTdesKeysToXml(string route)
        {            
            this.fileHandler.exportTdesKeys(route, this.TdesKeys);
        }

        public string importEncryptedMessage(string route)
        {
            this.message= this.fileHandler.readEncryptedText(route);
            return this.message;
        }

        public string decryptMessage()
        {
            byte[] encryptedMessageAsByteArray = HexaToByteArray(this.message);
            byte[] decryptedMessageAsByteArray = this.TDESEncrypter.Decrypt(encryptedMessageAsByteArray);
            return ByteArrayToHexa(decryptedMessageAsByteArray);
        }
        public string ByteArrayToHexa(byte[] data)
        {
            return BitConverter.ToString(data).Replace("-", "");
        }

        public byte[] HexaToByteArray(String hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }
    }
}
