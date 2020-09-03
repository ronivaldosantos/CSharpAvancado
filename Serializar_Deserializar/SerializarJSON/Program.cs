using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using _00_Bibliotca;
using System.IO;

namespace SerializarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario()
            {
                Nome = "Maria Regina",
                CPF = "333.333.333-33",
                Email = "maria@gmail.com"
            };

            //Serializador do JSON
            JavaScriptSerializer serializador = new JavaScriptSerializer();

            string stringObjSerializado = serializador.Serialize(usuario);

            StreamWriter sw = new StreamWriter(@"C:\Users\roniv\Documents\CSharpAvancado\SerializarJSON.json");

            sw.WriteLine(stringObjSerializado);
            sw.Close();

        }
    }
}
