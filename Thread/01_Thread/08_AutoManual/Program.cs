using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _08_AutoManual
{
    class Program
    {
        static ManualResetEvent manual01;
        static AutoResetEvent auto01;

        static void Main(string[] args)
        {
            //Indica que a Thread deve ficar parada até o valor seja true.
            manual01 = new ManualResetEvent(false);
            auto01 = new AutoResetEvent(false);

           // Thread t1 = new Thread(Executa01);
           // t1.Start();

            Thread t2 = new Thread(Executa02);
            t2.Start();

            Thread.Sleep(5000);
            //Libera a execução da Thread com status manual01.WaitOne
            manual01.Set();
            //Volta para o estado bloqueado
            manual01.Reset();

            //Libera a execução e volta para Reset automaticamente.
            auto01.Set();

            Thread.Sleep(5000);
            manual01.Set();
            auto01.Set();

            Console.ReadKey();
        }

        static void Executa01()
        {
            Console.WriteLine("01 - Iniciado executa01.");
            manual01.WaitOne();
            Console.WriteLine("02 - Em execução 01 executa01.");
            Console.WriteLine("03 - Em execução 02 executa01.");
            Console.WriteLine("04 - Finalizado executa01.");
        }

        static void Executa02()
        {
            Console.WriteLine("01 - Iniciado executa02.");
            auto01.WaitOne();
            Console.WriteLine("02 - Em execução 01 executa02.");
            auto01.WaitOne();
            Console.WriteLine("03 - Em execução 02 executa02.");
            Console.WriteLine("04 - Finalizado executa02.");
        }
    }
}
