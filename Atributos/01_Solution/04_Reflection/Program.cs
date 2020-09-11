using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_Reflection.Modelo;
     

namespace _04_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario()
            {
                Nome = "José",
                Email = "jose.costa@gmail.com",
                Senha = "123456ab",                
            };

            //Antes da alteração
            Log.Gravar((Usuario)usuario.Clone());

            usuario.Nome = "José Costa";

            //Depois da alteração
            Log.Gravar((Usuario)usuario.Clone());


            Carro carro = new Carro() { Marca = "Reanult", Modelo = "Logan" };
            Log.Gravar((Carro)carro.Clone());

            carro.Marca = "FIAT";
            carro.Modelo = "UNO";

            Log.Gravar((Carro)carro.Clone());

            Log.ApresentarLog();

            Console.WriteLine("Log gravado!!!");
            Console.ReadKey();
        }
    }
}
