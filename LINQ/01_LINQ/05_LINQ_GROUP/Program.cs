using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LINQ_GROUP
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] listaNum = { 1, 1, 1, 1, 4, 4, 2, 3, 5, 6, 6, 10, 9, 8 };

            //Utilizando distinct
            //var listaFiltrada = listaNum.Distinct().OrderBy(a=>a);

            //Utilizando Goup By
            var listaFiltrada = listaNum.OrderBy(a=>a).GroupBy(a => a).Select(a => a);

            //GROUP / DISTINCT 
            foreach (var item in listaFiltrada)
            {
                //Utilizando distinct    
                //Console.WriteLine(item);

                //Utilizando Goup By
                Console.WriteLine(item.Key);

            }
            Console.ReadKey();
        }
    }
}
