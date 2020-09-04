using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Delegates
{
    class Program
    {
        delegate int Calculadora(int a, int b);
        static void Main(string[] args)
        {
            /* Forma tradicional
            var so = Soma(10, 20);
            var su = Subtracao(20, 10);
            */

            // Uso Delegates
            Calculadora calc = new Calculadora(Soma);
            Calculadora calc2 = new Calculadora(Subtracao);
            int so = calc(10, 20);
            int su = calc2(20, 15);

            Console.WriteLine("Soma: " + so);
            Console.WriteLine("Subtração: " + su);
            Console.ReadKey();
        }

        static int Soma(int a, int b)
        {
            return a + b;
        }

        static int Subtracao(int a, int b)
        {
            return a - b;
        }
    }
}
