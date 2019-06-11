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
            String[] keys = new String[3];
            this.xmlDocumentReader.Load(route);            
            for (int i = 0; i < keys.Length; i++)
            {                
                keys[i] = readNode(this.xmlDocumentReader,"tdes" + (i + 1));
            }
            return keys;
        }
        public string readInitializationVector(String route)
        {                       
            return readNode(route,"iv");           
        }
        public string readRsaPublicKey(string route)
        {                        
            return readNode(route,"clavepublica");            
        }
        public string readEncryptedText(string route)
        {
            return this.readNode(route,"textoe");
        }

        public void exportTdesKeys(string route,string [] keys,string initializationVector)
        {
            initializeXml(route);
            for(int i = 0; i < keys.Length; i++)
            {
                writeNode(this.xmlTextWritter, "tdes" + (i+1), keys[i]);
            }
            writeNode(this.xmlTextWritter,"iv", initializationVector);
            finalizeXml();
        }

        public void exportRsaPublicKey(string route, String key)
        {
            initializeXml(route);
            writeNode(this.xmlTextWritter, "clavepublica", key);
            finalizeXml();
        }        

        public void exportEncrytpedText(string route,string message)
        {
            initializeXml(route);
            writeNode(this.xmlTextWritter, "textoe", message);
            finalizeXml();
        }

        public string readNode(string route,string nodeName)
        {
            this.xmlDocumentReader.Load(route);
            string nodeValue="";
            XmlNode node = this.xmlDocumentReader.DocumentElement.SelectSingleNode(nodeName);
            if (node != null) {
                nodeValue = node.InnerText;
            }                        
            return nodeValue;
        }

        public string readNode(XmlDocument xmlDocument,string nodeName)
        {
            string nodeValue = "";
            XmlNode node = xmlDocument.DocumentElement.SelectSingleNode(nodeName);
            if (node != null)
            {
                nodeValue = node.InnerText;
            }
            return nodeValue;
        }

        public void initializeXml(string route)
        {
            this.xmlTextWritter = new XmlTextWriter(route, null);
            this.xmlTextWritter.WriteStartDocument();
            this.xmlTextWritter.WriteStartElement("root");           
        }

        public void finalizeXml() {
            this.xmlTextWritter.WriteEndElement();
            this.xmlTextWritter.WriteEndDocument();
            this.xmlTextWritter.Close();
        }

        public void writeNode(XmlTextWriter xmlFile, string nodeName,string nodeValue)
        {
            xmlFile.WriteStartElement(nodeName);
            xmlTextWritter.WriteString(nodeValue);
            xmlTextWritter.WriteEndElement();
        }

    }
}
