using System;
using System.Threading;

namespace _03_MultThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DataIni: " + DateTime.Now);

            for (int i = 0; i < 5; i++)
            {
                Thread t1 = new Thread(ThreadRepeticao);
                t1.Start();
            }

            Console.WriteLine("Programa finalizado!");
            Console.ReadKey();
        }

        static void ThreadRepeticao()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Número: " + i);
            }

            Console.WriteLine("DataTerm: " + DateTime.Now);
        }
    }
}
