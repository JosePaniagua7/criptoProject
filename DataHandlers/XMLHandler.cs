using System;
using System.Xml;

namespace DataHandlers
{
    public class XMLHandler
    {
        XmlTextWriter xmlTextWritter;
        XmlDocument xmlDocumentReader;
        public XMLHandler()
        {
            this.xmlDocumentReader = new XmlDocument();
        }

        public String [] readTdesKeys(String route)
        {
            Console.WriteLine("The received Path during reading tdes: " + route);
            String[] keys = new String[3];
            this.xmlDocumentReader.Load(route);
            //Iterate three times over the keys, that allow scalable alrogithms
            for (int i = 0; i < keys.Length; i++)
            {
                XmlNode key = xmlDocumentReader.DocumentElement.SelectSingleNode("/tdes"+(i+1));
                if (key!=null)
                {
                    Console.WriteLine("El valor es: " + key.InnerText);
                    //keys[i] = key.InnerText;
                }
                else
                {
                    Console.WriteLine("Huston, tenemos un problema");
                }

            }
            return keys;
        }
        public string readRsaPublicKey(string route)
        {            
            string publicRsaKey = "";
            this.xmlDocumentReader.Load(route);
            XmlNodeList elemList = this.xmlDocumentReader.GetElementsByTagName("clavepublica");
            if (elemList.Count > 0)
            {
                publicRsaKey = elemList[0].InnerText;
            }
            return publicRsaKey;
        }

        public void exportTdesKeys(string route,string [] keys,string initializationVector)
        {
            Console.WriteLine("The received Path during tdes exporting: " + route);
            this.xmlTextWritter = new XmlTextWriter(route, null);
            // Opens the document  
            xmlTextWritter.WriteStartDocument();
            xmlTextWritter.WriteStartElement("root");
            for (int i = 0; i < keys.Length; i++)
            {
                xmlTextWritter.WriteStartElement("tdes" + (i + 1));
                xmlTextWritter.WriteString(keys[i]);
                xmlTextWritter.WriteEndElement();
            }
            xmlTextWritter.WriteStartElement("iv");
            xmlTextWritter.WriteString(initializationVector);
            xmlTextWritter.WriteEndElement();
            xmlTextWritter.WriteEndElement();
            xmlTextWritter.WriteEndDocument();            
            xmlTextWritter.Close();
        }

        public void exportRsaPublicKey(string route, String key)
        {
            Console.WriteLine("The received Path during exporting rsa: " + route);
            this.xmlTextWritter = new XmlTextWriter(route, null);
            // Opens the document  
            xmlTextWritter.WriteStartDocument();
            xmlTextWritter.WriteStartElement("root");
            xmlTextWritter.WriteStartElement("clavepublica");
            xmlTextWritter.WriteString(key);
            xmlTextWritter.WriteEndElement();
            xmlTextWritter.WriteEndElement();
            xmlTextWritter.WriteEndDocument();
            // close writer  
            xmlTextWritter.Close();
        }

        public string readEncryptedText(string route)
        {
            Console.WriteLine("The received Path during reading encrypted text: " + route);
            return this.readNode(route, "textoe");            
        }

        public void exportEncrytpedText(string route,string message)
        {
            Console.WriteLine("The received Path during exporting encrypted text: " + route);
            this.xmlTextWritter = new XmlTextWriter(route, null);
            // Opens the document  
            xmlTextWritter.WriteStartDocument();

            xmlTextWritter.WriteStartElement("textoe");
            xmlTextWritter.WriteString(message);
            xmlTextWritter.WriteEndElement();

            xmlTextWritter.WriteEndDocument();            
            xmlTextWritter.Close();
        }

        public string readNode(string route,string nodeName)
        {            
            this.xmlDocumentReader.Load(route);
            String nodeValue="";

            XmlNode node = xmlDocumentReader.DocumentElement.SelectSingleNode("/" + nodeName);
            if (node != null) {
                nodeValue = node.InnerText;
            }                        
            return nodeValue;
        }
        
    }
}
