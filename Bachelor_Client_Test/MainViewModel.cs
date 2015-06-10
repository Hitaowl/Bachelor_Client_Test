using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bachelor_Client_Test
{
    public class Client
    {
        public string Send(string content)
        {
            XStreamingElement message = this.XmlParser(content);
            string messageContent = this.Ausgabe(message);
            return messageContent;
        }

        // erstellt aus den Einzelteilen gueltiges XML, liefert das als Objekt zurueck
        public XStreamingElement XmlParser(string content)
        {            
            XStreamingElement message = new XStreamingElement("Message",
                                        new XStreamingElement("Content", content),
                                        new XStreamingElement("Child2", 2)
                );
            return message;
        }

        // Testweise, ich mach nen XElement drauss weil ich deutlich mehr Funktionen dafuer habe
        public string Ausgabe(XStreamingElement message)
        {
            XElement messageContent = new XElement("bla", message);
            return messageContent.ToString();
        }
    }
}
