using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            //LINQ/LAMBDA
            //LAMBDA = (entrada) => (expressao)

            //Array de inteiros.
            int[] lista = { 3, 9, 4, 6, 20, 10, 60, 90, 80, 50 };

            //var listaFiltrada = lista.Where(x => x > 10).Select(a => a).OrderBy(a => a);

            //Sintaxe alternativa para LINQ
            var listaFiltrada = from a in lista where a > 10 orderby a select a;

            foreach (var item in listaFiltrada)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}
