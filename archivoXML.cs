using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Diccionario_Personal
{
<<<<<<< HEAD
    public class archivoXML
=======
    class archivoXML
>>>>>>> ramaXML
    {
        /*La estructura del archivo xml es:
         * Idioma
         *  | Palabra
         *  |  | Tipo
         *  |  | Traduccion
         *  |  | Idea
         * 
         * De acuerdo con la función siguiente, se tiene que crear una funcion para agregar palabra
         * al archivo XML, el cuerpo del archivo xml es idioma
         * ???? Sigo pensando en crear un archivo xml para cada idioma, o uno solo donde 
         *      el cuerpo sea <Diccionario> y se divida por <Idioma> y esta en <Palabra>
         */
        public void creatingXML(XmlDocument doc)
        {

            //parte para entender como se creara el archivo xml 
            XmlDeclaration init = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = doc.DocumentElement;
            doc.InsertBefore(init, root);

            //cuerpo del archivo xml
            XmlElement element1 = doc.CreateElement(string.Empty, "cuerpo", string.Empty);
            doc.AppendChild(element1);

            //primer nivel que es agregado al documento, dentro del cuerpo
            XmlElement element2 = doc.CreateElement(String.Empty, "nivel1", string.Empty);
            doc.AppendChild(element2);

            //segundo nivel que es agregado al documento, dentro del primer nivel
            XmlElement element3 = doc.CreateElement(string.Empty, "nivel2", string.Empty);
            XmlText text1 = doc.CreateTextNode("Texto");
            element3.AppendChild(text1);
            element2.AppendChild(element3);

            //tercer nivel que es agregado al documento, dentro del segundo nivel
            XmlElement element4 = doc.CreateElement(string.Empty, "nivel3", string.Empty);
            XmlText text2 = doc.CreateTextNode("más texto");
            element4.AppendChild(text2);
            element2.AppendChild(element4);

            //ruta de guardado
            doc.Save("");

        }
<<<<<<< HEAD

=======
>>>>>>> ramaXML
    }
}
