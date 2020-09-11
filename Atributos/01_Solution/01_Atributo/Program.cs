using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Atributo
{
    [MeuAtributo("Atributo classe",Descricao ="Descrição atributo")]
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ola mundo");
            Console.ReadKey();
        }
    }
}
