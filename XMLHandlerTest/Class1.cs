using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataHandlers;
using System.IO;

namespace XMLHandlerTest
{
    public class Class1
    {
        [Test]
        public void readTdesKeysTest()
        {
            XMLHandler fileHandler = new XMLHandler();
            string[] tdesExpected = { "Hi", "Good", "Moorning" };
            string[] tdesKeysReceived=fileHandler.readTdesKeys("C:\\Users\\jose.paniagua\\Desktop\\tdesKeys.xml");            

            Assert.AreEqual(tdesExpected[0], tdesKeysReceived[0]);
            Assert.AreEqual(tdesExpected[1], tdesKeysReceived[1]);
            Assert.AreEqual(tdesExpected[2], tdesKeysReceived[2]);
        }
        [Test]
        public void readIVTest()
        {
            XMLHandler fileHandler = new XMLHandler();
            string expected = "VectorDeInicializacion";            
            string received = fileHandler.readInitializationVector("C:\\Users\\jose.paniagua\\Desktop\\tdesKeys.xml");            
            Assert.AreEqual(expected, received);            
        }

        [Test]
        public void readRsaPublicKeyTest()
        {
            XMLHandler fileHandler = new XMLHandler();
            string expected = "ClavePublicaEsclavo";
            string received = fileHandler.readRsaPublicKey("C:\\Users\\jose.paniagua\\Desktop\\clavepublica.xml");
            Console.WriteLine("Vamo a calmarno " + received);
            Assert.AreEqual(expected, received);
        }
        [Test]
        public void readEncryptedTextTest()
        {
            XMLHandler fileHandler = new XMLHandler();
            string expected = "EstoEsUnTestDeTextoEncryptado";
            string received = fileHandler.readEncryptedText("C:\\Users\\jose.paniagua\\Desktop\\textoTest.xml");
            Console.WriteLine("Vamo a calmarno " + received);
            Assert.AreEqual(expected, received);
        }

    }
}
