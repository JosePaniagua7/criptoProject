using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RSAEncrypter
{

    public class RSA
    {
        private RSACryptoServiceProvider CrytpServiceProvider;
        public RSA()
        {
            this.CrytpServiceProvider = new RSACryptoServiceProvider();
        }

        public byte[] Encrypt(byte[] DataToEncrypt)
        {
            return this.CrytpServiceProvider.Encrypt(DataToEncrypt, false);            
        }

        public byte[] Encrypt(String DataToEncrypt)
        {
            byte[] data = Encoding.ASCII.GetBytes(DataToEncrypt);
            return this.CrytpServiceProvider.Encrypt(data, false);
        }

        public String Decrypt(byte[] DataToDecrypt)
        {            
            byte [] decrypedDataAsByteArray= this.CrytpServiceProvider.Decrypt(DataToDecrypt, false);
            return Encoding.ASCII.GetString(decrypedDataAsByteArray);
        }

        public string getPublicKey()
        {
            return this.CrytpServiceProvider.ToXmlString(false);            
        }
        public string getPrivateKey()
        {
            return this.CrytpServiceProvider.ToXmlString(true);
        }

        public void setPublicKey(String publicKey)
        {
            this.CrytpServiceProvider.FromXmlString(publicKey);
        }



    }
}
