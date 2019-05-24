using RSAEncrypter;
using System;
using System.Linq;
using System.Text;
using TDESEncrypter;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*const String key1 = "Jose Fernando";
            const String key2 = "Paniagua Gomez";
            const String key3 = "Tengo 19";

            TDESEncrypt myEncrypter = new TDESEncrypt(key1, key2, key3,(key1+key2));

            byte[] encryptedText = myEncrypter.encrypt("Que ondas prro kyc la boca");                         
            String decryptedText= myEncrypter.decrypt(encryptedText);
            Console.WriteLine("Aca decrypted is: " + decryptedText);

            //Lets encrypt again, see how it works 
            encryptedText =myEncrypter.encrypt(decryptedText);
            decryptedText= myEncrypter.decrypt(encryptedText);
            Console.WriteLine("Ahora decrypted is: " + decryptedText);*/

            /*String text = "Que ondas";
            byte[] textAsByteArray = new ASCIIEncoding().GetBytes(text);

            RSA myRsa = new RSA();
            byte[] encryptedText = myRsa.Encrypt(textAsByteArray);
            for (int i = 0; i < encryptedText.Length; i++)
            {
                Console.Write(encryptedText[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("Fin Encriptacion");

            byte[] decryptedText = myRsa.Decrypt(encryptedText);
            String finalString= new ASCIIEncoding().GetString(decryptedText);
            Console.WriteLine("Fin desencriptacion: "+ finalString.Length);*/
        }
    }
}
