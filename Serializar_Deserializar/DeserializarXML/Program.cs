using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _00_Bibliotca;
using System.IO;
using System.Xml.Serialization;

namespace DeserializarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader stream = new StreamReader(@"C:\Users\roniv\Documents\CSharpAvancado\SerializarXML.xml");            
            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));

            //Realiza um casting para o usuário receba o deserialize. 
            //A classe deve ter as mesmas propriedades do arquivo.
            Usuario usuario = (Usuario)serializador.Deserialize(stream);

            Console.WriteLine("Usuário(nome): {0}, CPF: {1}, Email: {2}",usuario.Nome,usuario.CPF,usuario.Email);
            Console.ReadKey();

        }
    }
}
