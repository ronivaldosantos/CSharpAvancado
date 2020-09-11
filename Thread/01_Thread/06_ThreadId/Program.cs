using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _06_ThreadId
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 0; i < 5; i++)
            {
                Thread t1 = new Thread(ThreadRepeticao);
                t1.Start(i);
            }

            Console.WriteLine("Programa finalizado!");
            Console.ReadKey();
        }

        static void ThreadRepeticao(object Id)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Thread: " + Id + " - num: " + i + " - Id Thread: " + Thread.CurrentThread.ManagedThreadId);
            }           
        }
    }
}
