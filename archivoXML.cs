using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Diccionario_Personal
{
    class archivoXML
    {
        public void creatingXML(XmlDocument doc)
        {

            XmlDeclaration init = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = doc.DocumentElement;
            doc.InsertBefore(init, root);

            XmlElement element1 = doc.CreateElement(string.Empty, "cuerpo", string.Empty);
            doc.AppendChild(element1);
        }
    }
}
