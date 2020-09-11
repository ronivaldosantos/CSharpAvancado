using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _02_Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(ThreadRepeticao);
            t1.Start();

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Man: " + i);
            }

            Console.ReadKey();

        }

        static void ThreadRepeticao() 
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Número: " + i);
            }
        }
    }
}
