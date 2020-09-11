using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _07_ThreadMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Thread Sleep.
            Console.WriteLine("Processando...");
            Thread.Sleep(3000);
            Console.WriteLine("Fim");

            //Thread Join
            Thread t1 = new Thread(ThreadRepeticao);
            t1.Start();

            //Aguarda a execução da thread para prosseguir a execução do restante do programa.
            t1.Join();

            Console.WriteLine("Fim");
            Console.WriteLine("Fim");
            Console.WriteLine("Fim");
            Console.WriteLine("Fim");
            Console.WriteLine("Fim");
            Console.WriteLine("Fim");

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
