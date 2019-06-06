using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSAEncrypter; 

namespace EncrypterTests
{
    public class RSATests
    {
        [Test]
        public void getPublicKeyTest()
        {
            RSA client = new RSA(); 
            String publicKey=client.getPublicKey();
            Boolean hasReturnedSomething = false;
            if (publicKey.Length>0)
            {
                hasReturnedSomething = true;
                Console.WriteLine("The public Key is " + publicKey);
            }         
            Assert.AreEqual(true, hasReturnedSomething);
        }       
    }
}
