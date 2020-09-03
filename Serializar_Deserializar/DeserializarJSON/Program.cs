using System;
using System.IO;
using System.Web.Script.Serialization;
using _00_Bibliotca;

namespace DeserializarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader stream = new StreamReader(@"C:\Users\roniv\Documents\CSharpAvancado\SerializarJSON.json");
            string linhasDoArquivo = stream.ReadToEnd();

            JavaScriptSerializer serializador = new JavaScriptSerializer();
            Usuario usuario = (Usuario)serializador.Deserialize(linhasDoArquivo,typeof(Usuario));

            Console.WriteLine("Usuário(nome): {0}, CPF: {1}, Email: {2}", usuario.Nome, usuario.CPF, usuario.Email);
            Console.ReadKey();

        }
    }
}
