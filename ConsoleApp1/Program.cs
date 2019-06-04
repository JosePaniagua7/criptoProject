using System;
using System.Xml;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument document = new XmlDocument();
            string route = "C:\\Users\\jose.paniagua\\Desktop\\myFile.xml";

            document.Load(route);
            XmlNodeList elemList = document.GetElementsByTagName("clavepublica");
            for (int i = 0; i < elemList.Count; i++)
            {
                Console.WriteLine(elemList[i].InnerXml);
            }            
        }
    }
}
