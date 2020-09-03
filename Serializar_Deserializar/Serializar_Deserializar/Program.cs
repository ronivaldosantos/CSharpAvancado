using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using _00_Bibliotca;
using System.Xml.Serialization;

namespace SerializarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario() { Nome = "Ronivaldo Santos",
                                              CPF = "222.222.222-22", 
                                              Email = "teste@gmail.com" };

            //Serializar o objto. Passar de objeto para formato XML
            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));

            //Arquivo que será serializado no diretório.
            StreamWriter stream = new StreamWriter(@"C:\Users\roniv\Documents\CSharpAvancado\SerializarXML.xml");

            serializador.Serialize(stream,usuario);

        }
    }
}
