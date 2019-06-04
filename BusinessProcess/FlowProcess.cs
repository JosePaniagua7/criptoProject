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
        public void exportPublicKeyToXml()
        {

        }

        public string [] generateRSAKeys()
        {
            string[] keys = new string[2];
            keys[0] = "Prueba 1";
            keys[1] = "Prueba 2";
            return keys;
        }

        public void importTdesKeyFromXml()
        {

        }

        public string [] decryptTdesKeys()
        {
            string[] keys = new string[3];
            return keys;
        }

        public string encryptText()
        {
            string encryptedMessage = "";
            return encryptedMessage;
        }

        public void exportEncryptedTextToXml(string route)
        {
            
        }
    }
}
