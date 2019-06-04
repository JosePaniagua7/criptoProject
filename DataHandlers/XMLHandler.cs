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

        public String [] readTdesKeys(String url)
        {
            String[] keys = new String[3];
            this.xmlDocumentReader.Load("C:\\Users\\jose.paniagua\\Desktop\\myFile.xml");
            //Iterate three times over the keys, that allow scalable alrogithms
            for (int i = 0; i < keys.Length; i++)
            {
                XmlNode key = xmlDocumentReader.DocumentElement.SelectSingleNode("/tdes"+(i+1));
                keys[i] = key.InnerText;
            }            
            return keys;
        }

        public void generateXml(String fileUrl,String [] keys) {
            this.xmlTextWritter=new XmlTextWriter(fileUrl, null);
            // Opens the document  
            xmlTextWritter.WriteStartDocument();
            for (int i = 0; i < keys.Length; i++)
            {
                xmlTextWritter.WriteStartElement("tdes"+(i+1));
                xmlTextWritter.WriteString(keys[i]);
                xmlTextWritter.WriteEndElement();                
                
            }
            xmlTextWritter.WriteEndDocument();
            // close writer  
            xmlTextWritter.Close();            
        }
    }
}
