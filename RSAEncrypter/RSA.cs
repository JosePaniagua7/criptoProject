﻿using System;
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
            this.CrytpServiceProvider = new RSACryptoServiceProvider(512);
        }

        public byte[] Encrypt(byte[] DataToEncrypt)
        {
            return this.CrytpServiceProvider.Encrypt(DataToEncrypt, true);            
        }

        public byte[] Decrypt(byte[] DataToDecrypt)
        {
            return this.CrytpServiceProvider.Decrypt(DataToDecrypt, true);            
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
