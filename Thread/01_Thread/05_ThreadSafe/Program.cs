using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _05_ThreadSafe
{
    class Program
    {
        static int Rede = 0;
        static object variavelDeControle = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("DataIni: " + DateTime.Now);

            for (int i = 0; i < 5; i++)
            {
                Thread t1 = new Thread(ThreadRepeticao);
                t1.IsBackground = true;
                t1.Start();
            }
            Console.ReadKey();
        }

        static void ThreadRepeticao()
        {
            //FIFO - First In and First Out
            for (int i = 0; i < 1000; i++)
            {
                // A instrução lock obtém o bloqueio de exclusão mútua para um determinado objeto, 
                // executa um bloco de instruções e, em seguida, libera o bloqueio.
                lock (variavelDeControle)
                {
                    Console.WriteLine("Número: " + i);
                    Rede++;
                }
            }

            Console.WriteLine("DataTerm: " + DateTime.Now);
        }
    }
}
