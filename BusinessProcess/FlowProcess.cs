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
    public class FlowProcess
    {
        private RSA RSAEnrcypter;
        private TDES TDESEncrypter;
        private XMLHandler fileHandler;
        
        
        public FlowProcess()
        {
            this.RSAEnrcypter = new RSA();
            this.TDESEncrypter = new TDES();
            this.fileHandler = new XMLHandler();
        
        }
        public void exportPublicKeyToXml(string route)
        {

        }

        public string [] generateRSAKeys()
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
        
        public void generateTdesKeys()
        {
            this.TDESEncrypter.generateKeys();
            this.TDESEncrypter.generateInitializationVector();
        }
        public string getTdesKey()
        {
            byte[] key = this.TDESEncrypter.getKey();
            return ByteArrayToHexa(key);
        }
        public void importTdesKeyFromXml(String route)
        {

        }

        public string [] decryptTdesKeys()
        {
            string[] keys = new string[3];
            return keys;
        }

        public void setTdesKeys()
        {

        }
        public string encryptText()
        {
            string encryptedMessage = "";
            return encryptedMessage;
        }

        public void exportEncryptedTextToXml(string route)
        {
            
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
