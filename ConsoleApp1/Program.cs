using DataHandlers;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            XMLHandler fileHandler = new XMLHandler();
            string publicKey = fileHandler.readRsaPublicKey("C:\\Users\\jose.paniagua\\Desktop\\cp_esclavo.xml");
            Console.WriteLine("The public key is: " + publicKey);
        }
    }
}
